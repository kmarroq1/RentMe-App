using RentMe_App.View;
using System.Windows.Forms;

namespace RentMe_App
{
    public partial class MainAdminForm : Form
    {
        #region Data members

        public string usernameForm;
        public string employeeNameForm;
        private readonly LoginForm _loginForm;

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
        }

        #endregion

        #region Methods

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
            _loginForm.LogOut();
            this.Hide();
        }

        private void MainAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.LogOut();
        }

        private void MainAdminForm_Load(object sender, System.EventArgs e)
        {
            usernameValueLabel.Text = usernameForm;
            employeeNameValueLabel.Text = employeeNameForm;
        }

        #endregion
    }
}
