using System.Windows.Forms;

namespace RentMe_App.View
{
    /// <summary>
    /// class for main employee form
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public partial class MainEmployeeForm : Form
    {
        #region Data members

        /// <summary>
        /// Employee username
        /// </summary>
        public string usernameForm;

        /// <summary>
        /// Employee name
        /// </summary>
        public string employeeNameForm;

        /// <summary>
        /// Login Instance
        /// </summary>
        public LoginForm loginForm;
        
        private bool _killApp;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to initialize the MainEmployeeForm class
        /// </summary>
        /// <param name="loginForm">login form passed to main employee form</param>
        public MainEmployeeForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            SharedFormInfo.LoginForm = loginForm;
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
            this.loginForm.LogOut();
            Close();
        }

        /// <summary>
        /// method used to set the username to show on the form
        /// </summary>
        /// <param name="username">username of person logging in</param>
        public void SetEmployeeFormInfo(string username, string name)
        {
            usernameForm = username;
            employeeNameForm = name;
        }
        #endregion

        #region Event Handlers
        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logout();
        }

        private void MainEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_killApp) Application.Exit();
        }

        private void MainEmployeeForm_Load(object sender, System.EventArgs e)
        {
            usernameValueLabel.Text = SharedFormInfo.UsernameForm;
            employeeNameValueLabel.Text = SharedFormInfo.EmployeeNameForm;

            SharedFormInfo.MainEmployeeForm = this;
        }

        private void AddMemberUserControl1_Load(object sender, System.EventArgs e)
        {
            addMemberUserControl1.ClearFields();
        }
        #endregion
    }
}
