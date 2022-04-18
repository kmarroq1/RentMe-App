using RentMe_App.Controller;
using RentMe_App.Model;
using RentMe_App.View;
using RentMe_App.View.EmployeeModals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    /// <summary>
    /// user control class that encapsulates the search member controls
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public partial class SearchMemberUserControl : UserControl
    {
        #region Data members

        private readonly MemberController memberController;
        private List<Member> memberList;
        private DataTable dataTable;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the search furniture controls
        /// </summary>
        public SearchMemberUserControl()
        {
            InitializeComponent();
            memberController = new MemberController();

            ClearForm();
        }

        #endregion

        #region Methods

        private void RefreshSearchDataGrid()
        {
            HideErrorMessage();
            searchMemberDataGridView.DataSource = null;

            try
            {
                bool getMemberIDCheck = Int32.TryParse(memberIDTextBox.Text, out int memberID);
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string phone = phoneTextBox.Text;
                Match matchPhone = Regex.Match(phone, @"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$");

                memberList = new List<Member>();

                if (getMemberIDCheck == true && memberID > 0)
                {
                    memberList = memberController.GetMemberByID(memberID);
                    CheckMemberFound(memberList);
                }
                else if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
                {
                    memberList = memberController.GetMemberByName(firstName, lastName);
                    CheckMemberFound(memberList);
                }
                else if (matchPhone.Success)
                {
                    memberList = memberController.GetMemberByPhone(RemovePhoneSpecialCharacters(phone));
                    CheckMemberFound(memberList);
                }
                else if (!string.IsNullOrEmpty(phone) && !matchPhone.Success)
                {
                    string errorMessage = "Phone number contains 10 digits";
                    ShowErrorMessage(errorMessage);
                }
                else if (getMemberIDCheck == true && memberID <= 0)
                {
                    string errorMessage = "Member ID must be greater than 0";
                    ShowErrorMessage(errorMessage);
                }
                else if (getMemberIDCheck == false && memberIDTextBox.Text.Length > 0)
                {
                    string errorMessage = "Member ID must be number";
                    ShowErrorMessage(errorMessage);
                }
                else if ((string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName)) ||
                    (!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName)))
                {
                    string errorMessage = "Search by name requires both values";
                    ShowErrorMessage(errorMessage);
                }
                else
                {
                    ShowErrorMessage("Selection must be made to return result");
                }
            }
            catch (Exception)
            {
                ShowErrorMessage("Invalid Logic");
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

        private void CheckMemberFound(List<Member> memberList)
        {
            if (memberList.Count > 0)
            {
                BuildDataGridView();
            }
            else
            {
                ShowErrorMessage("No member found");
            }
        }

        private int GetAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }

        private void BuildDataGridView()
        {
            searchMemberDataGridView.DataSource = null;
            dataTable = new DataTable();
            string memberActive;

            dataTable.Columns.Add(new DataColumn("Member ID", typeof(int)));
            dataTable.Columns.Add(new DataColumn("First Name", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Last Name", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Address", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Phone", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Birth Date", typeof(DateTime)));
            dataTable.Columns.Add(new DataColumn("Active", typeof(string)));

            try
            {
                int age;
                memberActive = "No";

                foreach (Member go in memberList)
                {
                    DataRow row = dataTable.NewRow();
                    Member member = new Member
                    {
                        MemberID = go.MemberID,
                        Fname = go.Fname,
                        Lname = go.Lname,
                        Address1 = go.Address1,
                        Phone = go.Phone,
                        BirthDate = go.BirthDate,
                        Active = go.Active
                    };

                    if (go.Active == true)
                    {
                        memberActive = "Yes";
                    }

                    age = GetAge(member.BirthDate);

                    row["Member ID"] = member.MemberID;
                    row["First Name"] = member.Fname;
                    row["Last Name"] = member.Lname;
                    row["Address"] = member.Address1;
                    row["Phone"] = member.Phone;
                    row["Birth Date"] = member.BirthDate;
                    row["Active"] = memberActive;

                    dataTable.Rows.Add(row);
                }
            }
            catch (Exception)
            {
                ShowErrorMessage("Invalid Member");
            }

            searchMemberDataGridView.DataSource = dataTable;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            RefreshSearchDataGrid();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            searchMemberDataGridView.DataSource = null;
            ClearTextBoxes(memberIDTextBox, firstNameTextBox, lastNameTextBox, phoneTextBox);
            HideErrorMessage();
            editButton.Enabled = false;
            selectMemberButton.Enabled = false;
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Hide();
        }

        private void ClearTextBoxes(params TextBox[] textboxes)
        {
            foreach (TextBox textBox in textboxes) textBox.Clear();
        }

        private void MemberID_Enter(object sender, EventArgs e)
        {
            ClearTextBoxes(firstNameTextBox, lastNameTextBox, phoneTextBox);
            HideErrorMessage();
        }

        private void Phone_Enter(object sender, EventArgs e)
        {
            ClearTextBoxes(memberIDTextBox, firstNameTextBox, lastNameTextBox);
            HideErrorMessage();
        }

        private void Name_Enter(object sender, EventArgs e)
        {
            ClearTextBoxes(memberIDTextBox, phoneTextBox);
            HideErrorMessage();
        }

        private void SearchMemberDataGridView_VisibleChanged(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ShowErrorMessage(string message)
        {
            errorMessageLabel.Text = message;
            errorMessageLabel.Show();
        }
        #endregion

        #region Event Handlers
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (searchMemberDataGridView.SelectedRows.Count != 1)
            {
                ShowErrorMessage("Please select a member to edit.");
                return;
            }

            int selectedrowindex = searchMemberDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = searchMemberDataGridView.Rows[selectedrowindex];
            int selectedMemberID = Convert.ToInt32(selectedRow.Cells[0].Value);

            List<Member> selectedMember = memberController.GetMemberByID(selectedMemberID);

            EditMemberModal modal = new EditMemberModal(selectedMember[0]);

            modal.ShowDialog();

            RefreshSearchDataGrid();
        }

        private void SelectMemberButton_Click(object sender, EventArgs e)
        {
            if (searchMemberDataGridView.SelectedRows.Count != 1)
            {
                ShowErrorMessage("Please select a member to edit.");
                return;
            }

            Member selectedMember = memberController.GetMemberByID(Int32.Parse(Convert.ToString(searchMemberDataGridView.SelectedRows[0].Cells["Member ID"].Value)))[0];

            if (selectedMember.Active == false)
            {
                selectMemberButton.Enabled = searchMemberDataGridView.SelectedRows.Count == 1;
                ShowErrorMessage("Member must be active to process orders");
                return;
            }
            else
            {
                MainMemberForm mainMemberForm = new MainMemberForm(SharedFormInfo.MainEmployeeForm);
                SharedFormInfo.MemberIDForm = (int)selectedMember.MemberID;
                mainMemberForm.ShowDialog();
            }            

            RefreshSearchDataGrid();
        }

        private void SearchMemberDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            editButton.Enabled = searchMemberDataGridView.SelectedRows.Count == 1;
            selectMemberButton.Enabled = searchMemberDataGridView.SelectedRows.Count == 1;
        }

        private void SearchMemberDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectMemberButton.Enabled = true;
            searchMemberDataGridView.CurrentRow.Selected = true;
            HideErrorMessage();
        }
        #endregion
    }
}
