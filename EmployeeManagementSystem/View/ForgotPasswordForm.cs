using System;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.View
{
    public partial class ForgotPasswordForm : Form
    {
        private readonly PasswordController _controller = new PasswordController();

        public ForgotPasswordForm()
        {
            InitializeComponent();
            ViewTheme.Apply(this);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string error = _controller.SendResetCode(txtEmail.Text);
            if (error != null)
            {
                MessageBox.Show(error, "Unable to send reset code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = _controller.LastResetCode == null
                ? "If an active account uses this email, a reset code has been sent."
                : "SMTP is not configured for this local XAMPP environment.\r\n\r\n" +
                  "Your reset code is:\r\n" + _controller.LastResetCode;
            if (_controller.LastResetCode != null)
            {
                Clipboard.SetText(_controller.LastResetCode);
                message += "\r\n\r\nThe code was copied to your clipboard.";
            }
            MessageBox.Show(message, "Password reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (var reset = new ResetPasswordForm())
            {
                if (reset.ShowDialog(this) == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
