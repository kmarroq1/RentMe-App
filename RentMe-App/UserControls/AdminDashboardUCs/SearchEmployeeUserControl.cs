using RentMe_App.Controller;
using RentMe_App.Model;
using RentMe_App.View.AdminModals;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    /// <summary>
    /// User control for employee search.
    /// </summary>
    public partial class SearchEmployeeUserControl : UserControl
    {
        #region Data Members

        private readonly EmployeeController _employeeController;
        private List<Employee> _employeeList;
        private Employee _selectedEmployee;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for class.
        /// </summary>
        public SearchEmployeeUserControl()
        {
            InitializeComponent();
            EditButton.Enabled = false;
            _employeeController = new EmployeeController();
            _employeeList = new List<Employee>();
        }

        #endregion

        #region Methods

        private void SearchButton_Click(object sender, EventArgs e)
        {
            employeeSearchGridView.DataSource = null;
            employeeSearchGridView.Rows.Clear();

            try
            {
                if (!string.IsNullOrEmpty(idTextBox.Text) && int.Parse(idTextBox.Text) > 0)
                {
                    _employeeList = _employeeController.GetEmployeeById(int.Parse(idTextBox.Text));
                }
                else if (!string.IsNullOrEmpty(fNameTextBox.Text) && !string.IsNullOrEmpty(lNameTextBox.Text))
                {
                    _employeeList = _employeeController.GetEmployeeByName(fNameTextBox.Text, lNameTextBox.Text);
                }
                else if (!string.IsNullOrEmpty(phoneTextBox.Text) && IsPhoneNumber(phoneTextBox.Text))
                {
                    _employeeList = _employeeController.GetEmployeeByPhone(RemovePhoneSpecialCharacters(phoneTextBox.Text));
                }

                else if (!string.IsNullOrEmpty(idTextBox.Text) && int.Parse(idTextBox.Text) < 0)
                {
                    errorLabel.Text = "Employee ID must be a positive number";
                    return;
                }
                else if ((string.IsNullOrEmpty(fNameTextBox.Text) && !string.IsNullOrEmpty(lNameTextBox.Text)) ||
                         (!string.IsNullOrEmpty(fNameTextBox.Text) && string.IsNullOrEmpty(lNameTextBox.Text)))
                {
                    errorLabel.Text = "Search by name requires both values";
                    return;
                }
                else if (!string.IsNullOrEmpty(phoneTextBox.Text) && !IsPhoneNumber(phoneTextBox.Text))
                {
                    errorLabel.Text = "Invalid phone number";
                    return;
                }
                else
                {
                    errorLabel.Text = "Enter a value for ID, First/Last Name, or Phone # fields";
                    return;
                }
            }
            catch (FormatException)
            {
                errorLabel.Text = "Employee ID must be a positive number";
                return;
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
                return;
            }

            RefreshData();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            fNameTextBox.Clear();
            lNameTextBox.Clear();
            idTextBox.Clear();
            phoneTextBox.Clear();
            errorLabel.Text = "";
            infoLabel.Text = "";
            employeeSearchGridView.DataSource = null;
            employeeSearchGridView.Rows.Clear();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                var employeeID = int.Parse(employeeSearchGridView.SelectedRows[0].Cells["IDColumn"].Value.ToString());
                _selectedEmployee = _employeeList.Find(x => x.EmployeeId == employeeID);
                EditEmployeeModal newForm = new EditEmployeeModal(_selectedEmployee);

                employeeSearchGridView.DataSource = null;
                employeeSearchGridView.Rows.Clear();
                EditButton.Enabled = false;

                newForm.ShowDialog();
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEmployeeModal newForm = new AddEmployeeModal();
            employeeSearchGridView.DataSource = null;
            employeeSearchGridView.Rows.Clear();
            infoLabel.Text = "";
            newForm.ShowDialog();
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditButton.Enabled = employeeSearchGridView.SelectedRows.Count == 1;
            infoLabel.Text = "";
            errorLabel.Text = "";
            employeeSearchGridView.CurrentRow.Selected = true;
        }

        private void RefreshData()
        {
            if (_employeeList == null || _employeeList.Count == 0)
            {
                errorLabel.Text = "No employees found...";
                return;
            }

            employeeSearchGridView.DataSource = null;
            employeeSearchGridView.Rows.Clear();

            try
            {
                foreach (Employee employee in _employeeList)
                {
                    employeeSearchGridView.Rows.Add(employee.EmployeeId, employee.Name, employee.Address,
                        employee.City, employee.State, employee.Phone, employee.BirthDate.ToShortDateString(), employee.IsActive);
                }

                infoLabel.Text = "Tip: Select a row to edit";
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message + ": Invalid employee";
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

        private void ClearErrorAndNonNameFields(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            idTextBox.Text = "";
            phoneTextBox.Text = "";
        }

        private void ClearErrorAndNonIdFields(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            fNameTextBox.Text = "";
            lNameTextBox.Text = "";
            phoneTextBox.Text = "";
        }

        private void ClearErrorAndNonPhoneFields(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            fNameTextBox.Text = "";
            lNameTextBox.Text = "";
            idTextBox.Text = "";
        }

        #endregion

        private void EmployeeSearchGridView_SelectionChanged(object sender, EventArgs e)
        {
            EditButton.Enabled = employeeSearchGridView.SelectedRows.Count == 1;
        }
    }
}
