using System;
using System.Data;
using MySqlConnector;
using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem.Controllers
{
    public class LeaveController
    {
        public DataTable GetActiveTypes()
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(
                "SELECT leave_type_id, name FROM leave_types WHERE is_active = 1 ORDER BY name", conn))
            using (var adapter = new MySqlDataAdapter(cmd))
                adapter.Fill(table);
            return table;
        }

        public DataTable GetEmployeeBalances(int employeeId, int year)
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                EnsureBalances(conn, null, employeeId, year);
                using (var cmd = new MySqlCommand(@"
                    SELECT lt.name AS LeaveType, lb.allocated_days AS Allowed,
                           lb.days_used AS Used,
                           lb.allocated_days - lb.days_used - COALESCE((
                               SELECT SUM(DATEDIFF(lr.end_date, lr.start_date) + 1)
                               FROM leave_requests lr
                               WHERE lr.employee_id = lb.employee_id
                                 AND lr.leave_type_id = lb.leave_type_id
                                 AND YEAR(lr.start_date) = lb.year
                                 AND lr.status = 'Pending'
                           ), 0) AS Remaining
                    FROM leave_balances lb
                    JOIN leave_types lt ON lt.leave_type_id = lb.leave_type_id
                    WHERE lb.employee_id = @employeeId AND lb.year = @year
                    ORDER BY lt.name", conn))
                {
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.Parameters.AddWithValue("@year", year);
                    using (var adapter = new MySqlDataAdapter(cmd))
                        adapter.Fill(table);
                }
            }
            return table;
        }

        public DataTable GetEmployeeRequests(int employeeId)
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(@"
                SELECT lr.request_id, lt.name AS LeaveType,
                       lr.start_date AS StartDate, lr.end_date AS EndDate,
                       DATEDIFF(lr.end_date, lr.start_date) + 1 AS Days,
                       lr.status AS Status
                FROM leave_requests lr
                JOIN leave_types lt ON lt.leave_type_id = lr.leave_type_id
                WHERE lr.employee_id = @employeeId
                ORDER BY lr.start_date DESC, lr.request_id DESC", conn))
            {
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                using (var adapter = new MySqlDataAdapter(cmd))
                    adapter.Fill(table);
            }
            return table;
        }

        public DataTable GetManagerRequests(int managerEmployeeId, string status)
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(@"
                SELECT lr.request_id AS ID,
                       CONCAT(e.employee_code, ' - ', e.first_name, ' ', e.last_name) AS Employee,
                       lt.name AS LeaveType, lr.start_date AS StartDate, lr.end_date AS EndDate,
                       DATEDIFF(lr.end_date, lr.start_date) + 1 AS Days,
                       lr.reason AS Reason, lr.status AS Status, lr.employee_id
                FROM leave_requests lr
                JOIN employees e ON e.employee_id = lr.employee_id
                JOIN leave_types lt ON lt.leave_type_id = lr.leave_type_id
                WHERE e.department_id IN
                    (SELECT department_id FROM departments WHERE manager_id = @managerId)
                  AND (@status = 'All' OR lr.status = @status)
                ORDER BY (lr.status = 'Pending') DESC, lr.start_date DESC, lr.request_id DESC", conn))
            {
                cmd.Parameters.AddWithValue("@managerId", managerEmployeeId);
                cmd.Parameters.AddWithValue("@status", string.IsNullOrWhiteSpace(status) ? "Pending" : status);
                using (var adapter = new MySqlDataAdapter(cmd))
                    adapter.Fill(table);
            }
            return table;
        }

        public string SubmitRequest(int employeeId, int leaveTypeId, DateTime startDate, DateTime endDate, string reason)
        {
            if (employeeId <= 0) return "Your account is not linked to an employee record.";
            if (leaveTypeId <= 0) return "Select a leave type.";
            if (startDate.Date < DateTime.Today) return "Leave cannot start in the past.";
            if (endDate.Date < startDate.Date) return "The end date must be on or after the start date.";
            if (startDate.Year != endDate.Year) return "A leave request must be within one calendar year.";
            if (string.IsNullOrWhiteSpace(reason)) return "Enter a reason for the leave request.";

            int year = startDate.Year;
            int days = (endDate.Date - startDate.Date).Days + 1;
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        EnsureBalances(conn, transaction, employeeId, year);
                        using (var overlap = new MySqlCommand(@"
                            SELECT COUNT(*) FROM leave_requests
                            WHERE employee_id = @employeeId
                              AND status IN ('Pending', 'Approved')
                              AND start_date <= @endDate AND end_date >= @startDate", conn, transaction))
                        {
                            overlap.Parameters.AddWithValue("@employeeId", employeeId);
                            overlap.Parameters.AddWithValue("@startDate", startDate.Date);
                            overlap.Parameters.AddWithValue("@endDate", endDate.Date);
                            if (Convert.ToInt32(overlap.ExecuteScalar()) > 0)
                                return "These dates overlap another pending or approved leave request.";
                        }

                        decimal allocated;
                        decimal used;
                        using (var balance = new MySqlCommand(@"
                            SELECT lb.allocated_days, lb.days_used
                            FROM leave_balances lb
                            JOIN leave_types lt ON lt.leave_type_id = lb.leave_type_id
                            WHERE lb.employee_id = @employeeId AND lb.leave_type_id = @leaveTypeId
                              AND lb.year = @year AND lt.is_active = 1
                            FOR UPDATE", conn, transaction))
                        {
                            balance.Parameters.AddWithValue("@employeeId", employeeId);
                            balance.Parameters.AddWithValue("@leaveTypeId", leaveTypeId);
                            balance.Parameters.AddWithValue("@year", year);
                            using (var reader = balance.ExecuteReader())
                            {
                                if (!reader.Read())
                                    return "The selected leave type is unavailable for this year.";
                                allocated = reader.GetDecimal("allocated_days");
                                used = reader.GetDecimal("days_used");
                            }
                        }

                        decimal pendingDays;
                        using (var pending = new MySqlCommand(@"
                            SELECT COALESCE(SUM(DATEDIFF(end_date, start_date) + 1), 0)
                            FROM leave_requests
                            WHERE employee_id = @employeeId AND leave_type_id = @leaveTypeId
                              AND YEAR(start_date) = @year AND status = 'Pending'", conn, transaction))
                        {
                            pending.Parameters.AddWithValue("@employeeId", employeeId);
                            pending.Parameters.AddWithValue("@leaveTypeId", leaveTypeId);
                            pending.Parameters.AddWithValue("@year", year);
                            pendingDays = Convert.ToDecimal(pending.ExecuteScalar());
                        }
                        if (days > allocated - used - pendingDays)
                            return "There are not enough leave days remaining for this request.";

                        using (var insert = new MySqlCommand(@"
                            INSERT INTO leave_requests
                                (employee_id, leave_type_id, start_date, end_date, days, reason, status)
                            VALUES (@employeeId, @leaveTypeId, @startDate, @endDate, @days, @reason, 'Pending')", conn, transaction))
                        {
                            insert.Parameters.AddWithValue("@employeeId", employeeId);
                            insert.Parameters.AddWithValue("@leaveTypeId", leaveTypeId);
                            insert.Parameters.AddWithValue("@startDate", startDate.Date);
                            insert.Parameters.AddWithValue("@endDate", endDate.Date);
                            insert.Parameters.AddWithValue("@days", days);
                            insert.Parameters.AddWithValue("@reason", reason.Trim());
                            insert.ExecuteNonQuery();
                        }

                        AddManagerNotification(conn, transaction, employeeId,
                            "A new leave request requires your review.");
                        transaction.Commit();
                    }
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public string ReviewRequest(int requestId, int managerEmployeeId, int reviewerUserId, string decision)
        {
            if (requestId <= 0) return "Select a leave request.";
            if (managerEmployeeId <= 0 || reviewerUserId <= 0)
                return "Your manager account is not linked to an employee record.";
            if (decision != "Approved" && decision != "Rejected")
                return "Select approve or reject.";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        int employeeId;
                        int leaveTypeId;
                        DateTime startDate;
                        DateTime endDate;
                        using (var request = new MySqlCommand(@"
                            SELECT lr.employee_id, lr.leave_type_id, lr.start_date, lr.end_date, lr.status
                            FROM leave_requests lr
                            JOIN employees e ON e.employee_id = lr.employee_id
                            WHERE lr.request_id = @requestId
                              AND e.department_id IN
                                  (SELECT department_id FROM departments WHERE manager_id = @managerId)
                            FOR UPDATE", conn, transaction))
                        {
                            request.Parameters.AddWithValue("@requestId", requestId);
                            request.Parameters.AddWithValue("@managerId", managerEmployeeId);
                            using (var reader = request.ExecuteReader())
                            {
                                if (!reader.Read())
                                    return "The request is not assigned to your team or no longer exists.";
                                if (reader.GetString("status") != "Pending")
                                    return "This request has already been reviewed.";
                                employeeId = reader.GetInt32("employee_id");
                                leaveTypeId = reader.GetInt32("leave_type_id");
                                startDate = reader.GetDateTime("start_date");
                                endDate = reader.GetDateTime("end_date");
                            }
                        }

                        if (decision == "Approved")
                        {
                            int days = (endDate.Date - startDate.Date).Days + 1;
                            EnsureBalances(conn, transaction, employeeId, startDate.Year);
                            using (var balance = new MySqlCommand(@"
                                SELECT allocated_days, days_used FROM leave_balances
                                WHERE employee_id = @employeeId AND leave_type_id = @leaveTypeId
                                  AND year = @year FOR UPDATE", conn, transaction))
                            {
                                balance.Parameters.AddWithValue("@employeeId", employeeId);
                                balance.Parameters.AddWithValue("@leaveTypeId", leaveTypeId);
                                balance.Parameters.AddWithValue("@year", startDate.Year);
                                using (var reader = balance.ExecuteReader())
                                {
                                    if (!reader.Read())
                                        return "The employee has no balance for this leave type.";
                                    if (days > reader.GetDecimal("allocated_days") - reader.GetDecimal("days_used"))
                                        return "The employee no longer has enough leave days for this request.";
                                }
                            }

                            using (var updateBalance = new MySqlCommand(@"
                                UPDATE leave_balances SET days_used = days_used + @days
                                WHERE employee_id = @employeeId AND leave_type_id = @leaveTypeId AND year = @year",
                                conn, transaction))
                            {
                                updateBalance.Parameters.AddWithValue("@days", days);
                                updateBalance.Parameters.AddWithValue("@employeeId", employeeId);
                                updateBalance.Parameters.AddWithValue("@leaveTypeId", leaveTypeId);
                                updateBalance.Parameters.AddWithValue("@year", startDate.Year);
                                updateBalance.ExecuteNonQuery();
                            }
                        }

                        using (var updateRequest = new MySqlCommand(@"
                            UPDATE leave_requests SET status = @decision, reviewed_by = @reviewerId,
                                reviewed_at = CURRENT_TIMESTAMP
                            WHERE request_id = @requestId AND status = 'Pending'", conn, transaction))
                        {
                            updateRequest.Parameters.AddWithValue("@decision", decision);
                            updateRequest.Parameters.AddWithValue("@reviewerId", reviewerUserId);
                            updateRequest.Parameters.AddWithValue("@requestId", requestId);
                            if (updateRequest.ExecuteNonQuery() != 1)
                                return "The request was already reviewed.";
                        }

                        AddEmployeeNotification(conn, transaction, employeeId,
                            "Your leave request has been " + decision.ToLowerInvariant() + ".");
                        transaction.Commit();
                    }
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        private static void EnsureBalances(MySqlConnection conn, MySqlTransaction transaction, int employeeId, int year)
        {
            using (var cmd = new MySqlCommand(@"
                INSERT INTO leave_balances (employee_id, leave_type_id, year, allocated_days, days_used)
                SELECT @employeeId, leave_type_id, @year, days_allowed, 0
                FROM leave_types WHERE is_active = 1
                ON DUPLICATE KEY UPDATE allocated_days = allocated_days", conn, transaction))
            {
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.ExecuteNonQuery();
            }
        }

        private static void AddManagerNotification(
            MySqlConnection conn, MySqlTransaction transaction, int employeeId, string message)
        {
            using (var cmd = new MySqlCommand(@"
                INSERT INTO notifications (user_id, message)
                SELECT DISTINCT u.user_id, @message
                FROM users u
                JOIN (
                    SELECT d.manager_id AS employee_id
                    FROM departments d JOIN employees e ON e.department_id = d.department_id
                    WHERE e.employee_id = @employeeId AND d.manager_id IS NOT NULL
                ) managers ON managers.employee_id = u.employee_id
                WHERE u.is_active = 1", conn, transaction))
            {
                cmd.Parameters.AddWithValue("@message", message);
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                cmd.ExecuteNonQuery();
            }
        }

        private static void AddEmployeeNotification(
            MySqlConnection conn, MySqlTransaction transaction, int employeeId, string message)
        {
            using (var cmd = new MySqlCommand(@"
                INSERT INTO notifications (user_id, message)
                SELECT user_id, @message FROM users
                WHERE employee_id = @employeeId AND is_active = 1", conn, transaction))
            {
                cmd.Parameters.AddWithValue("@message", message);
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
