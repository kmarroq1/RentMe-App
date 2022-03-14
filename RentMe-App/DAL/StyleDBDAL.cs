using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe_App.DAL
{
    /// <summary>
    /// data layer class used to access the style
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class StyleDBDAL
    {
        #region Methods

        /// <summary>
        /// method used to connect to the database and run a query to return style
        /// </summary>
        /// <returns>list of styles</returns>
        public List<Style> GetAllStyles()
        {
            List<Style> styleList = new List<Style>();

            string selectStatement =
                "SELECT * " +
                "FROM style " +
                "ORDER BY Name";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Style style = new Style
                            {
                                Name = reader["name"].ToString()
                            };
                            styleList.Add(style);
                        }
                    }
                }
            }
            return styleList;
        }

        #endregion
    }
}
