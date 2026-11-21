using System;
using System.Data;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.View
{
    public partial class PositionsForm : Form
    {
        private readonly PositionController _controller = new PositionController();
        private int? _positionId;
        private string _description;
        private bool _isActive = true;

        public PositionsForm()
        {
            InitializeComponent();
            dgvPositions.AutoGenerateColumns = false;
            BindDepartments();
            try
            {
                RefreshPositions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Unable to load positions: " + ex.Message,
                    "Positions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPositions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !(dgvPositions.Rows[e.RowIndex].DataBoundItem is DataRowView row))
                return;
            _positionId = Convert.ToInt32(row["ID"]);
            txtTitle.Text = Convert.ToString(row["Title"]);
            _description = row["description"] == DBNull.Value ? null : Convert.ToString(row["description"]);
            _isActive = Convert.ToBoolean(row["is_active"]);
            cboDepartment.SelectedValue = row["department_id"] == DBNull.Value ? (object)DBNull.Value : row["department_id"];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string error = _controller.Create(new Position { Title = txtTitle.Text.Trim(), DepartmentId = SelectedDepartmentId() });
            if (error != null)
            {
                ShowError(error);
                return;
            }
            RefreshPositions();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!_positionId.HasValue)
            {
                ShowError("Select a position to update.");
                return;
            }
            string error = _controller.Update(new Position
            {
                PositionId = _positionId.Value,
                Title = txtTitle.Text.Trim(),
                Description = _description,
                DepartmentId = SelectedDepartmentId(),
                IsActive = _isActive
            });
            if (error != null)
            {
                ShowError(error);
                return;
            }
            RefreshPositions();
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void RefreshPositions()
        {
            dgvPositions.DataSource = _controller.GetAll();
        }

        private void ClearFields()
        {
            _positionId = null;
            _description = null;
            _isActive = true;
            txtTitle.Clear();
            cboDepartment.SelectedIndex = 0;
            dgvPositions.ClearSelection();
        }

        private void BindDepartments()
        {
            var departments = new EmployeeController().GetDepartments();
            var all = departments.NewRow();
            all["department_id"] = DBNull.Value;
            all["name"] = "No department";
            departments.Rows.InsertAt(all, 0);
            cboDepartment.DisplayMember = "name";
            cboDepartment.ValueMember = "department_id";
            cboDepartment.DataSource = departments;
        }

        private int? SelectedDepartmentId()
        {
            if (cboDepartment.SelectedValue == null || cboDepartment.SelectedValue == DBNull.Value)
                return null;
            return Convert.ToInt32(cboDepartment.SelectedValue);
        }

        private void ShowError(string message)
        {
            MessageBox.Show(this, message, "Positions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
