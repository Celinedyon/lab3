using System;
using System.Windows.Forms;
using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Database.TestConnection(out string error))
            {
                MessageBox.Show("Connection failed: " + error);
                return;
            }
            new EmployeeManagementSystem.Controllers.AuthController().EnsureAdminExists();
            while (true)
            {
                using (var loginForm = new EmployeeManagementSystem.View.LoginForm())
                {
                    if (loginForm.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                }

                using (var mainForm = new EmployeeManagementSystem.View.MainForm())
                {
                    if (mainForm.ShowDialog() != DialogResult.Retry)
                    {
                        return;
                    }
                }
            }
        }
    }
}