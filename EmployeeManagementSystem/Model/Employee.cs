using System;

namespace EmployeeManagementSystem.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public int? DepartmentId { get; set; }
        public string Department { get; set; }
        public int? PositionId { get; set; }
        public string Position { get; set; }
        public int? ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string Status { get; set; } // Active, On Leave, Suspended, Terminated
        public string EmergencyName { get; set; }
        public string EmergencyPhone { get; set; }
        public decimal Salary { get; set; }
        public decimal Allowances { get; set; }
        public decimal Deductions { get; set; }
    }
}