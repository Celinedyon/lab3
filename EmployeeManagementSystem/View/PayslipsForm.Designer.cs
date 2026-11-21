namespace EmployeeManagementSystem.View
{
    partial class PayslipsForm
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
            this.dgvPayslips = new System.Windows.Forms.DataGridView();
            this.colPayslipsMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayslipsYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayslipsGross = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayslipsDeductions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayslipsNetPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPayslip = new System.Windows.Forms.Panel();
            this.lblPayslipTitle = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblKeyBasic = new System.Windows.Forms.Label();
            this.lblValBasic = new System.Windows.Forms.Label();
            this.lblKeyAllowances = new System.Windows.Forms.Label();
            this.lblValAllowances = new System.Windows.Forms.Label();
            this.lblKeyGross = new System.Windows.Forms.Label();
            this.lblValGross = new System.Windows.Forms.Label();
            this.lblKeyDeductions = new System.Windows.Forms.Label();
            this.lblValDeductions = new System.Windows.Forms.Label();
            this.lblKeyUnpaid = new System.Windows.Forms.Label();
            this.lblValUnpaid = new System.Windows.Forms.Label();
            this.lblKeyNet = new System.Windows.Forms.Label();
            this.lblValNet = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayslips)).BeginInit();
            this.pnlPayslip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPayslips
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
            this.dgvPayslips.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayslips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayslips.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayslips.AllowUserToAddRows = false;
            this.dgvPayslips.AllowUserToDeleteRows = false;
            this.dgvPayslips.AllowUserToResizeRows = false;
            this.dgvPayslips.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvPayslips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayslips.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayslips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayslips.ColumnHeadersHeight = 36;
            this.dgvPayslips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayslips.EnableHeadersVisualStyles = false;
            this.dgvPayslips.GridColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.dgvPayslips.Location = new System.Drawing.Point(24, 20);
            this.dgvPayslips.MultiSelect = false;
            this.dgvPayslips.ReadOnly = true;
            this.dgvPayslips.RowHeadersVisible = false;
            this.dgvPayslips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayslips.Size = new System.Drawing.Size(560, 556);
            this.dgvPayslips.RowTemplate.Height = 30;
            this.dgvPayslips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colPayslipsMonth,
                this.colPayslipsYear,
                this.colPayslipsGross,
                this.colPayslipsDeductions,
                this.colPayslipsNetPay});
            this.dgvPayslips.Name = "dgvPayslips";
            this.dgvPayslips.TabIndex = 1;
            // 
            // colPayslipsMonth
            // 
            this.colPayslipsMonth.DataPropertyName = "Month";
            this.colPayslipsMonth.HeaderText = "Month";
            this.colPayslipsMonth.Name = "colPayslipsMonth";
            this.colPayslipsMonth.ReadOnly = true;
            // 
            // colPayslipsYear
            // 
            this.colPayslipsYear.DataPropertyName = "Year";
            this.colPayslipsYear.HeaderText = "Year";
            this.colPayslipsYear.Name = "colPayslipsYear";
            this.colPayslipsYear.ReadOnly = true;
            // 
            // colPayslipsGross
            // 
            this.colPayslipsGross.DataPropertyName = "Gross";
            this.colPayslipsGross.HeaderText = "Gross";
            this.colPayslipsGross.Name = "colPayslipsGross";
            this.colPayslipsGross.ReadOnly = true;
            // 
            // colPayslipsDeductions
            // 
            this.colPayslipsDeductions.DataPropertyName = "Deductions";
            this.colPayslipsDeductions.HeaderText = "Deductions";
            this.colPayslipsDeductions.Name = "colPayslipsDeductions";
            this.colPayslipsDeductions.ReadOnly = true;
            // 
            // colPayslipsNetPay
            // 
            this.colPayslipsNetPay.DataPropertyName = "Net";
            this.colPayslipsNetPay.HeaderText = "Net pay";
            this.colPayslipsNetPay.Name = "colPayslipsNetPay";
            this.colPayslipsNetPay.ReadOnly = true;
            // 
            // pnlPayslip
            // 
            this.pnlPayslip.BackColor = System.Drawing.Color.White;
            this.pnlPayslip.Location = new System.Drawing.Point(608, 20);
            this.pnlPayslip.Size = new System.Drawing.Size(368, 556);
            this.pnlPayslip.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlPayslip.Name = "pnlPayslip";
            this.pnlPayslip.TabIndex = 2;
            this.pnlPayslip.Controls.Add(this.lblPayslipTitle);
            this.pnlPayslip.Controls.Add(this.lblPeriod);
            this.pnlPayslip.Controls.Add(this.lblKeyBasic);
            this.pnlPayslip.Controls.Add(this.lblValBasic);
            this.pnlPayslip.Controls.Add(this.lblKeyAllowances);
            this.pnlPayslip.Controls.Add(this.lblValAllowances);
            this.pnlPayslip.Controls.Add(this.lblKeyGross);
            this.pnlPayslip.Controls.Add(this.lblValGross);
            this.pnlPayslip.Controls.Add(this.lblKeyDeductions);
            this.pnlPayslip.Controls.Add(this.lblValDeductions);
            this.pnlPayslip.Controls.Add(this.lblKeyUnpaid);
            this.pnlPayslip.Controls.Add(this.lblValUnpaid);
            this.pnlPayslip.Controls.Add(this.lblKeyNet);
            this.pnlPayslip.Controls.Add(this.lblValNet);
            this.pnlPayslip.Controls.Add(this.btnDownload);
            // 
            // lblPayslipTitle
            // 
            this.lblPayslipTitle.AutoSize = true;
            this.lblPayslipTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayslipTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPayslipTitle.Location = new System.Drawing.Point(24, 20);
            this.lblPayslipTitle.Text = "Payslip";
            this.lblPayslipTitle.Name = "lblPayslipTitle";
            this.lblPayslipTitle.TabIndex = 3;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPeriod.Location = new System.Drawing.Point(24, 52);
            this.lblPeriod.Text = "Select a payslip from the list";
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.TabIndex = 4;
            // 
            // lblKeyBasic
            // 
            this.lblKeyBasic.AutoSize = true;
            this.lblKeyBasic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyBasic.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblKeyBasic.Location = new System.Drawing.Point(24, 100);
            this.lblKeyBasic.Text = "Basic salary";
            this.lblKeyBasic.Name = "lblKeyBasic";
            this.lblKeyBasic.TabIndex = 5;
            // 
            // lblValBasic
            // 
            this.lblValBasic.AutoSize = false;
            this.lblValBasic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValBasic.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblValBasic.Location = new System.Drawing.Point(200, 100);
            this.lblValBasic.Text = "0.00";
            this.lblValBasic.Size = new System.Drawing.Size(140, 24);
            this.lblValBasic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValBasic.Name = "lblValBasic";
            this.lblValBasic.TabIndex = 6;
            // 
            // lblKeyAllowances
            // 
            this.lblKeyAllowances.AutoSize = true;
            this.lblKeyAllowances.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyAllowances.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblKeyAllowances.Location = new System.Drawing.Point(24, 144);
            this.lblKeyAllowances.Text = "Allowances";
            this.lblKeyAllowances.Name = "lblKeyAllowances";
            this.lblKeyAllowances.TabIndex = 7;
            // 
            // lblValAllowances
            // 
            this.lblValAllowances.AutoSize = false;
            this.lblValAllowances.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValAllowances.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblValAllowances.Location = new System.Drawing.Point(200, 144);
            this.lblValAllowances.Text = "0.00";
            this.lblValAllowances.Size = new System.Drawing.Size(140, 24);
            this.lblValAllowances.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValAllowances.Name = "lblValAllowances";
            this.lblValAllowances.TabIndex = 8;
            // 
            // lblKeyGross
            // 
            this.lblKeyGross.AutoSize = true;
            this.lblKeyGross.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyGross.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblKeyGross.Location = new System.Drawing.Point(24, 188);
            this.lblKeyGross.Text = "Gross pay";
            this.lblKeyGross.Name = "lblKeyGross";
            this.lblKeyGross.TabIndex = 9;
            // 
            // lblValGross
            // 
            this.lblValGross.AutoSize = false;
            this.lblValGross.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValGross.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblValGross.Location = new System.Drawing.Point(200, 188);
            this.lblValGross.Text = "0.00";
            this.lblValGross.Size = new System.Drawing.Size(140, 24);
            this.lblValGross.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValGross.Name = "lblValGross";
            this.lblValGross.TabIndex = 10;
            // 
            // lblKeyDeductions
            // 
            this.lblKeyDeductions.AutoSize = true;
            this.lblKeyDeductions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyDeductions.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblKeyDeductions.Location = new System.Drawing.Point(24, 232);
            this.lblKeyDeductions.Text = "Deductions";
            this.lblKeyDeductions.Name = "lblKeyDeductions";
            this.lblKeyDeductions.TabIndex = 11;
            // 
            // lblValDeductions
            // 
            this.lblValDeductions.AutoSize = false;
            this.lblValDeductions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValDeductions.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblValDeductions.Location = new System.Drawing.Point(200, 232);
            this.lblValDeductions.Text = "0.00";
            this.lblValDeductions.Size = new System.Drawing.Size(140, 24);
            this.lblValDeductions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValDeductions.Name = "lblValDeductions";
            this.lblValDeductions.TabIndex = 12;
            // 
            // lblKeyUnpaid
            // 
            this.lblKeyUnpaid.AutoSize = true;
            this.lblKeyUnpaid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyUnpaid.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblKeyUnpaid.Location = new System.Drawing.Point(24, 276);
            this.lblKeyUnpaid.Text = "Unpaid leave and absences";
            this.lblKeyUnpaid.Name = "lblKeyUnpaid";
            this.lblKeyUnpaid.TabIndex = 13;
            // 
            // lblValUnpaid
            // 
            this.lblValUnpaid.AutoSize = false;
            this.lblValUnpaid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValUnpaid.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblValUnpaid.Location = new System.Drawing.Point(200, 276);
            this.lblValUnpaid.Text = "0.00";
            this.lblValUnpaid.Size = new System.Drawing.Size(140, 24);
            this.lblValUnpaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValUnpaid.Name = "lblValUnpaid";
            this.lblValUnpaid.TabIndex = 14;
            // 
            // lblKeyNet
            // 
            this.lblKeyNet.AutoSize = true;
            this.lblKeyNet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyNet.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.lblKeyNet.Location = new System.Drawing.Point(24, 330);
            this.lblKeyNet.Text = "Net pay";
            this.lblKeyNet.Name = "lblKeyNet";
            this.lblKeyNet.TabIndex = 15;
            // 
            // lblValNet
            // 
            this.lblValNet.AutoSize = false;
            this.lblValNet.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValNet.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.lblValNet.Location = new System.Drawing.Point(160, 328);
            this.lblValNet.Text = "0.00";
            this.lblValNet.Size = new System.Drawing.Size(180, 28);
            this.lblValNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValNet.Name = "lblValNet";
            this.lblValNet.TabIndex = 16;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(24, 480);
            this.btnDownload.Size = new System.Drawing.Size(160, 36);
            this.btnDownload.Text = "Download PDF";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.TabIndex = 17;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // PayslipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.dgvPayslips);
            this.Controls.Add(this.pnlPayslip);
            this.Name = "PayslipsForm";
            this.Text = "Payslips";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayslips)).EndInit();
            this.pnlPayslip.ResumeLayout(false);
            this.pnlPayslip.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPayslips;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayslipsMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayslipsYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayslipsGross;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayslipsDeductions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayslipsNetPay;
        private System.Windows.Forms.Panel pnlPayslip;
        private System.Windows.Forms.Label lblPayslipTitle;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblKeyBasic;
        private System.Windows.Forms.Label lblValBasic;
        private System.Windows.Forms.Label lblKeyAllowances;
        private System.Windows.Forms.Label lblValAllowances;
        private System.Windows.Forms.Label lblKeyGross;
        private System.Windows.Forms.Label lblValGross;
        private System.Windows.Forms.Label lblKeyDeductions;
        private System.Windows.Forms.Label lblValDeductions;
        private System.Windows.Forms.Label lblKeyUnpaid;
        private System.Windows.Forms.Label lblValUnpaid;
        private System.Windows.Forms.Label lblKeyNet;
        private System.Windows.Forms.Label lblValNet;
        private System.Windows.Forms.Button btnDownload;
    }
}
