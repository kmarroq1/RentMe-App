using RentMe_App.Model;
using System;
using System.Windows.Forms;

namespace RentMe_App.View.InventoryModals
{
    /// <summary>
    /// UpdateRentalItemModal class for logic to update rental item in cart
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public partial class UpdateRentalItemModal : Form
    {
        #region Data members

        private readonly FurnitureInventory rentalItem;
        private readonly int indexInCart;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create modal
        /// </summary>
        public UpdateRentalItemModal(int index, FurnitureInventory furniture)
        {
            InitializeComponent();
            indexInCart = index;
            rentalItem = furniture;
            quantityToRentNumericUpDown.Maximum = rentalItem.Quantity;
            updateItemButton.Enabled = false;
        }

        #endregion

        #region Methods

        private void UpdateRentalItemModal_Load(object sender, EventArgs e)
        {
            furnitureIDValueLabel.Text = rentalItem.FurnitureID.ToString();
            nameValueLabel.Text = rentalItem.Name;
            descriptionValueLabel.Text = rentalItem.Description;
            styleValueLabel.Text = rentalItem.Style_Name;
            categoryValueLabel.Text = rentalItem.Category_Name;
            dailyRentalRateValueLabel.Text = rentalItem.Daily_Rental_Rate.ToString("C");
            quantityInStockValueLabel.Text = rentalItem.Quantity.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        private void ShowErrorMessage(string message)
        {
            errorMessageLabel.Text = message;
            errorMessageLabel.ForeColor = System.Drawing.Color.Red;
        }

        private void QuantityToRentNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (quantityToRentNumericUpDown.Value > 0)
            {
                updateItemButton.Enabled = true;
                HideErrorMessage();
            }
            else
            {
                updateItemButton.Enabled = false;
                ShowErrorMessage("Quantity to Rent must be greater than 0");
            }
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {
            Cart.UpdateRentalItem(indexInCart, CreateRentalItem());
            ShowErrorMessage("Item updated in cart");
        }

        private FurnitureInventory CreateRentalItem()
        {
            FurnitureInventory cartItem = new FurnitureInventory
            {
                FurnitureID = rentalItem.FurnitureID,
                Name = rentalItem.Name,
                Description = rentalItem.Description,
                Daily_Rental_Rate = rentalItem.Daily_Rental_Rate,
                Daily_Fine_Rate = rentalItem.Daily_Fine_Rate,
                Style_Name = rentalItem.Style_Name,
                Category_Name = rentalItem.Category_Name,
                Image_Small_Url = rentalItem.Image_Small_Url,
                Image_Large_Url = rentalItem.Image_Large_Url,
                Quantity = (int)quantityToRentNumericUpDown.Value
            };
            return cartItem;
        }

        #endregion
    }
}
