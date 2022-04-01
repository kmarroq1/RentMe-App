using RentMe_App.View.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMe_App.View
{
    public partial class MainEmployeeForm : Form, ILogout
    {
        private readonly LoginForm _loginForm;

        public MainEmployeeForm(LoginForm loginForm)
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

        private void MainEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Show();
        }
    }
}
