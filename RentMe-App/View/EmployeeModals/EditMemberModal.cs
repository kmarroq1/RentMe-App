﻿using RentMe_App.Controller;
using RentMe_App.Model;
using System;
using System.Windows.Forms;

namespace RentMe_App.View
{
    /// <summary>
    /// Displays the dialog to edit the selected Member.
    /// </summary>
    public partial class EditMemberModal : Form
    {
        private readonly MemberController _memberController;
        private readonly Member _oldMember;

        /// <summary>
        /// Initializes the Modal's components & fills Member fields with Member info.
        /// </summary>
        /// <param name="memberToEdit">The member to edit</param>
        public EditMemberModal(Member memberToEdit)
        {
            InitializeComponent();
            _memberController = new MemberController();
            _oldMember = memberToEdit;
            MemberDetailsUserControl.Member = memberToEdit;
        }

        private void ShowError(string message)
        {
            ErrorMessage.Text = message;
            ErrorMessage.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Member newMember = MemberDetailsUserControl.Member;
                newMember.MemberID = _oldMember.MemberID;

                _memberController.UpdateMember(_oldMember, newMember);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}
