namespace EmployeeManagementSystem.View
{
    partial class PayrollForm
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
            this.tabPayroll = new System.Windows.Forms.TabControl();
            this.tabSalary = new System.Windows.Forms.TabPage();
            this.dgvSalaries = new System.Windows.Forms.DataGridView();
            this.colSalariesEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalariesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalariesBasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalariesAllowances = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalariesDeductions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSalaryEmployee = new System.Windows.Forms.Label();
            this.txtSalaryEmployee = new System.Windows.Forms.TextBox();
            this.lblBasic = new System.Windows.Forms.Label();
            this.numBasic = new System.Windows.Forms.NumericUpDown();
            this.lblAllowances = new System.Windows.Forms.Label();
            this.numAllowances = new System.Windows.Forms.NumericUpDown();
            this.lblDeductions = new System.Windows.Forms.Label();
            this.numDeductions = new System.Windows.Forms.NumericUpDown();
            this.btnSaveSalary = new System.Windows.Forms.Button();
            this.tabRun = new System.Windows.Forms.TabPage();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.lblRunStatus = new System.Windows.Forms.Label();
            this.dgvPayroll = new System.Windows.Forms.DataGridView();
            this.colPayrollEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollBasic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollAllowances = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollDeductions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollUnpaidLeaveAndAbsences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollGrossPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollNetPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalNet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBasic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAllowances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeductions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
            this.tabPayroll.SuspendLayout();
            this.tabSalary.SuspendLayout();
            this.tabRun.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPayroll
            // 
            this.tabPayroll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.tabPayroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPayroll.Location = new System.Drawing.Point(24, 20);
            this.tabPayroll.SelectedIndex = 0;
            this.tabPayroll.Size = new System.Drawing.Size(952, 556);
            this.tabPayroll.Name = "tabPayroll";
            this.tabPayroll.TabIndex = 1;
            this.tabPayroll.Controls.Add(this.tabSalary);
            this.tabPayroll.Controls.Add(this.tabRun);
            // 
            // tabSalary
            // 
            this.tabSalary.BackColor = System.Drawing.Color.White;
            this.tabSalary.Location = new System.Drawing.Point(4, 29);
            this.tabSalary.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabSalary.Size = new System.Drawing.Size(944, 523);
            this.tabSalary.Text = "Salary setup";
            this.tabSalary.UseVisualStyleBackColor = false;
            this.tabSalary.Name = "tabSalary";
            this.tabSalary.TabIndex = 2;
            this.tabSalary.Controls.Add(this.dgvSalaries);
            this.tabSalary.Controls.Add(this.lblSalaryEmployee);
            this.tabSalary.Controls.Add(this.txtSalaryEmployee);
            this.tabSalary.Controls.Add(this.lblBasic);
            this.tabSalary.Controls.Add(this.numBasic);
            this.tabSalary.Controls.Add(this.lblAllowances);
            this.tabSalary.Controls.Add(this.numAllowances);
            this.tabSalary.Controls.Add(this.lblDeductions);
            this.tabSalary.Controls.Add(this.numDeductions);
            this.tabSalary.Controls.Add(this.btnSaveSalary);
            // 
            // dgvSalaries
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
            this.dgvSalaries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalaries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalaries.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalaries.AllowUserToAddRows = false;
            this.dgvSalaries.AllowUserToDeleteRows = false;
            this.dgvSalaries.AllowUserToResizeRows = false;
            this.dgvSalaries.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvSalaries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalaries.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalaries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalaries.ColumnHeadersHeight = 36;
            this.dgvSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalaries.EnableHeadersVisualStyles = false;
            this.dgvSalaries.GridColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.dgvSalaries.Location = new System.Drawing.Point(16, 16);
            this.dgvSalaries.MultiSelect = false;
            this.dgvSalaries.ReadOnly = true;
            this.dgvSalaries.RowHeadersVisible = false;
            this.dgvSalaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaries.Size = new System.Drawing.Size(560, 470);
            this.dgvSalaries.RowTemplate.Height = 30;
            this.dgvSalaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colSalariesEmployeeId,
                this.colSalariesName,
                this.colSalariesBasicSalary,
                this.colSalariesAllowances,
                this.colSalariesDeductions});
            this.dgvSalaries.Name = "dgvSalaries";
            this.dgvSalaries.TabIndex = 3;
            // 
            // colSalariesEmployeeId
            // 
            this.colSalariesEmployeeId.DataPropertyName = "EmployeeCode";
            this.colSalariesEmployeeId.HeaderText = "Employee ID";
            this.colSalariesEmployeeId.Name = "colSalariesEmployeeId";
            this.colSalariesEmployeeId.ReadOnly = true;
            // 
            // colSalariesName
            // 
            this.colSalariesName.DataPropertyName = "FullName";
            this.colSalariesName.HeaderText = "Name";
            this.colSalariesName.Name = "colSalariesName";
            this.colSalariesName.ReadOnly = true;
            // 
            // colSalariesBasicSalary
            // 
            this.colSalariesBasicSalary.DataPropertyName = "BasicSalary";
            this.colSalariesBasicSalary.HeaderText = "Basic salary";
            this.colSalariesBasicSalary.Name = "colSalariesBasicSalary";
            this.colSalariesBasicSalary.ReadOnly = true;
            // 
            // colSalariesAllowances
            // 
            this.colSalariesAllowances.DataPropertyName = "Allowances";
            this.colSalariesAllowances.HeaderText = "Allowances";
            this.colSalariesAllowances.Name = "colSalariesAllowances";
            this.colSalariesAllowances.ReadOnly = true;
            // 
            // colSalariesDeductions
            // 
            this.colSalariesDeductions.DataPropertyName = "Deductions";
            this.colSalariesDeductions.HeaderText = "Deductions";
            this.colSalariesDeductions.Name = "colSalariesDeductions";
            this.colSalariesDeductions.ReadOnly = true;
            // 
            // lblSalaryEmployee
            // 
            this.lblSalaryEmployee.AutoSize = true;
            this.lblSalaryEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryEmployee.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblSalaryEmployee.Location = new System.Drawing.Point(600, 16);
            this.lblSalaryEmployee.Text = "Employee";
            this.lblSalaryEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblSalaryEmployee.Name = "lblSalaryEmployee";
            this.lblSalaryEmployee.TabIndex = 4;
            // 
            // txtSalaryEmployee
            // 
            this.txtSalaryEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalaryEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryEmployee.Location = new System.Drawing.Point(600, 38);
            this.txtSalaryEmployee.Size = new System.Drawing.Size(300, 27);
            this.txtSalaryEmployee.ReadOnly = true;
            this.txtSalaryEmployee.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.txtSalaryEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.txtSalaryEmployee.Name = "txtSalaryEmployee";
            this.txtSalaryEmployee.TabIndex = 5;
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasic.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblBasic.Location = new System.Drawing.Point(600, 82);
            this.lblBasic.Text = "Basic salary";
            this.lblBasic.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.TabIndex = 6;
            // 
            // numBasic
            // 
            this.numBasic.DecimalPlaces = 2;
            this.numBasic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBasic.Location = new System.Drawing.Point(600, 104);
            this.numBasic.Size = new System.Drawing.Size(300, 27);
            this.numBasic.Maximum = new decimal(new int[] {1000000000, 0, 0, 0});
            this.numBasic.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.numBasic.Value = new decimal(new int[] {0, 0, 0, 0});
            this.numBasic.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.numBasic.Name = "numBasic";
            this.numBasic.TabIndex = 7;
            // 
            // lblAllowances
            // 
            this.lblAllowances.AutoSize = true;
            this.lblAllowances.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllowances.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblAllowances.Location = new System.Drawing.Point(600, 148);
            this.lblAllowances.Text = "Allowances";
            this.lblAllowances.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblAllowances.Name = "lblAllowances";
            this.lblAllowances.TabIndex = 8;
            // 
            // numAllowances
            // 
            this.numAllowances.DecimalPlaces = 2;
            this.numAllowances.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAllowances.Location = new System.Drawing.Point(600, 170);
            this.numAllowances.Size = new System.Drawing.Size(300, 27);
            this.numAllowances.Maximum = new decimal(new int[] {1000000000, 0, 0, 0});
            this.numAllowances.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.numAllowances.Value = new decimal(new int[] {0, 0, 0, 0});
            this.numAllowances.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.numAllowances.Name = "numAllowances";
            this.numAllowances.TabIndex = 9;
            // 
            // lblDeductions
            // 
            this.lblDeductions.AutoSize = true;
            this.lblDeductions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeductions.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblDeductions.Location = new System.Drawing.Point(600, 214);
            this.lblDeductions.Text = "Deductions";
            this.lblDeductions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblDeductions.Name = "lblDeductions";
            this.lblDeductions.TabIndex = 10;
            // 
            // numDeductions
            // 
            this.numDeductions.DecimalPlaces = 2;
            this.numDeductions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDeductions.Location = new System.Drawing.Point(600, 236);
            this.numDeductions.Size = new System.Drawing.Size(300, 27);
            this.numDeductions.Maximum = new decimal(new int[] {1000000000, 0, 0, 0});
            this.numDeductions.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.numDeductions.Value = new decimal(new int[] {0, 0, 0, 0});
            this.numDeductions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.numDeductions.Name = "numDeductions";
            this.numDeductions.TabIndex = 11;
            // 
            // btnSaveSalary
            // 
            this.btnSaveSalary.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnSaveSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSalary.ForeColor = System.Drawing.Color.White;
            this.btnSaveSalary.Location = new System.Drawing.Point(600, 288);
            this.btnSaveSalary.Size = new System.Drawing.Size(140, 36);
            this.btnSaveSalary.Text = "Save salary";
            this.btnSaveSalary.UseVisualStyleBackColor = false;
            this.btnSaveSalary.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveSalary.FlatAppearance.BorderSize = 0;
            this.btnSaveSalary.Name = "btnSaveSalary";
            this.btnSaveSalary.TabIndex = 12;
            this.btnSaveSalary.Click += new System.EventHandler(this.btnSaveSalary_Click);
            // 
            // tabRun
            // 
            this.tabRun.BackColor = System.Drawing.Color.White;
            this.tabRun.Location = new System.Drawing.Point(4, 29);
            this.tabRun.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabRun.Size = new System.Drawing.Size(944, 523);
            this.tabRun.Text = "Monthly payroll";
            this.tabRun.UseVisualStyleBackColor = false;
            this.tabRun.Name = "tabRun";
            this.tabRun.TabIndex = 13;
            this.tabRun.Controls.Add(this.lblMonth);
            this.tabRun.Controls.Add(this.cboMonth);
            this.tabRun.Controls.Add(this.lblYear);
            this.tabRun.Controls.Add(this.numYear);
            this.tabRun.Controls.Add(this.btnCalculate);
            this.tabRun.Controls.Add(this.btnApprove);
            this.tabRun.Controls.Add(this.lblRunStatus);
            this.tabRun.Controls.Add(this.dgvPayroll);
            this.tabRun.Controls.Add(this.lblTotalNet);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMonth.Location = new System.Drawing.Point(16, 12);
            this.lblMonth.Text = "Month";
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.TabIndex = 14;
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(16, 36);
            this.cboMonth.Size = new System.Drawing.Size(160, 28);
            this.cboMonth.Items.AddRange(new object[] {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"});
            this.cboMonth.SelectedIndex = 0;
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.TabIndex = 15;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblYear.Location = new System.Drawing.Point(196, 12);
            this.lblYear.Text = "Year";
            this.lblYear.Name = "lblYear";
            this.lblYear.TabIndex = 16;
            // 
            // numYear
            // 
            this.numYear.DecimalPlaces = 0;
            this.numYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numYear.Location = new System.Drawing.Point(196, 36);
            this.numYear.Size = new System.Drawing.Size(100, 27);
            this.numYear.Maximum = new decimal(new int[] {2100, 0, 0, 0});
            this.numYear.Minimum = new decimal(new int[] {2000, 0, 0, 0});
            this.numYear.Value = new decimal(new int[] {2026, 0, 0, 0});
            this.numYear.Name = "numYear";
            this.numYear.TabIndex = 17;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(316, 32);
            this.btnCalculate.Size = new System.Drawing.Size(160, 36);
            this.btnCalculate.Text = "Calculate payroll";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(486, 32);
            this.btnApprove.Size = new System.Drawing.Size(210, 36);
            this.btnApprove.Text = "Approve and lock month";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.TabIndex = 19;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // lblRunStatus
            // 
            this.lblRunStatus.AutoSize = true;
            this.lblRunStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunStatus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblRunStatus.Location = new System.Drawing.Point(716, 40);
            this.lblRunStatus.Text = "Status: Draft";
            this.lblRunStatus.Name = "lblRunStatus";
            this.lblRunStatus.TabIndex = 20;
            // 
            // dgvPayroll
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
            this.dgvPayroll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayroll.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPayroll.AllowUserToAddRows = false;
            this.dgvPayroll.AllowUserToDeleteRows = false;
            this.dgvPayroll.AllowUserToResizeRows = false;
            this.dgvPayroll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayroll.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayroll.ColumnHeadersHeight = 36;
            this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayroll.EnableHeadersVisualStyles = false;
            this.dgvPayroll.GridColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.dgvPayroll.Location = new System.Drawing.Point(16, 84);
            this.dgvPayroll.MultiSelect = false;
            this.dgvPayroll.ReadOnly = true;
            this.dgvPayroll.RowHeadersVisible = false;
            this.dgvPayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayroll.Size = new System.Drawing.Size(912, 400);
            this.dgvPayroll.RowTemplate.Height = 30;
            this.dgvPayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colPayrollEmployeeId,
                this.colPayrollName,
                this.colPayrollBasic,
                this.colPayrollAllowances,
                this.colPayrollDeductions,
                this.colPayrollUnpaidLeaveAndAbsences,
                this.colPayrollGrossPay,
                this.colPayrollNetPay});
            this.dgvPayroll.Name = "dgvPayroll";
            this.dgvPayroll.TabIndex = 21;
            // 
            // colPayrollEmployeeId
            // 
            this.colPayrollEmployeeId.DataPropertyName = "EmployeeCode";
            this.colPayrollEmployeeId.HeaderText = "Employee ID";
            this.colPayrollEmployeeId.Name = "colPayrollEmployeeId";
            this.colPayrollEmployeeId.ReadOnly = true;
            // 
            // colPayrollName
            // 
            this.colPayrollName.DataPropertyName = "FullName";
            this.colPayrollName.HeaderText = "Name";
            this.colPayrollName.Name = "colPayrollName";
            this.colPayrollName.ReadOnly = true;
            // 
            // colPayrollBasic
            // 
            this.colPayrollBasic.DataPropertyName = "Basic";
            this.colPayrollBasic.HeaderText = "Basic";
            this.colPayrollBasic.Name = "colPayrollBasic";
            this.colPayrollBasic.ReadOnly = true;
            // 
            // colPayrollAllowances
            // 
            this.colPayrollAllowances.DataPropertyName = "Allowances";
            this.colPayrollAllowances.HeaderText = "Allowances";
            this.colPayrollAllowances.Name = "colPayrollAllowances";
            this.colPayrollAllowances.ReadOnly = true;
            // 
            // colPayrollDeductions
            // 
            this.colPayrollDeductions.DataPropertyName = "Deductions";
            this.colPayrollDeductions.HeaderText = "Deductions";
            this.colPayrollDeductions.Name = "colPayrollDeductions";
            this.colPayrollDeductions.ReadOnly = true;
            // 
            // colPayrollUnpaidLeaveAndAbsences
            // 
            this.colPayrollUnpaidLeaveAndAbsences.DataPropertyName = "UnpaidDeduction";
            this.colPayrollUnpaidLeaveAndAbsences.HeaderText = "Unpaid leave and absences";
            this.colPayrollUnpaidLeaveAndAbsences.Name = "colPayrollUnpaidLeaveAndAbsences";
            this.colPayrollUnpaidLeaveAndAbsences.ReadOnly = true;
            // 
            // colPayrollGrossPay
            // 
            this.colPayrollGrossPay.DataPropertyName = "Gross";
            this.colPayrollGrossPay.HeaderText = "Gross pay";
            this.colPayrollGrossPay.Name = "colPayrollGrossPay";
            this.colPayrollGrossPay.ReadOnly = true;
            // 
            // colPayrollNetPay
            // 
            this.colPayrollNetPay.DataPropertyName = "Net";
            this.colPayrollNetPay.HeaderText = "Net pay";
            this.colPayrollNetPay.Name = "colPayrollNetPay";
            this.colPayrollNetPay.ReadOnly = true;
            // 
            // lblTotalNet
            // 
            this.lblTotalNet.AutoSize = true;
            this.lblTotalNet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNet.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.lblTotalNet.Location = new System.Drawing.Point(16, 494);
            this.lblTotalNet.Text = "Total net pay: 0.00";
            this.lblTotalNet.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalNet.Name = "lblTotalNet";
            this.lblTotalNet.TabIndex = 22;
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.tabPayroll);
            this.Name = "PayrollForm";
            this.Text = "Payroll";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBasic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAllowances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeductions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
            this.tabPayroll.ResumeLayout(false);
            this.tabSalary.ResumeLayout(false);
            this.tabSalary.PerformLayout();
            this.tabRun.ResumeLayout(false);
            this.tabRun.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabPayroll;
        private System.Windows.Forms.TabPage tabSalary;
        private System.Windows.Forms.DataGridView dgvSalaries;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalariesEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalariesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalariesBasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalariesAllowances;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalariesDeductions;
        private System.Windows.Forms.Label lblSalaryEmployee;
        private System.Windows.Forms.TextBox txtSalaryEmployee;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.NumericUpDown numBasic;
        private System.Windows.Forms.Label lblAllowances;
        private System.Windows.Forms.NumericUpDown numAllowances;
        private System.Windows.Forms.Label lblDeductions;
        private System.Windows.Forms.NumericUpDown numDeductions;
        private System.Windows.Forms.Button btnSaveSalary;
        private System.Windows.Forms.TabPage tabRun;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label lblRunStatus;
        private System.Windows.Forms.DataGridView dgvPayroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollBasic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollAllowances;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollDeductions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollUnpaidLeaveAndAbsences;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollGrossPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollNetPay;
        private System.Windows.Forms.Label lblTotalNet;
    }
}
