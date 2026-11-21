using System;

namespace EmployeeManagementSystem.Model
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public string Status => IsRead ? "Read" : "Unread";
        public DateTime CreatedAt { get; set; }
    }
}