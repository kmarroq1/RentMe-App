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
        private int _selectedEmployeeId;

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
            _selectedEmployeeId = 0;
        }

        #endregion

        #region Methods

        private void SearchButton_Click(object sender, EventArgs e)
        {
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
                    _employeeList = _employeeController.GetEmployeeByPhone(phoneTextBox.Text);
                }
                else if (!string.IsNullOrEmpty(idTextBox.Text) && int.Parse(idTextBox.Text) < 0)
                {
                    errorLabel.Text = "Employee ID must be a positive number";
                }
                else if ((string.IsNullOrEmpty(fNameTextBox.Text) && !string.IsNullOrEmpty(lNameTextBox.Text)) ||
                         (!string.IsNullOrEmpty(fNameTextBox.Text) && string.IsNullOrEmpty(lNameTextBox.Text)))
                {
                    errorLabel.Text = "Search by name requires both values";
                }
                else if (!string.IsNullOrEmpty(phoneTextBox.Text) && !IsPhoneNumber(phoneTextBox.Text))
                {
                    errorLabel.Text = "Invalid phone number";
                }
                else
                {
                    errorLabel.Text = "Enter a value for ID, First/Last Name, or Phone # fields";
                }
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message + ": Invalid data";
            }

            if (_employeeList.Count == 0)
            {
                errorLabel.Text = "No employees found...";
            }
            else
            {
                RefreshData();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            fNameTextBox.Clear();
            lNameTextBox.Clear();
            idTextBox.Clear();
            phoneTextBox.Clear();
            employeeSearchGridView.DataSource = null;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedEmployeeId = int.Parse(employeeSearchGridView.SelectedRows[0].Cells["ID"].Value.ToString());
                EditEmployeeModal newForm = new EditEmployeeModal(_selectedEmployeeId);
                newForm.ShowDialog();
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message + ": Invalid row data";
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEmployeeModal newForm = new AddEmployeeModal();
            newForm.ShowDialog();
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditButton.Enabled = employeeSearchGridView.SelectedRows.Count == 1;
        }

        private void RefreshData()
        {
            employeeSearchGridView.DataSource = null;

            try
            {
                foreach (Employee employee in _employeeList)
                {
                    employeeSearchGridView.Rows.Add(employee.EmployeeId, employee.Name, employee.Address,
                        employee.City, employee.State, employee.Dob, employee.IsActive);
                }
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message + ": Invalid employee";
            }
        }

        private static bool IsPhoneNumber(string phone)
        {
            Match phoneMatch = Regex.Match(phone, @"^\(\d{3}\) \d{3}-\d{4}$");
            return phoneMatch.Success;
        }

        #endregion

    }
}
