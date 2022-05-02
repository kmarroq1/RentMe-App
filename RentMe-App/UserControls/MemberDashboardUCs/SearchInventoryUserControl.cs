using RentMe_App.Controller;
using RentMe_App.Model;
using RentMe_App.View.InventoryModals;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    /// <summary>
    /// user control class that encapsulates the search inventory controls
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public partial class SearchInventoryUserControl : UserControl
    {
        #region Data members

        private readonly InventoryController inventoryController;
        private readonly StyleController styleController;
        private readonly CategoryController categoryController;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the search inventory controls
        /// </summary>
        public SearchInventoryUserControl()
        {
            InitializeComponent();
            inventoryController = new InventoryController();
            styleController = new StyleController();
            categoryController = new CategoryController();

            ClearForm();
        }

        #endregion

        #region Methods

        private void PopulateStyleComboBox()
        {
            styleComboBox.DataSource = GetStyleList();
            styleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            styleComboBox.DisplayMember = "Name";
            styleComboBox.SelectedIndex = 0;
        }

        private List<Style> GetStyleList()
        {
            List<Style> newList = styleController.GetAllStyles();
            newList.Insert(0, new Style("--Select--"));
            return newList;
        }

        private string GetStyleSelected()
        {
            int styleIndexSelected = styleComboBox.SelectedIndex;
            return GetStyleList()[styleIndexSelected].Name;
        }

        private void PopulateCategoryComboBox()
        {
            categoryComboBox.DataSource = GetCategoryList();
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.SelectedIndex = 0;
        }

        private List<Category> GetCategoryList()
        {
            List<Category> newList = categoryController.GetAllCategories();
            newList.Insert(0, new Category("--Select--"));
            return newList;
        }

        private string GetCategorySelected()
        {
            int categoryIndexSelected = categoryComboBox.SelectedIndex;
            return GetCategoryList()[categoryIndexSelected].Name;
        }

        private void RefreshSearchDataGrid()
        {
            searchInventoryDataGridView.DataSource = null;

            try
            {
                bool getFurnitureCheck = Int32.TryParse(furnitureIDTextBox.Text, out int furnitureID);
                string selectedStyleName = GetStyleSelected();
                string selectedCategoryName = GetCategorySelected();

                List<FurnitureInventory> inventoryList;

                if (getFurnitureCheck == true && furnitureID > 0)
                {
                    inventoryList = inventoryController.GetInventoryByID(furnitureID);
                    CheckFurnitureFound(inventoryList);
                }
                else if (styleComboBox.SelectedIndex > 0 && categoryComboBox.SelectedIndex == 0)
                {
                    inventoryList = inventoryController.GetInventoryByStyle(selectedStyleName);
                    CheckFurnitureFound(inventoryList);
                }
                else if (styleComboBox.SelectedIndex == 0 && categoryComboBox.SelectedIndex > 0)
                {
                    inventoryList = inventoryController.GetInventoryByCategory(selectedCategoryName);
                    CheckFurnitureFound(inventoryList);
                }
                else if (styleComboBox.SelectedIndex > 0 && categoryComboBox.SelectedIndex > 0)
                {
                    inventoryList = inventoryController.GetInventoryByCategoryStyle(selectedCategoryName, selectedStyleName);
                    CheckFurnitureFound(inventoryList);
                }
                else if (getFurnitureCheck == true && furnitureID <= 0)
                {
                    ClearDataGridView();
                    string errorMessage = "Furniture ID must be number greater than 0";
                    ShowErrorMessage(errorMessage);
                }
                else if (getFurnitureCheck == false && furnitureIDTextBox.Text.Length > 0)
                {
                    ClearDataGridView();
                    string errorMessage = "Furniture ID must be number";
                    ShowErrorMessage(errorMessage);
                }
                else
                {
                    ClearDataGridView();
                    string errorMessage = "Selection must be made to return result";
                    ShowErrorMessage(errorMessage);
                }
            }
            catch (Exception)
            {
                string errorMessage = "Invalid Logic";
                ShowErrorMessage(errorMessage);
            }
        }

        private void BuildDataGridView(List<FurnitureInventory> inventoryList)
        {
            searchInventoryDataGridView.DataSource = null;
            searchInventoryDataGridView.Columns.Clear();
            searchInventoryDataGridView.Enabled = true;
            searchInventoryDataGridView.AutoGenerateColumns = false;

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

            DataGridViewTextBoxColumn styleColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Style",
                Name = "styleColumn"
            };

            DataGridViewTextBoxColumn categoryColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Category",
                Name = "categoryColumn"
            };

            DataGridViewTextBoxColumn quantityInStockColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Qty in Stock",
                Name = "quantityInStockColumn"
            };

            DataGridViewTextBoxColumn dailyRentalRateColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Daily Rental Rate",
                Name = "dailyRentalRateColumn"
            };

            searchInventoryDataGridView.Columns.Add(furnitureIDColumn);
            searchInventoryDataGridView.Columns.Add(nameColumn);
            searchInventoryDataGridView.Columns.Add(descriptionColumn);
            searchInventoryDataGridView.Columns.Add(styleColumn);
            searchInventoryDataGridView.Columns.Add(categoryColumn);
            searchInventoryDataGridView.Columns.Add(quantityInStockColumn);
            searchInventoryDataGridView.Columns.Add(dailyRentalRateColumn);

            try
            {

                foreach (FurnitureInventory go in inventoryList)
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

                    //PictureBox pictureBox = new PictureBox();
                    //string stringPath = furnitureInventory.Image_Small_Url;

                    //pictureBox.Image = new Bitmap(stringPath);
                    //singleImageBox.SizeMode = PictureBoxSizeMode.AutoSize;

                    int n = searchInventoryDataGridView.Rows.Add();

                    searchInventoryDataGridView.Rows[n].Cells[0].Value = furnitureInventory.FurnitureID.ToString();
                    searchInventoryDataGridView.Rows[n].Cells[1].Value = furnitureInventory.Name;
                    searchInventoryDataGridView.Rows[n].Cells[2].Value = furnitureInventory.Description;
                    searchInventoryDataGridView.Rows[n].Cells[3].Value = furnitureInventory.Style_Name;
                    searchInventoryDataGridView.Rows[n].Cells[4].Value = furnitureInventory.Category_Name;
                    searchInventoryDataGridView.Rows[n].Cells[5].Value = furnitureInventory.Quantity.ToString();
                    searchInventoryDataGridView.Rows[n].Cells[6].Value = furnitureInventory.Daily_Rental_Rate.ToString("C");

                    n++;
                }
            }
            catch (Exception)
            {
                ShowErrorMessage("Invalid Search");
            }
        }

        private void SearchInventoryDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectRentalItemButton.Enabled = searchInventoryDataGridView.SelectedRows.Count == 1;
        }

        private void SearchInventoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRentalItemButton.Enabled = true;
            searchInventoryDataGridView.CurrentRow.Selected = true;
            HideErrorMessage();
        }

        private void SelectRentalItemButton_Click(object sender, EventArgs e)
        {
            if (searchInventoryDataGridView.SelectedRows.Count != 1)
            {
                ShowErrorMessage("Please select an item to add to cart");
                return;
            }

            int selectedrowindex = searchInventoryDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = searchInventoryDataGridView.Rows[selectedrowindex];
            int selectedFurnitureID = Convert.ToInt32(selectedRow.Cells[0].Value);

            List<FurnitureInventory> selectedRentalItem = inventoryController.GetInventoryByID(selectedFurnitureID);

            AddRentalItemModal modal = new AddRentalItemModal(selectedRentalItem[0]);

            modal.ShowDialog();

            RefreshSearchDataGrid();

        }

        private void CheckFurnitureFound(List<FurnitureInventory> inventoryList)
        {
            if (inventoryList.Count > 0)
            {
                selectRentalItemButton.Enabled = false;
                BuildDataGridView(inventoryList);
            }
            else
            {
                ClearForm();
                string errorMessage = "No furniture found";
                ShowErrorMessage(errorMessage);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            RefreshSearchDataGrid();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            searchInventoryDataGridView.Rows.Clear();
            searchInventoryDataGridView.Refresh();
            furnitureIDTextBox.Text = "";
            PopulateStyleComboBox();
            PopulateCategoryComboBox();
            HideErrorMessage();
            selectRentalItemButton.Enabled = false;
        }

        private void ClearDataGridView()
        {
            searchInventoryDataGridView.Rows.Clear();
            searchInventoryDataGridView.Refresh();
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

        private void FurnitureID_Enter(object sender, EventArgs e)
        {
            categoryComboBox.SelectedIndex = 0;
            styleComboBox.SelectedIndex = 0;
            HideErrorMessage();
        }

        private void StyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (furnitureIDTextBox.Text != "")
            {
                furnitureIDTextBox.Text = "";
            }
            HideErrorMessage();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (furnitureIDTextBox.Text != "")
            {
                furnitureIDTextBox.Text = "";
            }
            HideErrorMessage();
        }

        private void SearchInventoryUserControl_VisibleChanged(object sender, EventArgs e)
        {
            ClearForm();
            ClearDataGridView();
        }

        #endregion
    }
}
