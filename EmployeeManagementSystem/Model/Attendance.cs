using System;

namespace EmployeeManagementSystem.Model
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public DateTime WorkDate { get; set; }
        public DateTime? ClockIn { get; set; }
        public DateTime? ClockOut { get; set; }
        public decimal? HoursWorked { get; set; }
        public string Status { get; set; }
        public string CorrectionReason { get; set; }
    }
}