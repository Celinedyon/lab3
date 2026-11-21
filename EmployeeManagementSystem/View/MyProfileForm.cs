using System;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.View
{
    public partial class MyProfileForm : Form
    {
        public MyProfileForm()
        {
            InitializeComponent();
            LoadProfile();
        }

        private void LoadProfile()
        {
            User user = Session.CurrentUser;
            if (user == null) return;

            lblValEmail.Text = user.Email ?? "-";

            if (!user.EmployeeId.HasValue)
            {
                lblValStatus.Text = "Not linked to an employee record";
                return;
            }

            try
            {
                Employee employee = new EmployeeController().GetById(user.EmployeeId.Value);
                if (employee == null)
                {
                    lblValStatus.Text = "Employee record not found";
                    return;
                }

                lblValEmployeeId.Text = employee.EmployeeCode ?? employee.EmployeeId.ToString();
                lblValFullName.Text = employee.FullName;
                lblValPhone.Text = ValueOrDash(employee.Phone);
                lblValBirth.Text = employee.DateOfBirth.HasValue
                    ? employee.DateOfBirth.Value.ToString("d") : "-";
                lblValGender.Text = ValueOrDash(employee.Gender);
                lblValAddress.Text = ValueOrDash(employee.Address);
                lblValDepartment.Text = ValueOrDash(employee.Department);
                lblValPosition.Text = ValueOrDash(employee.Position);
                lblValHireDate.Text = employee.HireDate.ToString("d");
                lblValStatus.Text = ValueOrDash(employee.Status);
                lblValEmgName.Text = ValueOrDash(employee.EmergencyName);
                lblValEmgPhone.Text = ValueOrDash(employee.EmergencyPhone);
            }
            catch (Exception ex)
            {
                lblValStatus.Text = "Unable to load profile";
                MessageBox.Show(this, "Unable to load profile information: " + ex.Message,
                    "My profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string ValueOrDash(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? "-" : value;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            using (var f = new ChangePasswordForm())
            {
                f.ShowDialog(this);
            }
        }
    }
}
