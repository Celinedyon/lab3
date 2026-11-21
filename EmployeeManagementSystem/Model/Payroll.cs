namespace EmployeeManagementSystem.Model
{
    public class Payroll
    {
        public int PayrollId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public int PeriodYear { get; set; }
        public int PeriodMonth { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal Allowances { get; set; }
        public decimal Deductions { get; set; }
        public decimal UnpaidLeave { get; set; }
        public decimal GrossPay { get; set; }
        public decimal NetPay { get; set; }
        public string Status { get; set; } // Draft, Approved, Locked
    }
}