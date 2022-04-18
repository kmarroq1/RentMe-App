using RentMe_App.Model;
using System.Windows.Forms;

namespace RentMe_App.UserControls.MemberDashboardUCs
{
    public partial class ReturnCartUserControl : UserControl
    {
        public ReturnCartUserControl()
        {
            InitializeComponent();
        }

        public void UpdateElements()
        {
            if (Cart.Return != null)
            {
                ReturnCountValueLabel.Text = Cart.Return.TotalItems.ToString();
                ReturnBalanceValueLabel.Text = Cart.Return.TotalRate.ToString();
            }
            else
            {
                ReturnCountValueLabel.Text = "";
                ReturnBalanceValueLabel.Text = "";
            }
        }

        private void ReturnCartUserControl_Load(object sender, System.EventArgs e)
        {
            UpdateElements();
        }
    }
}
