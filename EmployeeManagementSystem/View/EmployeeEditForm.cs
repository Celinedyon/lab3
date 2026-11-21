using System;
using System.Data;
using System.Net.Mail;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.View
{
    public partial class EmployeeEditForm : Form
    {
        private readonly EmployeeController _controller = new EmployeeController();
        private readonly int? _employeeId;
        private Employee _employee;

        public EmployeeEditForm(int? employeeId = null)
        {
            InitializeComponent();
            ViewTheme.Apply(this);
            _employeeId = employeeId;
            dtpBirth.ShowCheckBox = true;
            cboGender.Items.Insert(0, "Not specified");
            cboGender.SelectedIndex = 0;
            if (_employeeId.HasValue)
            {
                lblPassword.Text = "Login Password (leave blank to keep)";
                txtPassword.Enabled = false;
            }

            try
            {
                BindLookup(cboDepartment, _controller.GetDepartments(), "department_id", "name", "No department");
                BindLookup(cboPosition, _controller.GetPositions(SelectedNullableId(cboDepartment)), "position_id", "title", "No position");
                cboDepartment.SelectedValueChanged += cboDepartment_SelectedValueChanged;
                if (_employeeId.HasValue)
                    LoadEmployee();
                else
                    dtpHireDate.Value = DateTime.Today;
            }

            catch (Exception ex)
            {
                btnSave.Enabled = false;
                MessageBox.Show(this, "Unable to load employee details: " + ex.Message,
                    "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            int? departmentId = SelectedNullableId(cboDepartment);
            BindLookup(cboPosition, _controller.GetPositions(departmentId), "position_id", "title", "No position");
        }

        private static void BindLookup(ComboBox combo, DataTable data, string valueMember, string displayMember, string emptyLabel)
        {
            var empty = data.NewRow();
            empty[valueMember] = DBNull.Value;
            empty[displayMember] = emptyLabel;
            data.Rows.InsertAt(empty, 0);
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            combo.DataSource = data;
        }

        private void LoadEmployee()
        {
            _employee = _controller.GetById(_employeeId.Value);
            if (_employee == null)
            {
                btnSave.Enabled = false;
                MessageBox.Show(this, "The selected employee could not be found.",
                    "Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Text = "Edit Employee";
            lblHeaderTitle.Text = "Edit Employee Information";
            lblHeaderSubtitle.Text = "Update records for " + _employee.FullName + " (" + _employee.EmployeeCode + ")";
            btnSave.Text = "Update Employee";
            txtEmployeeId.Text = _employee.EmployeeCode;
            txtFirstName.Text = _employee.FirstName;
            txtLastName.Text = _employee.LastName;
            txtEmail.Text = _employee.Email;
            txtPhone.Text = _employee.Phone;
            txtAddress.Text = _employee.Address;
            dtpBirth.Checked = _employee.DateOfBirth.HasValue;
            dtpBirth.Value = _employee.DateOfBirth ?? new DateTime(2000, 1, 1);
            cboGender.SelectedItem = string.IsNullOrWhiteSpace(_employee.Gender)
                ? "Not specified"
                : _employee.Gender;
            dtpHireDate.Value = _employee.HireDate;
            cboStatus.SelectedItem = _employee.Status;
            txtEmgName.Text = _employee.EmergencyName;
            txtEmgPhone.Text = _employee.EmergencyPhone;
            SelectLookupValue(cboDepartment, _employee.DepartmentId);
            SelectLookupValue(cboPosition, _employee.PositionId);
        }

        private static void SelectLookupValue(ComboBox combo, int? value)
        {
            combo.SelectedValue = value.HasValue ? (object)value.Value : DBNull.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            try
            {
                var parsedEmail = new MailAddress(email);
                if (!string.Equals(parsedEmail.Address, email, StringComparison.OrdinalIgnoreCase))
                    throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Enter a valid email address.",
                    "Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            var employee = new Employee
            {
                EmployeeId = _employee == null ? 0 : _employee.EmployeeId,
                EmployeeCode = _employee == null ? null : _employee.EmployeeCode,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Email = email,
                Phone = NullIfEmpty(txtPhone.Text),
                Address = NullIfEmpty(txtAddress.Text),
                DateOfBirth = dtpBirth.Checked ? (DateTime?)dtpBirth.Value.Date : null,
                Gender = Convert.ToString(cboGender.SelectedItem) == "Not specified"
                    ? null
                    : Convert.ToString(cboGender.SelectedItem),
                HireDate = dtpHireDate.Value.Date,
                DepartmentId = SelectedNullableId(cboDepartment),
                PositionId = SelectedNullableId(cboPosition),
                ManagerId = _employee == null ? null : _employee.ManagerId,
                Status = Convert.ToString(cboStatus.SelectedItem),
                EmergencyName = NullIfEmpty(txtEmgName.Text),
                EmergencyPhone = NullIfEmpty(txtEmgPhone.Text),
                Salary = _employee == null ? 0 : _employee.Salary,
                Allowances = _employee == null ? 0 : _employee.Allowances,
                Deductions = _employee == null ? 0 : _employee.Deductions
            };

            string error = _employee == null
                ? _controller.Create(employee, txtPassword.Text)
                : _controller.Update(employee);
            if (error != null)
            {
                MessageBox.Show(this, error, "Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private static int? SelectedNullableId(ComboBox combo)
        {
            if (combo.SelectedValue == null || combo.SelectedValue == DBNull.Value)
                return null;
            return Convert.ToInt32(combo.SelectedValue);
        }

        private static string NullIfEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
        }
    }
}
