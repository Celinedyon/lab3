namespace EmployeeManagementSystem.View
{
    partial class AttendanceCorrectionForm
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
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblClockIn = new System.Windows.Forms.Label();
            this.dtpClockIn = new System.Windows.Forms.DateTimePicker();
            this.lblClockOut = new System.Windows.Forms.Label();
            this.dtpClockOut = new System.Windows.Forms.DateTimePicker();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblEmployee.Location = new System.Drawing.Point(24, 16);
            this.lblEmployee.Text = "Employee";
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.TabIndex = 1;
            // 
            // txtEmployee
            // 
            this.txtEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee.Location = new System.Drawing.Point(24, 38);
            this.txtEmployee.Size = new System.Drawing.Size(400, 27);
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblDate.Location = new System.Drawing.Point(24, 80);
            this.lblDate.Text = "Date";
            this.lblDate.Name = "lblDate";
            this.lblDate.TabIndex = 3;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(24, 102);
            this.dtpDate.Size = new System.Drawing.Size(190, 27);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblStatus.Location = new System.Drawing.Point(234, 80);
            this.lblStatus.Text = "Status";
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.TabIndex = 5;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(234, 102);
            this.cboStatus.Size = new System.Drawing.Size(190, 28);
            this.cboStatus.Items.AddRange(new object[] {"Present", "Late", "Absent"});
            this.cboStatus.SelectedIndex = 0;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.TabIndex = 6;
            // 
            // lblClockIn
            // 
            this.lblClockIn.AutoSize = true;
            this.lblClockIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockIn.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblClockIn.Location = new System.Drawing.Point(24, 144);
            this.lblClockIn.Text = "Clock in";
            this.lblClockIn.Name = "lblClockIn";
            this.lblClockIn.TabIndex = 7;
            // 
            // dtpClockIn
            // 
            this.dtpClockIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpClockIn.Location = new System.Drawing.Point(24, 166);
            this.dtpClockIn.Size = new System.Drawing.Size(190, 27);
            this.dtpClockIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpClockIn.ShowUpDown = true;
            this.dtpClockIn.Name = "dtpClockIn";
            this.dtpClockIn.TabIndex = 8;
            // 
            // lblClockOut
            // 
            this.lblClockOut.AutoSize = true;
            this.lblClockOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockOut.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblClockOut.Location = new System.Drawing.Point(234, 144);
            this.lblClockOut.Text = "Clock out";
            this.lblClockOut.Name = "lblClockOut";
            this.lblClockOut.TabIndex = 9;
            // 
            // dtpClockOut
            // 
            this.dtpClockOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpClockOut.Location = new System.Drawing.Point(234, 166);
            this.dtpClockOut.Size = new System.Drawing.Size(190, 27);
            this.dtpClockOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpClockOut.ShowUpDown = true;
            this.dtpClockOut.Name = "dtpClockOut";
            this.dtpClockOut.TabIndex = 10;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblReason.Location = new System.Drawing.Point(24, 208);
            this.lblReason.Text = "Reason for the correction";
            this.lblReason.Name = "lblReason";
            this.lblReason.TabIndex = 11;
            // 
            // txtReason
            // 
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(24, 230);
            this.txtReason.Size = new System.Drawing.Size(400, 90);
            this.txtReason.Multiline = true;
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReason.Name = "txtReason";
            this.txtReason.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(224, 340);
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Name = "btnSave";
            this.btnSave.TabIndex = 13;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnCancel.Location = new System.Drawing.Point(334, 340);
            this.btnCancel.Size = new System.Drawing.Size(90, 36);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TabIndex = 14;
            // 
            // AttendanceCorrectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(460, 400);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblClockIn);
            this.Controls.Add(this.dtpClockIn);
            this.Controls.Add(this.lblClockOut);
            this.Controls.Add(this.dtpClockOut);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "AttendanceCorrectionForm";
            this.Text = "Correct attendance record";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblClockIn;
        private System.Windows.Forms.DateTimePicker dtpClockIn;
        private System.Windows.Forms.Label lblClockOut;
        private System.Windows.Forms.DateTimePicker dtpClockOut;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
