using RentMe_App.Model;
using System.Drawing;
using System.Windows.Forms;

namespace RentMe_App.View.MemberModals
{
    /// <summary>
    /// Displays a transation receipt.
    /// 
    /// Currently only used for Returns...
    /// </summary>
    public partial class ReceiptModal : Form
    {
        #region Fields
        private readonly Return _transaction;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructs a Receipt modal.
        /// Initializing its components and dynamic fields.
        /// </summary>
        /// <param name="transaction">The transaction to display.</param>
        public ReceiptModal(Return transaction)
        {
            _transaction = transaction;

            InitializeComponent();
            
            Text += "Return Receipt";

            TransactionTypeHeaderLabel.Text = "Return";

            MemberIDValueLabel.Text = _transaction.MemberID.ToString();

            MemberNameValueLabel.Text = SharedFormInfo.MemberName;

            ReturnTransactionIDValueLabel.Text = _transaction.RentalID.ToString();

            TransactionDateValueLabel.Text = _transaction.TransactionDate.ToShortDateString();

            DisplayItems();

            if (_transaction.Balance < 0)
            {
                TotalTypeLabel.Text = "Fees:";
                TotalAmountLabel.ForeColor = Color.Red;
            }
            else
            {
                TotalTypeLabel.Text = "Refund:";
                TotalAmountLabel.ForeColor = Color.Green;
            }

            TotalAmountLabel.Text = _transaction.Balance.ToString("C");
        }
        #endregion

        #region Methods
        private void DisplayItems()
        {
            ItemizationTextBox.Text = "";

            foreach (FurnitureInventory item in _transaction.ReturnedFurniture)
            {
                ItemizationTextBox.Text += $"{item.Quantity} x {item.Name} (daily rate per item: {item.Daily_Rental_Rate:C})\n";
            }
        }
        #endregion

        #region Event Handlers
        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
