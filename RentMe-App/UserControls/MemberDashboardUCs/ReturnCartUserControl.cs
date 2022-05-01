using RentMe_App.Controller;
using RentMe_App.Model;
using RentMe_App.View.MemberModals;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RentMe_App.UserControls.MemberDashboardUCs
{
    /// <summary>
    /// Displays the items queued to be returned.
    /// Allows the user to update the item quantities,
    /// remove items, and complete the return transaction.
    /// </summary>
    public partial class ReturnCartUserControl : UserControl
    {
        #region Fields
        private DataTable _DataTable;
        private readonly ReturnController _ReturnController;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates the ReturnCart UserControl,
        /// initializing its components & controller.
        /// </summary>
        public ReturnCartUserControl()
        {
            InitializeComponent();
            _ReturnController = new ReturnController();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Sets the Error Message to the given value and shows it.
        /// </summary>
        /// <param name="message">The message to display.</param>
        public void ShowErrorMessage(string message)
        {
            ErrorMessage.Text = message;
            ErrorMessage.Show();
        }

        /// <summary>
        /// Sync grid to cart & hide error message.
        /// </summary>
        public void UpdateElements()
        {
            ErrorMessage.Hide();
            UpdateItemButton.Enabled = false;
            DeleteItemButton.Enabled = false;

            Cart.Return.EmployeeID = SharedFormInfo.EmployeeIDForm;

            Cart.Return.MemberID = SharedFormInfo.MemberIDForm;

            ReturnsDataGridView.DataSource = null;

            if (Cart.Return != null && Cart.Return.ReturnedFurniture.Count > 0)
            {
                _DataTable = new DataTable();

                _DataTable.Columns.Add(new DataColumn("ID", typeof(int)));
                _DataTable.Columns.Add(new DataColumn("Name", typeof(string)));
                _DataTable.Columns.Add(new DataColumn("Qty to Return", typeof(int)));
                _DataTable.Columns.Add(new DataColumn("Daily Rate", typeof(string)));
                _DataTable.Columns.Add(new DataColumn("Days until Due", typeof(int)));
                _DataTable.Columns.Add(new DataColumn("Effect on Balance", typeof(string)));

                ReturnCountValueLabel.Text = Cart.Return.TotalItems.ToString();

                if (Cart.Return.Balance < 0)
                {
                    ReturnBalanceLabelLabel.Text = "Fees:";
                    ReturnBalanceValueLabel.ForeColor = Color.Red;
                }
                else
                {
                    ReturnBalanceLabelLabel.Text = "Refund:";
                    ReturnBalanceValueLabel.ForeColor = Color.Green;
                }
                ReturnBalanceValueLabel.Text = Cart.Return.Balance.ToString("C");

                foreach (FurnitureInventory item in Cart.Return.ReturnedFurniture)
                {
                    DataRow row = _DataTable.NewRow();

                    row["ID"] = item.FurnitureID;
                    row["Name"] = item.Name;
                    row["Qty to Return"] = item.Quantity;
                    row["Daily Rate"] = item.Daily_Rental_Rate.ToString("C");
                    row["Days until Due"] = item.DueDate.Date.Subtract(DateTime.Today).Days;
                    row["Effect on Balance"] = (item.Daily_Rental_Rate * item.DueDate.Date.Subtract(DateTime.Today).Days).ToString("C");

                    _DataTable.Rows.Add(row);
                }

                ReturnsDataGridView.DataSource = _DataTable;
            }
            else
            {
                ReturnCountValueLabel.Text = "";
                ReturnBalanceValueLabel.Text = "";
            }

        }

        private FurnitureInventory GetSelectedItem()
        {
            if (ReturnsDataGridView.SelectedRows.Count != 1)
                throw new ArgumentException("Please select a row");

            return Cart.Return.GetItemByID(Convert.ToInt32(ReturnsDataGridView.SelectedRows[0].Cells["ID"].Value));
        }
        #endregion

        #region Event Handlers
        private void ReturnCartUserControl_Load(object sender, EventArgs e)
        {
            UpdateElements();
        }

        private void ClearReturnsButton_Click(object sender, EventArgs e)
        {
            Cart.ClearReturns();
            UpdateElements();
        }

        private void CompleteReturnButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cart.Return.TransactionDate = DateTime.Now;
                _ReturnController.CompleteReturn(Cart.Return);
                new ReceiptModal(Cart.Return).ShowDialog();
                Cart.ClearReturns();
                UpdateElements();
            }
            catch (Exception err)
            {
                ErrorMessage.Text = err.Message;
                ErrorMessage.Show();
            }
        }

        private void ReturnsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ReturnsDataGridView.CurrentRow != null)
            {
                UpdateItemButton.Enabled = true;
                ReturnsDataGridView.CurrentRow.Selected = true;
                ErrorMessage.Hide();
                UpdateItemButton.Enabled = true;
                DeleteItemButton.Enabled = true;
            }
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {
            if (ReturnsDataGridView.SelectedRows.Count != 1)
            {
                UpdateItemButton.Enabled = false;

                return;
            }

            try
            {
                new ItemDetailsModal(GetSelectedItem(), true).ShowDialog();
                UpdateElements();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
        
        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            if (ReturnsDataGridView.SelectedRows.Count != 1)
            {
                DeleteItemButton.Enabled = false;

                return;
            }

            try
            {
                Cart.Return.ReturnedFurniture.Remove(GetSelectedItem());
                UpdateElements();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
        #endregion

    }
}
