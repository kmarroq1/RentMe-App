﻿using System;
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
    public partial class MainEmployeeForm : Form
    {
        private readonly LoginForm _loginForm;

        public MainEmployeeForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void MainEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Show();
        }
    }
}
