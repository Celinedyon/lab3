namespace EmployeeManagementSystem.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int? ManagerEmployeeId { get; set; }
        public string ManagerName { get; set; }
        public bool IsActive { get; set; }
    }
}