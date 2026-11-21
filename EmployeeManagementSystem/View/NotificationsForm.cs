using System;
using System.Data;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.View
{
    public partial class NotificationsForm : Form
    {
        private readonly NotificationController _controller = new NotificationController();
        private readonly int _userId;

        public NotificationsForm()
        {
            InitializeComponent();
            dgvNotifications.AutoGenerateColumns = false;
            _userId = Session.CurrentUser.UserId;
            colNotificationsDate.DefaultCellStyle.Format = "g";
            RefreshNotifications();
        }

        private void btnMarkRead_Click(object sender, EventArgs e)
        {
            if (dgvNotifications.CurrentRow == null ||
                !(dgvNotifications.CurrentRow.DataBoundItem is DataRowView row))
            {
                ShowError("Select a notification first.");
                return;
            }

            string error = _controller.MarkRead(Convert.ToInt32(row["notification_id"]), _userId);
            if (error != null)
            {
                ShowError(error);
                return;
            }
            RefreshNotifications();
        }

        private void btnMarkAll_Click(object sender, EventArgs e)
        {
            string error = _controller.MarkAllRead(_userId);
            if (error != null)
            {
                ShowError(error);
                return;
            }
            RefreshNotifications();
        }

        private void RefreshNotifications()
        {
            try
            {
                dgvNotifications.DataSource = _controller.GetAll(_userId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Unable to load notifications: " + ex.Message,
                    "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(this, message, "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
