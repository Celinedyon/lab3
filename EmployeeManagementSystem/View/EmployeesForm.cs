using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.View
{
    public partial class EmployeesForm : Form
    {
        private readonly EmployeeController _controller = new EmployeeController();

        public EmployeesForm()
        {
            InitializeComponent();
            dgvEmployees.AutoGenerateColumns = false;
            colEmployeesHireDate.DefaultCellStyle.Format = "d";
            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new object[] { "All statuses", "Active", "On Leave", "Suspended", "Terminated" });
            cboStatus.SelectedIndex = 0;

            try
            {
                var departments = _controller.GetDepartments();
                var allDepartments = departments.NewRow();
                allDepartments["department_id"] = DBNull.Value;
                allDepartments["name"] = "All departments";
                departments.Rows.InsertAt(allDepartments, 0);
                cboDepartment.DisplayMember = "name";
                cboDepartment.ValueMember = "name";
                cboDepartment.DataSource = departments;
                cboDepartment.SelectedIndexChanged += cboDepartment_SelectedIndexChanged;
                RefreshEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Unable to load employees: " + ex.Message,
                    "Employees", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshEmployees();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartment.DataSource != null)
                RefreshEmployees();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboDepartment.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            RefreshEmployees();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new EmployeeEditForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    RefreshEmployees();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? employeeId = SelectedEmployeeId();
            if (!employeeId.HasValue)
            {
                MessageBox.Show(this, "Select an employee to edit.",
                    "Employees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new EmployeeEditForm(employeeId.Value))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    RefreshEmployees();
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            int? employeeId = SelectedEmployeeId();
            if (!employeeId.HasValue)
            {
                MessageBox.Show(this, "Select an employee to change status.",
                    "Employees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = (DataRowView)dgvEmployees.CurrentRow.DataBoundItem;
            string currentStatus = Convert.ToString(row["Status"]);
            using (var dialog = new Form
            {
                Text = "Change employee status",
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                ClientSize = new Size(310, 120),
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false
            })
            {
                var status = new ComboBox
                {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Location = new Point(18, 18),
                    Size = new Size(274, 28)
                };
                status.Items.AddRange(new object[] { "Active", "On Leave", "Suspended", "Terminated" });
                status.SelectedItem = currentStatus;
                var save = new Button
                {
                    Text = "Save",
                    DialogResult = DialogResult.OK,
                    Location = new Point(112, 70),
                    Size = new Size(82, 32),
                    BackColor = Color.FromArgb(31, 58, 95),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                var cancel = new Button
                {
                    Text = "Cancel",
                    DialogResult = DialogResult.Cancel,
                    Location = new Point(205, 70),
                    Size = new Size(82, 32)
                };
                dialog.Controls.Add(status);
                dialog.Controls.Add(save);
                dialog.Controls.Add(cancel);
                dialog.AcceptButton = save;
                dialog.CancelButton = cancel;

                if (dialog.ShowDialog(this) != DialogResult.OK)
                    return;

                string error = _controller.SetStatus(employeeId.Value, Convert.ToString(status.SelectedItem));
                if (error != null)
                {
                    MessageBox.Show(this, error, "Employees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            RefreshEmployees();
        }

        private int? SelectedEmployeeId()
        {
            if (dgvEmployees.CurrentRow == null || !(dgvEmployees.CurrentRow.DataBoundItem is DataRowView row))
                return null;
            return Convert.ToInt32(row["employee_id"]);
        }

        private void RefreshEmployees()
        {
            string department = Convert.ToString(cboDepartment.SelectedValue);
            if (department == "All departments")
                department = null;
            string status = cboStatus.SelectedIndex <= 0 ? null : Convert.ToString(cboStatus.SelectedItem);
            dgvEmployees.DataSource = _controller.GetAll(txtSearch.Text.Trim(), department, status);
        }
    }
}
