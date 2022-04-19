using RentMe_App.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentMe_App.View
{
    /// <summary>
    /// login class that encapsulates the login controls
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public partial class LoginForm : Form
    {
        #region Data members

        private readonly LoginController loginController;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to initialize the LoginForm class
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            
            loginController = new LoginController();
        }

        #endregion

        #region Methods

        private void EmployeeLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;
                bool isAdmin = false;

                string loginInfo = CheckAuthorization(username, password, isAdmin);

                if (String.IsNullOrEmpty(loginInfo) == false && String.IsNullOrEmpty(username) == false && String.IsNullOrEmpty(password) == false)
                {
                    string[] loginInfoArray = loginInfo.Split('^');
                    string employeeIDForm = loginInfoArray[0];
                    string usernameForm = loginInfoArray[1];
                    string employeeNameForm = loginInfoArray[2];

                    Int32.TryParse(employeeIDForm, out int employeeID);
                    SharedFormInfo.EmployeeIDForm = employeeID;
                    SharedFormInfo.UsernameForm = usernameForm;
                    SharedFormInfo.EmployeeNameForm = employeeNameForm;

                    MainEmployeeForm mainEmployeeForm = new MainEmployeeForm(this);

                    Hide();
                    mainEmployeeForm.ShowDialog();
                }
            }
            catch (Exception)
            {
                string errorMessage = "Invalid form entries";
                ShowInvalidErrorMessage(errorMessage);
            }
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;
                bool isAdmin = true;

                string loginInfo = CheckAuthorization(username, password, isAdmin);

                if (String.IsNullOrEmpty(loginInfo) == false && String.IsNullOrEmpty(username) == false && String.IsNullOrEmpty(password) == false)
                {
                    string[] loginInfoArray = loginInfo.Split('^');
                    string employeeIDForm = loginInfoArray[0];
                    string usernameForm = loginInfoArray[1];
                    string employeeNameForm = loginInfoArray[2];

                    Int32.TryParse(employeeIDForm, out int employeeID);
                    SharedFormInfo.EmployeeIDForm = employeeID;
                    SharedFormInfo.UsernameForm = usernameForm;
                    SharedFormInfo.EmployeeNameForm = employeeNameForm;

                    MainAdminForm mainAdminForm = new MainAdminForm(this);

                    Hide();
                    mainAdminForm.ShowDialog();
                }
            }
            catch (Exception)
            {
                string errorMessage = "Invalid form entries";
                ShowInvalidErrorMessage(errorMessage);
            }
        }

        private string CheckAuthorization(string username, string password, bool isAdmin)
        {
            string loginInfo = null;

            if (String.IsNullOrEmpty(username) == true || String.IsNullOrEmpty(password) == true)
            {
                string errorMessage = "Fields cannot be empty";
                ShowInvalidErrorMessage(errorMessage);
            }
            else if (isAdmin)
            {
                loginInfo = loginController.GetAuthorizedAdminLoginInfo(username, password);
                if (String.IsNullOrEmpty(loginInfo) == true)
                {
                    string errorMessage = "Employee is not active or not authorized";
                    ShowInvalidErrorMessage(errorMessage);
                }
            }
            else
            {
                loginInfo = loginController.GetAuthorizedEmployeeLoginInfo(username, password);
                if (String.IsNullOrEmpty(loginInfo) == true)
                {
                    string errorMessage = "Employee is not active or not authorized";
                    ShowInvalidErrorMessage(errorMessage);
                }
            }
            return loginInfo;
        }

        /// <summary>
        /// method used to clear the text boxes and show login screen
        /// </summary>
        public void LogOut()
        {
            ClearForm();
            Show();
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        private void ShowInvalidErrorMessage(string errorMessage)
        {
            errorMessageLabel.Text = errorMessage;
            errorMessageLabel.ForeColor = Color.Red;
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            HideErrorMessage();
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            passwordTextBox.Text = "";
            HideErrorMessage();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ClearForm()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        #endregion
    }
}
