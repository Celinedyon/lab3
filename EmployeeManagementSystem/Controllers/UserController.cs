using System;
using System.Data;
using System.Net.Mail;
using MySqlConnector;
using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem.Controllers
{
    public class UserController
    {
        public DataTable GetAll()
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(
                "SELECT user_id AS ID, email AS Email, role AS Role, is_active AS Active FROM users ORDER BY email", conn))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                adapter.Fill(table);
            }
            return table;
        }

        public string Create(string email, string password, string role)
        {
            string validationError = ValidateAccount(email, password, role, true);
            if (validationError != null) return validationError;

            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(
                    @"INSERT INTO users (email, password_hash, role, is_active, employee_id)
                      VALUES (@email, @hash, @role, 1,
                          (SELECT employee_id FROM employees WHERE email = @email LIMIT 1))", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@email", email.Trim());
                    cmd.Parameters.AddWithValue("@hash", BCrypt.Net.BCrypt.HashPassword(password));
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.ExecuteNonQuery();
                }
                return null;
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
        }

        public string Update(int userId, string email, string role, bool isActive, string password)
        {
            string validationError = ValidateAccount(email, password, role, !string.IsNullOrWhiteSpace(password));
            if (validationError != null) return validationError;

            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(
                    @"UPDATE users SET email = @email, role = @role, is_active = @active,
                        employee_id = (SELECT employee_id FROM employees WHERE email = @email LIMIT 1),
                        reset_token = NULL, reset_token_expires_at = NULL" +
                    (string.IsNullOrWhiteSpace(password) ? "" : ", password_hash = @hash") +
                    " WHERE user_id = @id", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@email", email.Trim());
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@active", isActive);
                    cmd.Parameters.AddWithValue("@id", userId);
                    if (!string.IsNullOrWhiteSpace(password))
                        cmd.Parameters.AddWithValue("@hash", BCrypt.Net.BCrypt.HashPassword(password));
                    cmd.ExecuteNonQuery();
                }
                return null;
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
        }

        private static string ValidateAccount(string email, string password, string role, bool requirePassword)
        {
            if (string.IsNullOrWhiteSpace(email)) return "Email is required.";
            if (email.Trim().Length > 150) return "Email cannot exceed 150 characters.";
            if (requirePassword && (string.IsNullOrEmpty(password) || password.Length < 8))
                return "Password must be at least 8 characters long.";
            if (!string.IsNullOrEmpty(password) && password.Length < 8)
                return "Password must be at least 8 characters long.";
            if (role != "Administrator" && role != "HR Officer" && role != "Manager" && role != "Employee")
                return "Select a valid user role.";

            try
            {
                var address = new MailAddress(email.Trim());
                if (!string.Equals(address.Address, email.Trim(), StringComparison.OrdinalIgnoreCase))
                    return "Enter a valid email address.";
            }
            catch (FormatException) { return "Enter a valid email address."; }
            return null;
        }
    }
}
