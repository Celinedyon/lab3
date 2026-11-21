using System.Data;
using MySqlConnector;
using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem.Controllers
{
    public class TeamController
    {
        public DataTable GetTeam(int managerEmployeeId, string search)
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(@"
                SELECT DISTINCT e.employee_code AS EmployeeCode,
                       CONCAT(e.first_name, ' ', e.last_name) AS FullName,
                       e.email AS Email, p.title AS Position, e.phone AS Phone,
                       e.status AS Status
                FROM employees e
                JOIN departments d ON d.department_id = e.department_id
                LEFT JOIN positions p ON p.position_id = e.position_id
                WHERE d.manager_id = @managerId
                  AND (@search = '' OR e.employee_code LIKE @pattern
                       OR e.first_name LIKE @pattern OR e.last_name LIKE @pattern
                       OR e.email LIKE @pattern OR p.title LIKE @pattern
                       OR e.status LIKE @pattern)
                ORDER BY e.last_name, e.first_name", conn))
            {
                string query = (search ?? string.Empty).Trim();
                cmd.Parameters.AddWithValue("@managerId", managerEmployeeId);
                cmd.Parameters.AddWithValue("@search", query);
                cmd.Parameters.AddWithValue("@pattern", "%" + query + "%");
                using (var adapter = new MySqlDataAdapter(cmd))
                    adapter.Fill(table);
            }
            return table;
        }
    }
}
