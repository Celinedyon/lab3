using System;
using System.Data;
using MySqlConnector;
using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem.Controllers
{
    public class PayrollController
    {
        public DataTable GetSalaries()
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(@"
                SELECT e.employee_id AS EmployeeId, e.employee_code AS EmployeeCode,
                       CONCAT(e.first_name, ' ', e.last_name) AS FullName,
                       COALESCE(s.basic_salary, 0) AS BasicSalary,
                       COALESCE(s.allowances, 0) AS Allowances,
                       COALESCE(s.deductions, 0) AS Deductions
                FROM employees e
                LEFT JOIN salaries s ON s.employee_id = e.employee_id
                ORDER BY e.employee_code", conn))
            using (var adapter = new MySqlDataAdapter(cmd))
                adapter.Fill(table);
            return table;
        }

        public string SaveSalary(int employeeId, decimal basicSalary, decimal allowances, decimal deductions)
        {
            if (employeeId <= 0) return "Select an employee.";
            if (basicSalary < 0 || allowances < 0 || deductions < 0)
                return "Salary amounts cannot be negative.";
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(@"
                    INSERT INTO salaries (employee_id, basic_salary, allowances, deductions)
                    VALUES (@employeeId, @salary, @allowances, @deductions)
                    ON DUPLICATE KEY UPDATE basic_salary = VALUES(basic_salary),
                        allowances = VALUES(allowances), deductions = VALUES(deductions)", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.Parameters.AddWithValue("@salary", basicSalary);
                    cmd.Parameters.AddWithValue("@allowances", allowances);
                    cmd.Parameters.AddWithValue("@deductions", deductions);
                    if (cmd.ExecuteNonQuery() == 0)
                        return "The salary could not be saved.";
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public string CalculateAndSave(int year, int month, out DataTable payroll, out bool isLocked)
        {
            payroll = new DataTable();
            isLocked = false;
            if (year < 2000 || year > 2100 || month < 1 || month > 12)
                return "Select a valid payroll month and year.";

            DateTime monthStart = new DateTime(year, month, 1);
            DateTime monthEnd = monthStart.AddMonths(1).AddDays(-1);
            int monthDays = DateTime.DaysInMonth(year, month);
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        using (var createRun = new MySqlCommand(@"
                            INSERT IGNORE INTO payroll_runs (pay_month, pay_year, is_locked)
                            VALUES (@month, @year, 0)", conn, transaction))
                        {
                            createRun.Parameters.AddWithValue("@month", month);
                            createRun.Parameters.AddWithValue("@year", year);
                            createRun.ExecuteNonQuery();
                        }

                        int runId;
                        using (var getRun = new MySqlCommand(@"
                            SELECT run_id, is_locked FROM payroll_runs
                            WHERE pay_month = @month AND pay_year = @year FOR UPDATE", conn, transaction))
                        {
                            getRun.Parameters.AddWithValue("@month", month);
                            getRun.Parameters.AddWithValue("@year", year);
                            using (var reader = getRun.ExecuteReader())
                            {
                                if (!reader.Read())
                                    return "The payroll run could not be created.";
                                runId = reader.GetInt32("run_id");
                                isLocked = reader.GetBoolean("is_locked");
                            }
                        }
                        if (isLocked)
                            return "This payroll month is locked and cannot be recalculated.";

                        using (var delete = new MySqlCommand(
                            "DELETE FROM payslips WHERE run_id = @runId", conn, transaction))
                        {
                            delete.Parameters.AddWithValue("@runId", runId);
                            delete.ExecuteNonQuery();
                        }

                        var salaries = new DataTable();
                        using (var calculate = new MySqlCommand(@"
                            SELECT e.employee_id AS EmployeeId, e.employee_code AS EmployeeCode,
                                   CONCAT(e.first_name, ' ', e.last_name) AS FullName,
                                   COALESCE(s.basic_salary, 0) AS Basic,
                                   COALESCE(s.allowances, 0) AS Allowances,
                                   COALESCE(s.deductions, 0) AS StandardDeductions,
                                   COALESCE(unpaid.days, 0) + COALESCE(absent.days, 0) AS UnpaidDays
                            FROM employees e
                            LEFT JOIN salaries s ON s.employee_id = e.employee_id
                            LEFT JOIN (
                                SELECT lr.employee_id,
                                    SUM(DATEDIFF(LEAST(lr.end_date, @monthEnd),
                                                 GREATEST(lr.start_date, @monthStart)) + 1) AS days
                                FROM leave_requests lr
                                JOIN leave_types lt ON lt.leave_type_id = lr.leave_type_id
                                WHERE lr.status = 'Approved' AND lt.is_paid = 0
                                  AND lr.start_date <= @monthEnd AND lr.end_date >= @monthStart
                                GROUP BY lr.employee_id
                            ) unpaid ON unpaid.employee_id = e.employee_id
                            LEFT JOIN (
                                SELECT a.employee_id, COUNT(*) AS days
                                FROM attendance a
                                WHERE a.work_date BETWEEN @monthStart AND @monthEnd
                                  AND a.status = 'Absent'
                                  AND NOT EXISTS (
                                      SELECT 1 FROM leave_requests lr
                                      WHERE lr.employee_id = a.employee_id AND lr.status = 'Approved'
                                        AND a.work_date BETWEEN lr.start_date AND lr.end_date
                                  )
                                GROUP BY a.employee_id
                            ) absent ON absent.employee_id = e.employee_id
                            WHERE e.status = 'Active'
                            ORDER BY e.employee_code", conn, transaction))
                        {
                            calculate.Parameters.AddWithValue("@monthStart", monthStart);
                            calculate.Parameters.AddWithValue("@monthEnd", monthEnd);
                            using (var adapter = new MySqlDataAdapter(calculate))
                                adapter.Fill(salaries);
                        }
                        if (salaries.Rows.Count == 0)
                            return "There are no active employees to include in payroll.";

                        salaries.Columns.Add("UnpaidDeduction", typeof(decimal));
                        salaries.Columns.Add("Gross", typeof(decimal));
                        salaries.Columns.Add("Deductions", typeof(decimal));
                        salaries.Columns.Add("Net", typeof(decimal));
                        foreach (DataRow row in salaries.Rows)
                        {
                            decimal basic = Convert.ToDecimal(row["Basic"]);
                            decimal allowances = Convert.ToDecimal(row["Allowances"]);
                            decimal standardDeductions = Convert.ToDecimal(row["StandardDeductions"]);
                            int unpaidDays = Convert.ToInt32(row["UnpaidDays"]);
                            decimal unpaidDeduction = Math.Round(basic * unpaidDays / monthDays, 2, MidpointRounding.AwayFromZero);
                            decimal gross = basic + allowances;
                            row["UnpaidDeduction"] = unpaidDeduction;
                            row["Gross"] = gross;
                            row["Deductions"] = standardDeductions;
                            row["Net"] = gross - standardDeductions - unpaidDeduction;
                        }

                        using (var save = new MySqlCommand(@"
                            INSERT INTO payslips
                                (run_id, employee_id, basic_salary, allowances, standard_deductions,
                                 gross_pay, total_deductions, unpaid_deduction, net_pay)
                            VALUES (@runId, @employeeId, @basic, @allowances, @standardDeductions,
                                    @gross, @deductions, @unpaid, @net)", conn, transaction))
                        {
                            save.Parameters.Add("@runId", MySqlDbType.Int32);
                            save.Parameters.Add("@employeeId", MySqlDbType.Int32);
                            save.Parameters.Add("@basic", MySqlDbType.Decimal);
                            save.Parameters.Add("@allowances", MySqlDbType.Decimal);
                            save.Parameters.Add("@standardDeductions", MySqlDbType.Decimal);
                            save.Parameters.Add("@gross", MySqlDbType.Decimal);
                            save.Parameters.Add("@deductions", MySqlDbType.Decimal);
                            save.Parameters.Add("@unpaid", MySqlDbType.Decimal);
                            save.Parameters.Add("@net", MySqlDbType.Decimal);
                            foreach (DataRow row in salaries.Rows)
                            {
                                save.Parameters["@runId"].Value = runId;
                                save.Parameters["@employeeId"].Value = row["EmployeeId"];
                                save.Parameters["@basic"].Value = row["Basic"];
                                save.Parameters["@allowances"].Value = row["Allowances"];
                                save.Parameters["@standardDeductions"].Value = row["StandardDeductions"];
                                save.Parameters["@gross"].Value = row["Gross"];
                                save.Parameters["@deductions"].Value =
                                    Convert.ToDecimal(row["StandardDeductions"]) + Convert.ToDecimal(row["UnpaidDeduction"]);
                                save.Parameters["@unpaid"].Value = row["UnpaidDeduction"];
                                save.Parameters["@net"].Value = row["Net"];
                                save.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        payroll = salaries;
                    }
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public string GetRunStatus(int year, int month, out string status, out bool isLocked)
        {
            status = "Draft";
            isLocked = false;
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(@"
                    SELECT is_locked FROM payroll_runs WHERE pay_month = @month AND pay_year = @year", conn))
                {
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                        return null;
                    isLocked = Convert.ToBoolean(result);
                    status = isLocked ? "Locked" : "Draft";
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public DataTable GetPayrollRun(int year, int month)
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(@"
                SELECT e.employee_id AS EmployeeId, e.employee_code AS EmployeeCode,
                       CONCAT(e.first_name, ' ', e.last_name) AS FullName,
                       p.basic_salary AS Basic, p.allowances AS Allowances,
                       p.standard_deductions AS Deductions,
                       p.unpaid_deduction AS UnpaidDeduction,
                       p.gross_pay AS Gross, p.net_pay AS Net
                FROM payroll_runs r
                JOIN payslips p ON p.run_id = r.run_id
                JOIN employees e ON e.employee_id = p.employee_id
                WHERE r.pay_month = @month AND r.pay_year = @year
                ORDER BY e.employee_code", conn))
            {
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);
                using (var adapter = new MySqlDataAdapter(cmd))
                    adapter.Fill(table);
            }
            return table;
        }

        public string ApproveAndLock(int year, int month)
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        int runId;
                        bool isLocked;
                        using (var run = new MySqlCommand(@"
                            SELECT run_id, is_locked FROM payroll_runs
                            WHERE pay_month = @month AND pay_year = @year FOR UPDATE", conn, transaction))
                        {
                            run.Parameters.AddWithValue("@month", month);
                            run.Parameters.AddWithValue("@year", year);
                            using (var reader = run.ExecuteReader())
                            {
                                if (!reader.Read())
                                    return "Calculate payroll before approving the month.";
                                runId = reader.GetInt32("run_id");
                                isLocked = reader.GetBoolean("is_locked");
                            }
                        }
                        if (isLocked) return "This month is already locked.";

                        using (var count = new MySqlCommand(
                            "SELECT COUNT(*) FROM payslips WHERE run_id = @runId", conn, transaction))
                        {
                            count.Parameters.AddWithValue("@runId", runId);
                            if (Convert.ToInt32(count.ExecuteScalar()) == 0)
                                return "Calculate payroll before approving the month.";
                        }
                        using (var lockRun = new MySqlCommand(
                            "UPDATE payroll_runs SET is_locked = 1 WHERE run_id = @runId AND is_locked = 0",
                            conn, transaction))
                        {
                            lockRun.Parameters.AddWithValue("@runId", runId);
                            if (lockRun.ExecuteNonQuery() != 1)
                                return "The payroll month could not be locked.";
                        }
                        transaction.Commit();
                    }
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public DataTable GetEmployeePayslips(int employeeId)
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(@"
                SELECT p.payslip_id AS PayslipId, r.pay_month AS MonthNumber,
                       MONTHNAME(STR_TO_DATE(CONCAT(r.pay_year, '-', LPAD(r.pay_month, 2, '0'), '-01'),
                                             '%Y-%m-%d')) AS Month,
                       r.pay_year AS Year, p.gross_pay AS Gross,
                       p.total_deductions AS Deductions, p.net_pay AS Net
                FROM payslips p
                JOIN payroll_runs r ON r.run_id = p.run_id
                WHERE p.employee_id = @employeeId AND r.is_locked = 1
                ORDER BY r.pay_year DESC, r.pay_month DESC", conn))
            {
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                using (var adapter = new MySqlDataAdapter(cmd))
                    adapter.Fill(table);
            }
            return table;
        }

        public DataRow GetEmployeePayslip(int payslipId, int employeeId)
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(@"
                SELECT p.payslip_id AS PayslipId, r.pay_month AS MonthNumber,
                       MONTHNAME(STR_TO_DATE(CONCAT(r.pay_year, '-', LPAD(r.pay_month, 2, '0'), '-01'),
                                             '%Y-%m-%d')) AS Month,
                       r.pay_year AS Year, p.basic_salary AS BasicSalary,
                       p.allowances AS Allowances, p.gross_pay AS Gross,
                       p.standard_deductions AS StandardDeductions,
                       p.unpaid_deduction AS UnpaidDeduction,
                       p.total_deductions AS Deductions, p.net_pay AS Net
                FROM payslips p
                JOIN payroll_runs r ON r.run_id = p.run_id
                WHERE p.payslip_id = @payslipId AND p.employee_id = @employeeId AND r.is_locked = 1", conn))
            {
                cmd.Parameters.AddWithValue("@payslipId", payslipId);
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                using (var adapter = new MySqlDataAdapter(cmd))
                    adapter.Fill(table);
            }
            return table.Rows.Count == 0 ? null : table.Rows[0];
        }
    }
}
