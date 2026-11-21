using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.View
{
    public partial class PayslipsForm : Form
    {
        private readonly PayrollController _controller = new PayrollController();
        private DataRow _selectedPayslip;

        public PayslipsForm()
        {
            InitializeComponent();
            dgvPayslips.AutoGenerateColumns = false;
            dgvPayslips.SelectionChanged += dgvPayslips_SelectionChanged;
            btnDownload.Enabled = false;
            LoadPayslips();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (_selectedPayslip == null) return;
            using (var dialog = new SaveFileDialog
            {
                Title = "Save payslip as PDF",
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = "Payslip-" + Convert.ToString(_selectedPayslip["Year"]) + "-" +
                    Convert.ToString(_selectedPayslip["MonthNumber"]) + ".pdf",
                DefaultExt = "pdf",
                AddExtension = true
            })
            {
                if (dialog.ShowDialog(this) != DialogResult.OK) return;
                try
                {
                    PayslipPdfExporter.Save(dialog.FileName, new[]
                    {
                        "Employee: " + Session.CurrentUser.Email,
                        "Pay period: " + Convert.ToString(_selectedPayslip["Month"]) + " " +
                            Convert.ToString(_selectedPayslip["Year"]),
                        "Basic salary: " + Money("BasicSalary"),
                        "Allowances: " + Money("Allowances"),
                        "Gross pay: " + Money("Gross"),
                        "Standard deductions: " + Money("StandardDeductions"),
                        "Unpaid leave and absences: " + Money("UnpaidDeduction"),
                        "Total deductions: " + Money("Deductions"),
                        "Net pay: " + Money("Net"),
                        "Issued by Employee Management System"
                    });
                    MessageBox.Show("Payslip PDF saved.", "Payslips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to save PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadPayslips()
        {
            if (!Session.CurrentUser.EmployeeId.HasValue)
            {
                MessageBox.Show("This account is not linked to an employee record.", "Payslips",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                dgvPayslips.DataSource = _controller.GetEmployeePayslips(Session.CurrentUser.EmployeeId.Value);
                if (dgvPayslips.Rows.Count == 0)
                    ClearDetails();
                else
                    dgvPayslips.Rows[0].Selected = true;
                dgvPayslips_SelectionChanged(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to load payslips", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPayslips_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPayslips.CurrentRow == null ||
                !(dgvPayslips.CurrentRow.DataBoundItem is DataRowView row) ||
                !Session.CurrentUser.EmployeeId.HasValue)
            {
                ClearDetails();
                return;
            }

            try
            {
                _selectedPayslip = _controller.GetEmployeePayslip(
                    Convert.ToInt32(row["PayslipId"]), Session.CurrentUser.EmployeeId.Value);
                if (_selectedPayslip == null)
                {
                    ClearDetails();
                    return;
                }

                lblPeriod.Text = Convert.ToString(_selectedPayslip["Month"]) + " " +
                    Convert.ToString(_selectedPayslip["Year"]);
                lblValBasic.Text = Money("BasicSalary");
                lblValAllowances.Text = Money("Allowances");
                lblValGross.Text = Money("Gross");
                lblValDeductions.Text = Money("StandardDeductions");
                lblValUnpaid.Text = Money("UnpaidDeduction");
                lblValNet.Text = Money("Net");
                btnDownload.Enabled = true;
            }
            catch (Exception ex)
            {
                ClearDetails();
                MessageBox.Show(ex.Message, "Unable to load payslip", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string Money(string column)
        {
            return Convert.ToDecimal(_selectedPayslip[column]).ToString("N2", CultureInfo.CurrentCulture);
        }

        private void ClearDetails()
        {
            _selectedPayslip = null;
            lblPeriod.Text = "Select a payslip from the list";
            lblValBasic.Text = "0.00";
            lblValAllowances.Text = "0.00";
            lblValGross.Text = "0.00";
            lblValDeductions.Text = "0.00";
            lblValUnpaid.Text = "0.00";
            lblValNet.Text = "0.00";
            btnDownload.Enabled = false;
        }
    }
}
