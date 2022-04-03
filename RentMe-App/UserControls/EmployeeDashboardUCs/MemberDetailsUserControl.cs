using RentMe_App.Controller;
using RentMe_App.Interfaces;
using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    /// <summary>
    /// Contains fields to display Member details for registering and editing members.
    /// </summary>
    public partial class MemberDetailsUserControl : UserControl
    {
        #region Fields
        private readonly StatesController _statesController;
        private IHideErrorMessage _parentContainer;
        #endregion

        #region Properties
        /// <summary>
        /// Dictates how the implicitly stored member is accessed and mutated.
        /// </summary>
        public Member Member
        {
            get
            {
                Member newMember = new Member
                {
                    Fname = fnameTextBox.Text,
                    Lname = lnameTextBox.Text,
                    BirthDate = birthDateDateTimePicker.Value,
                    Phone = phoneTextBox.Text,
                    Active = activeCheckBox.Checked,
                    Address1 = address1TextBox.Text,
                    City = cityTextBox.Text,
                    Zip = zipTextBox.Text
                };

                if (stateComboBox.SelectedIndex > 0)
                    newMember.State = stateComboBox.SelectedItem.ToString();

                if (!string.IsNullOrWhiteSpace(address2TextBox.Text))
                    newMember.Address2 = address2TextBox.Text;

                return newMember;
            }
            set
            {
                fnameTextBox.Text = value.Fname;
                lnameTextBox.Text = value.Lname;
                birthDateDateTimePicker.Value = value.BirthDate;
                phoneTextBox.Text = value.Phone;
                activeCheckBox.Checked = value.Active;
                address1TextBox.Text = value.Address1;
                address2TextBox.Text = value.Address2;
                cityTextBox.Text = value.City;
                stateComboBox.SelectedIndex = stateComboBox.FindStringExact(value.State);
                zipTextBox.Text = value.Zip;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes UC's components & controller.
        /// </summary>
        public MemberDetailsUserControl()
        {
            InitializeComponent();
            _statesController = new StatesController();

            List<string> states = new List<string> { "--Select--" };
            states.AddRange(_statesController.GetStatesList().StatesList);
            stateComboBox.DataSource = new BindingSource(states, dataMember: null);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Clears all of the fields and resets the birth date field.
        /// </summary>
        public void ClearFields()
        {
            foreach (TextBox textBox in new TextBox[] { fnameTextBox, lnameTextBox, phoneTextBox, address1TextBox, address2TextBox, cityTextBox, zipTextBox })
                textBox.Clear();

            birthDateDateTimePicker.Value = new DateTime(1970, 1, 1, 0, 0, 0);
            activeCheckBox.Checked = true;
            stateComboBox.SelectedIndex = 0;
        }

        public void SetParentContainer(IHideErrorMessage container)
        {
            _parentContainer = container;
        }
        #endregion

        #region Event Handlers
        private void Field_Changed(object sender, EventArgs e)
        {
            if (_parentContainer != null) _parentContainer.HideErrorMessage();
        }
        #endregion
    }
}
