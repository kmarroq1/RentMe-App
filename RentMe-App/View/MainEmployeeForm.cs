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

        public string usernameForm;
        public string employeeNameForm;
        private readonly LoginForm _loginForm;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to initialize the MainEmployeeForm class
        /// </summary>
        /// <param name="loginForm">login form passed to main employee form</param>
        public MainEmployeeForm(LoginForm loginForm)
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
        public void SetEmployeeFormInfo(string username, string name)
        {
            usernameForm = username;
            employeeNameForm = name;
        }
        #endregion

        #region Event Handlers
        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _loginForm.LogOut();
            this.Hide();
        }

        private void MainEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.LogOut();
        }

        private void MainEmployeeForm_Load(object sender, System.EventArgs e)
        {
            usernameValueLabel.Text = usernameForm;
            employeeNameValueLabel.Text = employeeNameForm;
        }

        private void AddMemberUserControl1_Load(object sender, System.EventArgs e)
        {
            addMemberUserControl1.ClearFields();
        }
        #endregion
    }
}
