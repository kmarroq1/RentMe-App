using RentMe_App.Controller;
using RentMe_App.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentMe_App.View.AdminModals
{
    /// <summary>
    /// Class for employee adding modal.
    /// </summary>
    public partial class AddEmployeeModal : Form
    {
        #region Data Members

        private readonly EmployeeController _employeeController;
        private readonly StatesController _statesController;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for class.
        /// </summary>
        public AddEmployeeModal()
        {
            InitializeComponent();
            _employeeController = new EmployeeController();
            _statesController = new StatesController();
            PopulateFields();
        }

        #endregion

        #region Methods

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Validation();
                Employee newEmployee = new Employee()
                {
                    FName = fNameTextBox.Text,
                    LName = lNameTextBox.Text,
                    Sex = sexTextBox.Text,
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
                _employeeController.AddEmployee(newEmployee);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            fNameTextBox.Text = "";
            lNameTextBox.Text = "";
            sexTextBox.Text = "";
            address1TextBox.Text = "";
            address2TextBox.Text = "";
            cityTextBox.Text = "";
            stateComboBox.SelectedIndex = -1;
            zipTextBox.Text = "";
            dateTimePicker.Value = DateTime.Today;
            phoneTextBox.Text = "";
            passwordTextBox.Text = "";
            activeCheckbox.Checked = false;
            errorLabel.Text = "";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Validation()
        {
            if (fNameTextBox.Text == "" ||
                lNameTextBox.Text == "" ||
                sexTextBox.Text == "" ||
                address1TextBox.Text == "" ||
                cityTextBox.Text == "" ||
                stateComboBox.SelectedIndex == -1 ||
                zipTextBox.Text == "" ||
                phoneTextBox.Text == "" ||
                passwordTextBox.Text == "" ||
                confirmPasswordTextBox.Text == "")
            {
                throw new ArgumentException("Must populate required fields");
            }
            else if (!IsPhoneNumber(phoneTextBox.Text))
            {
                throw new ArgumentException("Invalid phone number");
            }
            else if (passwordTextBox.Text != "" && passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                throw new ArgumentException("Password confirmation does not match entered password");
            }
        }

        private void PopulateFields()
        {
            var states = _statesController.GetStatesList().StatesList;
            stateComboBox.DataSource = new BindingSource(states, null);

            activeCheckbox.Enabled = true;
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

    }
}
