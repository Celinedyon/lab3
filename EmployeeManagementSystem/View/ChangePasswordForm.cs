using System;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.View
{
    public partial class ChangePasswordForm : Form
    {
        private readonly PasswordController _controller = new PasswordController();

        public ChangePasswordForm()
        {
            InitializeComponent();
            ViewTheme.Apply(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNew.Text != txtConfirm.Text)
            {
                MessageBox.Show("The new passwords do not match.", "Change password",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string error = _controller.ChangePassword(Session.CurrentUser.UserId, txtCurrent.Text, txtNew.Text);
            if (error != null)
            {
                MessageBox.Show(error, "Unable to change password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Password changed successfully.", "Change password",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
