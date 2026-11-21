namespace EmployeeManagementSystem.View
{
    partial class LeaveForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.lblBalanceTitle = new System.Windows.Forms.Label();
            this.dgvBalance = new System.Windows.Forms.DataGridView();
            this.colBalanceLeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalanceAllowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalanceUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalanceRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRequest = new System.Windows.Forms.Panel();
            this.lblRequestTitle = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.colRequestsLeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestsFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestsTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestsDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestsStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.pnlBalance.SuspendLayout();
            this.pnlRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBalance
            // 
            this.pnlBalance.BackColor = System.Drawing.Color.White;
            this.pnlBalance.Location = new System.Drawing.Point(24, 20);
            this.pnlBalance.Size = new System.Drawing.Size(952, 170);
            this.pnlBalance.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.TabIndex = 1;
            this.pnlBalance.Controls.Add(this.lblBalanceTitle);
            this.pnlBalance.Controls.Add(this.dgvBalance);
            // 
            // lblBalanceTitle
            // 
            this.lblBalanceTitle.AutoSize = true;
            this.lblBalanceTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblBalanceTitle.Location = new System.Drawing.Point(20, 12);
            this.lblBalanceTitle.Text = "Leave balance";
            this.lblBalanceTitle.Name = "lblBalanceTitle";
            this.lblBalanceTitle.TabIndex = 2;
            // 
            // dgvBalance
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
            this.dgvBalance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBalance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBalance.AllowUserToAddRows = false;
            this.dgvBalance.AllowUserToDeleteRows = false;
            this.dgvBalance.AllowUserToResizeRows = false;
            this.dgvBalance.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBalance.BackgroundColor = System.Drawing.Color.White;
            this.dgvBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBalance.ColumnHeadersHeight = 36;
            this.dgvBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBalance.EnableHeadersVisualStyles = false;
            this.dgvBalance.GridColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.dgvBalance.Location = new System.Drawing.Point(16, 46);
            this.dgvBalance.MultiSelect = false;
            this.dgvBalance.ReadOnly = true;
            this.dgvBalance.RowHeadersVisible = false;
            this.dgvBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBalance.Size = new System.Drawing.Size(920, 110);
            this.dgvBalance.RowTemplate.Height = 30;
            this.dgvBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colBalanceLeaveType,
                this.colBalanceAllowed,
                this.colBalanceUsed,
                this.colBalanceRemaining});
            this.dgvBalance.Name = "dgvBalance";
            this.dgvBalance.TabIndex = 3;
            // 
            // colBalanceLeaveType
            // 
            this.colBalanceLeaveType.DataPropertyName = "LeaveType";
            this.colBalanceLeaveType.HeaderText = "Leave type";
            this.colBalanceLeaveType.Name = "colBalanceLeaveType";
            this.colBalanceLeaveType.ReadOnly = true;
            // 
            // colBalanceAllowed
            // 
            this.colBalanceAllowed.DataPropertyName = "Allowed";
            this.colBalanceAllowed.HeaderText = "Allowed";
            this.colBalanceAllowed.Name = "colBalanceAllowed";
            this.colBalanceAllowed.ReadOnly = true;
            // 
            // colBalanceUsed
            // 
            this.colBalanceUsed.DataPropertyName = "Used";
            this.colBalanceUsed.HeaderText = "Used";
            this.colBalanceUsed.Name = "colBalanceUsed";
            this.colBalanceUsed.ReadOnly = true;
            // 
            // colBalanceRemaining
            // 
            this.colBalanceRemaining.DataPropertyName = "Remaining";
            this.colBalanceRemaining.HeaderText = "Remaining";
            this.colBalanceRemaining.Name = "colBalanceRemaining";
            this.colBalanceRemaining.ReadOnly = true;
            // 
            // pnlRequest
            // 
            this.pnlRequest.BackColor = System.Drawing.Color.White;
            this.pnlRequest.Location = new System.Drawing.Point(24, 206);
            this.pnlRequest.Size = new System.Drawing.Size(380, 370);
            this.pnlRequest.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlRequest.Name = "pnlRequest";
            this.pnlRequest.TabIndex = 4;
            this.pnlRequest.Controls.Add(this.lblRequestTitle);
            this.pnlRequest.Controls.Add(this.lblType);
            this.pnlRequest.Controls.Add(this.cboType);
            this.pnlRequest.Controls.Add(this.lblFrom);
            this.pnlRequest.Controls.Add(this.dtpFrom);
            this.pnlRequest.Controls.Add(this.lblTo);
            this.pnlRequest.Controls.Add(this.dtpTo);
            this.pnlRequest.Controls.Add(this.lblReason);
            this.pnlRequest.Controls.Add(this.txtReason);
            this.pnlRequest.Controls.Add(this.lblDays);
            this.pnlRequest.Controls.Add(this.btnSubmit);
            // 
            // lblRequestTitle
            // 
            this.lblRequestTitle.AutoSize = true;
            this.lblRequestTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblRequestTitle.Location = new System.Drawing.Point(20, 14);
            this.lblRequestTitle.Text = "Request leave";
            this.lblRequestTitle.Name = "lblRequestTitle";
            this.lblRequestTitle.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblType.Location = new System.Drawing.Point(20, 54);
            this.lblType.Text = "Leave type";
            this.lblType.Name = "lblType";
            this.lblType.TabIndex = 6;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(20, 76);
            this.cboType.Size = new System.Drawing.Size(340, 28);
            this.cboType.Name = "cboType";
            this.cboType.TabIndex = 7;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblFrom.Location = new System.Drawing.Point(20, 118);
            this.lblFrom.Text = "From";
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.TabIndex = 8;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(20, 140);
            this.dtpFrom.Size = new System.Drawing.Size(160, 27);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.TabIndex = 9;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTo.Location = new System.Drawing.Point(200, 118);
            this.lblTo.Text = "To";
            this.lblTo.Name = "lblTo";
            this.lblTo.TabIndex = 10;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(200, 140);
            this.dtpTo.Size = new System.Drawing.Size(160, 27);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.TabIndex = 11;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblReason.Location = new System.Drawing.Point(20, 184);
            this.lblReason.Text = "Reason";
            this.lblReason.Name = "lblReason";
            this.lblReason.TabIndex = 12;
            // 
            // txtReason
            // 
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(20, 206);
            this.txtReason.Size = new System.Drawing.Size(340, 90);
            this.txtReason.Multiline = true;
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReason.Name = "txtReason";
            this.txtReason.TabIndex = 13;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDays.Location = new System.Drawing.Point(200, 328);
            this.lblDays.Text = "Days requested: 0";
            this.lblDays.Name = "lblDays";
            this.lblDays.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(20, 320);
            this.btnSubmit.Size = new System.Drawing.Size(160, 36);
            this.btnSubmit.Text = "Submit request";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvRequests
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(219, 230, 245);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvRequests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRequests.DefaultCellStyle = dataGridViewCellStyle5;
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
            this.dgvRequests.Location = new System.Drawing.Point(420, 206);
            this.dgvRequests.MultiSelect = false;
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.RowHeadersVisible = false;
            this.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequests.Size = new System.Drawing.Size(556, 370);
            this.dgvRequests.RowTemplate.Height = 30;
            this.dgvRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colRequestsLeaveType,
                this.colRequestsFrom,
                this.colRequestsTo,
                this.colRequestsDays,
                this.colRequestsStatus});
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.TabIndex = 16;
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
            // colRequestsStatus
            // 
            this.colRequestsStatus.DataPropertyName = "Status";
            this.colRequestsStatus.HeaderText = "Status";
            this.colRequestsStatus.Name = "colRequestsStatus";
            this.colRequestsStatus.ReadOnly = true;
            // 
            // LeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.pnlRequest);
            this.Controls.Add(this.dgvRequests);
            this.Name = "LeaveForm";
            this.Text = "Leave";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.pnlRequest.ResumeLayout(false);
            this.pnlRequest.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Label lblBalanceTitle;
        private System.Windows.Forms.DataGridView dgvBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalanceLeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalanceAllowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalanceUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalanceRemaining;
        private System.Windows.Forms.Panel pnlRequest;
        private System.Windows.Forms.Label lblRequestTitle;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestsLeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestsFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestsTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestsDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestsStatus;
    }
}
