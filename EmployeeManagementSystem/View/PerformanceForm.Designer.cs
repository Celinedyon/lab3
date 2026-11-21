namespace EmployeeManagementSystem.View
{
    partial class PerformanceForm
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
            this.tabPerformance = new System.Windows.Forms.TabControl();
            this.tabGoals = new System.Windows.Forms.TabPage();
            this.dgvGoals = new System.Windows.Forms.DataGridView();
            this.colGoalsEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoalsGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoalsDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoalsSetBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGoalEmployee = new System.Windows.Forms.Label();
            this.cboGoalEmployee = new System.Windows.Forms.ComboBox();
            this.lblGoal = new System.Windows.Forms.Label();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.lblDue = new System.Windows.Forms.Label();
            this.dtpDue = new System.Windows.Forms.DateTimePicker();
            this.btnAddGoal = new System.Windows.Forms.Button();
            this.tabReviews = new System.Windows.Forms.TabPage();
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.colReviewsEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReviewsReviewer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReviewsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReviewsRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReviewsComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReviewEmployee = new System.Windows.Forms.Label();
            this.cboReviewEmployee = new System.Windows.Forms.ComboBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnAddReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.tabPerformance.SuspendLayout();
            this.tabGoals.SuspendLayout();
            this.tabReviews.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPerformance
            // 
            this.tabPerformance.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.tabPerformance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPerformance.Location = new System.Drawing.Point(24, 20);
            this.tabPerformance.SelectedIndex = 0;
            this.tabPerformance.Size = new System.Drawing.Size(952, 556);
            this.tabPerformance.Name = "tabPerformance";
            this.tabPerformance.TabIndex = 1;
            this.tabPerformance.Controls.Add(this.tabGoals);
            this.tabPerformance.Controls.Add(this.tabReviews);
            // 
            // tabGoals
            // 
            this.tabGoals.BackColor = System.Drawing.Color.White;
            this.tabGoals.Location = new System.Drawing.Point(4, 29);
            this.tabGoals.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabGoals.Size = new System.Drawing.Size(944, 523);
            this.tabGoals.Text = "Goals";
            this.tabGoals.UseVisualStyleBackColor = false;
            this.tabGoals.Name = "tabGoals";
            this.tabGoals.TabIndex = 2;
            this.tabGoals.Controls.Add(this.dgvGoals);
            this.tabGoals.Controls.Add(this.lblGoalEmployee);
            this.tabGoals.Controls.Add(this.cboGoalEmployee);
            this.tabGoals.Controls.Add(this.lblGoal);
            this.tabGoals.Controls.Add(this.txtGoal);
            this.tabGoals.Controls.Add(this.lblDue);
            this.tabGoals.Controls.Add(this.dtpDue);
            this.tabGoals.Controls.Add(this.btnAddGoal);
            // 
            // dgvGoals
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
            this.dgvGoals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGoals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGoals.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGoals.AllowUserToAddRows = false;
            this.dgvGoals.AllowUserToDeleteRows = false;
            this.dgvGoals.AllowUserToResizeRows = false;
            this.dgvGoals.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvGoals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGoals.BackgroundColor = System.Drawing.Color.White;
            this.dgvGoals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGoals.ColumnHeadersHeight = 36;
            this.dgvGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGoals.EnableHeadersVisualStyles = false;
            this.dgvGoals.GridColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.dgvGoals.Location = new System.Drawing.Point(16, 16);
            this.dgvGoals.MultiSelect = false;
            this.dgvGoals.ReadOnly = true;
            this.dgvGoals.RowHeadersVisible = false;
            this.dgvGoals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoals.Size = new System.Drawing.Size(600, 470);
            this.dgvGoals.RowTemplate.Height = 30;
            this.dgvGoals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colGoalsEmployee,
                this.colGoalsGoal,
                this.colGoalsDueDate,
                this.colGoalsSetBy});
            this.dgvGoals.Name = "dgvGoals";
            this.dgvGoals.TabIndex = 3;
            // 
            // colGoalsEmployee
            // 
            this.colGoalsEmployee.DataPropertyName = "Employee";
            this.colGoalsEmployee.HeaderText = "Employee";
            this.colGoalsEmployee.Name = "colGoalsEmployee";
            this.colGoalsEmployee.ReadOnly = true;
            // 
            // colGoalsGoal
            // 
            this.colGoalsGoal.DataPropertyName = "Description";
            this.colGoalsGoal.HeaderText = "Goal";
            this.colGoalsGoal.Name = "colGoalsGoal";
            this.colGoalsGoal.ReadOnly = true;
            // 
            // colGoalsDueDate
            // 
            this.colGoalsDueDate.DataPropertyName = "DueDate";
            this.colGoalsDueDate.HeaderText = "Due date";
            this.colGoalsDueDate.Name = "colGoalsDueDate";
            this.colGoalsDueDate.ReadOnly = true;
            // 
            // colGoalsSetBy
            // 
            this.colGoalsSetBy.DataPropertyName = "SetBy";
            this.colGoalsSetBy.HeaderText = "Set by";
            this.colGoalsSetBy.Name = "colGoalsSetBy";
            this.colGoalsSetBy.ReadOnly = true;
            // 
            // lblGoalEmployee
            // 
            this.lblGoalEmployee.AutoSize = true;
            this.lblGoalEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalEmployee.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblGoalEmployee.Location = new System.Drawing.Point(640, 16);
            this.lblGoalEmployee.Text = "Employee";
            this.lblGoalEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblGoalEmployee.Name = "lblGoalEmployee";
            this.lblGoalEmployee.TabIndex = 4;
            // 
            // cboGoalEmployee
            // 
            this.cboGoalEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGoalEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGoalEmployee.FormattingEnabled = true;
            this.cboGoalEmployee.Location = new System.Drawing.Point(640, 38);
            this.cboGoalEmployee.Size = new System.Drawing.Size(280, 28);
            this.cboGoalEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.cboGoalEmployee.Name = "cboGoalEmployee";
            this.cboGoalEmployee.TabIndex = 5;
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblGoal.Location = new System.Drawing.Point(640, 82);
            this.lblGoal.Text = "Goal";
            this.lblGoal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.TabIndex = 6;
            // 
            // txtGoal
            // 
            this.txtGoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGoal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoal.Location = new System.Drawing.Point(640, 104);
            this.txtGoal.Size = new System.Drawing.Size(280, 90);
            this.txtGoal.Multiline = true;
            this.txtGoal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGoal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.TabIndex = 7;
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDue.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblDue.Location = new System.Drawing.Point(640, 208);
            this.lblDue.Text = "Due date";
            this.lblDue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblDue.Name = "lblDue";
            this.lblDue.TabIndex = 8;
            // 
            // dtpDue
            // 
            this.dtpDue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDue.Location = new System.Drawing.Point(640, 230);
            this.dtpDue.Size = new System.Drawing.Size(280, 27);
            this.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.TabIndex = 9;
            // 
            // btnAddGoal
            // 
            this.btnAddGoal.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnAddGoal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGoal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGoal.ForeColor = System.Drawing.Color.White;
            this.btnAddGoal.Location = new System.Drawing.Point(640, 282);
            this.btnAddGoal.Size = new System.Drawing.Size(120, 36);
            this.btnAddGoal.Text = "Add goal";
            this.btnAddGoal.UseVisualStyleBackColor = false;
            this.btnAddGoal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnAddGoal.FlatAppearance.BorderSize = 0;
            this.btnAddGoal.Name = "btnAddGoal";
            this.btnAddGoal.TabIndex = 10;
            this.btnAddGoal.Click += new System.EventHandler(this.btnAddGoal_Click);
            // 
            // tabReviews
            // 
            this.tabReviews.BackColor = System.Drawing.Color.White;
            this.tabReviews.Location = new System.Drawing.Point(4, 29);
            this.tabReviews.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabReviews.Size = new System.Drawing.Size(944, 523);
            this.tabReviews.Text = "Reviews";
            this.tabReviews.UseVisualStyleBackColor = false;
            this.tabReviews.Name = "tabReviews";
            this.tabReviews.TabIndex = 11;
            this.tabReviews.Controls.Add(this.dgvReviews);
            this.tabReviews.Controls.Add(this.lblReviewEmployee);
            this.tabReviews.Controls.Add(this.cboReviewEmployee);
            this.tabReviews.Controls.Add(this.lblRating);
            this.tabReviews.Controls.Add(this.numRating);
            this.tabReviews.Controls.Add(this.lblComments);
            this.tabReviews.Controls.Add(this.txtComments);
            this.tabReviews.Controls.Add(this.btnAddReview);
            // 
            // dgvReviews
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
            this.dgvReviews.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReviews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReviews.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReviews.AllowUserToAddRows = false;
            this.dgvReviews.AllowUserToDeleteRows = false;
            this.dgvReviews.AllowUserToResizeRows = false;
            this.dgvReviews.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReviews.BackgroundColor = System.Drawing.Color.White;
            this.dgvReviews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReviews.ColumnHeadersHeight = 36;
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReviews.EnableHeadersVisualStyles = false;
            this.dgvReviews.GridColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.dgvReviews.Location = new System.Drawing.Point(16, 16);
            this.dgvReviews.MultiSelect = false;
            this.dgvReviews.ReadOnly = true;
            this.dgvReviews.RowHeadersVisible = false;
            this.dgvReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReviews.Size = new System.Drawing.Size(600, 470);
            this.dgvReviews.RowTemplate.Height = 30;
            this.dgvReviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colReviewsEmployee,
                this.colReviewsReviewer,
                this.colReviewsDate,
                this.colReviewsRating,
                this.colReviewsComments});
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.TabIndex = 12;
            // 
            // colReviewsEmployee
            // 
            this.colReviewsEmployee.DataPropertyName = "Employee";
            this.colReviewsEmployee.HeaderText = "Employee";
            this.colReviewsEmployee.Name = "colReviewsEmployee";
            this.colReviewsEmployee.ReadOnly = true;
            // 
            // colReviewsReviewer
            // 
            this.colReviewsReviewer.DataPropertyName = "Reviewer";
            this.colReviewsReviewer.HeaderText = "Reviewer";
            this.colReviewsReviewer.Name = "colReviewsReviewer";
            this.colReviewsReviewer.ReadOnly = true;
            // 
            // colReviewsDate
            // 
            this.colReviewsDate.DataPropertyName = "ReviewDate";
            this.colReviewsDate.HeaderText = "Date";
            this.colReviewsDate.Name = "colReviewsDate";
            this.colReviewsDate.ReadOnly = true;
            // 
            // colReviewsRating
            // 
            this.colReviewsRating.DataPropertyName = "Rating";
            this.colReviewsRating.HeaderText = "Rating";
            this.colReviewsRating.Name = "colReviewsRating";
            this.colReviewsRating.ReadOnly = true;
            // 
            // colReviewsComments
            // 
            this.colReviewsComments.DataPropertyName = "Comments";
            this.colReviewsComments.HeaderText = "Comments";
            this.colReviewsComments.Name = "colReviewsComments";
            this.colReviewsComments.ReadOnly = true;
            // 
            // lblReviewEmployee
            // 
            this.lblReviewEmployee.AutoSize = true;
            this.lblReviewEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewEmployee.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblReviewEmployee.Location = new System.Drawing.Point(640, 16);
            this.lblReviewEmployee.Text = "Employee";
            this.lblReviewEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblReviewEmployee.Name = "lblReviewEmployee";
            this.lblReviewEmployee.TabIndex = 13;
            // 
            // cboReviewEmployee
            // 
            this.cboReviewEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReviewEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReviewEmployee.FormattingEnabled = true;
            this.cboReviewEmployee.Location = new System.Drawing.Point(640, 38);
            this.cboReviewEmployee.Size = new System.Drawing.Size(280, 28);
            this.cboReviewEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.cboReviewEmployee.Name = "cboReviewEmployee";
            this.cboReviewEmployee.TabIndex = 14;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblRating.Location = new System.Drawing.Point(640, 82);
            this.lblRating.Text = "Rating (1 to 5)";
            this.lblRating.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblRating.Name = "lblRating";
            this.lblRating.TabIndex = 15;
            // 
            // numRating
            // 
            this.numRating.DecimalPlaces = 0;
            this.numRating.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRating.Location = new System.Drawing.Point(640, 104);
            this.numRating.Size = new System.Drawing.Size(120, 27);
            this.numRating.Maximum = new decimal(new int[] {5, 0, 0, 0});
            this.numRating.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numRating.Value = new decimal(new int[] {3, 0, 0, 0});
            this.numRating.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.numRating.Name = "numRating";
            this.numRating.TabIndex = 16;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblComments.Location = new System.Drawing.Point(640, 148);
            this.lblComments.Text = "Comments";
            this.lblComments.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblComments.Name = "lblComments";
            this.lblComments.TabIndex = 17;
            // 
            // txtComments
            // 
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(640, 170);
            this.txtComments.Size = new System.Drawing.Size(280, 120);
            this.txtComments.Multiline = true;
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.txtComments.Name = "txtComments";
            this.txtComments.TabIndex = 18;
            // 
            // btnAddReview
            // 
            this.btnAddReview.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnAddReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReview.ForeColor = System.Drawing.Color.White;
            this.btnAddReview.Location = new System.Drawing.Point(640, 308);
            this.btnAddReview.Size = new System.Drawing.Size(140, 36);
            this.btnAddReview.Text = "Save review";
            this.btnAddReview.UseVisualStyleBackColor = false;
            this.btnAddReview.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnAddReview.FlatAppearance.BorderSize = 0;
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.TabIndex = 19;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // PerformanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.tabPerformance);
            this.Name = "PerformanceForm";
            this.Text = "Performance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.tabPerformance.ResumeLayout(false);
            this.tabGoals.ResumeLayout(false);
            this.tabGoals.PerformLayout();
            this.tabReviews.ResumeLayout(false);
            this.tabReviews.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabPerformance;
        private System.Windows.Forms.TabPage tabGoals;
        private System.Windows.Forms.DataGridView dgvGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoalsEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoalsGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoalsDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoalsSetBy;
        private System.Windows.Forms.Label lblGoalEmployee;
        private System.Windows.Forms.ComboBox cboGoalEmployee;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.DateTimePicker dtpDue;
        private System.Windows.Forms.Button btnAddGoal;
        private System.Windows.Forms.TabPage tabReviews;
        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewsEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewsReviewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewsDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewsRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewsComments;
        private System.Windows.Forms.Label lblReviewEmployee;
        private System.Windows.Forms.ComboBox cboReviewEmployee;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnAddReview;
    }
}
