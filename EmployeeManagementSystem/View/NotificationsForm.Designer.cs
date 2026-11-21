namespace EmployeeManagementSystem.View
{
    partial class NotificationsForm
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
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnMarkRead = new System.Windows.Forms.Button();
            this.btnMarkAll = new System.Windows.Forms.Button();
            this.dgvNotifications = new System.Windows.Forms.DataGridView();
            this.colNotificationsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotificationsMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotificationsStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).BeginInit();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Location = new System.Drawing.Point(24, 20);
            this.pnlToolbar.Size = new System.Drawing.Size(952, 64);
            this.pnlToolbar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.TabIndex = 1;
            this.pnlToolbar.Controls.Add(this.btnMarkRead);
            this.pnlToolbar.Controls.Add(this.btnMarkAll);
            // 
            // btnMarkRead
            // 
            this.btnMarkRead.BackColor = System.Drawing.Color.White;
            this.btnMarkRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkRead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkRead.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnMarkRead.Location = new System.Drawing.Point(16, 14);
            this.btnMarkRead.Size = new System.Drawing.Size(150, 36);
            this.btnMarkRead.Text = "Mark as read";
            this.btnMarkRead.UseVisualStyleBackColor = false;
            this.btnMarkRead.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnMarkRead.Name = "btnMarkRead";
            this.btnMarkRead.TabIndex = 2;
            this.btnMarkRead.Click += new System.EventHandler(this.btnMarkRead_Click);
            // 
            // btnMarkAll
            // 
            this.btnMarkAll.BackColor = System.Drawing.Color.White;
            this.btnMarkAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAll.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.btnMarkAll.Location = new System.Drawing.Point(176, 14);
            this.btnMarkAll.Size = new System.Drawing.Size(170, 36);
            this.btnMarkAll.Text = "Mark all as read";
            this.btnMarkAll.UseVisualStyleBackColor = false;
            this.btnMarkAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnMarkAll.Name = "btnMarkAll";
            this.btnMarkAll.TabIndex = 3;
            this.btnMarkAll.Click += new System.EventHandler(this.btnMarkAll_Click);
            // 
            // dgvNotifications
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
            this.dgvNotifications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNotifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotifications.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotifications.AllowUserToAddRows = false;
            this.dgvNotifications.AllowUserToDeleteRows = false;
            this.dgvNotifications.AllowUserToResizeRows = false;
            this.dgvNotifications.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvNotifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotifications.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotifications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotifications.ColumnHeadersHeight = 36;
            this.dgvNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNotifications.EnableHeadersVisualStyles = false;
            this.dgvNotifications.GridColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.dgvNotifications.Location = new System.Drawing.Point(24, 100);
            this.dgvNotifications.MultiSelect = false;
            this.dgvNotifications.ReadOnly = true;
            this.dgvNotifications.RowHeadersVisible = false;
            this.dgvNotifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotifications.Size = new System.Drawing.Size(952, 476);
            this.dgvNotifications.RowTemplate.Height = 30;
            this.dgvNotifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colNotificationsDate,
                this.colNotificationsMessage,
                this.colNotificationsStatus});
            this.dgvNotifications.Name = "dgvNotifications";
            this.dgvNotifications.TabIndex = 4;
            // 
            // colNotificationsDate
            // 
            this.colNotificationsDate.DataPropertyName = "CreatedAt";
            this.colNotificationsDate.HeaderText = "Date";
            this.colNotificationsDate.Name = "colNotificationsDate";
            this.colNotificationsDate.ReadOnly = true;
            // 
            // colNotificationsMessage
            // 
            this.colNotificationsMessage.DataPropertyName = "Message";
            this.colNotificationsMessage.HeaderText = "Message";
            this.colNotificationsMessage.Name = "colNotificationsMessage";
            this.colNotificationsMessage.ReadOnly = true;
            // 
            // colNotificationsStatus
            // 
            this.colNotificationsStatus.DataPropertyName = "Status";
            this.colNotificationsStatus.HeaderText = "Status";
            this.colNotificationsStatus.Name = "colNotificationsStatus";
            this.colNotificationsStatus.ReadOnly = true;
            // 
            // NotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.dgvNotifications);
            this.Name = "NotificationsForm";
            this.Text = "Notifications";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).EndInit();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnMarkRead;
        private System.Windows.Forms.Button btnMarkAll;
        private System.Windows.Forms.DataGridView dgvNotifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotificationsDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotificationsMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotificationsStatus;
    }
}
