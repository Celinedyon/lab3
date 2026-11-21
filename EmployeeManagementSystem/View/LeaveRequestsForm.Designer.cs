namespace EmployeeManagementSystem.View
{
    partial class LeaveRequestsForm
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.colRequestsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestsEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestsLeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestsFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestsTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestsDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestsReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestsStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Location = new System.Drawing.Point(24, 20);
            this.pnlFilter.Size = new System.Drawing.Size(952, 76);
            this.pnlFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.TabIndex = 1;
            this.pnlFilter.Controls.Add(this.lblStatus);
            this.pnlFilter.Controls.Add(this.cboStatus);
            this.pnlFilter.Controls.Add(this.btnRefresh);
            this.pnlFilter.Controls.Add(this.btnApprove);
            this.pnlFilter.Controls.Add(this.btnReject);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblStatus.Location = new System.Drawing.Point(16, 6);
            this.lblStatus.Text = "Show requests";
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.TabIndex = 2;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(16, 30);
            this.cboStatus.Size = new System.Drawing.Size(190, 28);
            this.cboStatus.Items.AddRange(new object[] {"Pending", "Approved", "Rejected", "All"});
            this.cboStatus.SelectedIndex = 0;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnRefresh.Location = new System.Drawing.Point(226, 26);
            this.btnRefresh.Size = new System.Drawing.Size(100, 36);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(730, 26);
            this.btnApprove.Size = new System.Drawing.Size(100, 36);
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.TabIndex = 5;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(840, 26);
            this.btnReject.Size = new System.Drawing.Size(100, 36);
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.Name = "btnReject";
            this.btnReject.TabIndex = 6;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // dgvRequests
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
            this.dgvRequests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRequests.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToDeleteRows = false;
            this.dgvRequests.AllowUserToResizeRows = false;
            this.dgvRequests.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequests.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRequests.ColumnHeadersHeight = 36;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRequests.EnableHeadersVisualStyles = false;
            this.dgvRequests.GridColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.dgvRequests.Location = new System.Drawing.Point(24, 112);
            this.dgvRequests.MultiSelect = false;
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.RowHeadersVisible = false;
            this.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequests.Size = new System.Drawing.Size(952, 464);
            this.dgvRequests.RowTemplate.Height = 30;
            this.dgvRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colRequestsId,
                this.colRequestsEmployee,
                this.colRequestsLeaveType,
                this.colRequestsFrom,
                this.colRequestsTo,
                this.colRequestsDays,
                this.colRequestsReason,
                this.colRequestsStatus});
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.TabIndex = 7;
            // 
            // colRequestsId
            // 
            this.colRequestsId.DataPropertyName = "ID";
            this.colRequestsId.HeaderText = "ID";
            this.colRequestsId.Name = "colRequestsId";
            this.colRequestsId.ReadOnly = true;
            // 
            // colRequestsEmployee
            // 
            this.colRequestsEmployee.DataPropertyName = "Employee";
            this.colRequestsEmployee.HeaderText = "Employee";
            this.colRequestsEmployee.Name = "colRequestsEmployee";
            this.colRequestsEmployee.ReadOnly = true;
            // 
            // colRequestsLeaveType
            // 
            this.colRequestsLeaveType.DataPropertyName = "LeaveType";
            this.colRequestsLeaveType.HeaderText = "Leave type";
            this.colRequestsLeaveType.Name = "colRequestsLeaveType";
            this.colRequestsLeaveType.ReadOnly = true;
            // 
            // colRequestsFrom
            // 
            this.colRequestsFrom.DataPropertyName = "StartDate";
            this.colRequestsFrom.HeaderText = "From";
            this.colRequestsFrom.Name = "colRequestsFrom";
            this.colRequestsFrom.ReadOnly = true;
            // 
            // colRequestsTo
            // 
            this.colRequestsTo.DataPropertyName = "EndDate";
            this.colRequestsTo.HeaderText = "To";
            this.colRequestsTo.Name = "colRequestsTo";
            this.colRequestsTo.ReadOnly = true;
            // 
            // colRequestsDays
            // 
            this.colRequestsDays.DataPropertyName = "Days";
            this.colRequestsDays.HeaderText = "Days";
            this.colRequestsDays.Name = "colRequestsDays";
            this.colRequestsDays.ReadOnly = true;
            // 
            // colRequestsReason
            // 
            this.colRequestsReason.DataPropertyName = "Reason";
            this.colRequestsReason.HeaderText = "Reason";
            this.colRequestsReason.Name = "colRequestsReason";
            this.colRequestsReason.ReadOnly = true;
            // 
            // colRequestsStatus
            // 
            this.colRequestsStatus.DataPropertyName = "Status";
            this.colRequestsStatus.HeaderText = "Status";
            this.colRequestsStatus.Name = "colRequestsStatus";
            this.colRequestsStatus.ReadOnly = true;
            // 
            // LeaveRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.dgvRequests);
            this.Name = "LeaveRequestsForm";
            this.Text = "Leave requests";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestsEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestsLeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestsFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestsTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestsDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestsReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestsStatus;
    }
}
