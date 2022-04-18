using RentMe_App.Model;
using RentMe_App.UserControls.MemberDashboardUCs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe_App.View.EmployeeModals
{
    /// <summary>
    /// Defines a form that allows employee to view order details
    /// </summary>
    public partial class ViewOrderModal : Form
    {
        #region Data Members

        private List<Furniture> _furnitureList;
        private readonly OrdersController ordersController;
        private readonly Order currentOrder;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public ViewOrderModal(Order selectedOrder)
        {
            InitializeComponent();
            ordersController = new OrdersController();
            currentOrder = selectedOrder;
            PopulateGridView();
        }

        #endregion

        #region Methods

        private void RentAgainButton_Click(object sender, System.EventArgs e)
        {
            //check to see if there's any available in the inventory
            //add to rental cart
        }

        private void ReturnButton_Click(object sender, System.EventArgs e)
        {
            //add condition for if item has already been returned
            //add option to choose quantity to return
            Cart.Return.ReturnedFurniture.Add(CreateReturnItem());
        }

        private FurnitureInventory CreateReturnItem()
        {
            var selectedItem = _furnitureList.Find(x => x.FurnitureID == int.Parse(furnitureOrderedDataGridView.SelectedRows[0].Cells["FurnitureID"].Value.ToString()));
            return new FurnitureInventory
            {
                FurnitureID = (int)selectedItem.FurnitureID,
                Name = selectedItem.Name,
                Description = selectedItem.Description,
                Daily_Rental_Rate = selectedItem.Daily_Rental_Rate,
                Daily_Fine_Rate = selectedItem.Daily_Fine_Rate,
                Style_Name = selectedItem.Style_Name,
                Category_Name = selectedItem.Category_Name,
                Image_Small_Url = selectedItem.Image_Small_Url,
                Image_Large_Url = selectedItem.Image_Large_Url,
                Quantity = 1,
            };
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void PopulateGridView()
        {
            try
            {
                Order updatedOrder = ordersController.GetOrderFurnitureList(currentOrder);
                _furnitureList = updatedOrder.FurnitureList;
                foreach (var furniture in _furnitureList)
                {
                    furnitureOrderedDataGridView.Rows.Add(furniture.FurnitureID, furniture.Image_Small_Url, furniture.Name, currentOrder.OrderDate, 0, 0, furniture.Daily_Rental_Rate, currentOrder.Balance);
                }
            }
            catch (Exception exception)
            {
                var error = exception.Message;
            }
        }

        #endregion

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorLabel.Text = "";
            ReturnButton.Enabled = true;
            furnitureOrderedDataGridView.CurrentRow.Selected = true;
        }
    }
}
