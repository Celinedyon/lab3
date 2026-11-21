namespace EmployeeManagementSystem.View
{
    partial class AttendanceForm
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
            this.pnlToday = new System.Windows.Forms.Panel();
            this.lblTodayTitle = new System.Windows.Forms.Label();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.lblClockStatus = new System.Windows.Forms.Label();
            this.lblHoursToday = new System.Windows.Forms.Label();
            this.btnClockIn = new System.Windows.Forms.Button();
            this.btnClockOut = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.colAttendanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttendanceEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttendanceClockIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttendanceClockOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttendanceHoursWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttendanceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttendanceNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.pnlToday.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToday
            // 
            this.pnlToday.BackColor = System.Drawing.Color.White;
            this.pnlToday.Location = new System.Drawing.Point(24, 20);
            this.pnlToday.Size = new System.Drawing.Size(952, 140);
            this.pnlToday.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlToday.Name = "pnlToday";
            this.pnlToday.TabIndex = 1;
            this.pnlToday.Controls.Add(this.lblTodayTitle);
            this.pnlToday.Controls.Add(this.lblTodayDate);
            this.pnlToday.Controls.Add(this.lblClockStatus);
            this.pnlToday.Controls.Add(this.lblHoursToday);
            this.pnlToday.Controls.Add(this.btnClockIn);
            this.pnlToday.Controls.Add(this.btnClockOut);
            // 
            // lblTodayTitle
            // 
            this.lblTodayTitle.AutoSize = true;
            this.lblTodayTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTodayTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTodayTitle.Text = "Today";
            this.lblTodayTitle.Name = "lblTodayTitle";
            this.lblTodayTitle.TabIndex = 2;
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.lblTodayDate.Location = new System.Drawing.Point(20, 48);
            this.lblTodayDate.Text = "-";
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.TabIndex = 3;
            // 
            // lblClockStatus
            // 
            this.lblClockStatus.AutoSize = true;
            this.lblClockStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockStatus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblClockStatus.Location = new System.Drawing.Point(20, 86);
            this.lblClockStatus.Text = "Not clocked in yet";
            this.lblClockStatus.Name = "lblClockStatus";
            this.lblClockStatus.TabIndex = 4;
            // 
            // lblHoursToday
            // 
            this.lblHoursToday.AutoSize = true;
            this.lblHoursToday.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursToday.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHoursToday.Location = new System.Drawing.Point(20, 108);
            this.lblHoursToday.Text = "Hours worked today: 0.00";
            this.lblHoursToday.Name = "lblHoursToday";
            this.lblHoursToday.TabIndex = 5;
            // 
            // btnClockIn
            // 
            this.btnClockIn.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnClockIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClockIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClockIn.ForeColor = System.Drawing.Color.White;
            this.btnClockIn.Location = new System.Drawing.Point(690, 46);
            this.btnClockIn.Size = new System.Drawing.Size(120, 44);
            this.btnClockIn.Text = "Clock in";
            this.btnClockIn.UseVisualStyleBackColor = false;
            this.btnClockIn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnClockIn.FlatAppearance.BorderSize = 0;
            this.btnClockIn.Name = "btnClockIn";
            this.btnClockIn.TabIndex = 6;
            this.btnClockIn.Click += new System.EventHandler(this.btnClockIn_Click);
            // 
            // btnClockOut
            // 
            this.btnClockOut.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnClockOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClockOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClockOut.ForeColor = System.Drawing.Color.White;
            this.btnClockOut.Location = new System.Drawing.Point(820, 46);
            this.btnClockOut.Size = new System.Drawing.Size(120, 44);
            this.btnClockOut.Text = "Clock out";
            this.btnClockOut.UseVisualStyleBackColor = false;
            this.btnClockOut.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnClockOut.FlatAppearance.BorderSize = 0;
            this.btnClockOut.Name = "btnClockOut";
            this.btnClockOut.TabIndex = 7;
            this.btnClockOut.Click += new System.EventHandler(this.btnClockOut_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Location = new System.Drawing.Point(24, 176);
            this.pnlFilter.Size = new System.Drawing.Size(952, 76);
            this.pnlFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.TabIndex = 8;
            this.pnlFilter.Controls.Add(this.lblFrom);
            this.pnlFilter.Controls.Add(this.dtpFrom);
            this.pnlFilter.Controls.Add(this.lblTo);
            this.pnlFilter.Controls.Add(this.dtpTo);
            this.pnlFilter.Controls.Add(this.lblEmployee);
            this.pnlFilter.Controls.Add(this.cboEmployee);
            this.pnlFilter.Controls.Add(this.btnShow);
            this.pnlFilter.Controls.Add(this.btnCorrect);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblFrom.Location = new System.Drawing.Point(16, 6);
            this.lblFrom.Text = "From";
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.TabIndex = 9;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(16, 30);
            this.dtpFrom.Size = new System.Drawing.Size(150, 27);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.TabIndex = 10;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTo.Location = new System.Drawing.Point(186, 6);
            this.lblTo.Text = "To";
            this.lblTo.Name = "lblTo";
            this.lblTo.TabIndex = 11;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(186, 30);
            this.dtpTo.Size = new System.Drawing.Size(150, 27);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.TabIndex = 12;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblEmployee.Location = new System.Drawing.Point(356, 6);
            this.lblEmployee.Text = "Employee";
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.TabIndex = 13;
            // 
            // cboEmployee
            // 
            this.cboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(356, 30);
            this.cboEmployee.Size = new System.Drawing.Size(220, 28);
            this.cboEmployee.Items.AddRange(new object[] {"All employees"});
            this.cboEmployee.SelectedIndex = 0;
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.TabIndex = 14;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(596, 26);
            this.btnShow.Size = new System.Drawing.Size(130, 36);
            this.btnShow.Text = "Show history";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.Name = "btnShow";
            this.btnShow.TabIndex = 15;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.BackColor = System.Drawing.Color.White;
            this.btnCorrect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrect.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnCorrect.Location = new System.Drawing.Point(736, 26);
            this.btnCorrect.Size = new System.Drawing.Size(140, 36);
            this.btnCorrect.Text = "Correct record";
            this.btnCorrect.UseVisualStyleBackColor = false;
            this.btnCorrect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.TabIndex = 16;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // dgvAttendance
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
            this.dgvAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AllowUserToResizeRows = false;
            this.dgvAttendance.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendance.ColumnHeadersHeight = 36;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAttendance.EnableHeadersVisualStyles = false;
            this.dgvAttendance.GridColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.dgvAttendance.Location = new System.Drawing.Point(24, 268);
            this.dgvAttendance.MultiSelect = false;
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(952, 308);
            this.dgvAttendance.RowTemplate.Height = 30;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colAttendanceDate,
                this.colAttendanceEmployee,
                this.colAttendanceClockIn,
                this.colAttendanceClockOut,
                this.colAttendanceHoursWorked,
                this.colAttendanceStatus,
                this.colAttendanceNote});
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.TabIndex = 17;
            // 
            // colAttendanceDate
            // 
            this.colAttendanceDate.DataPropertyName = "WorkDate";
            this.colAttendanceDate.HeaderText = "Date";
            this.colAttendanceDate.Name = "colAttendanceDate";
            this.colAttendanceDate.ReadOnly = true;
            // 
            // colAttendanceEmployee
            // 
            this.colAttendanceEmployee.DataPropertyName = "Employee";
            this.colAttendanceEmployee.HeaderText = "Employee";
            this.colAttendanceEmployee.Name = "colAttendanceEmployee";
            this.colAttendanceEmployee.ReadOnly = true;
            // 
            // colAttendanceClockIn
            // 
            this.colAttendanceClockIn.DataPropertyName = "ClockIn";
            this.colAttendanceClockIn.HeaderText = "Clock in";
            this.colAttendanceClockIn.Name = "colAttendanceClockIn";
            this.colAttendanceClockIn.ReadOnly = true;
            // 
            // colAttendanceClockOut
            // 
            this.colAttendanceClockOut.DataPropertyName = "ClockOut";
            this.colAttendanceClockOut.HeaderText = "Clock out";
            this.colAttendanceClockOut.Name = "colAttendanceClockOut";
            this.colAttendanceClockOut.ReadOnly = true;
            // 
            // colAttendanceHoursWorked
            // 
            this.colAttendanceHoursWorked.DataPropertyName = "HoursWorked";
            this.colAttendanceHoursWorked.HeaderText = "Hours worked";
            this.colAttendanceHoursWorked.Name = "colAttendanceHoursWorked";
            this.colAttendanceHoursWorked.ReadOnly = true;
            // 
            // colAttendanceStatus
            // 
            this.colAttendanceStatus.DataPropertyName = "Status";
            this.colAttendanceStatus.HeaderText = "Status";
            this.colAttendanceStatus.Name = "colAttendanceStatus";
            this.colAttendanceStatus.ReadOnly = true;
            // 
            // colAttendanceNote
            // 
            this.colAttendanceNote.DataPropertyName = "Note";
            this.colAttendanceNote.HeaderText = "Note";
            this.colAttendanceNote.Name = "colAttendanceNote";
            this.colAttendanceNote.ReadOnly = true;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.pnlToday);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.dgvAttendance);
            this.Name = "AttendanceForm";
            this.Text = "Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.pnlToday.ResumeLayout(false);
            this.pnlToday.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlToday;
        private System.Windows.Forms.Label lblTodayTitle;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.Label lblClockStatus;
        private System.Windows.Forms.Label lblHoursToday;
        private System.Windows.Forms.Button btnClockIn;
        private System.Windows.Forms.Button btnClockOut;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendanceEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendanceClockIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendanceClockOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendanceHoursWorked;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendanceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendanceNote;
    }
}
