namespace EmployeeManagementSystem.View
{
    partial class UsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.colUsersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsersEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsersRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsersActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(219, 230, 245);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersHeight = 36;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.dgvUsers.Location = new System.Drawing.Point(24, 20);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(612, 556);
            this.dgvUsers.RowTemplate.Height = 30;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colUsersId,
                this.colUsersEmail,
                this.colUsersRole,
                this.colUsersActive});
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // colUsersId
            // 
            this.colUsersId.DataPropertyName = "ID";
            this.colUsersId.HeaderText = "ID";
            this.colUsersId.Name = "colUsersId";
            this.colUsersId.ReadOnly = true;
            // 
            // colUsersEmail
            // 
            this.colUsersEmail.DataPropertyName = "Email";
            this.colUsersEmail.HeaderText = "Email";
            this.colUsersEmail.Name = "colUsersEmail";
            this.colUsersEmail.ReadOnly = true;
            // 
            // colUsersRole
            // 
            this.colUsersRole.DataPropertyName = "Role";
            this.colUsersRole.HeaderText = "Role";
            this.colUsersRole.Name = "colUsersRole";
            this.colUsersRole.ReadOnly = true;
            // 
            // colUsersActive
            // 
            this.colUsersActive.DataPropertyName = "Active";
            this.colUsersActive.HeaderText = "Active";
            this.colUsersActive.Name = "colUsersActive";
            this.colUsersActive.ReadOnly = true;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Location = new System.Drawing.Point(656, 20);
            this.pnlDetails.Size = new System.Drawing.Size(320, 392);
            this.pnlDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.TabIndex = 2;
            this.pnlDetails.Controls.Add(this.lblCardTitle);
            this.pnlDetails.Controls.Add(this.lblEmail);
            this.pnlDetails.Controls.Add(this.txtEmail);
            this.pnlDetails.Controls.Add(this.lblPassword);
            this.pnlDetails.Controls.Add(this.txtPassword);
            this.pnlDetails.Controls.Add(this.lblRole);
            this.pnlDetails.Controls.Add(this.cboRole);
            this.pnlDetails.Controls.Add(this.chkActive);
            this.pnlDetails.Controls.Add(this.btnAdd);
            this.pnlDetails.Controls.Add(this.btnUpdate);
            this.pnlDetails.Controls.Add(this.btnClear);
            this.pnlDetails.Controls.Add(this.lblHint);
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCardTitle.Location = new System.Drawing.Point(20, 16);
            this.lblCardTitle.Text = "User details";
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblEmail.Location = new System.Drawing.Point(20, 56);
            this.lblEmail.Text = "Email";
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(20, 78);
            this.txtEmail.Size = new System.Drawing.Size(280, 27);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPassword.Location = new System.Drawing.Point(20, 118);
            this.lblPassword.Text = "Password";
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(20, 140);
            this.txtPassword.Size = new System.Drawing.Size(280, 27);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.TabIndex = 7;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblRole.Location = new System.Drawing.Point(20, 180);
            this.lblRole.Text = "Role";
            this.lblRole.Name = "lblRole";
            this.lblRole.TabIndex = 8;
            // 
            // cboRole
            // 
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(20, 202);
            this.cboRole.Size = new System.Drawing.Size(280, 28);
            this.cboRole.Items.AddRange(new object[] {"Administrator", "HR Officer", "Manager", "Employee"});
            this.cboRole.Name = "cboRole";
            this.cboRole.TabIndex = 9;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.chkActive.Location = new System.Drawing.Point(20, 246);
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Name = "chkActive";
            this.chkActive.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 290);
            this.btnAdd.Size = new System.Drawing.Size(88, 36);
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnUpdate.Location = new System.Drawing.Point(116, 290);
            this.btnUpdate.Size = new System.Drawing.Size(88, 36);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnClear.Location = new System.Drawing.Point(212, 290);
            this.btnClear.Size = new System.Drawing.Size(88, 36);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.TabIndex = 13;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = false;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHint.Location = new System.Drawing.Point(20, 336);
            this.lblHint.Text = "When updating, leave the password blank to keep the current one.";
            this.lblHint.Size = new System.Drawing.Size(280, 36);
            this.lblHint.Name = "lblHint";
            this.lblHint.TabIndex = 14;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.pnlDetails);
            this.Name = "UsersForm";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsersId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsersEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsersRole;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUsersActive;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblHint;
    }
}
