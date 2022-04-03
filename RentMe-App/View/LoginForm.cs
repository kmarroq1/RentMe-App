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

        private readonly MainAdminForm mainAdminForm;
        private readonly MainEmployeeForm mainEmployeeForm;
        private readonly LoginController loginController;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to initialize the LoginForm class
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            this.mainAdminForm = new MainAdminForm(this);
            this.mainEmployeeForm = new MainEmployeeForm(this);
            this.loginController = new LoginController();
        }

        #endregion

        #region Methods

        private void EmployeeLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = this.usernameTextBox.Text;
                string password = this.passwordTextBox.Text;
                bool isAdmin = false;

                string loginInfo = this.CheckAuthorization(username, password, isAdmin);

                if (String.IsNullOrEmpty(loginInfo) == false && String.IsNullOrEmpty(username) == false && String.IsNullOrEmpty(password) == false)
                {
                    string[] loginInfoArray = loginInfo.Split('^');
                    string usernameForm = loginInfoArray[1];
                    string nameForm = loginInfoArray[2];

                    mainEmployeeForm.SetEmployeeFormInfo(usernameForm, nameForm);

                    mainEmployeeForm.Show();
                    mainAdminForm.Hide();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                string errorMessage = "Invalid form entries";
                this.ShowInvalidErrorMessage(errorMessage);
            }
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = this.usernameTextBox.Text;
                string password = this.passwordTextBox.Text;
                bool isAdmin = true;

                string loginInfo = this.CheckAuthorization(username, password, isAdmin);

                if (String.IsNullOrEmpty(loginInfo) == false && String.IsNullOrEmpty(username) == false && String.IsNullOrEmpty(password) == false)
                {
                    string[] loginInfoArray = loginInfo.Split('^');
                    string usernameForm = loginInfoArray[1];
                    string nameForm = loginInfoArray[2];

                    mainAdminForm.SetAdminFormInfo(usernameForm, nameForm);

                    mainAdminForm.Show();
                    mainEmployeeForm.Hide();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                string errorMessage = "Invalid form entries";
                this.ShowInvalidErrorMessage(errorMessage);
            }
        }

        private string CheckAuthorization(string username, string password, bool isAdmin)
        {
            string loginInfo = null;

            if (String.IsNullOrEmpty(username) == true || String.IsNullOrEmpty(password) == true)
            {
                string errorMessage = "Fields cannot be empty";
                this.ShowInvalidErrorMessage(errorMessage);
            }
            else if (isAdmin)
            {
                loginInfo = this.loginController.GetAuthorizedAdminLoginInfo(username, password);
                if (String.IsNullOrEmpty(loginInfo) == true)
                {
                    string errorMessage = "Employee is not active or not authorized";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
            }
            else
            {
                loginInfo = this.loginController.GetAuthorizedEmployeeLoginInfo(username, password);
                if (String.IsNullOrEmpty(loginInfo) == true)
                {
                    string errorMessage = "Employee is not active or not authorized";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
            }
            return loginInfo;
        }

        /// <summary>
        /// method used to clear the text boxes and show login screen
        /// </summary>
        public void LogOut()
        {
            this.ClearForm();
            this.Show();
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
            this.usernameTextBox.Text = "";
            HideErrorMessage();
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            this.passwordTextBox.Text = "";
            HideErrorMessage();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ClearForm()
        {
            this.usernameTextBox.Text = "";
            this.passwordTextBox.Text = "";
        }

        #endregion
    }
}
