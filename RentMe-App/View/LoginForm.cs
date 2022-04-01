using System;
using System.Windows.Forms;

namespace RentMe_App.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ShowEmployeeButton_Click(object sender, EventArgs e)
        {
            (new MainEmployeeForm(this)).Show();
            Hide();
        }

        private void ShowAdminButton_Click(object sender, EventArgs e)
        {
            (new MainAdminForm(this)).Show();
            Hide();
        }
    }
}
