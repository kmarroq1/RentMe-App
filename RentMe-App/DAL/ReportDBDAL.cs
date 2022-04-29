using Microsoft.Reporting.WinForms;
using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Report = RentMe_App.Model.Report;

namespace RentMe_App.DAL
{
    /// <summary>
    /// data layer class used to access the report data
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class ReportDBDAL
    {
        #region Methods

        /// <summary>
        /// method used to call the stored function spGetMostPopularFurnitureDuringDates
        /// </summary>
        /// <param name="startDate">start date</param>
        /// <param name="endDate">end date</param>
        /// <returns>report data</returns>
        public DataSet GetMostPopularFurnitureDuringDates(DateTime startDate, DateTime endDate)
        {
            DataSet dsReport;
            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "spGetMostPopularFurnitureDuringDates",
                    CommandType = CommandType.StoredProcedure
                })
                {
                    selectCommand.Parameters.Add("@startDate", SqlDbType.DateTime);
                    selectCommand.Parameters["@startDate"].Value = startDate;
                    selectCommand.Parameters.Add("@endDate", SqlDbType.DateTime);
                    selectCommand.Parameters["@endDate"].Value = endDate;

                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        selectCommand.Connection = connection;
                        selectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand = selectCommand;
                        using (dsReport = new DataSet())
                        {
                            sda.Fill(dsReport, "ReportDataTable");
                        }
                    }
                }
            }
            return dsReport;
        }

        #endregion
    }
}
