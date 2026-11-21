namespace EmployeeManagementSystem.Model
{
    public class LeaveBalance
    {
        public int BalanceId { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public string LeaveType { get; set; }
        public int Year { get; set; }
        public decimal AllocatedDays { get; set; }
        public decimal UsedDays { get; set; }
        public decimal RemainingDays => AllocatedDays - UsedDays;
    }
}