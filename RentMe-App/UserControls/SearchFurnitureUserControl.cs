using RentMe_App.Controller;
using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMe_App.UserControls
{
    /// <summary>
    /// user control class that encapsulates the search furniture controls
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public partial class SearchFurnitureUserControl : UserControl
    {
        #region Data members

        private readonly FurnitureController furnitureController;
        private readonly StyleController styleController;
        private readonly CategoryController categoryController;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the search furniture controls
        /// </summary>
        public SearchFurnitureUserControl()
        {
            this.InitializeComponent();
            this.furnitureController = new FurnitureController();
            this.styleController = new StyleController();
            this.categoryController = new CategoryController();

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
            newList.Insert(0, new Style("Select ----"));
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
            newList.Insert(0, new Category("Select ----"));
            return newList;
        }

        private string GetCategorySelected()
        {
            int categoryIndexSelected = categoryComboBox.SelectedIndex;
            return GetCategoryList()[categoryIndexSelected].Name;
        }

        private void RefreshSearchDataGrid()
        {
            this.searchFurnitureDataGridView.DataSource = null;

            try
            {
                int furnitureID = int.Parse(furnitureIDTextBox.Text);
                List<Furniture> furnitureList = furnitureController.GetFurniture(furnitureID, GetStyleSelected(), GetCategorySelected());

                this.searchFurnitureDataGridView.DataSource = furnitureList;

                AdjustColumnOrder();
            }
            catch (Exception)
            {
                string errorMessage = "FurnitureID must be number and cannot be empty or Category or Style must be selected";
                this.ShowInvalidErrorMessage(errorMessage);
        }
        }

        private void AdjustColumnOrder()
        {
            searchFurnitureDataGridView.Columns["image_small_url"].DisplayIndex = 0;
            searchFurnitureDataGridView.Columns["furnitureID"].DisplayIndex = 1;
            searchFurnitureDataGridView.Columns["name"].DisplayIndex = 2;
            searchFurnitureDataGridView.Columns["description"].DisplayIndex = 3;
            searchFurnitureDataGridView.Columns["daily_rental_rate"].DisplayIndex = 4;
            searchFurnitureDataGridView.Columns["daily_fine_rate"].DisplayIndex = 5;
            searchFurnitureDataGridView.Columns["style_name"].DisplayIndex = 6;
            searchFurnitureDataGridView.Columns["category_name"].DisplayIndex = 7;
            searchFurnitureDataGridView.Columns["image_large_url"].Visible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.RefreshSearchDataGrid();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void ClearForm()
        {
            this.searchFurnitureDataGridView.DataSource = null;
            this.furnitureIDTextBox.Text = "";
            this.PopulateStyleComboBox();
            this.PopulateCategoryComboBox();
            this.HideErrorMessage();
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

        private void FurnitureID_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void SearchFurnitureDataGridView_VisibleChanged(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        #endregion
    }
}
