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
        public DataTable GetMostPopularFurnitureDuringDates(DateTime startDate, DateTime endDate)
        {
            DataTable table;
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
                        sda.SelectCommand = selectCommand;
                        using (table = new DataTable())
                        {
                            sda.Fill(table);
                        }
                    }
                }
            }
            return table;
        }

        #endregion
    }
}
