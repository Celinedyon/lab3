using System;
using System.Data;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.View
{
    public partial class PerformanceForm : Form
    {
        private readonly PerformanceController _controller = new PerformanceController();
        private readonly bool _isManager;
        private readonly int _managerEmployeeId;
        private readonly int? _employeeId;

        public PerformanceForm()
        {
            InitializeComponent();
            dgvGoals.AutoGenerateColumns = false;
            dgvReviews.AutoGenerateColumns = false;
            _isManager = Session.CurrentUser.Role == "Manager";
            _managerEmployeeId = Session.CurrentUser.EmployeeId.GetValueOrDefault(-1);
            _employeeId = Session.CurrentUser.EmployeeId;

            SetManagerControlsVisible(_isManager);
            LoadPerformance();
        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            if (!_isManager || cboGoalEmployee.SelectedValue == null) return;
            string error = _controller.AddGoal(Convert.ToInt32(cboGoalEmployee.SelectedValue),
                _managerEmployeeId, Session.CurrentUser.UserId, txtGoal.Text, dtpDue.Value.Date);
            if (error != null)
            {
                MessageBox.Show(error, "Unable to save goal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtGoal.Clear();
            LoadPerformance();
            MessageBox.Show("Goal saved.", "Performance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            if (!_isManager || cboReviewEmployee.SelectedValue == null) return;
            string error = _controller.AddReview(Convert.ToInt32(cboReviewEmployee.SelectedValue),
                _managerEmployeeId, Session.CurrentUser.UserId, Decimal.ToInt32(numRating.Value), txtComments.Text);
            if (error != null)
            {
                MessageBox.Show(error, "Unable to save review", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtComments.Clear();
            LoadPerformance();
            MessageBox.Show("Review saved.", "Performance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadPerformance()
        {
            try
            {
                if (_isManager)
                {
                    DataTable team = _controller.GetTeamEmployees(_managerEmployeeId);
                    BindEmployees(cboGoalEmployee, team);
                    BindEmployees(cboReviewEmployee, team.Copy());
                    btnAddGoal.Enabled = team.Rows.Count > 0;
                    btnAddReview.Enabled = team.Rows.Count > 0;
                }

                int scopeEmployeeId = _employeeId.GetValueOrDefault(-1);
                dgvGoals.DataSource = _controller.GetGoals(_managerEmployeeId,
                    _isManager ? (int?)null : scopeEmployeeId);
                dgvReviews.DataSource = _controller.GetReviews(_managerEmployeeId,
                    _isManager ? (int?)null : scopeEmployeeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to load performance records",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void BindEmployees(ComboBox comboBox, DataTable employees)
        {
            comboBox.DataSource = employees;
            comboBox.DisplayMember = "Employee";
            comboBox.ValueMember = "EmployeeId";
            comboBox.SelectedIndex = employees.Rows.Count == 0 ? -1 : 0;
        }

        private void SetManagerControlsVisible(bool visible)
        {
            lblGoalEmployee.Visible = visible;
            cboGoalEmployee.Visible = visible;
            lblGoal.Visible = visible;
            txtGoal.Visible = visible;
            lblDue.Visible = visible;
            dtpDue.Visible = visible;
            btnAddGoal.Visible = visible;
            lblReviewEmployee.Visible = visible;
            cboReviewEmployee.Visible = visible;
            lblRating.Visible = visible;
            numRating.Visible = visible;
            lblComments.Visible = visible;
            txtComments.Visible = visible;
            btnAddReview.Visible = visible;
        }
    }
}
