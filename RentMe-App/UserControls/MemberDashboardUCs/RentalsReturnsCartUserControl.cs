using RentMe_App.Model;
using System.Windows.Forms;

namespace RentMe_App.UserControls.MemberDashboardUCs
{
    public partial class RentalsReturnsCartUserControl : UserControl
    {
        public RentalsReturnsCartUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates the carts to reflect the static Cart object.
        /// </summary>
        public void RefreshData()
        {
            if (Cart.Rental != null)
            {
                RentalCountValueLabel.Text = Cart.Rental.TotalItemsInCart.ToString();
                RentalTotalValueLabel.Text = Cart.Rental.TotalRentalRate.ToString();
            }
            else
            {
                RentalCountValueLabel.Text = "";
                RentalTotalValueLabel.Text = "";
            }
        }

        private void RentalsReturnsCartUserControl_Load(object sender, System.EventArgs e)
        {
            RefreshData();
        }
    }
}
