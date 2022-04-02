using RentMe_App.Controller;
using RentMe_App.Model;
using System;
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
            PopulateFields();
        }

        #endregion

        #region Methods

        private void UpdateButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                //Make sure employee wasn't changed before updating
                _employeeController.UpdateEmployee(_employee);
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

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void PopulateFields()
        {
            fNameTextBox.Text = _employee.FName;
            lNameTextBox.Text = _employee.LName;
            sexTextBox.Text = _employee.Sex;
            address1TextBox.Text = _employee.Address1;
            address2TextBox.Text = _employee.Address2;
            cityTextBox.Text = _employee.City;
            //stateComboBox.SelectedIndex = _employee.State;
            zipTextBox.Text = _employee.Zip;
            dateTimePicker.Value = _employee.BirthDate;
            phoneTextBox.Text = _employee.Phone;
            //passwordTextBox.Text = _login.Password;
            activeCheckbox.Checked = _employee.IsActive;
        }

        #endregion

    }
}
