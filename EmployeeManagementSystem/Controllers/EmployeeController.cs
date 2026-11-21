using System;
using System.Data;
using MySqlConnector;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeController
    {
        public DataTable GetAll(string search = null, string department = null, string status = null)
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT e.employee_id, e.employee_code, e.first_name, e.last_name, e.email,
                           e.phone, e.address, e.date_of_birth, e.gender, e.hire_date,
                           CONCAT(e.first_name, ' ', e.last_name) AS FullName,
                           e.department_id, d.name AS department,
                           e.position_id, p.title AS position,
                           NULL AS manager_id, NULL AS mgr_first, NULL AS mgr_last,
                           e.status, e.emergency_name, e.emergency_phone,
                           COALESCE(s.basic_salary, 0) AS salary,
                           COALESCE(s.allowances, 0) AS allowances,
                           COALESCE(s.deductions, 0) AS deductions
                    FROM employees e
                    LEFT JOIN departments d ON e.department_id = d.department_id
                    LEFT JOIN positions p ON e.position_id = p.position_id
                    LEFT JOIN salaries s ON e.employee_id = s.employee_id
                    WHERE 1=1";
                if (!string.IsNullOrWhiteSpace(search))
                    sql += " AND (e.employee_code LIKE @search OR e.first_name LIKE @search OR e.last_name LIKE @search OR e.email LIKE @search)";
                if (!string.IsNullOrWhiteSpace(department))
                    sql += " AND d.name = @department";
                if (!string.IsNullOrWhiteSpace(status))
                    sql += " AND e.status = @status";
                sql += " ORDER BY e.employee_code";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    if (!string.IsNullOrWhiteSpace(search))
                        cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                    if (!string.IsNullOrWhiteSpace(department))
                        cmd.Parameters.AddWithValue("@department", department);
                    if (!string.IsNullOrWhiteSpace(status))
                        cmd.Parameters.AddWithValue("@status", status);
                    using (var adapter = new MySqlDataAdapter(cmd))
                        adapter.Fill(table);
                }
            }
            return table;
        }
        public Employee GetById(int employeeId)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT e.employee_id, e.employee_code, e.first_name, e.last_name, e.email,
                           e.phone, e.address, e.date_of_birth, e.gender, e.hire_date,
                           e.department_id, d.name AS department,
                           e.position_id, p.title AS position,
                           NULL AS manager_id, NULL AS mgr_first, NULL AS mgr_last,
                           e.status, e.emergency_name, e.emergency_phone,
                           COALESCE(s.basic_salary, 0) AS salary,
                           COALESCE(s.allowances, 0) AS allowances,
                           COALESCE(s.deductions, 0) AS deductions
                    FROM employees e
                    LEFT JOIN departments d ON e.department_id = d.department_id
                    LEFT JOIN positions p ON e.position_id = p.position_id
                    LEFT JOIN salaries s ON e.employee_id = s.employee_id
                    WHERE e.employee_id = @id";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", employeeId);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (!r.Read()) return null;
                        return ReadEmployee(r);
                    }
                }
            }
        }

        public string Create(Employee emp)
        {
            if (string.IsNullOrWhiteSpace(emp.FirstName) || string.IsNullOrWhiteSpace(emp.LastName)
                || string.IsNullOrWhiteSpace(emp.Email))
                return "First name, last name and email are required.";
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string code = GenerateEmployeeCode(conn);
                    string sql = @"
                        INSERT INTO employees (employee_code, first_name, last_name, email, phone, address,
                                               date_of_birth, gender, hire_date, department_id, position_id,
                                               status, emergency_name, emergency_phone)
                        VALUES (@code, @first, @last, @email, @phone, @address,
                                @dob, @gender, @hire, @dept, @pos, 'Active', @emgName, @emgPhone)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@first", emp.FirstName);
                        cmd.Parameters.AddWithValue("@last", emp.LastName);
                        cmd.Parameters.AddWithValue("@email", emp.Email);
                        cmd.Parameters.AddWithValue("@phone", (object)emp.Phone ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@address", (object)emp.Address ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@dob", (object)emp.DateOfBirth ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@gender", (object)emp.Gender ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@hire", emp.HireDate == default ? (object)DateTime.Today : emp.HireDate);
                        cmd.Parameters.AddWithValue("@dept", (object)emp.DepartmentId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@pos", (object)emp.PositionId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@emgName", (object)emp.EmergencyName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@emgPhone", (object)emp.EmergencyPhone ?? DBNull.Value);
                        cmd.ExecuteNonQuery();
                        int employeeId = Convert.ToInt32(cmd.LastInsertedId);
                        SaveSalary(conn, employeeId, emp.Salary, emp.Allowances, emp.Deductions);
                    }
                    InitializeLeaveBalances(conn, code);
                }
                return null;
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
        }
        public string Update(Employee emp)
        {
            if (emp.EmployeeId <= 0) return "Invalid employee.";
            if (string.IsNullOrWhiteSpace(emp.FirstName) || string.IsNullOrWhiteSpace(emp.LastName)
                || string.IsNullOrWhiteSpace(emp.Email))
                return "First name, last name and email are required.";
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        UPDATE employees SET first_name=@first, last_name=@last, email=@email,
                            phone=@phone, address=@address, date_of_birth=@dob, gender=@gender, hire_date=@hire,
                            department_id=@dept, position_id=@pos, status=@status,
                            emergency_name=@emgName, emergency_phone=@emgPhone
                        WHERE employee_id=@id";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", emp.EmployeeId);
                        cmd.Parameters.AddWithValue("@first", emp.FirstName);
                        cmd.Parameters.AddWithValue("@last", emp.LastName);
                        cmd.Parameters.AddWithValue("@email", emp.Email);
                        cmd.Parameters.AddWithValue("@phone", (object)emp.Phone ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@address", (object)emp.Address ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@dob", (object)emp.DateOfBirth ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@gender", (object)emp.Gender ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@hire", emp.HireDate == default ? (object)DateTime.Today : emp.HireDate);
                        cmd.Parameters.AddWithValue("@dept", (object)emp.DepartmentId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@pos", (object)emp.PositionId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@status", emp.Status);
                        cmd.Parameters.AddWithValue("@emgName", (object)emp.EmergencyName ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@emgPhone", (object)emp.EmergencyPhone ?? DBNull.Value);
                        cmd.ExecuteNonQuery();
                        SaveSalary(conn, emp.EmployeeId, emp.Salary, emp.Allowances, emp.Deductions);
                    }
                }
                return null;
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
        }
        public string SetStatus(int employeeId, string status)
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(
                        "UPDATE employees SET status = @status WHERE employee_id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@id", employeeId);
                        cmd.ExecuteNonQuery();
                    }
                }
                return null;
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
        }

        public DataTable GetDepartments()
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("SELECT department_id, name FROM departments WHERE is_active = 1 ORDER BY name", conn))
            using (var adapter = new MySqlDataAdapter(cmd))
                adapter.Fill(table);
            return table;
        }

        public DataTable GetPositions()
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("SELECT position_id, title FROM positions WHERE is_active = 1 ORDER BY title", conn))
            using (var adapter = new MySqlDataAdapter(cmd))
                adapter.Fill(table);
            return table;
        }

        public DataTable GetEmployees()
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("SELECT employee_id, employee_code, first_name, last_name FROM employees WHERE status = 'Active' ORDER BY employee_code", conn))
            using (var adapter = new MySqlDataAdapter(cmd))
                adapter.Fill(table);
            return table;
        }
        private string GenerateEmployeeCode(MySqlConnection conn)
        {
            using (var cmd = new MySqlCommand("SELECT IFNULL(MAX(CAST(SUBSTRING(employee_code, 4) AS UNSIGNED)), 0) FROM employees WHERE employee_code LIKE 'EMP%'", conn))
            {
                int next = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                return $"EMP{next:D4}";
            }
        }

        private void InitializeLeaveBalances(MySqlConnection conn, string employeeCode)
        {
            int employeeId = 0;
            using (var cmd = new MySqlCommand("SELECT employee_id FROM employees WHERE employee_code = @code", conn))
            {
                cmd.Parameters.AddWithValue("@code", employeeCode);
                var result = cmd.ExecuteScalar();
                if (result != null) employeeId = Convert.ToInt32(result);
            }
            if (employeeId == 0) return;
            int year = DateTime.Now.Year;
            using (var cmd = new MySqlCommand(
                @"INSERT INTO leave_balances (employee_id, leave_type_id, year, allocated_days, days_used)
                  SELECT @empId, leave_type_id, @year, days_allowed, 0 FROM leave_types WHERE is_active = 1
                  ON DUPLICATE KEY UPDATE allocated_days = VALUES(allocated_days)", conn))
            {
                cmd.Parameters.AddWithValue("@empId", employeeId);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.ExecuteNonQuery();
            }
        }

        private void SaveSalary(MySqlConnection conn, int employeeId, decimal basicSalary, decimal allowances, decimal deductions)
        {
            using (var cmd = new MySqlCommand(@"
                INSERT INTO salaries (employee_id, basic_salary, allowances, deductions)
                VALUES (@employeeId, @salary, @allowances, @deductions)
                ON DUPLICATE KEY UPDATE basic_salary = VALUES(basic_salary),
                    allowances = VALUES(allowances), deductions = VALUES(deductions)", conn))
            {
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                cmd.Parameters.AddWithValue("@salary", basicSalary);
                cmd.Parameters.AddWithValue("@allowances", allowances);
                cmd.Parameters.AddWithValue("@deductions", deductions);
                cmd.ExecuteNonQuery();
            }
        }

        private Employee ReadEmployee(MySqlDataReader r)
        {
            return new Employee
            {
                EmployeeId = r.GetInt32("employee_id"),
                EmployeeCode = r.GetString("employee_code"),
                FirstName = r.GetString("first_name"),
                LastName = r.GetString("last_name"),
                Email = r.GetString("email"),
                Phone = r.IsDBNull(r.GetOrdinal("phone")) ? null : r.GetString("phone"),
                Address = r.IsDBNull(r.GetOrdinal("address")) ? null : r.GetString("address"),
                DateOfBirth = r.IsDBNull(r.GetOrdinal("date_of_birth")) ? (DateTime?)null : r.GetDateTime("date_of_birth"),
                Gender = r.IsDBNull(r.GetOrdinal("gender")) ? null : r.GetString("gender"),
                HireDate = r.GetDateTime("hire_date"),
                DepartmentId = r.IsDBNull(r.GetOrdinal("department_id")) ? (int?)null : r.GetInt32("department_id"),
                Department = r.IsDBNull(r.GetOrdinal("department")) ? null : r.GetString("department"),
                PositionId = r.IsDBNull(r.GetOrdinal("position_id")) ? (int?)null : r.GetInt32("position_id"),
                Position = r.IsDBNull(r.GetOrdinal("position")) ? null : r.GetString("position"),
                ManagerId = r.IsDBNull(r.GetOrdinal("manager_id")) ? (int?)null : r.GetInt32("manager_id"),
                ManagerName = r.IsDBNull(r.GetOrdinal("mgr_first")) ? null : r.GetString("mgr_first") + " " + r.GetString("mgr_last"),
                Status = r.GetString("status"),
                EmergencyName = r.IsDBNull(r.GetOrdinal("emergency_name")) ? null : r.GetString("emergency_name"),
                EmergencyPhone = r.IsDBNull(r.GetOrdinal("emergency_phone")) ? null : r.GetString("emergency_phone"),
                Salary = r.GetDecimal("salary"),
                Allowances = r.GetDecimal("allowances"),
                Deductions = r.GetDecimal("deductions")
            };
        }
    }
}