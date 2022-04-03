using RentMe_App.Model;
using System;
using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    public partial class MemberDetailsUserControl : UserControl
    {
        public MemberDetailsUserControl()
        {
            InitializeComponent();
        }

        public void ClearFields()
        {
            memberBindingSource.Clear();
            birthDateDateTimePicker.Value = DateTime.Now;
        }

        public Member Member
        {
            get
            {
                Member newMember = new Member
                { Fname = fnameTextBox.Text
                , Lname = lnameTextBox.Text
                , BirthDate = birthDateDateTimePicker.Value
                , Phone = phoneTextBox.Text
                , Active = activeCheckBox.Checked
                , Address1 = address1TextBox.Text
                , City = cityTextBox.Text
                // , State = stateComboBox.SelectedText
                , Zip = zipTextBox.Text
                };

                if (!string.IsNullOrWhiteSpace(address2TextBox.Text))
                    newMember.Address2 = address2TextBox.Text;

                return newMember;
            }
            set => memberBindingSource.DataSource = value;
        }
    }
}
