using System;
using System.Data;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.View
{
    public partial class LeaveRequestsForm : Form
    {
        private readonly LeaveController _controller = new LeaveController();
        private readonly int _managerEmployeeId;

        public LeaveRequestsForm()
        {
            InitializeComponent();
            dgvRequests.AutoGenerateColumns = false;
            _managerEmployeeId = Session.CurrentUser.EmployeeId.GetValueOrDefault(-1);
            colRequestsFrom.DefaultCellStyle.Format = "d";
            colRequestsTo.DefaultCellStyle.Format = "d";
            colRequestsDays.DefaultCellStyle.Format = "0.##";
            RefreshRequests();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshRequests();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            ReviewSelectedRequest("Approved");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            ReviewSelectedRequest("Rejected");
        }

        private void ReviewSelectedRequest(string decision)
        {
            if (dgvRequests.CurrentRow == null ||
                !(dgvRequests.CurrentRow.DataBoundItem is DataRowView row))
            {
                ShowError("Select a leave request first.");
                return;
            }

            if (Convert.ToString(row["Status"]) != "Pending")
            {
                ShowError("Only pending requests can be reviewed.");
                return;
            }

            string employee = Convert.ToString(row["Employee"]);
            string prompt = decision == "Approved"
                ? "Approve the leave request from " + employee + "?"
                : "Reject the leave request from " + employee + "?";
            if (MessageBox.Show(this, prompt, "Leave request",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            string error = _controller.ReviewRequest(
                Convert.ToInt32(row["ID"]),
                _managerEmployeeId,
                Session.CurrentUser.UserId,
                decision);
            if (error != null)
            {
                ShowError(error);
                return;
            }
            RefreshRequests();
        }

        private void RefreshRequests()
        {
            try
            {
                string status = Convert.ToString(cboStatus.SelectedItem);
                dgvRequests.DataSource = _controller.GetManagerRequests(_managerEmployeeId, status);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Unable to load leave requests: " + ex.Message,
                    "Leave requests", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(this, message, "Leave requests", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
