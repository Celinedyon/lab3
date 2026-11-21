using System;
using System.Data;
using MySqlConnector;
using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem.Controllers
{
    public class PerformanceController
    {
        public DataTable GetTeamEmployees(int managerEmployeeId)
        {
            var table = new DataTable();
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(@"
                SELECT DISTINCT e.employee_id AS EmployeeId,
                       CONCAT(e.employee_code, ' - ', e.first_name, ' ', e.last_name) AS Employee
                FROM employees e
                JOIN departments d ON d.department_id = e.department_id
                WHERE d.manager_id = @managerId AND e.employee_id <> @managerId
                  AND e.status <> 'Terminated'
                ORDER BY Employee", conn))
            {
                cmd.Parameters.AddWithValue("@managerId", managerEmployeeId);
                using (var adapter = new MySqlDataAdapter(cmd))
                    adapter.Fill(table);
            }
            return table;
        }

        public DataTable GetGoals(int managerEmployeeId, int? employeeId)
        {
            var table = new DataTable();
            string scope = employeeId.HasValue
                ? "g.employee_id = @employeeId"
                : "d.manager_id = @managerId AND e.employee_id <> @managerId";
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(@"
                SELECT CONCAT(e.employee_code, ' - ', e.first_name, ' ', e.last_name) AS Employee,
                       g.description AS Description, g.due_date AS DueDate, u.email AS SetBy
                FROM goals g
                JOIN employees e ON e.employee_id = g.employee_id
                LEFT JOIN departments d ON d.department_id = e.department_id
                JOIN users u ON u.user_id = g.set_by
                WHERE " + scope + @"
                ORDER BY g.due_date IS NULL, g.due_date DESC, g.goal_id DESC", conn))
            {
                if (employeeId.HasValue)
                    cmd.Parameters.AddWithValue("@employeeId", employeeId.Value);
                else
                    cmd.Parameters.AddWithValue("@managerId", managerEmployeeId);
                using (var adapter = new MySqlDataAdapter(cmd))
                    adapter.Fill(table);
            }
            return table;
        }

        public DataTable GetReviews(int managerEmployeeId, int? employeeId)
        {
            var table = new DataTable();
            string scope = employeeId.HasValue
                ? "r.employee_id = @employeeId"
                : "d.manager_id = @managerId AND e.employee_id <> @managerId";
            using (var conn = Database.GetConnection())
            using (var cmd = new MySqlCommand(@"
                SELECT CONCAT(e.employee_code, ' - ', e.first_name, ' ', e.last_name) AS Employee,
                       u.email AS Reviewer, r.review_date AS ReviewDate,
                       r.rating AS Rating, r.comments AS Comments
                FROM reviews r
                JOIN employees e ON e.employee_id = r.employee_id
                LEFT JOIN departments d ON d.department_id = e.department_id
                JOIN users u ON u.user_id = r.reviewer_id
                WHERE " + scope + @"
                ORDER BY r.review_date DESC, r.review_id DESC", conn))
            {
                if (employeeId.HasValue)
                    cmd.Parameters.AddWithValue("@employeeId", employeeId.Value);
                else
                    cmd.Parameters.AddWithValue("@managerId", managerEmployeeId);
                using (var adapter = new MySqlDataAdapter(cmd))
                    adapter.Fill(table);
            }
            return table;
        }

        public string AddGoal(int employeeId, int managerEmployeeId, int userId, string description, DateTime dueDate)
        {
            if (employeeId <= 0 || managerEmployeeId <= 0 || userId <= 0)
                return "Select a team member.";
            if (string.IsNullOrWhiteSpace(description))
                return "Enter a goal description.";
            if (description.Trim().Length > 500)
                return "The goal description cannot exceed 500 characters.";
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(@"
                    INSERT INTO goals (employee_id, set_by, description, due_date)
                    SELECT e.employee_id, @userId, @description, @dueDate
                    FROM employees e
                    JOIN departments d ON d.department_id = e.department_id
                    WHERE e.employee_id = @employeeId AND d.manager_id = @managerId
                      AND e.status <> 'Terminated'", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@description", description.Trim());
                    cmd.Parameters.AddWithValue("@dueDate", dueDate.Date);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.Parameters.AddWithValue("@managerId", managerEmployeeId);
                    if (cmd.ExecuteNonQuery() != 1)
                        return "You can only set goals for your own team members.";
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }

        public string AddReview(int employeeId, int managerEmployeeId, int userId, int rating, string comments)
        {
            if (employeeId <= 0 || managerEmployeeId <= 0 || userId <= 0)
                return "Select a team member.";
            if (rating < 1 || rating > 5)
                return "Rating must be between 1 and 5.";
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand(@"
                    INSERT INTO reviews (employee_id, reviewer_id, rating, comments, review_date)
                    SELECT e.employee_id, @userId, @rating, @comments, CURDATE()
                    FROM employees e
                    JOIN departments d ON d.department_id = e.department_id
                    WHERE e.employee_id = @employeeId AND d.manager_id = @managerId
                      AND e.status <> 'Terminated'", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@rating", rating);
                    cmd.Parameters.AddWithValue("@comments",
                        string.IsNullOrWhiteSpace(comments) ? (object)DBNull.Value : comments.Trim());
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.Parameters.AddWithValue("@managerId", managerEmployeeId);
                    if (cmd.ExecuteNonQuery() != 1)
                        return "You can only review your own team members.";
                }
                return null;
            }
            catch (MySqlException ex) { return ex.Message; }
        }
    }
}
