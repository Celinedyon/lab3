using System;
using System.Data;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.View
{
    public partial class LeaveTypesForm : Form
    {
        private readonly LeaveTypeController _controller = new LeaveTypeController();
        private int? _leaveTypeId;
        private bool _isActive = true;

        public LeaveTypesForm()
        {
            InitializeComponent();
            dgvLeaveTypes.AutoGenerateColumns = false;
            colLeaveTypesDaysAllowed.DefaultCellStyle.Format = "0.##";
            try
            {
                RefreshLeaveTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Unable to load leave types: " + ex.Message,
                    "Leave types", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLeaveTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !(dgvLeaveTypes.Rows[e.RowIndex].DataBoundItem is DataRowView row))
                return;
            _leaveTypeId = Convert.ToInt32(row["ID"]);
            txtName.Text = Convert.ToString(row["Name"]);
            numDays.Value = Convert.ToDecimal(row["DaysAllowed"]);
            chkPaid.Checked = Convert.ToBoolean(row["IsPaid"]);
            _isActive = Convert.ToBoolean(row["is_active"]);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string error = _controller.Create(BuildLeaveType());
            if (error != null)
            {
                ShowError(error);
                return;
            }
            RefreshLeaveTypes();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!_leaveTypeId.HasValue)
            {
                ShowError("Select a leave type to update.");
                return;
            }
            var leaveType = BuildLeaveType();
            leaveType.LeaveTypeId = _leaveTypeId.Value;
            leaveType.IsActive = _isActive;
            string error = _controller.Update(leaveType);
            if (error != null)
            {
                ShowError(error);
                return;
            }
            RefreshLeaveTypes();
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private LeaveType BuildLeaveType()
        {
            return new LeaveType
            {
                Name = txtName.Text.Trim(),
                AllowedDays = numDays.Value,
                IsPaid = chkPaid.Checked,
                IsActive = true
            };
        }

        private void RefreshLeaveTypes()
        {
            dgvLeaveTypes.DataSource = _controller.GetAll();
        }

        private void ClearFields()
        {
            _leaveTypeId = null;
            _isActive = true;
            txtName.Clear();
            numDays.Value = 0;
            chkPaid.Checked = true;
            dgvLeaveTypes.ClearSelection();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(this, message, "Leave types", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
