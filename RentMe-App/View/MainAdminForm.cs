using RentMe_App.View;
using RentMe_App.View.Interfaces;
using System.Windows.Forms;

namespace RentMe_App
{
    public partial class MainAdminForm : Form, ILogout
    {
        private readonly LoginForm _loginForm;
        private bool _killApp;

        public MainAdminForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            dashboardHeaderUserControl.SetParameters(this);
            _killApp = true;
        }

        public void Logout()
        {
            _killApp = false;
            _loginForm.Show();
            Close();
        }

        private void MainAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_killApp) Application.Exit();
        }
    }
}
