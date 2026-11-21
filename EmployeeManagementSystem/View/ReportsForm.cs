using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.View
{
    public partial class ReportsForm : Form
    {
        private readonly ReportsController _controller = new ReportsController();
        private readonly int? _managerEmployeeId;
        private DataTable _report;

        public ReportsForm()
        {
            InitializeComponent();
            dgvReport.AutoGenerateColumns = true;
            if (Session.CurrentUser.Role == "Manager")
                _managerEmployeeId = Session.CurrentUser.EmployeeId;
            dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpTo.Value = DateTime.Today;
            btnExport.Enabled = false;
            LoadDepartments();
            GenerateReport();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (_report == null) return;
            using (var dialog = new SaveFileDialog
            {
                Title = "Export report",
                Filter = "CSV files (*.csv)|*.csv",
                FileName = cboReport.Text.Replace(" ", "-") + ".csv",
                DefaultExt = "csv",
                AddExtension = true
            })
            {
                if (dialog.ShowDialog(this) != DialogResult.OK) return;
                try
                {
                    var csv = new StringBuilder();
                    for (int column = 0; column < _report.Columns.Count; column++)
                    {
                        if (column > 0) csv.Append(',');
                        csv.Append(CsvField(_report.Columns[column].ColumnName));
                    }
                    csv.AppendLine();
                    foreach (DataRow row in _report.Rows)
                    {
                        for (int column = 0; column < _report.Columns.Count; column++)
                        {
                            if (column > 0) csv.Append(',');
                            csv.Append(CsvField(Convert.ToString(row[column])));
                        }
                        csv.AppendLine();
                    }
                    File.WriteAllText(dialog.FileName, csv.ToString(), new UTF8Encoding(true));
                    MessageBox.Show("Report exported.", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to export report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadDepartments()
        {
            try
            {
                DataTable departments = _controller.GetDepartments();
                DataRow allDepartments = departments.NewRow();
                allDepartments["DepartmentId"] = DBNull.Value;
                allDepartments["Department"] = "All departments";
                departments.Rows.InsertAt(allDepartments, 0);
                cboDepartment.DataSource = departments;
                cboDepartment.DisplayMember = "Department";
                cboDepartment.ValueMember = "DepartmentId";
                cboDepartment.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to load departments", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateReport()
        {
            try
            {
                int? departmentId = null;
                if (cboDepartment.SelectedValue != null && cboDepartment.SelectedValue != DBNull.Value)
                    departmentId = Convert.ToInt32(cboDepartment.SelectedValue);

                _report = _controller.GetReport(cboReport.Text, dtpFrom.Value.Date, dtpTo.Value.Date,
                    departmentId, _managerEmployeeId);
                dgvReport.DataSource = _report;
                lblRowCount.Text = _report.Rows.Count + (_report.Rows.Count == 1 ? " row" : " rows");
                btnExport.Enabled = _report.Columns.Count > 0;
            }
            catch (Exception ex)
            {
                _report = null;
                dgvReport.DataSource = null;
                lblRowCount.Text = "0 rows";
                btnExport.Enabled = false;
                MessageBox.Show(ex.Message, "Unable to generate report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string CsvField(string value)
        {
            value = value ?? string.Empty;
            if (value.Length > 0 && "=+-@\t\r".IndexOf(value[0]) >= 0)
                value = "'" + value;
            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }
    }
}
