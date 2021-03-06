using RentMe_App.Controller;
using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe_App.View.InventoryModals
{
    /// <summary>
    /// RentalReceiptModal class for logic to create rental receipt
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public partial class RentalReceiptModal : Form
    {
        #region Data Members

        private readonly int transactionID;
        private readonly RentalController rentalController;
        private readonly MemberController memberController;
        private Rental rental;
        private List<Member> memberList;
        private List<FurnitureInventory> rentalFurnitureList;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create modal
        /// </summary>
        public RentalReceiptModal(int transactionIdentifier)
        {
            InitializeComponent();
            transactionID = transactionIdentifier;
            rentalItemsTextBox.ScrollBars = ScrollBars.Vertical;
            rental = new Rental();
            memberList = new List<Member>();
            rentalFurnitureList = new List<FurnitureInventory>();
            rentalController = new RentalController();
            memberController = new MemberController();
        }

        #endregion

        #region Methods

        private void RentalReceiptModal_Load(object sender, EventArgs e)
        {
            try
            {
                rental = rentalController.GetRentalByID(transactionID);
                rentalTransactionIDValueLabel.Text = rental.TransactionID.ToString();
                transactionDateValueLabel.Text = rental.TransactionDate.ToString("MM-dd-yyyy");
                dueDateValueLabel.Text = rental.ReturnDate.ToString("MM-dd-yyyy");

                memberList = memberController.GetMemberByID(rental.MemberID);
                memberIDValueLabel.Text = rental.MemberID.ToString();
                memberNameValueLabel.Text = memberList[0].Fname + " " + memberList[0].Lname;

                rentalFurnitureList = rentalController.GetRentalFurniture(transactionID);
                string furniture = "";
                decimal totalCost = 0;
                int totalDaysRented = DaysBetween(rental.TransactionDate.Date, rental.ReturnDate.Date);
                Console.WriteLine(totalDaysRented.ToString());

                Console.WriteLine(totalDaysRented.ToString());
                for (int count = 0; count < rentalFurnitureList.Count; count++)
                {
                    furniture += rentalFurnitureList[count].Quantity.ToString()
                        + " x "
                        + rentalFurnitureList[count].Name.ToString()
                        + " (daily rate per item: "
                        + rentalFurnitureList[count].Daily_Rental_Rate.ToString("C")
                        + ")"
                        + Environment.NewLine;

                    totalCost += rentalFurnitureList[count].Quantity * (totalDaysRented * rentalFurnitureList[count].Daily_Rental_Rate);
                }
                rentalItemsTextBox.Text = furniture;
                totalCostValueLabel.Text = totalCost.ToString("C");
            }
            catch (Exception)
            {
                string errorMessage = "Invalid Logic";
                ShowErrorMessage(errorMessage);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowErrorMessage(string message)
        {
            errorMessageLabel.Text = message;
            errorMessageLabel.ForeColor = System.Drawing.Color.Red;
        }

        private int DaysBetween(DateTime d1, DateTime d2)
        {
            TimeSpan span = d2.Subtract(d1);
            return (int)Math.Abs(span.Days);
        }

        #endregion
    }
}
