using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Controllers
{
    public static class Session
    {
        public static User CurrentUser { get; set; }
    }
}