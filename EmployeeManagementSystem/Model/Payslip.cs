using System;

namespace EmployeeManagementSystem.Model
{
    public class Payslip
    {
        public int PayslipId { get; set; }
        public int PayrollId { get; set; }
        public DateTime IssuedAt { get; set; }
    }
}