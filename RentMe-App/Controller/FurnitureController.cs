using RentMe_App.DAL;
using RentMe_App.Model;
using System;
using System.Collections.Generic;

namespace RentMe_App.Controller
{
    /// <summary>
    /// class controller used to access the DAL for furniture
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class FurnitureController
    {
        #region Data Members

        private readonly FurnitureDBDAL furnitureDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// create a FurnitureController object
        /// </summary>
        public FurnitureController()
        {
            furnitureDBSource = new FurnitureDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to get furniture by furnitureID
        /// </summary>
        /// <param name="furnitureID">furniture furnitureID</param>
        /// <returns>list of furniture objects</returns>
        public List<Furniture> GetFurnitureByID(int furnitureID)
        {
            if (furnitureID < 0)
            {
                throw new ArgumentException("FurnitureID must be greater than 0 to return results");
            }
            return furnitureDBSource.GetFurnitureByID(furnitureID);
        }

        /// <summary>
        /// method used to get furniture by style_name
        /// </summary>
        /// <param name="style_name">furniture style_name</param>
        /// <returns>list of furniture objects</returns>
        public List<Furniture> GetFurnitureByStyle(string style_name)
        {
            if (string.IsNullOrEmpty(style_name))
            {
                throw new ArgumentException("Style cannot be null or empty");
            }
            return furnitureDBSource.GetFurnitureByStyle(style_name);
        }

        /// <summary>
        /// method used to get furniture by category_name
        /// </summary>
        /// <param name="category_name">furniture category_name</param>
        /// <returns>list of furniture objects</returns>
        public List<Furniture> GetFurnitureByCategory(string category_name)
        {
            if (string.IsNullOrEmpty(category_name))
            {
                throw new ArgumentException("Category cannot be null or empty");
            }
            return furnitureDBSource.GetFurnitureByCategory(category_name);
        }

        /// <summary>
        /// method used to get furniture by style_name and category_name
        /// </summary>
        /// <param name="style_name">furniture style_name</param>
        /// <param name="category_name">furniture category_name</param>
        /// <returns>list of furniture objects</returns>
        public List<Furniture> GetFurnitureByCategoryStyle(string category_name, string style_name)
        {
            if (string.IsNullOrEmpty(style_name) || string.IsNullOrEmpty(category_name))
            {
                throw new ArgumentException("Style and Category must be selected to return results");
            }
            return furnitureDBSource.GetFurnitureByCategoryStyle(category_name, style_name);
        }

        #endregion
    }
}
