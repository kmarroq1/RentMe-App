using RentMe_App.Model;
using System.Data.SqlClient;
using System.Data;
using System;

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
                    string returnTransactionInsertStatement = @"INSERT INTO [returnTransaction]
                                                                    ( employeeID, return_date )
                                                                VALUES
                                                                    ( @EmployeeID, @ReturnDate )
                                                                ;";

                    int newRentalID = -1;

                    using (SqlCommand cmd = new SqlCommand(returnTransactionInsertStatement, connection, transaction))
                    {
                        cmd.Parameters.Add("EmployeeID", SqlDbType.Int);
                        cmd.Parameters["EmployeeID"].Value = returnToComplete.EmployeeID;

                        cmd.Parameters.Add("ReturnDate", SqlDbType.Date);
                        cmd.Parameters["ReturnDate"].Value = DateTime.Now;

                        newRentalID = Convert.ToInt32(cmd.ExecuteScalar());
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
