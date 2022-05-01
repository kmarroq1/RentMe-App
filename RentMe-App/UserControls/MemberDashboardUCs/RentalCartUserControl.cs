using RentMe_App.Controller;
using RentMe_App.Model;
using RentMe_App.View.InventoryModals;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe_App.UserControls.MemberDashboardUCs
{
    /// <summary>
    /// user control class that encapsulates the rental cart
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public partial class RentalCartUserControl : UserControl
    {
        #region Data Members

        private readonly InventoryController inventoryController;
        private List<FurnitureInventory> rentalCartList;
        private readonly RentalController rentalController;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the rental cart controls
        /// </summary>
        public RentalCartUserControl()
        {
            InitializeComponent();
            inventoryController = new InventoryController();
            rentalCartList = new List<FurnitureInventory>();
            rentalController = new RentalController();

            currentTotalValueLabel.Text = "$0.00";
        }

        #endregion

        #region Methods

        private void RentalCartUserControl_Load(object sender, System.EventArgs e)
        {
            rentalCartList = Cart.RentalList;
            RefreshRentalCartDataGrid();
            HideErrorMessage();
        }

        private void RefreshRentalCartDataGrid()
        {
            if (rentalCartList.Count > 0)
            {
                completeRentalButton.Enabled = true;
                BuildDataGridView(rentalCartList);
                int totalItemsInCart = 0;
                decimal totalCost = 0;
                for (int count = 0; count < rentalCartList.Count; count++)
                {
                    totalItemsInCart += rentalCartList[count].Quantity;
                    totalCost += rentalCartList[count].Quantity * rentalCartList[count].Daily_Rental_Rate;
                }

                totalItemsInCartValuelabel.Text = totalItemsInCart.ToString();
                currentTotalValueLabel.Text = totalCost.ToString("C");
            }
            else
            {
                string errorMessage = "Cart Is Empty";
                ShowErrorMessage(errorMessage);
            }
        }

        private void BuildDataGridView(List<FurnitureInventory> rentalCartList)
        {
            rentalCartDataGridView.DataSource = null;
            rentalCartDataGridView.Columns.Clear();
            rentalCartDataGridView.Enabled = true;
            rentalCartDataGridView.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn furnitureIDColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Furniture ID",
                Name = "furnitureIDColumn"
            };

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Name = "nameColumn"
            };

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Decription",
                Name = "descriptionColumn"
            };

            DataGridViewTextBoxColumn quantityToRentColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Qty to Rent",
                Name = "quantityToRentColumn"
            };

            DataGridViewTextBoxColumn dailyRentalRateColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Daily Rental Rate",
                Name = "dailyRentalRateColumn"
            };

            rentalCartDataGridView.Columns.Add(furnitureIDColumn);
            rentalCartDataGridView.Columns.Add(nameColumn);
            rentalCartDataGridView.Columns.Add(descriptionColumn);
            rentalCartDataGridView.Columns.Add(quantityToRentColumn);
            rentalCartDataGridView.Columns.Add(dailyRentalRateColumn);

            try
            {

                foreach (FurnitureInventory go in rentalCartList)
                {
                    FurnitureInventory furnitureInventory = new FurnitureInventory
                    {
                        FurnitureID = go.FurnitureID,
                        Image_Small_Url = go.Image_Small_Url,
                        Name = go.Name,
                        Description = go.Description,
                        Style_Name = go.Style_Name,
                        Category_Name = go.Category_Name,
                        Quantity = go.Quantity,
                        Daily_Rental_Rate = go.Daily_Rental_Rate
                    };

                    int n = rentalCartDataGridView.Rows.Add();

                    rentalCartDataGridView.Rows[n].Cells[0].Value = furnitureInventory.FurnitureID.ToString();
                    rentalCartDataGridView.Rows[n].Cells[1].Value = furnitureInventory.Name;
                    rentalCartDataGridView.Rows[n].Cells[2].Value = furnitureInventory.Description;
                    rentalCartDataGridView.Rows[n].Cells[3].Value = furnitureInventory.Quantity.ToString();
                    rentalCartDataGridView.Rows[n].Cells[4].Value = furnitureInventory.Daily_Rental_Rate.ToString("C");

                    n++;
                }
            }
            catch (Exception)
            {
                ShowErrorMessage("Invalid Cart");
            }
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

        private void RentalCartDataGridView_VisibleChanged(object sender, EventArgs e)
        {
            dueDateTimePicker.MinDate = DateTime.Today;
            RefreshRentalCartDataGrid();
        }

        private void ClearDataGridView()
        {
            rentalCartDataGridView.Rows.Clear();
            rentalCartDataGridView.Refresh();
        }

        private void DueDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
            int totalDaysRented = DaysBetween(DateTime.Now.Date, dueDateTimePicker.Value.Date);
            decimal totalCost = 0;

            if (totalDaysRented == 0 && rentalCartList.Count > 0)
            {
                totalDaysRented = 1;
            }

            for (int count = 0; count < rentalCartList.Count; count++)
            {
                totalCost += rentalCartList[count].Quantity * (rentalCartList[count].Daily_Rental_Rate * totalDaysRented);
            }
            currentTotalValueLabel.Text = totalCost.ToString("C");
        }

        private void ClearForm()
        {

            totalItemsInCartValuelabel.Text = "0";
            currentTotalValueLabel.Text = "$0.00";
            dueDateTimePicker.Value = DateTime.Today;
            HideErrorMessage();
            completeRentalButton.Enabled = false;
        }

        private void CompleteRentalButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DaysBetween(dueDateTimePicker.Value.Date, DateTime.Today.Date) == 0)
                {
                    ShowErrorMessage("You must choose a rental date in the future");
                }
                else
                {
                    HideErrorMessage();
                    int transactionID = -1;
                    transactionID = rentalController.CreateRentalTransaction(SharedFormInfo.MemberIDForm, SharedFormInfo.EmployeeIDForm, DateTime.Parse(dueDateTimePicker.Value.ToString("MM/dd/yyyy")), Cart.RentalList);

                    if (transactionID > 0)
                    {
                        RentalReceiptModal modal = new RentalReceiptModal(transactionID);

                        modal.ShowDialog();

                        Cart.RentalList.Clear();
                        RefreshRentalCartDataGrid();
                        ClearDataGridView();
                        ClearForm();

                    }
                    else
                    {
                        ShowErrorMessage("Please review transaction");
                    }
                }
            }
            catch (Exception)
            {
                ShowErrorMessage("Invalid Complete Cart");
            }
        }

        private void RentalCartDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            updateItemButton.Enabled = rentalCartDataGridView.SelectedRows.Count == 1;
            deleteItemButton.Enabled = rentalCartDataGridView.SelectedRows.Count == 1;
        }

        private void RentalCartDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateItemButton.Enabled = true;
            deleteItemButton.Enabled = true;
            rentalCartDataGridView.CurrentRow.Selected = true;
            HideErrorMessage();
        }

        private void UpdateItemButton_Click(object sender, EventArgs e)
        {
            if (rentalCartDataGridView.SelectedRows.Count != 1)
            {
                ShowErrorMessage("Please select an item to update");
                return;
            }

            int selectedrowindex = rentalCartDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = rentalCartDataGridView.Rows[selectedrowindex];
            int selectedFurnitureID = Convert.ToInt32(selectedRow.Cells[0].Value);

            List<FurnitureInventory> selectedRentalItem = inventoryController.GetInventoryByID(selectedFurnitureID);

            UpdateRentalItemModal modal = new UpdateRentalItemModal(selectedrowindex, selectedRentalItem[0]);

            modal.ShowDialog();

            RefreshRentalCartDataGrid();
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                int currentSelectedIndex = rentalCartDataGridView.CurrentCell.RowIndex;
                bool deleteCompleted = Cart.DeleteRentalItem(currentSelectedIndex);

                if (Cart.RentalList.Count > 0 && deleteCompleted)
                {
                    RefreshRentalCartDataGrid();
                    ShowErrorMessage("Item was deleted");
                }
                else if (Cart.RentalList.Count == 0 && deleteCompleted)
                {
                    RefreshRentalCartDataGrid();
                    ClearDataGridView();
                    ClearForm();
                    ShowErrorMessage("Item was deleted");
                }
            }
            catch (Exception)
            {
                ShowErrorMessage("Invalid Delete");
            }
        }

        private void ClearRentalsButton_Click(object sender, EventArgs e)
        {
            Cart.RentalList.Clear();
            RefreshRentalCartDataGrid();
            ClearDataGridView();
            ClearForm();
        }

        private void RentalCartUserControl_VisibleChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private int DaysBetween(DateTime d1, DateTime d2)
        {
            TimeSpan span = d2.Subtract(d1);
            return (int)Math.Abs(span.Days);
        }

        #endregion
    }
}
