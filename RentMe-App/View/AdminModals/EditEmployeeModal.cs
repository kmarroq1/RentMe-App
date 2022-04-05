using RentMe_App.Controller;
using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentMe_App.View.AdminModals
{
    /// <summary>
    /// Class for employee editing modal.
    /// </summary>
    public partial class EditEmployeeModal : Form
    {
        #region Data Members

        private readonly Employee _employee;
        private readonly EmployeeController _employeeController;
        private readonly StatesController _statesController;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for class.
        /// </summary>
        public EditEmployeeModal(Employee employee)
        {
            InitializeComponent();
            _employee = employee ?? throw new ArgumentNullException(nameof(employee));
            _employeeController = new EmployeeController();
            new LoginController();
            _statesController = new StatesController();
            PopulateFields();
        }

        #endregion

        #region Methods

        private void UpdateButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                Validation();

                var editedEmployee = new Employee()
                {
                    FName = fNameTextBox.Text,
                    LName = lNameTextBox.Text,
                    Sex = sexComboBox.SelectedValue.ToString(),
                    Address1 = address1TextBox.Text,
                    Address2 = address2TextBox.Text,
                    City = cityTextBox.Text,
                    State = stateComboBox.SelectedValue.ToString(),
                    Zip = zipTextBox.Text,
                    BirthDate = dateTimePicker.Value,
                    Phone = RemovePhoneSpecialCharacters(phoneTextBox.Text),
                    Password = passwordTextBox.Text,
                    IsActive = activeCheckbox.Checked
                };
                _employeeController.UpdateEmployee(_employee, editedEmployee);
                errorLabel.Text = "Employee updated!";
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }

        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            fNameTextBox.Text = "";
            lNameTextBox.Text = "";
            sexComboBox.SelectedIndex = 0;
            address1TextBox.Text = "";
            address2TextBox.Text = "";
            cityTextBox.Text = "";
            stateComboBox.SelectedIndex = 0;
            zipTextBox.Text = "";
            dateTimePicker.Value = DateTime.Today;
            phoneTextBox.Text = "";
            passwordTextBox.Text = "";
            activeCheckbox.Checked = false;
            errorLabel.Text = "";
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void PopulateFields()
        {
            fNameTextBox.Text = _employee.FName;
            lNameTextBox.Text = _employee.LName;
            var sex = new List<string>() { "--Select--", "female", "male", "other" };
            sexComboBox.DataSource = new BindingSource(sex, null);
            sexComboBox.SelectedItem = _employee.Sex;

            address1TextBox.Text = _employee.Address1;
            address2TextBox.Text = _employee.Address2;
            cityTextBox.Text = _employee.City;

            var states = new List<string>() { "--Select--" };
            states.AddRange(_statesController.GetStatesList().StatesList);
            stateComboBox.DataSource = new BindingSource(states, null);
            stateComboBox.SelectedItem = _employee.State;
            zipTextBox.Text = _employee.Zip;

            dateTimePicker.Value = _employee.BirthDate;

            phoneTextBox.Text = _employee.Phone;

            passwordTextBox.Text = "";
            confirmPasswordTextBox.Text = "";

            activeCheckbox.Checked = _employee.IsActive;
        }

        private void Validation()
        {
            if (fNameTextBox.Text == "" ||
            lNameTextBox.Text == "" ||
            sexComboBox.SelectedIndex == 0 ||
            address1TextBox.Text == "" ||
            cityTextBox.Text == "" ||
            stateComboBox.SelectedIndex == 0 ||
            zipTextBox.Text == "" ||
            phoneTextBox.Text == "")
            {
                throw new ArgumentException("Must populate required fields");
            }
            else if (!IsPhoneNumber(phoneTextBox.Text))
            {
                throw new ArgumentException("Invalid phone number");
            }
            else if (passwordTextBox.Text != "" && passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                throw new ArgumentException("Make sure your password fields match");
            }
        }

        private static bool IsPhoneNumber(string phone)
        {
            if (string.IsNullOrEmpty(phone))
            {
                throw new ArgumentException("Invalid phone number");
            }
            else
            {
                Match phoneMatch = Regex.Match(phone, @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$");
                return phoneMatch.Success;
            }
        }

        private string RemovePhoneSpecialCharacters(string phone)
        {
            var stringPhone = phone;
            var charactersToRemove = new string[] { " ", ".", "-", ")", "(", "'" };
            foreach (var c in charactersToRemove)
            {
                stringPhone = stringPhone.Replace(c, string.Empty);
            }
            return stringPhone;
        }

        #endregion

        private void ClearError(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }
    }
}
