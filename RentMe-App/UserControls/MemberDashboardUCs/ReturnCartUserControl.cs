using RentMe_App.Controller;
using RentMe_App.Model;
using RentMe_App.View.MemberModals;
using System;
using System.Data;
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

            Cart.Return.EmployeeID = SharedFormInfo.EmployeeIDForm;

            Cart.Return.MemberID = SharedFormInfo.MemberIDForm;

            ReturnsDataGridView.DataSource = null;

            if (Cart.Return != null && Cart.Return.ReturnedFurniture.Count > 0)
            {
                _DataTable = new DataTable();

                _DataTable.Columns.Add(new DataColumn("ID", typeof(int)));
                _DataTable.Columns.Add(new DataColumn("Name", typeof(string)));
                _DataTable.Columns.Add(new DataColumn("Qty to Return", typeof(int)));
                _DataTable.Columns.Add(new DataColumn("Balance/Fine", typeof(decimal)));

                ReturnCountValueLabel.Text = Cart.Return.TotalItems.ToString();
                ReturnBalanceValueLabel.Text = Cart.Return.TotalRate.ToString();

                foreach (FurnitureInventory item in Cart.Return.ReturnedFurniture)
                {
                    DataRow row = _DataTable.NewRow();

                    row["ID"] = item.FurnitureID;
                    row["Name"] = item.Name;
                    row["Qty to Return"] = item.Quantity;
                    row["Balance/Fine"] = item.Daily_Rental_Rate;

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

            FurnitureInventory selectedItem = new FurnitureInventory
            { FurnitureID = 1
            , Name = "Test Furniture"
            , Description = "Just a test Chic Bed"
            , Style_Name = "Chic"
            , Category_Name = "Bed"
            , Daily_Rental_Rate = 10.0M
            , Quantity = 4
            };

            return selectedItem;
        }
        #endregion

        #region Event Listeners
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
                _ReturnController.CompleteReturn(Cart.Return);
                MessageBox.Show("Return successfully processed.", "Success");
                Cart.ClearReturns();
                UpdateElements();
            }
            catch (Exception err)
            {
                ErrorMessage.Text = err.Message;
                ErrorMessage.Show();
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
        #endregion
    }
}
