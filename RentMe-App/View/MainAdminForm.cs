using RentMe_App.View;
using System.Windows.Forms;

namespace RentMe_App
{
    /// <summary>
    /// class for main employee form
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public partial class MainAdminForm : Form
    {
        #region Data members

        /// <summary>
        /// Admin username
        /// </summary>
        public string usernameForm;

        /// <summary>
        /// Admin name
        /// </summary>
        public string employeeNameForm;

        private readonly LoginForm _loginForm;
        private bool _killApp;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to initialize the MainAdminForm class
        /// </summary>
        /// <param name="loginForm">login form passed to main admin form</param>
        public MainAdminForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _killApp = true;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Logs the user out.
        /// </summary>
        public void Logout()
        {
            _killApp = false;
            _loginForm.Show();
            _loginForm.LogOut();
            Close();
        }

        /// <summary>
        /// method used to set the username to show on the form
        /// </summary>
        /// <param name="username">username of person logging in</param>
        public void SetAdminFormInfo(string username, string name)
        {
            usernameForm = username;
            employeeNameForm = name;
        }

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logout();
        }

        private void MainAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_killApp) Application.Exit();
        }

        private void MainAdminForm_Load(object sender, System.EventArgs e)
        {
            usernameValueLabel.Text = usernameForm;
            employeeNameValueLabel.Text = employeeNameForm;
        }

        #endregion
    }
}
