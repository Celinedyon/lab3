using System;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.View
{
    public partial class AttendanceCorrectionForm : Form
    {
        private readonly AttendanceController _controller = new AttendanceController();
        private readonly int _attendanceId;

        public AttendanceCorrectionForm(
            int attendanceId, string employeeName, DateTime workDate,
            DateTime? clockIn, DateTime? clockOut, string status)
        {
            InitializeComponent();
            ViewTheme.Apply(this);
            _attendanceId = attendanceId;
            txtEmployee.Text = employeeName;
            dtpDate.Value = workDate.Date;
            dtpDate.Enabled = false;

            dtpClockIn.ShowCheckBox = true;
            dtpClockOut.ShowCheckBox = true;
            dtpClockIn.Checked = clockIn.HasValue;
            dtpClockOut.Checked = clockOut.HasValue;
            dtpClockIn.Value = clockIn ?? workDate.Date.AddHours(9);
            dtpClockOut.Value = clockOut ?? workDate.Date.AddHours(17);

            int statusIndex = cboStatus.Items.IndexOf(status);
            if (statusIndex >= 0)
                cboStatus.SelectedIndex = statusIndex;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime? clockIn = dtpClockIn.Checked
                ? (DateTime?)dtpDate.Value.Date.Add(dtpClockIn.Value.TimeOfDay)
                : null;
            DateTime? clockOut = dtpClockOut.Checked
                ? (DateTime?)dtpDate.Value.Date.Add(dtpClockOut.Value.TimeOfDay)
                : null;

            string error = _controller.Correct(
                _attendanceId, clockIn, clockOut,
                Convert.ToString(cboStatus.SelectedItem), txtReason.Text,
                Session.CurrentUser.UserId, Session.CurrentUser.EmployeeId.GetValueOrDefault(-1));
            if (error != null)
            {
                MessageBox.Show(this, error, "Attendance correction",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
