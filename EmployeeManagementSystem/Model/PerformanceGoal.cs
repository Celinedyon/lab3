using System;

namespace EmployeeManagementSystem.Model
{
    public class PerformanceGoal
    {
        public int GoalId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int ManagerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string Status { get; set; } // Open, Completed, Cancelled
    }
}