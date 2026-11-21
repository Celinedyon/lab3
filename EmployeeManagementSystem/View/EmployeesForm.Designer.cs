namespace EmployeeManagementSystem.View
{
    partial class EmployeesForm
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.colEmployeesEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeesFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeesEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeesDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeesPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeesPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeesHireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeesStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Location = new System.Drawing.Point(24, 20);
            this.pnlFilter.Size = new System.Drawing.Size(952, 74);
            this.pnlFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.TabIndex = 1;
            this.pnlFilter.Controls.Add(this.lblSearch);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.lblDepartment);
            this.pnlFilter.Controls.Add(this.cboDepartment);
            this.pnlFilter.Controls.Add(this.lblStatus);
            this.pnlFilter.Controls.Add(this.cboStatus);
            this.pnlFilter.Controls.Add(this.btnSearch);
            this.pnlFilter.Controls.Add(this.btnReset);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSearch.Location = new System.Drawing.Point(16, 6);
            this.lblSearch.Text = "Search (name or ID)";
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(16, 30);
            this.txtSearch.Size = new System.Drawing.Size(250, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TabIndex = 3;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDepartment.Location = new System.Drawing.Point(286, 6);
            this.lblDepartment.Text = "Department";
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.TabIndex = 4;
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(286, 30);
            this.cboDepartment.Size = new System.Drawing.Size(190, 28);
            this.cboDepartment.Items.AddRange(new object[] {"All departments"});
            this.cboDepartment.SelectedIndex = 0;
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblStatus.Location = new System.Drawing.Point(496, 6);
            this.lblStatus.Text = "Status";
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.TabIndex = 6;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(496, 30);
            this.cboStatus.Size = new System.Drawing.Size(160, 28);
            this.cboStatus.Items.AddRange(new object[] {"All statuses", "Active", "On Leave", "Suspended", "Terminated"});
            this.cboStatus.SelectedIndex = 0;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(676, 26);
            this.btnSearch.Size = new System.Drawing.Size(100, 36);
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnReset.Location = new System.Drawing.Point(786, 26);
            this.btnReset.Size = new System.Drawing.Size(100, 36);
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnReset.Name = "btnReset";
            this.btnReset.TabIndex = 9;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(24, 108);
            this.btnAdd.Size = new System.Drawing.Size(150, 36);
            this.btnAdd.Text = "+ Add employee";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnEdit.Location = new System.Drawing.Point(184, 108);
            this.btnEdit.Size = new System.Drawing.Size(100, 36);
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.White;
            this.btnStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnStatus.Location = new System.Drawing.Point(294, 108);
            this.btnStatus.Size = new System.Drawing.Size(140, 36);
            this.btnStatus.Text = "Change status";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.TabIndex = 12;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // dgvEmployees
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
            this.dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployees.ColumnHeadersHeight = 36;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployees.EnableHeadersVisualStyles = false;
            this.dgvEmployees.GridColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.dgvEmployees.Location = new System.Drawing.Point(24, 156);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(952, 420);
            this.dgvEmployees.RowTemplate.Height = 30;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colEmployeesEmployeeId,
                this.colEmployeesFullName,
                this.colEmployeesEmail,
                this.colEmployeesDepartment,
                this.colEmployeesPosition,
                this.colEmployeesPhone,
                this.colEmployeesHireDate,
                this.colEmployeesStatus});
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.TabIndex = 13;
            // 
            // colEmployeesEmployeeId
            // 
            this.colEmployeesEmployeeId.DataPropertyName = "EmployeeCode";
            this.colEmployeesEmployeeId.HeaderText = "Employee ID";
            this.colEmployeesEmployeeId.Name = "colEmployeesEmployeeId";
            this.colEmployeesEmployeeId.ReadOnly = true;
            // 
            // colEmployeesFullName
            // 
            this.colEmployeesFullName.DataPropertyName = "FullName";
            this.colEmployeesFullName.HeaderText = "Full name";
            this.colEmployeesFullName.Name = "colEmployeesFullName";
            this.colEmployeesFullName.ReadOnly = true;
            // 
            // colEmployeesEmail
            // 
            this.colEmployeesEmail.DataPropertyName = "Email";
            this.colEmployeesEmail.HeaderText = "Email";
            this.colEmployeesEmail.Name = "colEmployeesEmail";
            this.colEmployeesEmail.ReadOnly = true;
            // 
            // colEmployeesDepartment
            // 
            this.colEmployeesDepartment.DataPropertyName = "Department";
            this.colEmployeesDepartment.HeaderText = "Department";
            this.colEmployeesDepartment.Name = "colEmployeesDepartment";
            this.colEmployeesDepartment.ReadOnly = true;
            // 
            // colEmployeesPosition
            // 
            this.colEmployeesPosition.DataPropertyName = "Position";
            this.colEmployeesPosition.HeaderText = "Position";
            this.colEmployeesPosition.Name = "colEmployeesPosition";
            this.colEmployeesPosition.ReadOnly = true;
            // 
            // colEmployeesPhone
            // 
            this.colEmployeesPhone.DataPropertyName = "Phone";
            this.colEmployeesPhone.HeaderText = "Phone";
            this.colEmployeesPhone.Name = "colEmployeesPhone";
            this.colEmployeesPhone.ReadOnly = true;
            // 
            // colEmployeesHireDate
            // 
            this.colEmployeesHireDate.DataPropertyName = "HireDate";
            this.colEmployeesHireDate.HeaderText = "Hire date";
            this.colEmployeesHireDate.Name = "colEmployeesHireDate";
            this.colEmployeesHireDate.ReadOnly = true;
            // 
            // colEmployeesStatus
            // 
            this.colEmployeesStatus.DataPropertyName = "Status";
            this.colEmployeesStatus.HeaderText = "Status";
            this.colEmployeesStatus.Name = "colEmployeesStatus";
            this.colEmployeesStatus.ReadOnly = true;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "EmployeesForm";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeesEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeesFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeesEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeesDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeesPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeesPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeesHireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeesStatus;
    }
}
