using RentMe_App.View;
using System.Windows.Forms;

namespace RentMe_App
{
    public partial class MainAdminForm : Form
    {
        private readonly LoginForm _loginForm;

        public MainAdminForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void MainAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Show();
        }
    }
}
