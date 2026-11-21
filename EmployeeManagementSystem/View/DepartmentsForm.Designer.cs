namespace EmployeeManagementSystem.View
{
    partial class DepartmentsForm
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
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.colDepartmentsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentsDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentsManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentsEmployees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblManager = new System.Windows.Forms.Label();
            this.cboManager = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDepartments
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
            this.dgvDepartments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepartments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDepartments.AllowUserToAddRows = false;
            this.dgvDepartments.AllowUserToDeleteRows = false;
            this.dgvDepartments.AllowUserToResizeRows = false;
            this.dgvDepartments.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.dgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartments.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDepartments.ColumnHeadersHeight = 36;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDepartments.EnableHeadersVisualStyles = false;
            this.dgvDepartments.GridColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.dgvDepartments.Location = new System.Drawing.Point(24, 20);
            this.dgvDepartments.MultiSelect = false;
            this.dgvDepartments.ReadOnly = true;
            this.dgvDepartments.RowHeadersVisible = false;
            this.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartments.Size = new System.Drawing.Size(612, 556);
            this.dgvDepartments.RowTemplate.Height = 30;
            this.dgvDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDepartmentsId,
                this.colDepartmentsDepartment,
                this.colDepartmentsManager,
                this.colDepartmentsEmployees});
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.TabIndex = 1;
            this.dgvDepartments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartments_CellClick);
            // 
            // colDepartmentsId
            // 
            this.colDepartmentsId.DataPropertyName = "ID";
            this.colDepartmentsId.HeaderText = "ID";
            this.colDepartmentsId.Name = "colDepartmentsId";
            this.colDepartmentsId.ReadOnly = true;
            // 
            // colDepartmentsDepartment
            // 
            this.colDepartmentsDepartment.DataPropertyName = "Name";
            this.colDepartmentsDepartment.HeaderText = "Department";
            this.colDepartmentsDepartment.Name = "colDepartmentsDepartment";
            this.colDepartmentsDepartment.ReadOnly = true;
            // 
            // colDepartmentsManager
            // 
            this.colDepartmentsManager.DataPropertyName = "Manager";
            this.colDepartmentsManager.HeaderText = "Manager";
            this.colDepartmentsManager.Name = "colDepartmentsManager";
            this.colDepartmentsManager.ReadOnly = true;
            // 
            // colDepartmentsEmployees
            // 
            this.colDepartmentsEmployees.DataPropertyName = "EmployeeCount";
            this.colDepartmentsEmployees.HeaderText = "Employees";
            this.colDepartmentsEmployees.Name = "colDepartmentsEmployees";
            this.colDepartmentsEmployees.ReadOnly = true;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Location = new System.Drawing.Point(656, 20);
            this.pnlDetails.Size = new System.Drawing.Size(320, 248);
            this.pnlDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.TabIndex = 2;
            this.pnlDetails.Controls.Add(this.lblCardTitle);
            this.pnlDetails.Controls.Add(this.lblName);
            this.pnlDetails.Controls.Add(this.txtName);
            this.pnlDetails.Controls.Add(this.lblManager);
            this.pnlDetails.Controls.Add(this.cboManager);
            this.pnlDetails.Controls.Add(this.btnAdd);
            this.pnlDetails.Controls.Add(this.btnUpdate);
            this.pnlDetails.Controls.Add(this.btnClear);
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCardTitle.Location = new System.Drawing.Point(20, 16);
            this.lblCardTitle.Text = "Department details";
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblName.Location = new System.Drawing.Point(20, 56);
            this.lblName.Text = "Department name";
            this.lblName.Name = "lblName";
            this.lblName.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(20, 78);
            this.txtName.Size = new System.Drawing.Size(280, 27);
            this.txtName.Name = "txtName";
            this.txtName.TabIndex = 5;
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblManager.Location = new System.Drawing.Point(20, 118);
            this.lblManager.Text = "Department manager";
            this.lblManager.Name = "lblManager";
            this.lblManager.TabIndex = 6;
            // 
            // cboManager
            // 
            this.cboManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManager.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboManager.FormattingEnabled = true;
            this.cboManager.Location = new System.Drawing.Point(20, 140);
            this.cboManager.Size = new System.Drawing.Size(280, 28);
            this.cboManager.Name = "cboManager";
            this.cboManager.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 188);
            this.btnAdd.Size = new System.Drawing.Size(88, 36);
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnUpdate.Location = new System.Drawing.Point(116, 188);
            this.btnUpdate.Size = new System.Drawing.Size(88, 36);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnClear.Location = new System.Drawing.Point(212, 188);
            this.btnClear.Size = new System.Drawing.Size(88, 36);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.TabIndex = 10;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.dgvDepartments);
            this.Controls.Add(this.pnlDetails);
            this.Name = "DepartmentsForm";
            this.Text = "Departments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentsDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentsManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentsEmployees;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.ComboBox cboManager;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
    }
}
