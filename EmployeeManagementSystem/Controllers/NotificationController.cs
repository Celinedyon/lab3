using System;
using System.Data;
using MySqlConnector;
using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem.Controllers
{
    public class NotificationController
    {
        public DataTable GetAll(int userId)
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(@"
                SELECT notification_id, created_at AS CreatedAt, message AS Message,
                       CASE WHEN is_read = 1 THEN 'Read' ELSE 'Unread' END AS Status
                FROM notifications
                WHERE user_id = @userId
                ORDER BY created_at DESC, notification_id DESC", conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                using (var adapter = new MySqlDataAdapter(cmd))
                    adapter.Fill(table);
            }
            return table;
        }

        public string MarkRead(int notificationId, int userId)
        {
            if (notificationId <= 0 || userId <= 0) return "Select a notification.";
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(
                    "UPDATE notifications SET is_read = 1 WHERE notification_id = @id AND user_id = @userId", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", notificationId);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        using (var check = new MySqlCommand(
                            "SELECT COUNT(*) FROM notifications WHERE notification_id = @id AND user_id = @userId", conn))
                        {
                            check.Parameters.AddWithValue("@id", notificationId);
                            check.Parameters.AddWithValue("@userId", userId);
                            if (Convert.ToInt32(check.ExecuteScalar()) == 0)
                                return "The notification no longer exists.";
                        }
                    }
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public string MarkAllRead(int userId)
        {
            if (userId <= 0) return "Invalid user account.";
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(
                    "UPDATE notifications SET is_read = 1 WHERE user_id = @userId AND is_read = 0", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }
    }
}
