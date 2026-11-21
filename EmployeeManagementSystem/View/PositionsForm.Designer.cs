namespace EmployeeManagementSystem.View
{
    partial class PositionsForm
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
            this.dgvPositions = new System.Windows.Forms.DataGridView();
            this.colPositionsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPositionsPositionTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPositions
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
            this.dgvPositions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPositions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPositions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPositions.AllowUserToAddRows = false;
            this.dgvPositions.AllowUserToDeleteRows = false;
            this.dgvPositions.AllowUserToResizeRows = false;
            this.dgvPositions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.dgvPositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPositions.BackgroundColor = System.Drawing.Color.White;
            this.dgvPositions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPositions.ColumnHeadersHeight = 36;
            this.dgvPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPositions.EnableHeadersVisualStyles = false;
            this.dgvPositions.GridColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.dgvPositions.Location = new System.Drawing.Point(24, 20);
            this.dgvPositions.MultiSelect = false;
            this.dgvPositions.ReadOnly = true;
            this.dgvPositions.RowHeadersVisible = false;
            this.dgvPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPositions.Size = new System.Drawing.Size(612, 556);
            this.dgvPositions.RowTemplate.Height = 30;
            this.dgvPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colPositionsId,
                this.colPositionsPositionTitle});
            this.dgvPositions.Name = "dgvPositions";
            this.dgvPositions.TabIndex = 1;
            this.dgvPositions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPositions_CellClick);
            // 
            // colPositionsId
            // 
            this.colPositionsId.DataPropertyName = "ID";
            this.colPositionsId.HeaderText = "ID";
            this.colPositionsId.Name = "colPositionsId";
            this.colPositionsId.ReadOnly = true;
            // 
            // colPositionsPositionTitle
            // 
            this.colPositionsPositionTitle.DataPropertyName = "Title";
            this.colPositionsPositionTitle.HeaderText = "Position title";
            this.colPositionsPositionTitle.Name = "colPositionsPositionTitle";
            this.colPositionsPositionTitle.ReadOnly = true;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Location = new System.Drawing.Point(656, 20);
            this.pnlDetails.Size = new System.Drawing.Size(320, 230);
            this.pnlDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.TabIndex = 2;
            this.pnlDetails.Controls.Add(this.lblCardTitle);
            this.pnlDetails.Controls.Add(this.lblTitle);
            this.pnlDetails.Controls.Add(this.txtTitle);
            this.pnlDetails.Controls.Add(this.lblDepartment);
            this.pnlDetails.Controls.Add(this.cboDepartment);
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
            this.lblCardTitle.Text = "Position details";
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTitle.Location = new System.Drawing.Point(20, 56);
            this.lblTitle.Text = "Position title";
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(20, 78);
            this.txtTitle.Size = new System.Drawing.Size(280, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.TabIndex = 5;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblDepartment.Location = new System.Drawing.Point(20, 112);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.TabIndex = 6;
            this.lblDepartment.Text = "Department";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(20, 134);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(280, 25);
            this.cboDepartment.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 178);
            this.btnAdd.Size = new System.Drawing.Size(88, 36);
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnUpdate.Location = new System.Drawing.Point(116, 178);
            this.btnUpdate.Size = new System.Drawing.Size(88, 36);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnClear.Location = new System.Drawing.Point(212, 178);
            this.btnClear.Size = new System.Drawing.Size(88, 36);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.TabIndex = 8;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // PositionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.dgvPositions);
            this.Controls.Add(this.pnlDetails);
            this.Name = "PositionsForm";
            this.Text = "Positions";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPositions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPositionsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPositionsPositionTitle;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
    }
}
