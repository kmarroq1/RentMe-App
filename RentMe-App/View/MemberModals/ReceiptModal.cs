using RentMe_App.Model;
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

            RentalTransactionIDValueLabel.Text = _transaction.RentalID.ToString();

            TransactionDateValueLabel.Text = _transaction.TransactionDate.ToShortDateString();

            DisplayItems();

            DueDateValueLabel.Text = _transaction.ReturnDate.ToShortDateString();

            TotalTypeLabel.Text = "Balance";

            TotalAmountLabel.Text = _transaction.TotalRate.ToString("C");
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
