using System;
using System.Windows.Forms;
using RentMe_App.View.AdminModals;

namespace RentMe_App.UserControls
{
    /// <summary>
    /// User control for employee search.
    /// </summary>
    public partial class SearchEmployeeUserControl : UserControl
    {
        private readonly int selectedEmployeeID;

        /// <summary>
        /// Constructor for class.
        /// </summary>
        public SearchEmployeeUserControl()
        {
            InitializeComponent();
            EditButton.Enabled = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //get results
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            fNameTextBox.Clear();
            lNameTextBox.Clear();
            idTextBox.Clear();
            phoneTextBox.Clear();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                EditButton.Enabled = true;
            }

            EditEmployeeModal newForm = new EditEmployeeModal(selectedEmployeeID);
            newForm.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEmployeeModal newForm = new AddEmployeeModal();
        }
    }
}
