using RentMe_App.Model;
using System.Data.SqlClient;

namespace RentMe_App.DAL
{
    /// <summary>
    /// States data access layer
    /// </summary>
    class StatesDBDAL
    {
        #region Queries

        /// <summary>
        /// Returns list of all states
        /// </summary>
        /// <returns> States list </returns>
        public States GetStatesList()
        {
            States states = new States();

            string selectStatement = "SELECT * FROM states";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return null;
                        }

                        while (reader.Read())
                        {
                            states.StatesList.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return states;
        }

        #endregion
    }
}
