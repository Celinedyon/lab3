using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.View
{
    public partial class LoginForm : Form
    {
        private readonly AuthController _auth = new AuthController();

        public LoginForm()
        {
            InitializeComponent();
            ViewTheme.Apply(this);
        }

        private void lblLogo_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            float w = lblLogo.Width;
            float h = lblLogo.Height;
            float sx = w / 76f;
            float sy = h / 76f;

            // Rounded badge background
            using (var bgBrush = new SolidBrush(Color.FromArgb(41, 71, 115)))
            using (var path = new GraphicsPath())
            {
                float r = 12f * sx;
                path.AddArc(0, 0, r * 2, r * 2, 180, 90);
                path.AddArc(w - r * 2, 0, r * 2, r * 2, 270, 90);
                path.AddArc(w - r * 2, h - r * 2, r * 2, r * 2, 0, 90);
                path.AddArc(0, h - r * 2, r * 2, r * 2, 90, 90);
                path.CloseFigure();
                g.FillPath(bgBrush, path);
            }

            // People icons above EMS
            using (var backBrush = new SolidBrush(Color.FromArgb(185, 212, 245)))
            using (var frontBrush = new SolidBrush(Color.White))
            {
                // Left person (background)
                g.FillEllipse(backBrush, 17f * sx, 12f * sy, 12f * sx, 12f * sy);
                using (var leftBody = new GraphicsPath())
                {
                    leftBody.AddArc(11f * sx, 24f * sy, 24f * sx, 17f * sy, 180, 180);
                    leftBody.CloseFigure();
                    g.FillPath(backBrush, leftBody);
                }

                // Right person (background)
                g.FillEllipse(backBrush, 47f * sx, 12f * sy, 12f * sx, 12f * sy);
                using (var rightBody = new GraphicsPath())
                {
                    rightBody.AddArc(41f * sx, 24f * sy, 24f * sx, 17f * sy, 180, 180);
                    rightBody.CloseFigure();
                    g.FillPath(backBrush, rightBody);
                }

                // Center person (foreground)
                g.FillEllipse(frontBrush, 31f * sx, 8f * sy, 14f * sx, 14f * sy);
                using (var centerBody = new GraphicsPath())
                {
                    centerBody.AddArc(22f * sx, 23f * sy, 32f * sx, 21f * sy, 180, 180);
                    centerBody.CloseFigure();
                    g.FillPath(frontBrush, centerBody);
                }
            }

            // EMS text below people icon
            float fontSize = Math.Max(8f, 12f * sy);
            using (var font = new Font("Segoe UI", fontSize, FontStyle.Bold))
            using (var textBrush = new SolidBrush(Color.White))
            using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                g.DrawString("EMS", font, textBrush, new RectangleF(0, 44f * sy, w, 28f * sy), sf);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var f = new ForgotPasswordForm())
            {
                f.ShowDialog(this);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (email == "" || password == "")
            {
                MessageBox.Show("Enter your email and password.");
                return;
            }

            User user = _auth.Login(email, password);
            if (user == null)
            {
                MessageBox.Show("Invalid email or password.");
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            Session.CurrentUser = user;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
