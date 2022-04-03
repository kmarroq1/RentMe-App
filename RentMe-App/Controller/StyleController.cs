using RentMe_App.DAL;
using RentMe_App.Model;
using System.Collections.Generic;

namespace RentMe_App.Controller
{
    /// <summary>
    /// class controller used to access the DAL for style
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class StyleController
    {
        #region Data Members

        private readonly StyleDBDAL styleDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// create a StyleController object
        /// </summary>
        public StyleController()
        {
            styleDBSource = new StyleDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to get all styles
        /// </summary>
        /// <returns>list of style objects</returns>
        public List<Style> GetAllStyles()
        {
            return styleDBSource.GetAllStyles();
        }

        #endregion
    }
}
