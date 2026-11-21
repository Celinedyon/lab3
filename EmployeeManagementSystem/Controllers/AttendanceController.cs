using System;
using System.Data;
using MySqlConnector;
using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem.Controllers
{
    public class AttendanceController
    {
        public DataTable GetAll(int? employeeId = null, DateTime? from = null, DateTime? to = null, int? managerEmployeeId = null)
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT a.attendance_id, a.employee_id, e.employee_code,
                           CONCAT(e.first_name, ' ', e.last_name) AS Employee,
                           a.work_date AS WorkDate,
                           TIMESTAMP(a.work_date, a.clock_in) AS ClockIn,
                           TIMESTAMP(a.work_date, a.clock_out) AS ClockOut,
                           a.hours_worked AS HoursWorked,
                           a.status AS Status, a.correction_reason AS Note
                    FROM attendance a
                    JOIN employees e ON a.employee_id = e.employee_id
                    WHERE 1=1";
                if (employeeId.HasValue) sql += " AND a.employee_id = @empId";
                if (managerEmployeeId.HasValue)
                    sql += @" AND e.department_id IN
                                  (SELECT department_id FROM departments WHERE manager_id = @managerId)";
                if (from.HasValue) sql += " AND a.work_date >= @from";
                if (to.HasValue) sql += " AND a.work_date <= @to";
                sql += " ORDER BY a.work_date DESC, e.employee_code";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (employeeId.HasValue) cmd.Parameters.AddWithValue("@empId", employeeId.Value);
                    if (managerEmployeeId.HasValue) cmd.Parameters.AddWithValue("@managerId", managerEmployeeId.Value);
                    if (from.HasValue) cmd.Parameters.AddWithValue("@from", from.Value.Date);
                    if (to.HasValue) cmd.Parameters.AddWithValue("@to", to.Value.Date);
                    using (var adapter = new MySqlDataAdapter(cmd))
                        adapter.Fill(table);
                }
            }
            return table;
        }

        public DataRow GetToday(int employeeId)
        {
            var table = GetAll(employeeId, DateTime.Today, DateTime.Today);
            return table.Rows.Count == 0 ? null : table.Rows[0];
        }

        public string ClockIn(int employeeId)
        {
            if (employeeId <= 0) return "Your account is not linked to an employee record.";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        var now = DateTime.Now;
                        object existingClockIn;
                        using (var check = new MySqlCommand(
                            "SELECT clock_in FROM attendance WHERE employee_id = @emp AND work_date = @date FOR UPDATE",
                            conn, transaction))
                        {
                            check.Parameters.AddWithValue("@emp", employeeId);
                            check.Parameters.AddWithValue("@date", now.Date);
                            existingClockIn = check.ExecuteScalar();
                        }

                        if (existingClockIn != null && existingClockIn != DBNull.Value)
                            return "You have already clocked in today.";

                        string status = now.TimeOfDay > new TimeSpan(9, 0, 0) ? "Late" : "Present";
                        string sql = existingClockIn == null
                            ? @"INSERT INTO attendance (employee_id, work_date, clock_in, status)
                                VALUES (@emp, @date, @now, @status)"
                            : @"UPDATE attendance SET clock_in = @now, clock_out = NULL,
                                    hours_worked = NULL, status = @status
                                WHERE employee_id = @emp AND work_date = @date AND clock_in IS NULL";
                        using (var cmd = new MySqlCommand(sql, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@emp", employeeId);
                            cmd.Parameters.AddWithValue("@date", now.Date);
                            cmd.Parameters.AddWithValue("@now", now.TimeOfDay);
                            cmd.Parameters.AddWithValue("@status", status);
                            if (cmd.ExecuteNonQuery() != 1)
                                return "Unable to record your clock-in. Please refresh and try again.";
                        }
                        transaction.Commit();
                    }
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public string ClockOut(int employeeId)
        {
            if (employeeId <= 0) return "Your account is not linked to an employee record.";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    var now = DateTime.Now;
                    using (var cmd = new MySqlCommand(@"
                        UPDATE attendance
                        SET clock_out = TIME(@now),
                            hours_worked = ROUND(TIME_TO_SEC(TIMEDIFF(TIME(@now), clock_in)) / 3600.0, 2)
                        WHERE employee_id = @emp AND work_date = @date
                          AND clock_in IS NOT NULL AND clock_out IS NULL
                          AND TIME(@now) >= clock_in", conn))
                    {
                        cmd.Parameters.AddWithValue("@emp", employeeId);
                        cmd.Parameters.AddWithValue("@date", now.Date);
                        cmd.Parameters.AddWithValue("@now", now);
                        if (cmd.ExecuteNonQuery() == 0)
                            return "Clock in before clocking out. You may already have clocked out today.";
                    }
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public string Correct(
            int attendanceId, DateTime? clockIn, DateTime? clockOut, string status, string reason,
            int correctedByUserId, int managerEmployeeId)
        {
            if (attendanceId <= 0) return "Select an attendance record to correct.";
            if (correctedByUserId <= 0 || managerEmployeeId <= 0)
                return "Your manager account is not linked to an employee record.";
            if (string.IsNullOrWhiteSpace(reason)) return "A reason is required for the correction.";
            if (reason.Trim().Length > 255)
                return "The correction reason cannot exceed 255 characters.";
            if (clockOut.HasValue && !clockIn.HasValue)
                return "A clock-in time is required when a clock-out time is entered.";
            if (clockIn.HasValue && clockOut.HasValue &&
                clockOut.Value.TimeOfDay < clockIn.Value.TimeOfDay)
                return "Clock-out time cannot be earlier than clock-in time.";
            if (status != "Present" && status != "Late" && status != "Absent")
                return "Select a valid attendance status.";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(@"
                        UPDATE attendance a
                        JOIN employees e ON e.employee_id = a.employee_id
                        SET a.clock_in = TIME(@ci), a.clock_out = TIME(@co),
                            a.hours_worked = CASE WHEN @ci IS NULL OR @co IS NULL THEN NULL
                                ELSE ROUND(TIME_TO_SEC(TIMEDIFF(TIME(@co), TIME(@ci))) / 3600.0, 2) END,
                            a.status = @status, a.correction_reason = @reason,
                            a.corrected_by = @correctedBy
                        WHERE a.attendance_id = @id
                          AND e.department_id IN
                              (SELECT department_id FROM departments WHERE manager_id = @managerId)", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", attendanceId);
                        cmd.Parameters.AddWithValue("@ci", (object)clockIn ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@co", (object)clockOut ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@reason", reason.Trim());
                        cmd.Parameters.AddWithValue("@correctedBy", correctedByUserId);
                        cmd.Parameters.AddWithValue("@managerId", managerEmployeeId);
                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            using (var check = new MySqlCommand(
                                @"SELECT COUNT(*) FROM attendance a
                                  JOIN employees e ON e.employee_id = a.employee_id
                                  WHERE a.attendance_id = @id AND e.department_id IN
                                      (SELECT department_id FROM departments WHERE manager_id = @managerId)", conn))
                            {
                                check.Parameters.AddWithValue("@id", attendanceId);
                                check.Parameters.AddWithValue("@managerId", managerEmployeeId);
                                if (Convert.ToInt32(check.ExecuteScalar()) == 0)
                                    return "The attendance record is not in your team or no longer exists.";
                            }
                        }
                    }
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public DataTable GetEmployees(int? managerEmployeeId = null)
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(
                @"SELECT employee_id, CONCAT(employee_code, ' - ', first_name, ' ', last_name) AS name
                  FROM employees WHERE status = 'Active'
                    AND (@managerId IS NULL OR department_id IN
                        (SELECT department_id FROM departments WHERE manager_id = @managerId))
                  ORDER BY employee_code",
                conn))
            {
                cmd.Parameters.AddWithValue("@managerId", (object)managerEmployeeId ?? DBNull.Value);
                using (var adapter = new MySqlDataAdapter(cmd))
                    adapter.Fill(table);
            }
            return table;
        }
    }
}
