using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using MySqlConnector;
using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem.Controllers
{
    public class PasswordController
    {
        public string LastResetCode { get; private set; }

        public string ChangePassword(int userId, string currentPassword, string newPassword)
        {
            if (userId <= 0) return "The signed-in account is invalid.";
            string validationError = ValidateNewPassword(newPassword);
            if (validationError != null) return validationError;
            if (string.IsNullOrEmpty(currentPassword)) return "Enter your current password.";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string passwordHash;
                    using (var query = new MySqlCommand(
                        "SELECT password_hash FROM users WHERE user_id = @userId AND is_active = 1", conn))
                    {
                        query.Parameters.AddWithValue("@userId", userId);
                        object result = query.ExecuteScalar();
                        if (result == null || result == DBNull.Value)
                            return "The account is inactive or no longer exists.";
                        passwordHash = Convert.ToString(result);
                    }

                    if (!BCrypt.Net.BCrypt.Verify(currentPassword, passwordHash))
                        return "The current password is incorrect.";

                    using (var update = new MySqlCommand(@"
                        UPDATE users SET password_hash = @hash, reset_token = NULL,
                                         reset_token_expires_at = NULL
                        WHERE user_id = @userId AND is_active = 1", conn))
                    {
                        update.Parameters.AddWithValue("@hash", BCrypt.Net.BCrypt.HashPassword(newPassword));
                        update.Parameters.AddWithValue("@userId", userId);
                        if (update.ExecuteNonQuery() != 1)
                            return "The password could not be updated.";
                    }
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public string SendResetCode(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return "Enter your email address.";
            string smtpError;
            SmtpSettings settings = GetSmtpSettings(out smtpError);

            string code = CreateToken();
            string tokenHash = HashToken(code);
            bool accountFound;
            try
            {
                using (var conn = Database.GetConnection())
                using (var update = new MySqlCommand(@"
                    UPDATE users
                    SET reset_token = @token, reset_token_expires_at = DATE_ADD(UTC_TIMESTAMP(), INTERVAL 30 MINUTE)
                    WHERE email = @email AND is_active = 1", conn))
                {
                    conn.Open();
                    update.Parameters.AddWithValue("@token", tokenHash);
                    update.Parameters.AddWithValue("@email", email.Trim());
                    accountFound = update.ExecuteNonQuery() == 1;
                }
            }
            catch (MySqlException ex) { return ex.Message; }

            if (!accountFound) return null;
            LastResetCode = settings == null ? code : null;
            if (settings == null) return null;
            try
            {
                using (var message = new MailMessage(settings.From, email.Trim()))
                {
                    message.Subject = "Employee Management System password reset";
                    message.Body = "Your password reset code is:\r\n\r\n" + code +
                        "\r\n\r\nThis code expires in 30 minutes. If you did not request a reset, ignore this email.";
                    using (var client = new SmtpClient(settings.Host, settings.Port))
                    {
                        client.EnableSsl = settings.EnableSsl;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential(settings.Username, settings.Password);
                        client.Send(message);
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                try
                {
                    using (var conn = Database.GetConnection())
                    using (var clear = new MySqlCommand(@"
                        UPDATE users SET reset_token = NULL, reset_token_expires_at = NULL
                        WHERE email = @email AND reset_token = @token", conn))
                    {
                        conn.Open();
                        clear.Parameters.AddWithValue("@email", email.Trim());
                        clear.Parameters.AddWithValue("@token", tokenHash);
                        clear.ExecuteNonQuery();
                    }
                }
                catch (MySqlException clearError)
                {
                    return "The reset email could not be sent, and the temporary reset code could not be cleared: " +
                        ex.Message + " " + clearError.Message;
                }
                return "The reset email could not be sent: " + ex.Message;
            }
        }

        public string ResetPassword(string code, string newPassword)
        {
            string validationError = ValidateNewPassword(newPassword);
            if (validationError != null) return validationError;
            if (string.IsNullOrWhiteSpace(code)) return "Enter the reset code from your email.";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        int userId;
                        using (var query = new MySqlCommand(@"
                            SELECT user_id FROM users
                            WHERE reset_token = @token AND reset_token_expires_at > UTC_TIMESTAMP()
                              AND is_active = 1
                            FOR UPDATE", conn, transaction))
                        {
                            query.Parameters.AddWithValue("@token", HashToken(code.Trim()));
                            object result = query.ExecuteScalar();
                            if (result == null || result == DBNull.Value)
                                return "The reset code is invalid or has expired.";
                            userId = Convert.ToInt32(result);
                        }

                        using (var update = new MySqlCommand(@"
                            UPDATE users
                            SET password_hash = @hash, reset_token = NULL, reset_token_expires_at = NULL
                            WHERE user_id = @userId AND is_active = 1", conn, transaction))
                        {
                            update.Parameters.AddWithValue("@hash", BCrypt.Net.BCrypt.HashPassword(newPassword));
                            update.Parameters.AddWithValue("@userId", userId);
                            if (update.ExecuteNonQuery() != 1)
                                return "The password could not be reset.";
                        }
                        transaction.Commit();
                    }
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        private static string ValidateNewPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                return "The new password must be at least 8 characters long.";
            return null;
        }

        private static string CreateToken()
        {
            byte[] bytes = new byte[32];
            using (var generator = RandomNumberGenerator.Create())
                generator.GetBytes(bytes);
            return Convert.ToBase64String(bytes).TrimEnd('=').Replace('+', '-').Replace('/', '_');
        }

        private static string HashToken(string token)
        {
            using (var sha = SHA256.Create())
            {
                byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(token));
                var result = new StringBuilder(hash.Length * 2);
                foreach (byte value in hash)
                    result.Append(value.ToString("x2"));
                return result.ToString();
            }
        }

        private static SmtpSettings GetSmtpSettings(out string error)
        {
            error = null;
            string host = GetSetting("EMS_SMTP_HOST");
            string username = GetSetting("EMS_SMTP_USER");
            string password = GetSetting("EMS_SMTP_PASSWORD");
            string from = GetSetting("EMS_SMTP_FROM");
            string portValue = GetSetting("EMS_SMTP_PORT");
            string sslValue = GetSetting("EMS_SMTP_SSL");
            int port;
            if (string.IsNullOrWhiteSpace(host) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(from))
            {
                error = "Password reset email is not configured. Set EMS_SMTP_HOST, EMS_SMTP_PORT, " +
                    "EMS_SMTP_USER, EMS_SMTP_PASSWORD, EMS_SMTP_FROM, and EMS_SMTP_SSL.";
                return null;
            }

            if (!int.TryParse(portValue, out port) || port < 1 || port > 65535)
            {
                error = "EMS_SMTP_PORT must be a valid TCP port.";
                return null;
            }

            bool enableSsl;
            if (!bool.TryParse(sslValue, out enableSsl))
            {
                error = "EMS_SMTP_SSL must be set to true or false.";
                return null;
            }

            try
            {
                var sender = new MailAddress(from);
                return new SmtpSettings
                {
                    Host = host,
                    Port = port,
                    Username = username,
                    Password = password,
                    From = sender.ToString(),
                    EnableSsl = enableSsl
                };
            }
            catch (FormatException)
            {
                error = "EMS_SMTP_FROM must be a valid email address.";
                return null;
            }
        }

        private static string GetSetting(string name)
        {
            string value = Environment.GetEnvironmentVariable(name);
            if (!string.IsNullOrWhiteSpace(value)) return value;
            return ConfigurationManager.AppSettings[name];
        }

        private sealed class SmtpSettings
        {
            public string Host { get; set; }
            public int Port { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string From { get; set; }
            public bool EnableSsl { get; set; }
        }
    }
}
