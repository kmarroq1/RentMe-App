using System;
using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    public partial class SearchEmployeeUserControl : UserControl
    {
        public SearchEmployeeUserControl()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

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

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
