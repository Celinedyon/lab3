namespace EmployeeManagementSystem.Model
{
    public class LeaveType
    {
        public int LeaveTypeId { get; set; }
        public string Name { get; set; }
        public decimal AllowedDays { get; set; }
        public bool IsPaid { get; set; }
        public bool IsActive { get; set; }
    }
}