namespace EmployeeManagementSystem.View
{
    partial class TeamForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvTeam = new System.Windows.Forms.DataGridView();
            this.colTeamEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).BeginInit();
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
            this.pnlFilter.Controls.Add(this.btnSearch);
            this.pnlFilter.Controls.Add(this.btnReset);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSearch.Location = new System.Drawing.Point(16, 6);
            this.lblSearch.Text = "Search team members";
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(16, 30);
            this.txtSearch.Size = new System.Drawing.Size(320, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(356, 26);
            this.btnSearch.Size = new System.Drawing.Size(100, 36);
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnReset.Location = new System.Drawing.Point(466, 26);
            this.btnReset.Size = new System.Drawing.Size(100, 36);
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnReset.Name = "btnReset";
            this.btnReset.TabIndex = 5;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvTeam
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
            this.dgvTeam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTeam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeam.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeam.AllowUserToAddRows = false;
            this.dgvTeam.AllowUserToDeleteRows = false;
            this.dgvTeam.AllowUserToResizeRows = false;
            this.dgvTeam.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeam.BackgroundColor = System.Drawing.Color.White;
            this.dgvTeam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTeam.ColumnHeadersHeight = 36;
            this.dgvTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTeam.EnableHeadersVisualStyles = false;
            this.dgvTeam.GridColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.dgvTeam.Location = new System.Drawing.Point(24, 110);
            this.dgvTeam.MultiSelect = false;
            this.dgvTeam.ReadOnly = true;
            this.dgvTeam.RowHeadersVisible = false;
            this.dgvTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeam.Size = new System.Drawing.Size(952, 466);
            this.dgvTeam.RowTemplate.Height = 30;
            this.dgvTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTeamEmployeeId,
                this.colTeamFullName,
                this.colTeamEmail,
                this.colTeamPosition,
                this.colTeamPhone,
                this.colTeamStatus});
            this.dgvTeam.Name = "dgvTeam";
            this.dgvTeam.TabIndex = 6;
            // 
            // colTeamEmployeeId
            // 
            this.colTeamEmployeeId.DataPropertyName = "EmployeeCode";
            this.colTeamEmployeeId.HeaderText = "Employee ID";
            this.colTeamEmployeeId.Name = "colTeamEmployeeId";
            this.colTeamEmployeeId.ReadOnly = true;
            // 
            // colTeamFullName
            // 
            this.colTeamFullName.DataPropertyName = "FullName";
            this.colTeamFullName.HeaderText = "Full name";
            this.colTeamFullName.Name = "colTeamFullName";
            this.colTeamFullName.ReadOnly = true;
            // 
            // colTeamEmail
            // 
            this.colTeamEmail.DataPropertyName = "Email";
            this.colTeamEmail.HeaderText = "Email";
            this.colTeamEmail.Name = "colTeamEmail";
            this.colTeamEmail.ReadOnly = true;
            // 
            // colTeamPosition
            // 
            this.colTeamPosition.DataPropertyName = "Position";
            this.colTeamPosition.HeaderText = "Position";
            this.colTeamPosition.Name = "colTeamPosition";
            this.colTeamPosition.ReadOnly = true;
            // 
            // colTeamPhone
            // 
            this.colTeamPhone.DataPropertyName = "Phone";
            this.colTeamPhone.HeaderText = "Phone";
            this.colTeamPhone.Name = "colTeamPhone";
            this.colTeamPhone.ReadOnly = true;
            // 
            // colTeamStatus
            // 
            this.colTeamStatus.DataPropertyName = "Status";
            this.colTeamStatus.HeaderText = "Status";
            this.colTeamStatus.Name = "colTeamStatus";
            this.colTeamStatus.ReadOnly = true;
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.dgvTeam);
            this.Name = "TeamForm";
            this.Text = "Team";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeam)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamStatus;
    }
}
