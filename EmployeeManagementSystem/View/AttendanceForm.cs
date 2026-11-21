using System;
using System.Data;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.View
{
    public partial class AttendanceForm : Form
    {
        private readonly AttendanceController _controller = new AttendanceController();
        private readonly bool _isManager;
        private readonly int? _employeeId;

        public AttendanceForm()
        {
            InitializeComponent();
            dgvAttendance.AutoGenerateColumns = false;
            _isManager = Session.CurrentUser.Role == "Manager";
            _employeeId = Session.CurrentUser.EmployeeId;

            lblTodayDate.Text = DateTime.Today.ToString("dddd, MMMM d, yyyy");
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today;
            btnClockIn.Visible = !_isManager;
            btnClockOut.Visible = !_isManager;
            btnCorrect.Visible = _isManager;
            lblEmployee.Visible = _isManager;
            cboEmployee.Visible = _isManager;
            try
            {
                if (_isManager)
                {
                    var employees = _controller.GetEmployees(_employeeId.GetValueOrDefault(-1));
                    var allEmployees = employees.NewRow();
                    allEmployees["employee_id"] = DBNull.Value;
                    allEmployees["name"] = "All employees";
                    employees.Rows.InsertAt(allEmployees, 0);
                    cboEmployee.DisplayMember = "name";
                    cboEmployee.ValueMember = "employee_id";
                    cboEmployee.DataSource = employees;
                }

                if (!_employeeId.HasValue)
                {
                    btnClockIn.Enabled = false;
                    btnClockOut.Enabled = false;
                    lblClockStatus.Text = "Your account is not linked to an employee record.";
                }

                RefreshAttendance();
                RefreshToday();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Unable to load attendance: " + ex.Message,
                    "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClockIn_Click(object sender, EventArgs e)
        {
            RunAttendanceAction(_controller.ClockIn(_employeeId.GetValueOrDefault()));
        }

        private void btnClockOut_Click(object sender, EventArgs e)
        {
            RunAttendanceAction(_controller.ClockOut(_employeeId.GetValueOrDefault()));
        }

        private void RunAttendanceAction(string error)
        {
            if (error != null)
            {
                MessageBox.Show(this, error, "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RefreshToday();
            RefreshAttendance();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show(this, "The start date must be on or before the end date.",
                    "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RefreshAttendance();
        }

        private void RefreshAttendance()
        {
            int? employeeId = _isManager ? (int?)null : _employeeId.GetValueOrDefault(-1);
            if (_isManager)
            {
                employeeId = cboEmployee.SelectedValue == null || cboEmployee.SelectedValue == DBNull.Value
                    ? (int?)null
                    : Convert.ToInt32(cboEmployee.SelectedValue);
            }

            int? managerEmployeeId = _isManager ? _employeeId.GetValueOrDefault(-1) : (int?)null;
            var records = _controller.GetAll(employeeId, dtpFrom.Value.Date, dtpTo.Value.Date, managerEmployeeId);
            dgvAttendance.DataSource = records;
            colAttendanceDate.DefaultCellStyle.Format = "d";
            colAttendanceClockIn.DefaultCellStyle.Format = "t";
            colAttendanceClockOut.DefaultCellStyle.Format = "t";
            colAttendanceHoursWorked.DefaultCellStyle.Format = "0.00";
        }

        private void RefreshToday()
        {
            if (!_employeeId.HasValue)
                return;

            var today = _controller.GetToday(_employeeId.Value);
            if (today == null)
            {
                lblClockStatus.Text = "Not clocked in yet";
                lblHoursToday.Text = "Hours worked today: 0.00";
                return;
            }

            if (today["ClockIn"] != DBNull.Value)
                lblClockStatus.Text = "Clocked in at " + Convert.ToDateTime(today["ClockIn"]).ToString("h:mm tt");
            if (today["ClockOut"] != DBNull.Value)
                lblClockStatus.Text += "  |  Clocked out at " + Convert.ToDateTime(today["ClockOut"]).ToString("h:mm tt");

            decimal hours = today["HoursWorked"] == DBNull.Value
                ? (today["ClockIn"] == DBNull.Value ? 0 : (decimal)(DateTime.Now - Convert.ToDateTime(today["ClockIn"])).TotalHours)
                : Convert.ToDecimal(today["HoursWorked"]);
            lblHoursToday.Text = "Hours worked today: " + Math.Max(0, hours).ToString("0.00");
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.CurrentRow == null || !(dgvAttendance.CurrentRow.DataBoundItem is DataRowView row))
            {
                MessageBox.Show(this, "Select an attendance record to correct.",
                    "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime workDate = Convert.ToDateTime(row["WorkDate"]);
            DateTime? clockIn = row["ClockIn"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ClockIn"]);
            DateTime? clockOut = row["ClockOut"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ClockOut"]);
            using (var form = new AttendanceCorrectionForm(
                Convert.ToInt32(row["attendance_id"]), Convert.ToString(row["Employee"]),
                workDate, clockIn, clockOut, Convert.ToString(row["Status"])))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    RefreshAttendance();
            }
        }
    }
}
