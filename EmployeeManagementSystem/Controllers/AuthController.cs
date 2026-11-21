using System;
using MySqlConnector;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Controllers
{
    public class AuthController
    {
        // Returns the user if the login is valid, otherwise null
        public User Login(string email, string password)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var link = new MySqlCommand(
                    "UPDATE users u JOIN employees e ON e.email = u.email " +
                    "SET u.employee_id = e.employee_id " +
                    "WHERE u.email = @email AND u.employee_id IS NULL", conn))
                {
                    link.Parameters.AddWithValue("@email", email.Trim());
                    link.ExecuteNonQuery();
                }
                string sql = "SELECT u.user_id, u.email, u.password_hash, u.role, u.is_active, " +
                             "COALESCE(u.employee_id, e.employee_id) AS employee_id " +
                             "FROM users u LEFT JOIN employees e ON e.email = u.email " +
                             "WHERE u.email = @email";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (!r.Read()) return null;

                        var user = new User
                        {
                            UserId = r.GetInt32("user_id"),
                            Email = r.GetString("email"),
                            PasswordHash = r.GetString("password_hash"),
                            Role = r.GetString("role"),
                            IsActive = r.GetBoolean("is_active"),
                            EmployeeId = r.IsDBNull(r.GetOrdinal("employee_id"))
                                ? (int?)null : r.GetInt32("employee_id")
                        };

                        if (!user.IsActive) return null;
                        if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash)) return null;
                        return user;
                    }
                }
            }
        }

        // Creates the first admin account if the users table is empty
        public void EnsureAdminExists()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var check = new MySqlCommand("SELECT COUNT(*) FROM users", conn))
                {
                    long count = Convert.ToInt64(check.ExecuteScalar());
                    if (count > 0) return;
                }

                string sql = "INSERT INTO users (email, password_hash, role) " +
                             "VALUES (@email, @hash, 'Administrator')";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@email", "admin@ems.com");
                    cmd.Parameters.AddWithValue("@hash", BCrypt.Net.BCrypt.HashPassword("Admin@123"));
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}