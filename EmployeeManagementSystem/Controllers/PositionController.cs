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
            using (var cmd = new MySqlCommand("SELECT position_id AS ID, title AS Title, description, is_active FROM positions ORDER BY title", conn))
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
                        IsActive = r.GetBoolean("is_active")
                    };
                }
            }
        }

        public string Create(Position pos)
        {
            if (string.IsNullOrWhiteSpace(pos.Title)) return "Position title is required.";
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(
                    "INSERT INTO positions (title, description, is_active) VALUES (@title, @desc, 1)", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@title", pos.Title);
                    cmd.Parameters.AddWithValue("@desc", (object)pos.Description ?? DBNull.Value);
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
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(
                    "UPDATE positions SET title = @title, description = @desc, is_active = @active WHERE position_id = @id", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", pos.PositionId);
                    cmd.Parameters.AddWithValue("@title", pos.Title);
                    cmd.Parameters.AddWithValue("@desc", (object)pos.Description ?? DBNull.Value);
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