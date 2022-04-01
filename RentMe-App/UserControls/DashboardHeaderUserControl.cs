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

namespace RentMe_App.UserControls
{
    public partial class DashboardHeaderUserControl : UserControl
    {
        private ILogout _parentForm;

        public DashboardHeaderUserControl()
        {
            InitializeComponent();
        }

        public void SetParameters(ILogout parentForm)
        {
            _parentForm = parentForm;
        }

        private void DashboardHeaderUserControl_Load(object sender, EventArgs e)
        {

        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _parentForm.Logout();
        }
    }
}
