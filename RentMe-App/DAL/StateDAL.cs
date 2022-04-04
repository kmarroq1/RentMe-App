using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe_App.DAL
{
    /// <summary>
    /// Data Access Layer which communicates with the States table in the db.
    /// </summary>
    public class StateDAL
    {
        /// <summary>
        /// Collects the list of abbreviations from the states table.
        /// </summary>
        /// <returns>The abbreviations in the states table.</returns>
        public List<string> GetStateAbbreviations()
        {
            List<string> abbreviations = new List<string>();

            string selectStatement = @"SELECT [name]
                                       FROM [states]";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                    while (reader.Read())
                        abbreviations.Add(reader.GetString(reader.GetOrdinal("name")));
            }

            return abbreviations;
        }
    }
}
