using RentMe_App.Model;
using RentMe_App.UserControls.MemberDashboardUCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RentMe_App.View.EmployeeModals
{
    /// <summary>
    /// Defines a form that allows employee to view order details
    /// </summary>
    public partial class ViewOrderModal : Form
    {
        #region Data Members

        private List<FurnitureInventory> _furnitureList;
        private readonly OrdersController ordersController;
        private readonly Order currentOrder;
        private FurnitureInventory selectedFurniture;
        private int furnitureRentalTransactionID;
        private double? totalBalance;

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
            ReturnButton.Enabled = false;
            furnitureRentalTransactionID = currentOrder.OrderType == "rental" ? currentOrder.TransactionID : (int)currentOrder.RentalTransactionID;
            PopulateGridView();
            PopulateData();
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
            try
            {
                Cart.Return.RentalID = furnitureRentalTransactionID;
                Cart.Return.ReturnedFurniture.Add(CreateReturnItem());
                Cart.Return.RentalID = currentOrder.OrderType == "rental" ? currentOrder.TransactionID : (int)currentOrder.RentalTransactionID;
                errorLabel.Text = "Added to cart!";
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private FurnitureInventory CreateReturnItem()
        {
            selectedFurniture = _furnitureList.Find(x => x.FurnitureID == int.Parse(furnitureOrderedDataGridView.SelectedRows[0].Cells["FurnitureID"].Value.ToString()));
            return new FurnitureInventory
            {
                FurnitureID = (int)selectedFurniture.FurnitureID,
                Name = selectedFurniture.Name,
                Description = selectedFurniture.Description,
                Daily_Rental_Rate = selectedFurniture.Daily_Rental_Rate,
                Daily_Fine_Rate = selectedFurniture.Daily_Fine_Rate,
                Style_Name = selectedFurniture.Style_Name,
                Category_Name = selectedFurniture.Category_Name,
                Image_Small_Url = selectedFurniture.Image_Small_Url,
                Image_Large_Url = selectedFurniture.Image_Large_Url,
                Quantity = ReturnQuantityValidation(),
                RentalTransactionID = furnitureRentalTransactionID,
            };
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private int ReturnQuantityValidation()
        {
            var enteredValue = (int)qtyReturnNumericUpDown.Value;
            var isInCart = Cart.Return.ReturnedFurniture.Any(x => x.FurnitureID == selectedFurniture.FurnitureID && x.RentalTransactionID == furnitureRentalTransactionID);
            var cartQuantity = 0;
            if (isInCart)
            {
                cartQuantity = Cart.Return.ReturnedFurniture.Find(x => x.FurnitureID == selectedFurniture.FurnitureID).Quantity;
            }
            var returnLimit = (selectedFurniture.QuantityRented - selectedFurniture.QuantityReturned) - cartQuantity;

            if (!isInCart && (returnLimit == 0 || currentOrder.OrderType == "return"))
            {
                throw new Exception("This item has already been returned.");
            }
            else if (enteredValue == 0)
            {
                throw new Exception("Must return more than 0 items.");
            }
            else if (isInCart && returnLimit > 0)
            {
                errorLabel.Text = "You can return " + returnLimit + " more of this item.";
                return (int)qtyReturnNumericUpDown.Value;
            }
            else if (isInCart && returnLimit == 0)
            {
                throw new Exception("Your return cart has all of these items already.");
            }
            else if (enteredValue > returnLimit)
            {
                throw new Exception("You can only return up to " + returnLimit + " items.");
            }
            else
            {
                return (int)qtyReturnNumericUpDown.Value;
            }
        }

        private void PopulateData()
        {
            transactionTypeLabel.Text = currentOrder.OrderType;
            dueDateLabel.Text = currentOrder.DueDate.ToShortDateString();
            amountPaidLabel.Text = currentOrder.OrderTotal.ToString();
            balanceLabel.Text = totalBalance.ToString();
        }

        private void PopulateGridView()
        {
            try
            {
                Order updatedOrder = ordersController.GetOrderFurnitureList(currentOrder);
                _furnitureList = updatedOrder.FurnitureList;
                foreach (var furniture in _furnitureList)
                {
                    if (furniture.QuantityReturned == null || furniture.QuantityRented == null || furniture.QuantityReturned < 0 || furniture.QuantityRented < 0)
                    {
                        furniture.QuantityReturned = 0;
                        furniture.QuantityRented = 0;
                    }

                    double? balance = null;
                    if (currentOrder.OrderType == "rental" && currentOrder.DateReturned == null && DateTime.Now > currentOrder.DueDate) //late
                    {
                        var overdraftFee = (DateTime.Now - currentOrder.DueDate).TotalDays * (double)furniture.Daily_Fine_Rate;
                        balance = currentOrder.OrderTotal - ((furniture.QuantityRented - furniture.QuantityReturned) * (double)furniture.Daily_Rental_Rate * (currentOrder.OrderDate - currentOrder.DueDate).TotalDays) + overdraftFee;
                    }
                    else if (currentOrder.OrderType == "rental" && currentOrder.DateReturned == null && DateTime.Now == currentOrder.DueDate) //on time
                    {
                        balance = currentOrder.OrderTotal - ((furniture.QuantityRented - furniture.QuantityReturned) * (double)furniture.Daily_Rental_Rate * (currentOrder.OrderDate - DateTime.Now).TotalDays);
                    }
                    else if (currentOrder.OrderType == "rental" && currentOrder.DateReturned == null && DateTime.Now < currentOrder.DueDate) //early
                    {
                        balance = currentOrder.OrderTotal - ((furniture.QuantityRented - furniture.QuantityReturned) * (double)furniture.Daily_Rental_Rate * (currentOrder.OrderDate - DateTime.Now).TotalDays);
                    }
                    else
                    {
                        balance = 0; //already returned
                    }
                    var formattedBalance = Math.Round((double)balance, 2);
                    totalBalance += formattedBalance;
                    furnitureOrderedDataGridView.Rows.Add(furniture.FurnitureID, furniture.Image_Small_Url, furniture.Name, currentOrder.OrderDate.ToShortDateString(), furniture.QuantityRented, furniture.QuantityReturned, furniture.Daily_Rental_Rate, formattedBalance);
                }
            }
            catch (Exception exception)
            {
                errorLabel.Text = exception.Message;
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selectedFurniture = _furnitureList.Find(x => x.FurnitureID == int.Parse(furnitureOrderedDataGridView.SelectedRows[0].Cells["FurnitureID"].Value.ToString()));
            errorLabel.Text = "";
            ReturnButton.Enabled = true;
            furnitureOrderedDataGridView.CurrentRow.Selected = true;
        }

        #endregion
    }
}
