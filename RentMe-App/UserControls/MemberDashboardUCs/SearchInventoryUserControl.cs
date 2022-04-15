using RentMe_App.Controller;
using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
        private DataTable dataTable;

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
                else if (getFurnitureCheck == false && furnitureIDTextBox.Text.Length > 0)
                {
                    string errorMessage = "Furniture ID must be number";
                    ShowInvalidErrorMessage(errorMessage);
                }
                else
                {
                    string errorMessage = "Selection must be made to return result";
                    ShowInvalidErrorMessage(errorMessage);
                }
            }
            catch (Exception)
            {
                string errorMessage = "Invalid Logic";
                ShowInvalidErrorMessage(errorMessage);
            }
        }

    private void BuildDataGridView(List<FurnitureInventory> inventoryList)
        {
            searchInventoryDataGridView.DataSource = null;
            searchInventoryDataGridView.Columns.Clear();
            dataTable = new DataTable();

            dataTable.Columns.Add(new DataColumn("Furniture ID", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Image", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Description", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Style", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Category", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Qty in Stock", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Daily Rental Rate", typeof(decimal)));

            try
            {

                foreach (FurnitureInventory go in inventoryList)
                {
                    DataRow row = dataTable.NewRow();
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

                    row["Furniture ID"] = furnitureInventory.FurnitureID;
                    row["Image"] = furnitureInventory.Image_Small_Url;
                    row["Name"] = furnitureInventory.Name;
                    row["Description"] = furnitureInventory.Description;
                    row["Style"] = furnitureInventory.Style_Name;
                    row["Category"] = furnitureInventory.Category_Name;
                    row["Qty in Stock"] = furnitureInventory.Quantity;
                    row["Daily Rental Rate"] = furnitureInventory.Daily_Rental_Rate;

                    dataTable.Rows.Add(row);
                }
            }
            catch (Exception)
            {
                ShowInvalidErrorMessage("Invalid Member");
            }

            searchInventoryDataGridView.DataSource = dataTable;

            DataGridViewButtonColumn addButton = new DataGridViewButtonColumn();
            addButton.Name = "addButton";
            addButton.HeaderText = "";
            addButton.Text = "Add";
            addButton.UseColumnTextForButtonValue = true;
            searchInventoryDataGridView.Columns.Add(addButton);
        }

        private void CheckFurnitureFound(List<FurnitureInventory> inventoryList)
        {
            if (inventoryList.Count > 0)
            {
                BuildDataGridView(inventoryList);
            }
            else
            {
                string errorMessage = "No furniture found";
                ShowInvalidErrorMessage(errorMessage);
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
            searchInventoryDataGridView.DataSource = null;
            furnitureIDTextBox.Text = "";
            PopulateStyleComboBox();
            PopulateCategoryComboBox();
            HideErrorMessage();
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        private void ShowInvalidErrorMessage(string message)
        {
            errorMessageLabel.Text = message;
            errorMessageLabel.ForeColor = Color.Red;
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

        private void SearchFurnitureDataGridView_VisibleChanged(object sender, EventArgs e)
        {
            ClearForm();
        }

        #endregion
    }
}
