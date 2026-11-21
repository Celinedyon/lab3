using System;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.View
{
    public partial class TeamForm : Form
    {
        private readonly TeamController _controller = new TeamController();
        private readonly int _managerEmployeeId;

        public TeamForm()
        {
            InitializeComponent();
            dgvTeam.AutoGenerateColumns = false;
            _managerEmployeeId = Session.CurrentUser.EmployeeId.GetValueOrDefault(-1);
            txtSearch.KeyDown += txtSearch_KeyDown;
            LoadTeam();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadTeam();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadTeam();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadTeam();
            }
        }

        private void LoadTeam()
        {
            try
            {
                dgvTeam.DataSource = _controller.GetTeam(_managerEmployeeId, txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to load team", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
