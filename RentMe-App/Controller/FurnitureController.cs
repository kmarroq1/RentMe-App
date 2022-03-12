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
        /// method used to get furniture by furnitureID, style_name or category_name
        /// </summary>
        /// <param name="furnitureID">furniture furnitureID</param>
        /// <param name="style_name">furniture style_name</param>
        /// <param name="category_name">furniture category_name</param>
        /// <returns>list of furniture objects</returns>
        public List<Furniture> GetFurniture(int furnitureID, string style_name, string category_name)
        {
            if (string.IsNullOrEmpty(style_name) && string.IsNullOrEmpty(category_name) && furnitureID < 0)
            {
                throw new ArgumentException("Style, Name or FurnitureID must be present and valid to return results");
            }
            return furnitureDBSource.GetFurniture(furnitureID, style_name, category_name);
        }

        #endregion
    }
}
