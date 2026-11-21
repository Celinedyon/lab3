using System;
using System.Data;
using MySqlConnector;
using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem.Controllers
{
    public class ReportsController
    {
        public DataTable GetDepartments()
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(
                "SELECT department_id AS DepartmentId, name AS Department FROM departments ORDER BY name", conn))
            using (var adapter = new MySqlDataAdapter(cmd))
                adapter.Fill(table);
            return table;
        }

        public DataTable GetReport(string report, DateTime from, DateTime to, int? departmentId,
            int? managerEmployeeId = null)
        {
            if (from.Date > to.Date)
                throw new ArgumentException("The start date must be on or before the end date.");

            var table = new DataTable();
            string sql;
            switch (report)
            {
                case "Employee list":
                    sql = @"
                        SELECT e.employee_code AS EmployeeCode,
                               CONCAT(e.first_name, ' ', e.last_name) AS FullName,
                               e.email AS Email, e.phone AS Phone, d.name AS Department,
                               p.title AS Position, e.status AS Status, e.hire_date AS HireDate
                        FROM employees e
                        LEFT JOIN departments d ON d.department_id = e.department_id
                        LEFT JOIN positions p ON p.position_id = e.position_id
                        WHERE (@departmentId IS NULL OR e.department_id = @departmentId)
                          AND (@managerId IS NULL OR d.manager_id = @managerId)
                        ORDER BY e.last_name, e.first_name";
                    break;
                case "Attendance report":
                    sql = @"
                        SELECT e.employee_code AS EmployeeCode,
                               CONCAT(e.first_name, ' ', e.last_name) AS Employee,
                               d.name AS Department, a.work_date AS WorkDate,
                               a.clock_in AS ClockIn, a.clock_out AS ClockOut,
                               a.hours_worked AS HoursWorked, a.status AS Status,
                               a.correction_reason AS CorrectionReason
                        FROM attendance a
                        JOIN employees e ON e.employee_id = a.employee_id
                        LEFT JOIN departments d ON d.department_id = e.department_id
                        WHERE a.work_date BETWEEN @from AND @to
                          AND (@departmentId IS NULL OR e.department_id = @departmentId)
                          AND (@managerId IS NULL OR d.manager_id = @managerId)
                        ORDER BY a.work_date DESC, e.last_name, e.first_name";
                    break;
                case "Leave report":
                    sql = @"
                        SELECT e.employee_code AS EmployeeCode,
                               CONCAT(e.first_name, ' ', e.last_name) AS Employee,
                               d.name AS Department, t.name AS LeaveType,
                               r.start_date AS StartDate, r.end_date AS EndDate,
                               r.days AS Days, r.status AS Status, r.reason AS Reason
                        FROM leave_requests r
                        JOIN employees e ON e.employee_id = r.employee_id
                        JOIN leave_types t ON t.leave_type_id = r.leave_type_id
                        LEFT JOIN departments d ON d.department_id = e.department_id
                        WHERE r.start_date <= @to AND r.end_date >= @from
                          AND (@departmentId IS NULL OR e.department_id = @departmentId)
                          AND (@managerId IS NULL OR d.manager_id = @managerId)
                        ORDER BY r.start_date DESC, e.last_name, e.first_name";
                    break;
                case "Payroll report":
                    sql = @"
                        SELECT r.pay_year AS Year, r.pay_month AS Month,
                               e.employee_code AS EmployeeCode,
                               CONCAT(e.first_name, ' ', e.last_name) AS Employee,
                               d.name AS Department, p.gross_pay AS GrossPay,
                               p.total_deductions AS TotalDeductions,
                               p.unpaid_deduction AS UnpaidDeduction,
                               p.net_pay AS NetPay, r.is_locked AS Approved
                        FROM payroll_runs r
                        JOIN payslips p ON p.run_id = r.run_id
                        JOIN employees e ON e.employee_id = p.employee_id
                        LEFT JOIN departments d ON d.department_id = e.department_id
                        WHERE DATE(CONCAT(r.pay_year, '-', LPAD(r.pay_month, 2, '0'), '-01')) <= @to
                          AND LAST_DAY(DATE(CONCAT(r.pay_year, '-', LPAD(r.pay_month, 2, '0'), '-01'))) >= @from
                          AND (@departmentId IS NULL OR e.department_id = @departmentId)
                          AND (@managerId IS NULL OR d.manager_id = @managerId)
                        ORDER BY r.pay_year DESC, r.pay_month DESC, e.last_name, e.first_name";
                    break;
                default:
                    throw new ArgumentException("Select a valid report type.");
            }

            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@from", from.Date);
                cmd.Parameters.AddWithValue("@to", to.Date);
                cmd.Parameters.AddWithValue("@departmentId",
                    departmentId.HasValue ? (object)departmentId.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@managerId",
                    managerEmployeeId.HasValue ? (object)managerEmployeeId.Value : DBNull.Value);
                using (var adapter = new MySqlDataAdapter(cmd))
                    adapter.Fill(table);
            }
            return table;
        }
    }
}
