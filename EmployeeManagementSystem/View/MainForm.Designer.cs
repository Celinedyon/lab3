namespace EmployeeManagementSystem.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lnkChangePassword = new System.Windows.Forms.LinkLabel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.flowNav = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.flowNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.pnlContent.Location = new System.Drawing.Point(230, 64);
            this.pnlContent.Size = new System.Drawing.Size(1050, 696);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1280, 64);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.Controls.Add(this.lnkChangePassword);
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Controls.Add(this.lblUser);
            // 
            // lnkChangePassword
            // 
            this.lnkChangePassword.AutoSize = true;
            this.lnkChangePassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkChangePassword.LinkColor = System.Drawing.Color.FromArgb(47, 82, 135);
            this.lnkChangePassword.Location = new System.Drawing.Point(828, 22);
            this.lnkChangePassword.Text = "Change password";
            this.lnkChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lnkChangePassword.Name = "lnkChangePassword";
            this.lnkChangePassword.TabIndex = 3;
            this.lnkChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChangePassword_LinkClicked);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = false;
            this.lblPageTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPageTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPageTitle.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.lblPageTitle.Size = new System.Drawing.Size(550, 64);
            this.lblPageTitle.Text = "Page title";
            this.lblPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.TabIndex = 4;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = false;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblUser.Location = new System.Drawing.Point(700, 0);
            this.lblUser.Padding = new System.Windows.Forms.Padding(0, 0, 24, 0);
            this.lblUser.Size = new System.Drawing.Size(330, 64);
            this.lblUser.Text = "user@company.com  |  Role";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUser.Name = "lblUser";
            this.lblUser.TabIndex = 5;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Size = new System.Drawing.Size(230, 760);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.TabIndex = 6;
            this.pnlSidebar.Controls.Add(this.flowNav);
            this.pnlSidebar.Controls.Add(this.lblBrand);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            // 
            // flowNav
            // 
            this.flowNav.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.flowNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowNav.Location = new System.Drawing.Point(0, 70);
            this.flowNav.Size = new System.Drawing.Size(230, 630);
            this.flowNav.WrapContents = false;
            this.flowNav.Name = "flowNav";
            this.flowNav.TabIndex = 7;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = false;
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(0, 0);
            this.lblBrand.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblBrand.Size = new System.Drawing.Size(230, 70);
            this.lblBrand.Text = "Employee Management";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(205, 216, 233);
            this.btnLogout.Location = new System.Drawing.Point(0, 700);
            this.btnLogout.Size = new System.Drawing.Size(230, 46);
            this.btnLogout.Text = "   Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "MainForm";
            this.Text = "Employee Management System (EMS)";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.flowNav.ResumeLayout(false);
            this.flowNav.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.LinkLabel lnkChangePassword;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.FlowLayoutPanel flowNav;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnLogout;
    }
}
