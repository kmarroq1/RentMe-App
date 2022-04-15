using RentMe_App.DAL;
using RentMe_App.Model;
using System.Collections.Generic;

namespace RentMe_App.Controller
{
    /// <summary>
    /// class controller used to access the DAL for inventory
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class InventoryController
    {
        #region Data Members

        private readonly InventoryDBDAL inventoryDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// create a InventoryController object
        /// </summary>
        public InventoryController()
        {
            inventoryDBSource = new InventoryDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to get furniture with inventory by ID
        /// </summary>
        /// <param name="furnitureID">furniture ID</param>
        /// <returns>list of furniture with inventory objects</returns>
        public List<FurnitureInventory> GetInventoryByID(int furnitureID)
        {
            return inventoryDBSource.GetInventoryByID(furnitureID);
        }

        /// <summary>
        /// method used to get furniture with inventory by style
        /// </summary>
        /// <param name="style_name">furniture style name</param>
        /// <returns>list of furniture with inventory objects</returns>
        public List<FurnitureInventory> GetInventoryByStyle(string style_name)
        {
            return inventoryDBSource.GetInventoryByStyle(style_name);
        }

        /// <summary>
        /// method used to get furniture with inventory by category
        /// </summary>
        /// <param name="category_name">furniture category name</param>
        /// <returns>list of furniture with inventory objects</returns>
        public List<FurnitureInventory> GetInventoryByCategory(string category_name)
        {
            return inventoryDBSource.GetInventoryByCategory(category_name);
        }

        /// <summary>
        /// method used to get furniture with inventory by category and style
        /// </summary>
        /// <param name="category_name">furniture category name</param>
        /// <param name="style_name">furniture style name</param>
        /// <returns>list of furniture with inventory objects</returns>
        public List<FurnitureInventory> GetInventoryByCategoryStyle(string category_name, string style_name)
        {
            return inventoryDBSource.GetInventoryByCategoryStyle(category_name, style_name);
        }

        #endregion
    }
}
