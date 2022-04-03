using RentMe_App.Controller;
using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    public partial class AddMemberUserControl : UserControl
    {
        private readonly MemberController _memberController;

        public AddMemberUserControl()
        {
            InitializeComponent();
            _memberController = new MemberController();
        }

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
                _memberController.AddMember(newMember);
            } catch (Exception ex)
            {
                errorMessageLabel.Text = ex.Message;
                errorMessageLabel.Show();
            }
        }
    }
}
