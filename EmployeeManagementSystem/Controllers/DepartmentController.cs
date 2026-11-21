using System;
using System.Data;
using MySqlConnector;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Controllers
{
    public class DepartmentController
    {
        public DataTable GetAll()
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(@"
                SELECT d.department_id AS ID, d.name AS Name, d.manager_id,
                       CONCAT(m.first_name, ' ', m.last_name) AS Manager,
                       (SELECT COUNT(*) FROM employees e WHERE e.department_id = d.department_id) AS EmployeeCount,
                       d.is_active
                FROM departments d
                LEFT JOIN employees m ON d.manager_id = m.employee_id
                ORDER BY d.name", conn))
            using (var adapter = new MySqlDataAdapter(cmd))
                adapter.Fill(table);
            return table;
        }

        public Department GetById(int id)
        {
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(            "SELECT * FROM departments WHERE department_id = @id", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);
                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return null;
                    return new Department
                    {
                        DepartmentId = r.GetInt32("department_id"),
                        Name = r.GetString("name"),
                        ManagerEmployeeId = r.IsDBNull(r.GetOrdinal("manager_id")) ? (int?)null : r.GetInt32("manager_id"),
                        IsActive = r.GetBoolean("is_active")
                    };
                }
            }
        }

        public string Create(Department dept)
        {
            if (string.IsNullOrWhiteSpace(dept.Name)) return "Department name is required.";
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(
                    "INSERT INTO departments (name, manager_id, is_active) VALUES (@name, @mgr, 1)", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", dept.Name);
                    cmd.Parameters.AddWithValue("@mgr", (object)dept.ManagerEmployeeId ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public string Update(Department dept)
        {
            if (dept.DepartmentId <= 0) return "Invalid department.";
            if (string.IsNullOrWhiteSpace(dept.Name)) return "Department name is required.";
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(
                    "UPDATE departments SET name = @name, manager_id = @mgr, is_active = @active WHERE department_id = @id", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", dept.DepartmentId);
                    cmd.Parameters.AddWithValue("@name", dept.Name);
                    cmd.Parameters.AddWithValue("@mgr", (object)dept.ManagerEmployeeId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@active", dept.IsActive);
                    cmd.ExecuteNonQuery();
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public string Delete(int id)
        {
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("UPDATE departments SET is_active = 0 WHERE department_id = @id", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public DataTable GetManagers()
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("SELECT employee_id, CONCAT(employee_code, ' - ', first_name, ' ', last_name) AS name FROM employees WHERE status = 'Active' ORDER BY employee_code", conn))
            using (var adapter = new MySqlDataAdapter(cmd))
                adapter.Fill(table);
            return table;
        }
    }
}