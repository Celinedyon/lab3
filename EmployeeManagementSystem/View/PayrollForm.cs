using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.View
{
    public partial class PayrollForm : Form
    {
        private readonly PayrollController _controller = new PayrollController();
        private int? _selectedEmployeeId;

        public PayrollForm()
        {
            InitializeComponent();
            dgvSalaries.AutoGenerateColumns = false;
            dgvPayroll.AutoGenerateColumns = false;
            cboMonth.Items.AddRange(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames
                .Take(12).Cast<object>().ToArray());
            cboMonth.SelectedIndex = DateTime.Today.Month - 1;
            numYear.Value = DateTime.Today.Year;
            dgvSalaries.SelectionChanged += dgvSalaries_SelectionChanged;
            cboMonth.SelectedIndexChanged += cboMonth_SelectedIndexChanged;
            numYear.ValueChanged += numYear_ValueChanged;
            LoadSalaries();
            LoadPayrollRun();
        }

        private void btnSaveSalary_Click(object sender, EventArgs e)
        {
            if (!_selectedEmployeeId.HasValue)
            {
                MessageBox.Show("Select an employee first.", "Payroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string error = _controller.SaveSalary(_selectedEmployeeId.Value, numBasic.Value,
                numAllowances.Value, numDeductions.Value);
            if (error != null)
            {
                MessageBox.Show(error, "Unable to save salary", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadSalaries();
            MessageBox.Show("Salary details saved.", "Payroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DataTable payroll;
            bool isLocked;
            string error = _controller.CalculateAndSave(SelectedYear(), SelectedMonth(), out payroll, out isLocked);
            if (error != null)
            {
                MessageBox.Show(error, "Unable to calculate payroll", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadPayrollRun();
                return;
            }
            dgvPayroll.DataSource = payroll;
            UpdateTotal();
            UpdateRunControls("Draft", false, payroll.Rows.Count > 0);
            MessageBox.Show("Payroll calculated and saved as a draft.", "Payroll",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Approving locks this month and publishes its payslips. Continue?",
                "Approve payroll", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            string error = _controller.ApproveAndLock(SelectedYear(), SelectedMonth());
            if (error != null)
            {
                MessageBox.Show(error, "Unable to approve payroll", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadPayrollRun();
            MessageBox.Show("Payroll approved. The month is now locked and payslips are available.",
                "Payroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int SelectedMonth()
        {
            return cboMonth.SelectedIndex + 1;
        }

        private int SelectedYear()
        {
            return Decimal.ToInt32(numYear.Value);
        }

        private void LoadSalaries()
        {
            try
            {
                dgvSalaries.DataSource = _controller.GetSalaries();
                if (dgvSalaries.Rows.Count > 0 && dgvSalaries.CurrentRow == null)
                    dgvSalaries.Rows[0].Selected = true;
                dgvSalaries_SelectionChanged(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to load salaries", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSalaries_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSalaries.CurrentRow == null || !(dgvSalaries.CurrentRow.DataBoundItem is DataRowView row))
            {
                _selectedEmployeeId = null;
                txtSalaryEmployee.Clear();
                return;
            }

            _selectedEmployeeId = Convert.ToInt32(row["EmployeeId"]);
            txtSalaryEmployee.Text = Convert.ToString(row["EmployeeCode"]) + " - " + Convert.ToString(row["FullName"]);
            numBasic.Value = Math.Min(numBasic.Maximum, Convert.ToDecimal(row["BasicSalary"]));
            numAllowances.Value = Math.Min(numAllowances.Maximum, Convert.ToDecimal(row["Allowances"]));
            numDeductions.Value = Math.Min(numDeductions.Maximum, Convert.ToDecimal(row["Deductions"]));
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPayrollRun();
        }

        private void numYear_ValueChanged(object sender, EventArgs e)
        {
            LoadPayrollRun();
        }

        private void LoadPayrollRun()
        {
            if (cboMonth.SelectedIndex < 0) return;
            try
            {
                string status;
                bool isLocked;
                string error = _controller.GetRunStatus(SelectedYear(), SelectedMonth(), out status, out isLocked);
                if (error != null)
                {
                    MessageBox.Show(error, "Unable to load payroll status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable payroll = _controller.GetPayrollRun(SelectedYear(), SelectedMonth());
                dgvPayroll.DataSource = payroll;
                UpdateTotal();
                UpdateRunControls(payroll.Rows.Count == 0 ? "Not calculated" : status, isLocked, payroll.Rows.Count > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to load payroll", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRunControls(string status, bool isLocked, bool hasPayslips)
        {
            lblRunStatus.Text = "Status: " + status;
            btnCalculate.Enabled = !isLocked;
            btnApprove.Enabled = !isLocked && hasPayslips;
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            var table = dgvPayroll.DataSource as DataTable;
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                    total += Convert.ToDecimal(row["Net"]);
            }
            lblTotalNet.Text = "Total net pay: " + total.ToString("N2");
        }
    }
}
