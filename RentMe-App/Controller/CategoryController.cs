using RentMe_App.DAL;
using RentMe_App.Model;
using System.Collections.Generic;

namespace RentMe_App.Controller
{
    /// <summary>
    /// class controller used to access the DAL for category
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class CategoryController
    {
        #region Data Members

        private readonly CategoryDBDAL categoryDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// create a CategoryController object
        /// </summary>
        public CategoryController()
        {
            categoryDBSource = new CategoryDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to get all categories
        /// </summary>
        /// <returns>list of category objects</returns>
        public List<Category> GetAllCategories()
        {
            return categoryDBSource.GetAllCategories();
        }

        #endregion
    }
}
