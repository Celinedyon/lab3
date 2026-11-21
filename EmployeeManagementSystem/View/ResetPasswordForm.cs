using System;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.View
{
    public sealed class ResetPasswordForm : Form
    {
        private readonly PasswordController _controller = new PasswordController();
        private readonly TextBox _code = new TextBox();
        private readonly TextBox _newPassword = new TextBox();
        private readonly TextBox _confirmPassword = new TextBox();

        public ResetPasswordForm()
        {
            Text = "Reset password";
            ClientSize = new Size(420, 310);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.FromArgb(244, 246, 249);
            Font = new Font("Segoe UI", 10F);
            ViewTheme.Apply(this);

            AddField("Reset code", _code, 20, false);
            AddField("New password", _newPassword, 82, true);
            AddField("Confirm new password", _confirmPassword, 144, true);

            var save = new Button
            {
                Text = "Reset password",
                Location = new Point(184, 232),
                Size = new Size(130, 36),
                BackColor = Color.FromArgb(31, 58, 95),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            save.FlatAppearance.BorderSize = 0;
            save.Click += Save_Click;

            var cancel = new Button
            {
                Text = "Cancel",
                Location = new Point(324, 232),
                Size = new Size(72, 36),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(31, 58, 95),
                FlatStyle = FlatStyle.Flat,
                DialogResult = DialogResult.Cancel,
                Cursor = Cursors.Hand
            };
            cancel.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            Controls.Add(save);
            Controls.Add(cancel);
            AcceptButton = save;
            CancelButton = cancel;
        }

        private void AddField(string title, TextBox input, int top, bool password)
        {
            Controls.Add(new Label
            {
                Text = title,
                AutoSize = true,
                Location = new Point(24, top),
                ForeColor = Color.FromArgb(30, 41, 59)
            });
            input.Location = new Point(24, top + 22);
            input.Size = new Size(372, 27);
            input.BorderStyle = BorderStyle.FixedSingle;
            input.UseSystemPasswordChar = password;
            Controls.Add(input);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (_newPassword.Text != _confirmPassword.Text)
            {
                MessageBox.Show("The new passwords do not match.", "Reset password",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string error = _controller.ResetPassword(_code.Text, _newPassword.Text);
            if (error != null)
            {
                MessageBox.Show(error, "Unable to reset password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Password reset successfully. You can now sign in with the new password.",
                "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
