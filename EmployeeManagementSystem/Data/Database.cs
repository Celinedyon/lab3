using System;
using MySqlConnector;

namespace EmployeeManagementSystem.Data
{
    public static class Database
    {
        private const string ConnectionString =
            "Server=localhost;Port=3306;Database=ems_db;User ID=root;Password=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public static bool TestConnection(out string error)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                }
                error = "";
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}