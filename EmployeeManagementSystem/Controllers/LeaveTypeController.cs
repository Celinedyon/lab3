using System;
using System.Data;
using MySqlConnector;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Controllers
{
    public class LeaveTypeController
    {
        public DataTable GetAll()
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("SELECT leave_type_id AS ID, name AS Name, days_allowed AS DaysAllowed, is_paid AS IsPaid, is_active FROM leave_types ORDER BY name", conn))
            using (var adapter = new MySqlDataAdapter(cmd))
                adapter.Fill(table);
            return table;
        }

        public LeaveType GetById(int id)
        {
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand("SELECT * FROM leave_types WHERE leave_type_id = @id", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);
                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return null;
                    return new LeaveType
                    {
                        LeaveTypeId = r.GetInt32("leave_type_id"),
                        Name = r.GetString("name"),
                        AllowedDays = r.GetDecimal("days_allowed"),
                        IsPaid = r.GetBoolean("is_paid"),
                        IsActive = r.GetBoolean("is_active")
                    };
                }
            }
        }

        public string Create(LeaveType lt)
        {
            if (string.IsNullOrWhiteSpace(lt.Name)) return "Leave type name is required.";
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(
                    "INSERT INTO leave_types (name, days_allowed, is_paid, is_active) VALUES (@name, @days, @paid, 1)", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", lt.Name);
                    cmd.Parameters.AddWithValue("@days", lt.AllowedDays);
                    cmd.Parameters.AddWithValue("@paid", lt.IsPaid);
                    cmd.ExecuteNonQuery();
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public string Update(LeaveType lt)
        {
            if (lt.LeaveTypeId <= 0) return "Invalid leave type.";
            if (string.IsNullOrWhiteSpace(lt.Name)) return "Leave type name is required.";
            if (lt.AllowedDays < 0) return "Allowed days cannot be negative.";
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(
                    "UPDATE leave_types SET name = @name, days_allowed = @days, is_paid = @paid, is_active = @active WHERE leave_type_id = @id", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", lt.LeaveTypeId);
                    cmd.Parameters.AddWithValue("@name", lt.Name);
                    cmd.Parameters.AddWithValue("@days", lt.AllowedDays);
                    cmd.Parameters.AddWithValue("@paid", lt.IsPaid);
                    cmd.Parameters.AddWithValue("@active", lt.IsActive);
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
                using (var cmd = new MySqlCommand("UPDATE leave_types SET is_active = 0 WHERE leave_type_id = @id", conn))
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