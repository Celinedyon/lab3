using System;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.View
{
    public partial class LeaveForm : Form
    {
        private readonly LeaveController _controller = new LeaveController();
        private readonly int? _employeeId;

        public LeaveForm()
        {
            InitializeComponent();
            dgvBalance.AutoGenerateColumns = false;
            dgvRequests.AutoGenerateColumns = false;
            _employeeId = Session.CurrentUser.EmployeeId;
            dtpFrom.MinDate = DateTime.Today;
            dtpTo.MinDate = DateTime.Today;
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
            dtpFrom.ValueChanged += UpdateRequestedDays;
            dtpTo.ValueChanged += UpdateRequestedDays;

            try
            {
                cboType.DisplayMember = "name";
                cboType.ValueMember = "leave_type_id";
                cboType.DataSource = _controller.GetActiveTypes();
                colBalanceAllowed.DefaultCellStyle.Format = "0.##";
                colBalanceUsed.DefaultCellStyle.Format = "0.##";
                colBalanceRemaining.DefaultCellStyle.Format = "0.##";
                colRequestsFrom.DefaultCellStyle.Format = "d";
                colRequestsTo.DefaultCellStyle.Format = "d";
                colRequestsDays.DefaultCellStyle.Format = "0.##";

                if (!_employeeId.HasValue)
                {
                    btnSubmit.Enabled = false;
                    MessageBox.Show(this, "Your account is not linked to an employee record.",
                        "Leave", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                RefreshData();
                UpdateRequestedDays(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                btnSubmit.Enabled = false;
                MessageBox.Show(this, "Unable to load leave information: " + ex.Message,
                    "Leave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRequestedDays(object sender, EventArgs e)
        {
            int days = (dtpTo.Value.Date - dtpFrom.Value.Date).Days + 1;
            lblDays.Text = "Days requested: " + Math.Max(0, days);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!_employeeId.HasValue || cboType.SelectedValue == null)
            {
                ShowError("Select an active leave type.");
                return;
            }

            string error = _controller.SubmitRequest(
                _employeeId.Value,
                Convert.ToInt32(cboType.SelectedValue),
                dtpFrom.Value.Date,
                dtpTo.Value.Date,
                txtReason.Text);
            if (error != null)
            {
                ShowError(error);
                return;
            }

            MessageBox.Show(this, "Your leave request has been submitted for manager review.",
                "Leave", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtReason.Clear();
            RefreshData();
        }

        private void RefreshData()
        {
            dgvBalance.DataSource = _controller.GetEmployeeBalances(_employeeId.Value, DateTime.Today.Year);
            dgvRequests.DataSource = _controller.GetEmployeeRequests(_employeeId.Value);
        }

        private void ShowError(string message)
        {
            MessageBox.Show(this, message, "Leave", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
