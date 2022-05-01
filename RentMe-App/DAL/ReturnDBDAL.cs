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
                                                                OUTPUT INSERTED.transactionID
                                                                VALUES
                                                                    ( @EmployeeID, @ReturnDate )
                                                                ;";

                    int newReturnID = -1;

                    using (SqlCommand cmd = new SqlCommand(returnTransactionInsertStatement, connection, transaction))
                    {
                        cmd.Parameters.Add("EmployeeID", SqlDbType.Int);
                        cmd.Parameters["EmployeeID"].Value = returnToComplete.EmployeeID;

                        cmd.Parameters.Add("ReturnDate", SqlDbType.Date);
                        cmd.Parameters["ReturnDate"].Value = DateTime.Now;

                        newReturnID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    Console.WriteLine(newReturnID);

                    foreach (FurnitureInventory furniture in returnToComplete.ReturnedFurniture)
                    {
                        string furnitureReturnedInsertStatement = @"INSERT INTO [furnitureReturned]
	                                                                    (furnitureID, rental_transactionID, return_transactionID, quantity)
                                                                    VALUES
	                                                                    (@FurnitureID, @RentalID, @ReturnID, @Quantity)
                                                                    ;";

                        using (SqlCommand cmd = new SqlCommand(furnitureReturnedInsertStatement, connection, transaction))
                        {
                            cmd.Parameters.Add("FurnitureID", SqlDbType.Int);
                            cmd.Parameters["FurnitureID"].Value = furniture.FurnitureID;

                            cmd.Parameters.Add("RentalID", SqlDbType.Int);
                            cmd.Parameters["RentalID"].Value = furniture.RentalTransactionID;

                            cmd.Parameters.Add("ReturnID", SqlDbType.Int);
                            cmd.Parameters["ReturnID"].Value = newReturnID;

                            cmd.Parameters.Add("Quantity", SqlDbType.Int);
                            cmd.Parameters["Quantity"].Value = furniture.Quantity;

                            cmd.ExecuteNonQuery();
                        }

                        string furnitureInventoryUpdateStatement = @"UPDATE [inventory]
                                                                     SET [quantity] = [quantity] + @Quantity
                                                                     WHERE [furnitureID] = @FurnitureID;";

                        using (SqlCommand cmd = new SqlCommand(furnitureInventoryUpdateStatement, connection, transaction))
                        {
                            cmd.Parameters.Add("Quantity", SqlDbType.Int);
                            cmd.Parameters["Quantity"].Value = furniture.Quantity;

                            cmd.Parameters.Add("FurnitureID", SqlDbType.Int);
                            cmd.Parameters["FurnitureID"].Value = furniture.FurnitureID;

                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
            }
        }
        #endregion
    }
}
