namespace EmployeeManagementSystem.View
{
    partial class LeaveTypesForm
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
            this.dgvLeaveTypes = new System.Windows.Forms.DataGridView();
            this.colLeaveTypesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeaveTypesLeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeaveTypesDaysAllowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeaveTypesPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.chkPaid = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLeaveTypes
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
            this.dgvLeaveTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLeaveTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLeaveTypes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLeaveTypes.AllowUserToAddRows = false;
            this.dgvLeaveTypes.AllowUserToDeleteRows = false;
            this.dgvLeaveTypes.AllowUserToResizeRows = false;
            this.dgvLeaveTypes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.dgvLeaveTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaveTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeaveTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLeaveTypes.ColumnHeadersHeight = 36;
            this.dgvLeaveTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLeaveTypes.EnableHeadersVisualStyles = false;
            this.dgvLeaveTypes.GridColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.dgvLeaveTypes.Location = new System.Drawing.Point(24, 20);
            this.dgvLeaveTypes.MultiSelect = false;
            this.dgvLeaveTypes.ReadOnly = true;
            this.dgvLeaveTypes.RowHeadersVisible = false;
            this.dgvLeaveTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaveTypes.Size = new System.Drawing.Size(612, 556);
            this.dgvLeaveTypes.RowTemplate.Height = 30;
            this.dgvLeaveTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colLeaveTypesId,
                this.colLeaveTypesLeaveType,
                this.colLeaveTypesDaysAllowed,
                this.colLeaveTypesPaid});
            this.dgvLeaveTypes.Name = "dgvLeaveTypes";
            this.dgvLeaveTypes.TabIndex = 1;
            this.dgvLeaveTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeaveTypes_CellClick);
            // 
            // colLeaveTypesId
            // 
            this.colLeaveTypesId.DataPropertyName = "ID";
            this.colLeaveTypesId.HeaderText = "ID";
            this.colLeaveTypesId.Name = "colLeaveTypesId";
            this.colLeaveTypesId.ReadOnly = true;
            // 
            // colLeaveTypesLeaveType
            // 
            this.colLeaveTypesLeaveType.DataPropertyName = "Name";
            this.colLeaveTypesLeaveType.HeaderText = "Leave type";
            this.colLeaveTypesLeaveType.Name = "colLeaveTypesLeaveType";
            this.colLeaveTypesLeaveType.ReadOnly = true;
            // 
            // colLeaveTypesDaysAllowed
            // 
            this.colLeaveTypesDaysAllowed.DataPropertyName = "DaysAllowed";
            this.colLeaveTypesDaysAllowed.HeaderText = "Days allowed";
            this.colLeaveTypesDaysAllowed.Name = "colLeaveTypesDaysAllowed";
            this.colLeaveTypesDaysAllowed.ReadOnly = true;
            // 
            // colLeaveTypesPaid
            // 
            this.colLeaveTypesPaid.DataPropertyName = "IsPaid";
            this.colLeaveTypesPaid.HeaderText = "Paid";
            this.colLeaveTypesPaid.Name = "colLeaveTypesPaid";
            this.colLeaveTypesPaid.ReadOnly = true;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Location = new System.Drawing.Point(656, 20);
            this.pnlDetails.Size = new System.Drawing.Size(320, 288);
            this.pnlDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.TabIndex = 2;
            this.pnlDetails.Controls.Add(this.lblCardTitle);
            this.pnlDetails.Controls.Add(this.lblName);
            this.pnlDetails.Controls.Add(this.txtName);
            this.pnlDetails.Controls.Add(this.lblDays);
            this.pnlDetails.Controls.Add(this.numDays);
            this.pnlDetails.Controls.Add(this.chkPaid);
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
            this.lblCardTitle.Text = "Leave type details";
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblName.Location = new System.Drawing.Point(20, 56);
            this.lblName.Text = "Leave type";
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
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblDays.Location = new System.Drawing.Point(20, 118);
            this.lblDays.Text = "Days allowed";
            this.lblDays.Name = "lblDays";
            this.lblDays.TabIndex = 6;
            // 
            // numDays
            // 
            this.numDays.DecimalPlaces = 0;
            this.numDays.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDays.Location = new System.Drawing.Point(20, 140);
            this.numDays.Size = new System.Drawing.Size(280, 27);
            this.numDays.Maximum = new decimal(new int[] {365, 0, 0, 0});
            this.numDays.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.numDays.Value = new decimal(new int[] {0, 0, 0, 0});
            this.numDays.Name = "numDays";
            this.numDays.TabIndex = 7;
            // 
            // chkPaid
            // 
            this.chkPaid.AutoSize = true;
            this.chkPaid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPaid.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.chkPaid.Location = new System.Drawing.Point(20, 184);
            this.chkPaid.Text = "Paid leave";
            this.chkPaid.UseVisualStyleBackColor = true;
            this.chkPaid.Checked = true;
            this.chkPaid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPaid.Name = "chkPaid";
            this.chkPaid.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 228);
            this.btnAdd.Size = new System.Drawing.Size(88, 36);
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnUpdate.Location = new System.Drawing.Point(116, 228);
            this.btnUpdate.Size = new System.Drawing.Size(88, 36);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnClear.Location = new System.Drawing.Point(212, 228);
            this.btnClear.Size = new System.Drawing.Size(88, 36);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.TabIndex = 11;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // LeaveTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.dgvLeaveTypes);
            this.Controls.Add(this.pnlDetails);
            this.Name = "LeaveTypesForm";
            this.Text = "Leave types";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLeaveTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveTypesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveTypesLeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeaveTypesDaysAllowed;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colLeaveTypesPaid;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown numDays;
        private System.Windows.Forms.CheckBox chkPaid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
    }
}
