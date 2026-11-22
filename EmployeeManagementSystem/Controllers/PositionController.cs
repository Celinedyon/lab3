using System;
using System.Data;
using MySqlConnector;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Controllers
{
    public class PositionController
    {
        public DataTable GetAll()
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("SELECT p.position_id AS ID, p.title AS Title, p.description, p.department_id, d.name AS Department, p.is_active FROM positions p LEFT JOIN departments d ON d.department_id = p.department_id ORDER BY p.title", conn))
            using (var adapter = new MySqlDataAdapter(cmd))
                adapter.Fill(table);
            return table;
        }

        public Position GetById(int id)
        {
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("SELECT * FROM positions WHERE position_id = @id", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);
                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return null;
                    return new Position
                    {
                        PositionId = r.GetInt32("position_id"),
                        Title = r.GetString("title"),
                        Description = r.IsDBNull(r.GetOrdinal("description")) ? null : r.GetString("description"),
                        DepartmentId = r.IsDBNull(r.GetOrdinal("department_id")) ? (int?)null : r.GetInt32("department_id"),
                        Department = r.IsDBNull(r.GetOrdinal("department")) ? null : r.GetString("department"),
                        IsActive = r.GetBoolean("is_active")
                    };
                }
            }
        }

        public string Create(Position pos)
        {
            if (string.IsNullOrWhiteSpace(pos.Title)) return "Position title is required.";
            if (!pos.DepartmentId.HasValue) return "Select a department for this position.";
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(
                    "INSERT INTO positions (title, description, department_id, is_active) VALUES (@title, @desc, @department, 1)", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@title", pos.Title);
                    cmd.Parameters.AddWithValue("@desc", (object)pos.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@department", (object)pos.DepartmentId ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public string Update(Position pos)
        {
            if (pos.PositionId <= 0) return "Invalid position.";
            if (string.IsNullOrWhiteSpace(pos.Title)) return "Position title is required.";
            if (!pos.DepartmentId.HasValue) return "Select a department for this position.";
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(
                    "UPDATE positions SET title = @title, description = @desc, department_id = @department, is_active = @active WHERE position_id = @id", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", pos.PositionId);
                    cmd.Parameters.AddWithValue("@title", pos.Title);
                    cmd.Parameters.AddWithValue("@desc", (object)pos.Description ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@department", (object)pos.DepartmentId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@active", pos.IsActive);
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
                using (var cmd = new MySqlCommand("UPDATE positions SET is_active = 0 WHERE position_id = @id", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }
    }
}