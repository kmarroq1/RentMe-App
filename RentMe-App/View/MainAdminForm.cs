using RentMe_App.View;
using RentMe_App.View.Interfaces;
using System.Windows.Forms;

namespace RentMe_App
{
    public partial class MainAdminForm : Form, ILogout
    {
        private readonly LoginForm _loginForm;

        public MainAdminForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            dashboardHeaderUserControl.SetParameters(this);
        }

        public void Logout()
        {
            _loginForm.Show();
            Close();
        }

        private void MainAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Show();
        }
    }
}
