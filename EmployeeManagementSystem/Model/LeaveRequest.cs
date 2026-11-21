using System;

namespace EmployeeManagementSystem.Model
{
    public class LeaveRequest
    {
        public int RequestId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int LeaveTypeId { get; set; }
        public string LeaveType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Days { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; } // Pending, Approved, Rejected
        public int? ReviewedBy { get; set; }
        public DateTime? ReviewedAt { get; set; }
    }
}