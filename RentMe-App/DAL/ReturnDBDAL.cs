using RentMe_App.Model;
using System.Data.SqlClient;

namespace RentMe_App.DAL
{
    /// <summary>
    /// Acts as a direct access to the Returns portion of the db.
    /// </summary>
    public class ReturnDBDAL
    {
        #region Methods
        /// <summary>
        /// Writes the Return Transaction to the appropriate tables.
        /// </summary>
        /// <param name="returnToComplete">The Transaction to write to the DB.</param>
        public void CompleteReturn(Return returnToComplete)
        {
            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    string returnTransactionInsertStatement = "";

                    using (SqlCommand cmd = new SqlCommand(returnTransactionInsertStatement, connection, transaction))
                    {

                    }

                    foreach (FurnitureInventory furniture in returnToComplete.ReturnedFurniture)
                    {
                        string furnitureReturnedInsertStatement = "";

                        using (SqlCommand cmd = new SqlCommand(furnitureReturnedInsertStatement, connection, transaction))
                        {

                        }

                        string furnitureRentedDeleteStatement = "";

                        using (SqlCommand cmd = new SqlCommand(furnitureRentedDeleteStatement, connection, transaction))
                        {

                        }
                    }

                    string furnitureInventoryUpdateStatement = "";

                    using (SqlCommand cmd = new SqlCommand(furnitureInventoryUpdateStatement, connection, transaction))
                    {

                    }

                    transaction.Commit();
                }
            }
        }
        #endregion
    }
}
