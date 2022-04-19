using RentMe_App.Controller;
using RentMe_App.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace RentMe_App.UserControls.MemberDashboardUCs
{
    public partial class ReturnCartUserControl : UserControl
    {
        private DataTable _DataTable;
        private readonly ReturnController _ReturnController;

        public ReturnCartUserControl()
        {
            InitializeComponent();
            _ReturnController = new ReturnController();
        }

        public void UpdateElements()
        {
            ErrorMessage.Hide();

            Cart.Return.EmployeeID = 1; // FIXME!!!

            Cart.Return.MemberID = SharedFormInfo.MemberIDForm;

            ReturnsDataGridView.DataSource = null;

            _DataTable = new DataTable();

            _DataTable.Columns.Add(new DataColumn("ID", typeof(int)));
            _DataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            _DataTable.Columns.Add(new DataColumn("Qty to Return", typeof(int)));
            _DataTable.Columns.Add(new DataColumn("Balance/Fine", typeof(decimal)));

            if (Cart.Return != null)
            {
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
            }
            else
            {
                ReturnCountValueLabel.Text = "";
                ReturnBalanceValueLabel.Text = "";
            }

            ReturnsDataGridView.DataSource = _DataTable;
        }

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

        private void ViewReturnItemButton_Click(object sender, EventArgs e)
        {
            Cart.Return.ReturnedFurniture.Add(new FurnitureInventory
            { FurnitureID = 1
            , Name = "Test furniture"
            , Quantity = 3
            , Daily_Rental_Rate = 10.0M
            });
            UpdateElements();
        }
    }
}
