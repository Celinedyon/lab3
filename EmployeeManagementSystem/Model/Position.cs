namespace EmployeeManagementSystem.Model
{
    public class Position
    {
        public int PositionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? DepartmentId { get; set; }
        public string Department { get; set; }
        public bool IsActive { get; set; }
    }
}