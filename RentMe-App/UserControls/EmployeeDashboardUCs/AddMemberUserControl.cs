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
        public AddMemberUserControl()
        {
            InitializeComponent();
        }

        public void ClearFields()
        {
            memberDetailsUserControl.ClearFields();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
