using RentMe_App.Model;
using System;
using System.Windows.Forms;

namespace RentMe_App.View.InventoryModals
{
    public partial class AddRentalItemModal : Form
    {
        private readonly FurnitureInventory rentalFurniture;

        public AddRentalItemModal(FurnitureInventory furniture)
        {
            InitializeComponent();
            rentalFurniture = furniture;
            quantityToRentNumericUpDown.Maximum = rentalFurniture.Quantity;
        }

        private void AddRentalItemModal_Load(object sender, EventArgs e)
        {
            furnitureIDValueLabel.Text = rentalFurniture.FurnitureID.ToString();
            nameValueLabel.Text = rentalFurniture.Name;
            descriptionValueLabel.Text = rentalFurniture.Description;
            styleValueLabel.Text = rentalFurniture.Style_Name;
            categoryValueLabel.Text = rentalFurniture.Category_Name;
            dailyRentalRateValueLabel.Text = rentalFurniture.Daily_Rental_Rate.ToString("C");
            quantityInStockValueLabel.Text = rentalFurniture.Quantity.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            quantityToRentNumericUpDown.Value = 0;
            HideErrorMessage();
        }

        private void HideErrorMessage()
        {

        }
    }
}
