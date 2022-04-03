using RentMe_App.Controller;
using RentMe_App.Model;
using System;
using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    /// <summary>
    /// User control for registering new Members in the db
    /// </summary>
    public partial class AddMemberUserControl : UserControl
    {
        private readonly MemberController _memberController;

        /// <summary>
        /// Initializes the UserControl's components and controller.
        /// </summary>
        public AddMemberUserControl()
        {
            InitializeComponent();
            _memberController = new MemberController();
        }

        /// <summary>
        /// Clears the fields in the user details.
        /// </summary>
        public void ClearFields()
        {
            memberDetailsUserControl.ClearFields();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Member newMember = memberDetailsUserControl.Member;

                if (newMember.Fname == null
                || newMember.Lname == null
                || newMember.Phone == null
                || newMember.Address1 == null
                || newMember.City == null
                || newMember.State == null
                || newMember.Zip == null
                ) throw new InvalidOperationException("Form missing required fields.");

                _memberController.AddMember(newMember);
                
                MessageBox.Show($"Successfully added {newMember.Fname} {newMember.Lname}.", "New Member Registered");
            }
            catch (Exception ex)
            {
                errorMessageLabel.Text = ex.Message;
                errorMessageLabel.Show();
            }
        }
    }
}
