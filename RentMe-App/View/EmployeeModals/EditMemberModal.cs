using RentMe_App.Model;
using System.Windows.Forms;

namespace RentMe_App.View
{
    /// <summary>
    /// Displays the dialog to edit the selected Member.
    /// </summary>
    public partial class EditMemberModal : Form
    {
        /// <summary>
        /// Initializes the Modal's components & fills Member fields with Member info.
        /// </summary>
        /// <param name="memberToEdit">The member to edit</param>
        public EditMemberModal(Member memberToEdit)
        {
            InitializeComponent();
            MemberDetailsUserControl.Member = memberToEdit;
        }
    }
}
