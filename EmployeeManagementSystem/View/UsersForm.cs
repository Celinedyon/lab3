using System;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;

namespace EmployeeManagementSystem.View
{
    public partial class UsersForm : Form
    {
        private readonly UserController _users = new UserController();
        private int _selectedId = 0;

        public UsersForm()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
            if (!DesignMode) LoadUsers();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
            _selectedId = Convert.ToInt32(row.Cells["colUsersId"].Value);
            txtEmail.Text = row.Cells["colUsersEmail"].Value.ToString();
            cboRole.Text = row.Cells["colUsersRole"].Value.ToString();
            chkActive.Checked = Convert.ToBoolean(row.Cells["colUsersActive"].Value);
            txtPassword.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string err = _users.Create(txtEmail.Text.Trim(), txtPassword.Text, cboRole.Text);
            if (err != null) { MessageBox.Show(err); return; }
            LoadUsers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) { MessageBox.Show("Select a user in the list first."); return; }
            string err = _users.Update(_selectedId, txtEmail.Text.Trim(), cboRole.Text,
                                       chkActive.Checked, txtPassword.Text);
            if (err != null) { MessageBox.Show(err); return; }
            LoadUsers();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void LoadUsers()
        {
            dgvUsers.DataSource = _users.GetAll();
            ClearFields();
        }

        private void ClearFields()
        {
            _selectedId = 0;
            txtEmail.Text = "";
            txtPassword.Text = "";
            cboRole.SelectedIndex = -1;
            chkActive.Checked = true;
            dgvUsers.ClearSelection();
        }
    }
}
