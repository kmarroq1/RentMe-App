using RentMe_App.Controller;
using RentMe_App.Model;
using System;
using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    /// <summary>
    /// Contains fields to display Member details for registering and editing members.
    /// </summary>
    public partial class MemberDetailsUserControl : UserControl
    {
        private readonly StateController _stateController;

        /// <summary>
        /// Initializes UC's components & controller.
        /// </summary>
        public MemberDetailsUserControl()
        {
            InitializeComponent();
            _stateController = new StateController();
        }

        /// <summary>
        /// Clears all of the fields and resets the birth date field.
        /// </summary>
        public void ClearFields()
        {
            memberBindingSource.Clear();
            birthDateDateTimePicker.Value = DateTime.Now;
        }

        /// <summary>
        /// Dictates how the implicitly stored member is accessed and mutated.
        /// </summary>
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
                , State = stateComboBox.SelectedItem.ToString()
                , Zip = zipTextBox.Text
                };

                if (!string.IsNullOrWhiteSpace(address2TextBox.Text))
                    newMember.Address2 = address2TextBox.Text;

                return newMember;
            }
            set => memberBindingSource.DataSource = value;
        }

        private void MemberDetailsUserControl_Load(object sender, EventArgs e)
        {
            stateComboBox.Items.AddRange(_stateController.GetStateAbbreviations().ToArray());
        }
    }
}
