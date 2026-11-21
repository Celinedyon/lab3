using System;
using System.Windows.Forms;
using System.Drawing;
using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Data;
using MySqlConnector;

namespace EmployeeManagementSystem.View
{
    public partial class MainForm : Form
    {
        private Button _active;

        public MainForm()
        {
            InitializeComponent();
            lblUser.Text = Session.CurrentUser.Email + "  |  " + Session.CurrentUser.Role;
            BuildMenu();
        }

        private void lnkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var f = new ChangePasswordForm())
            {
                f.ShowDialog(this);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.CurrentUser = null;
            DialogResult = DialogResult.Retry;
            Close();
        }

        private static readonly Color Navy = Color.FromArgb(26, 47, 77);
        private static readonly Color NavyLight = Color.FromArgb(41, 71, 115);
        private static readonly Color NavText = Color.FromArgb(218, 228, 241);

        private static string GetMenuIcon(string name)
        {
            switch (name)
            {
                case "Dashboard": return "[■] ";
                case "Users": return "[👥] ";
                case "Employees": return "[👤] ";
                case "Departments": return "[🏢] ";
                case "Positions": return "[💼] ";
                case "Leave Types": return "[📋] ";
                case "Payroll": return "[💰] ";
                case "Reports": return "[📈] ";
                case "Team": return "[👥] ";
                case "Attendance": return "[⏱] ";
                case "Leave Requests": return "[📝] ";
                case "Leave": return "[📅] ";
                case "Payslips": return "[💳] ";
                case "Performance": return "[★] ";
                case "Notifications": return "[🔔] ";
                case "My Profile": return "[👤] ";
                default: return "[•] ";
            }
        }

        // Which menu items each role can see (FR-1.2)
        private string[] GetMenu(string role)
        {
            switch (role)
            {
                case "Administrator":
                    return new[] { "Dashboard", "Users", "Employees", "Departments", "Positions" };
                case "HR Officer":
                    return new[] { "Dashboard", "Employees", "Departments", "Positions",
                                   "Leave Types", "Payroll", "Reports" };
                case "Manager":
                    return new[] { "Dashboard", "Team", "Attendance", "Leave Requests",
                                   "Performance", "Reports", "Notifications" };
                case "Employee":
                    return new[] { "Dashboard", "My Profile", "Attendance", "Leave",
                                   "Payslips", "Performance", "Notifications" };
                default:
                    return new string[0];
            }
        }

        private Button MakeNavButton(string text)
        {
            var b = new Button
            {
                Text = "  " + GetMenuIcon(text) + " " + text,
                Tag = text,
                Width = 230,
                Height = 46,
                FlatStyle = FlatStyle.Flat,
                ForeColor = NavText,
                BackColor = Navy,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Margin = Padding.Empty,
                Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = NavyLight;
            return b;
        }

        private void BuildMenu()
        {
            Button first = null;
            foreach (string name in GetMenu(Session.CurrentUser.Role))
            {
                Button b = MakeNavButton(name);
                b.Click += Nav_Click;
                flowNav.Controls.Add(b);
                if (first == null) first = b;
            }
            if (first != null) Nav_Click(first, EventArgs.Empty);
        }

        private void Nav_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            string name = (string)b.Tag;

            if (_active != null)
            {
                _active.BackColor = Navy;
                _active.ForeColor = NavText;
            }
            _active = b;
            b.BackColor = NavyLight;
            b.ForeColor = Color.White;

            lblPageTitle.Text = name;
            ShowPage(CreatePage(name));
        }

        private Form CreatePage(string name)
        {
            switch (name)
            {
                case "Dashboard": return CreateDashboardPage();
                case "Users": return new UsersForm();
                case "Employees": return new EmployeesForm();
                case "Departments": return new DepartmentsForm();
                case "Positions": return new PositionsForm();
                case "Leave Types": return new LeaveTypesForm();
                case "Payroll": return new PayrollForm();
                case "Reports": return new ReportsForm();
                case "Team": return new TeamForm();
                case "Attendance": return new AttendanceForm();
                case "Leave Requests": return new LeaveRequestsForm();
                case "Performance": return new PerformanceForm();
                case "My Profile": return new MyProfileForm();
                case "Leave": return new LeaveForm();
                case "Payslips": return new PayslipsForm();
                case "Notifications": return new NotificationsForm();
                default: return new Form();
            }
        }

        private Form CreateDashboardPage()
        {
            var page = new Form { BackColor = Color.FromArgb(244, 246, 249) };
            var root = new Panel { Dock = DockStyle.Fill, Padding = new Padding(30) };
            var welcome = new Label
            {
                AutoSize = true,
                Text = Session.CurrentUser.Role == "Administrator"
                    ? "Administration overview"
                    : "Good day, " + (Session.CurrentUser.FullName ?? Session.CurrentUser.Email),
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Location = new Point(30, 24)
            };
            var subtitle = new Label
            {
                AutoSize = true,
                Text = Session.CurrentUser.Role == "Administrator"
                    ? "Monitor accounts, access roles, and organization activity."
                    : "Here is an overview of your employee management system.",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(100, 116, 139),
                Location = new Point(32, 66)
            };
            var cards = new FlowLayoutPanel
            {
                Location = new Point(30, 112),
                Size = new Size(900, 120),
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                BackColor = Color.Transparent
            };
            if (Session.CurrentUser.Role == "Administrator")
            {
                AddMetricCard(cards, "Total users", CountRows("users"), Color.FromArgb(47, 82, 135));
                AddMetricCard(cards, "Active users", CountRows("users", "is_active = 1"), Color.FromArgb(16, 128, 112));
                AddMetricCard(cards, "Employees", CountRows("employees"), Color.FromArgb(221, 143, 32));
                AddMetricCard(cards, "Departments", CountRows("departments"), Color.FromArgb(117, 82, 156));
            }
            else
            {
                AddMetricCard(cards, "Employees", CountRows("employees"), Color.FromArgb(47, 82, 135));
                AddMetricCard(cards, "Departments", CountRows("departments"), Color.FromArgb(16, 128, 112));
                AddMetricCard(cards, "Pending leave", CountRows("leave_requests", "status = 'Pending'"), Color.FromArgb(221, 143, 32));
                AddMetricCard(cards, "Attendance today", CountRows("attendance", "work_date = CURDATE()"), Color.FromArgb(117, 82, 156));
            }
            var chart = CreateBarChart(Session.CurrentUser.Role == "Administrator");
            var infoCard = CreateSystemInfoCard();
            root.Controls.Add(welcome);
            root.Controls.Add(subtitle);
            root.Controls.Add(cards);
            root.Controls.Add(chart);
            root.Controls.Add(infoCard);
            page.Controls.Add(root);
            return page;
        }

        private Panel CreateSystemInfoCard()
        {
            var pnl = new Panel
            {
                Location = new Point(700, 260),
                Size = new Size(330, 330),
                BackColor = Color.White,
                Padding = new Padding(20)
            };
            var title = new Label
            {
                AutoSize = true,
                Text = "System Status",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Location = new Point(20, 18)
            };
            var dbStatus = new Label
            {
                AutoSize = true,
                Text = "● Database: Connected (ems_db)",
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(22, 101, 52),
                Location = new Point(22, 60)
            };
            var dateLabel = new Label
            {
                AutoSize = true,
                Text = "Date: " + DateTime.Today.ToString("dddd, MMM dd, yyyy"),
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(71, 85, 105),
                Location = new Point(22, 95)
            };
            var userLabel = new Label
            {
                AutoSize = true,
                Text = "Session: " + Session.CurrentUser.Role,
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(71, 85, 105),
                Location = new Point(22, 125)
            };
            var sep = new Panel
            {
                Location = new Point(20, 165),
                Size = new Size(290, 1),
                BackColor = Color.FromArgb(226, 232, 240)
            };
            var projectTitle = new Label
            {
                AutoSize = true,
                Text = "Application Details",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(26, 47, 77),
                Location = new Point(22, 180)
            };
            var studentInfo = new Label
            {
                AutoSize = true,
                Text = "System: Employee Management System (EMS)\nArchitecture: MVC Pattern\nUI: Windows Forms (C# .NET)",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(100, 116, 139),
                Location = new Point(22, 208)
            };
            pnl.Controls.Add(title);
            pnl.Controls.Add(dbStatus);
            pnl.Controls.Add(dateLabel);
            pnl.Controls.Add(userLabel);
            pnl.Controls.Add(sep);
            pnl.Controls.Add(projectTitle);
            pnl.Controls.Add(studentInfo);
            return pnl;
        }

        private Panel CreateBarChart(bool administrator)
        {
            var chart = new Panel
            {
                Location = new Point(30, 260),
                Size = new Size(650, 330),
                BackColor = Color.White,
                Padding = new Padding(24)
            };
            var title = new Label
            {
                AutoSize = true,
                Text = administrator ? "User role distribution" : "Workforce overview",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Location = new Point(24, 18)
            };
            chart.Controls.Add(title);
            int[] values = administrator
                ? new[] { CountValue("users", "role = 'Administrator'"), CountValue("users", "role = 'HR Officer'"), CountValue("users", "role = 'Manager'"), CountValue("users", "role = 'Employee'") }
                : new[] { CountValue("employees", "status = 'Active'"), CountValue("employees", "status = 'On Leave'"), CountValue("employees", "status = 'Suspended'"), CountValue("employees", "status = 'Terminated'") };
            string[] labels = administrator
                ? new[] { "Admin", "HR", "Managers", "Employees" }
                : new[] { "Active", "On leave", "Suspended", "Terminated" };
            Color[] colors =
            {
                Color.FromArgb(16, 128, 112),
                Color.FromArgb(221, 143, 32),
                Color.FromArgb(117, 82, 156),
                Color.FromArgb(190, 75, 75)
            };
            var bars = new Panel { Location = new Point(24, 58), Size = new Size(590, 240), BackColor = Color.White };
            bars.Paint += delegate(object sender, PaintEventArgs e)
            {
                int max = 1;
                foreach (int value in values) if (value > max) max = value;
                using (var axis = new Pen(Color.FromArgb(226, 232, 240)))
                using (var text = new SolidBrush(Color.FromArgb(100, 116, 139)))
                {
                    e.Graphics.DrawLine(axis, 32, 180, 560, 180);
                    for (int i = 0; i < values.Length; i++)
                    {
                        int height = values[i] * 140 / max;
                        int x = 70 + i * 125;
                        e.Graphics.FillRectangle(new SolidBrush(colors[i]), x, 180 - height, 54, height);
                        e.Graphics.DrawString(values[i].ToString(), new Font("Segoe UI", 9F, FontStyle.Bold), text, x + 20, 158 - height);
                        e.Graphics.DrawString(labels[i], new Font("Segoe UI", 8.5F), text, x - 8, 193);
                    }
                }
            };
            chart.Controls.Add(bars);
            return chart;
        }

        private int CountValue(string table, string condition)
        {
            int value;
            return int.TryParse(CountRows(table, condition), out value) ? value : 0;
        }

        private void AddMetricCard(FlowLayoutPanel parent, string title, string value, Color accent)
        {
            var card = new Panel { Width = 205, Height = 108, BackColor = Color.White, Margin = new Padding(0, 0, 14, 0) };
            var stripe = new Panel { Dock = DockStyle.Left, Width = 6, BackColor = accent };
            var titleLabel = new Label { AutoSize = true, Text = title, Location = new Point(20, 18), Font = new Font("Segoe UI", 9.5F), ForeColor = Color.FromArgb(100, 116, 139) };
            var valueLabel = new Label { AutoSize = true, Text = value, Location = new Point(20, 43), Font = new Font("Segoe UI", 24F, FontStyle.Bold), ForeColor = Color.FromArgb(30, 41, 59) };
            card.Controls.Add(stripe);
            card.Controls.Add(titleLabel);
            card.Controls.Add(valueLabel);
            parent.Controls.Add(card);
        }

        private string CountRows(string table, string condition = null)
        {
            try
            {
                using (var conn = Database.GetConnection())
                using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM " + table + (condition == null ? "" : " WHERE " + condition), conn))
                {
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                }
            }
            catch
            {
                return "—";
            }
        }

        private void ShowPage(Form page)
        {
            while (pnlContent.Controls.Count > 0)
            {
                pnlContent.Controls[0].Dispose();
            }
            ViewTheme.Apply(page);
            page.TopLevel = false;
            page.FormBorderStyle = FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
            page.Show();
        }
    }
}
