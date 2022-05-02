using RentMe_App.Model;
using System;
using System.Windows.Forms;

namespace RentMe_App.View.MemberModals
{
    /// <summary>
    /// Defines an items details modal
    /// </summary>
    public partial class ItemDetailsModal : Form
    {
        #region Fields
        private readonly string _transactionType;
        private FurnitureInventory _furniture;
        #endregion

        #region Properties
        /// <summary>
        /// Dictates how the stored furniture object can be accessed and mutated.
        /// </summary>
        public FurnitureInventory Furniture
        {
            get => _furniture;
            set => _furniture = value ?? throw new ArgumentNullException("Furniture", "The furniture object cannot be null");
        }
        #endregion

        #region Contructors
        /// <summary>
        /// Constructs an ItemDetails modal.
        /// </summary>
        /// <param name="furniture">The piece of furniture to display the details of</param>
        /// <param name="isUpdate">Whether the modal appeared for an update</param>
        public ItemDetailsModal(FurnitureInventory furniture, bool? isUpdate)
        {
            _transactionType = "Return";
            _furniture = furniture;

            InitializeComponent();

            TransactionTypeLabel.Text = _transactionType;

            DisplayFurnitureDetails();

            SubmitButton.Text = (isUpdate.HasValue && isUpdate.Value) ? "Update" : _transactionType;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Updates the text fields in the furniture details section
        /// based off of the passed Furniture object.
        /// </summary>
        private void DisplayFurnitureDetails()
        {
            FurnitureIDValueLabel.Text = _furniture.FurnitureID.ToString();

            NameLabel.Text = _furniture.Name;

            DescriptionTextBox.Text = _furniture.Description;

            StyleLabel.Text = _furniture.Style_Name;

            CategoryLabel.Text = _furniture.Category_Name;

            RateLabel.Text = _furniture.Daily_Rental_Rate.ToString("C");

            FineLabel.Text = _furniture.Daily_Fine_Rate.ToString("C");

            QuantityNumericUpDown.Value = _furniture.Quantity;
            QuantityNumericUpDown.Maximum = _furniture.QuantityRented.Value - _furniture.QuantityReturned.Value;
        }

        /// <summary>
        /// Displays a message in the ErrorMessage,
        /// and makes it visible.
        /// </summary>
        /// <param name="message">The message to display.</param>
        public void ShowError(string message)
        {
            ErrorMessage.Text = message;
            ErrorMessage.Show();
        }
        #endregion

        #region Event Handlers
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (QuantityNumericUpDown.Value == _furniture.Quantity)
                    throw new ArgumentException("Quantity not changed. Nothing to update.");

                if (QuantityNumericUpDown.Value < 0)
                    throw new ArgumentException("Quantity cannot be negative");

                if (QuantityNumericUpDown.Value > (_furniture.QuantityRented - _furniture.QuantityReturned))
                    throw new ArgumentException("Quantity exceeds number of rented items.");

                _furniture.Quantity = (int) QuantityNumericUpDown.Value;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (QuantityNumericUpDown.Value < 0)
            {
                ShowError("Quantity cannot be negative.");
                SubmitButton.Enabled = false;
                return;
            }
            
            ErrorMessage.Hide();
            SubmitButton.Enabled = true;
        }
        #endregion
    }
}
