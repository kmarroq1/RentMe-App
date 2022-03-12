using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe_App.DAL
{
    /// <summary>
    /// get a connection object for cs6235-g5 database
    /// Author: cs6235-g5
    /// Version: Spring 2022
    /// </summary>
    public class RentMeAppDBConnection
    {
        #region Methods

        /// <summary>
        /// method used to connect to cs6235-g5 database
        /// </summary>
        /// <returns>return connection to database</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=cs6232-g5;" +
                "Integrated Security=True";


            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        #endregion
    }
}
