using RentMe_App.Controller;
using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    public partial class MemberDetailsUserControl : UserControl
    {
        private readonly MemberController _memberController;

        public MemberDetailsUserControl()
        {
            InitializeComponent();
            _memberController = new MemberController();
        }

        public void ClearFields()
        {
            memberBindingSource.Clear();
        }

        public BindingSource Member
        {
            get => memberBindingSource;
        }
    }
}
