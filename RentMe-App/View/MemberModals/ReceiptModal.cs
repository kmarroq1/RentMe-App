﻿using RentMe_App.Model;
using System.Windows.Forms;

namespace RentMe_App.View.MemberModals
{
    public partial class ReceiptModal : Form
    {
        #region Fields
        private readonly Return _transaction;
        #endregion

        #region Constructors
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
