using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.View
{
    public partial class MyProfileForm : Form
    {
        public MyProfileForm()
        {
            InitializeComponent();

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            using (var f = new ChangePasswordForm())
            {
                f.ShowDialog(this);
            }
        }
    }
}
