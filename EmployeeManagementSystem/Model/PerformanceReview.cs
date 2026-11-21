using System;

namespace EmployeeManagementSystem.Model
{
    public class PerformanceReview
    {
        public int ReviewId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int ManagerId { get; set; }
        public string ReviewerName { get; set; }
        public DateTime ReviewDate { get; set; }
        public decimal Rating { get; set; }
        public string Comments { get; set; }
    }
}