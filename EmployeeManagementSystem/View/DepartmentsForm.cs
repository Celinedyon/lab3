using System;
using System.Data;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.View
{
    public partial class DepartmentsForm : Form
    {
        private readonly DepartmentController _controller = new DepartmentController();
        private int? _departmentId;
        private bool _isActive = true;

        public DepartmentsForm()
        {
            InitializeComponent();
            dgvDepartments.AutoGenerateColumns = false;
            try
            {
                var managers = _controller.GetManagers();
                var noManager = managers.NewRow();
                noManager["employee_id"] = DBNull.Value;
                noManager["name"] = "No manager";
                managers.Rows.InsertAt(noManager, 0);
                cboManager.DisplayMember = "name";
                cboManager.ValueMember = "employee_id";
                cboManager.DataSource = managers;
                RefreshDepartments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Unable to load departments: " + ex.Message,
                    "Departments", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !(dgvDepartments.Rows[e.RowIndex].DataBoundItem is DataRowView row))
                return;
            _departmentId = Convert.ToInt32(row["ID"]);
            txtName.Text = Convert.ToString(row["Name"]);
            _isActive = Convert.ToBoolean(row["is_active"]);
            cboManager.SelectedValue = row["manager_id"] == DBNull.Value
                ? (object)DBNull.Value
                : row["manager_id"];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var department = BuildDepartment();
            string error = _controller.Create(department);
            if (error != null)
            {
                ShowError(error);
                return;
            }
            RefreshDepartments();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!_departmentId.HasValue)
            {
                ShowError("Select a department to update.");
                return;
            }
            var department = BuildDepartment();
            department.DepartmentId = _departmentId.Value;
            department.IsActive = _isActive;
            string error = _controller.Update(department);
            if (error != null)
            {
                ShowError(error);
                return;
            }
            RefreshDepartments();
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private Department BuildDepartment()
        {
            int? managerId = cboManager.SelectedValue == null || cboManager.SelectedValue == DBNull.Value
                ? (int?)null
                : Convert.ToInt32(cboManager.SelectedValue);
            return new Department
            {
                Name = txtName.Text.Trim(),
                ManagerEmployeeId = managerId,
                IsActive = true
            };
        }

        private void RefreshDepartments()
        {
            dgvDepartments.DataSource = _controller.GetAll();
        }

        private void ClearFields()
        {
            _departmentId = null;
            _isActive = true;
            txtName.Clear();
            if (cboManager.Items.Count > 0)
                cboManager.SelectedIndex = 0;
            dgvDepartments.ClearSelection();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(this, message, "Departments", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
