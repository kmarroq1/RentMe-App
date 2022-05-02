using RentMe_App.DAL;
using System;
using System.Data;

namespace RentMe_App.Controller
{
    /// <summary>
    /// class controller used to access the DAL for report
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class ReportController
    {
        #region Data Members

        private readonly ReportDBDAL reportDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// create a ReportController object
        /// </summary>
        public ReportController()
        {
            reportDBSource = new ReportDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to call stored function and return non report data
        /// </summary>
        /// <param name="startDate">start date</param>
        /// <param name="endDate">end date</param>
        /// <returns>report data</returns>
        public DataTable GetMostPopularFurnitureDuringDates(DateTime startDate, DateTime endDate)
        {
            if (!DateTime.TryParse(startDate.ToString(), out _))
            {
                throw new ArgumentException("Start Date is not valid", "startDate");

            }

            if (!DateTime.TryParse(endDate.ToString(), out _))
            {
                throw new ArgumentException("End Date is not valid", "endDate");

            }
            return reportDBSource.GetMostPopularFurnitureDuringDates(startDate, endDate);
        }

        #endregion
    }
}
