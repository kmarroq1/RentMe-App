using RentMe_App.Model;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;

namespace RentMe_App.DAL
{
    /// <summary>
    /// data layer class used to access the rental tables
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class RentalDBDAL
    {
        #region Methods

        /// <summary>
        /// Writes the Rental Transaction to the appropriate tables.
        /// </summary>
        /// <param name="memberID">memberID of member renting</param>
        /// <param name="employeeID">employeeID of employee assisting</param>
        /// <param name="transactionDate">date transaction was made</param>
        /// <param name="returnDate">date customer will return</param>
        /// <param name="rentalFurnitureList">list of furniture to rent</param>
        /// <returns>returns bool to indicate completed</returns>
        public bool CreateRentalTransaction(int memberID, int employeeID,
            DateTime returnDate, List<FurnitureInventory> rentalFurnitureList)
        {
            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    string rentalTransactionInsertStatement = @"INSERT INTO [rentalTransaction]
                                                                    ( employeeID, memberID, transaction_date, return_date )
                                                                OUTPUT INSERTED.transactionID
                                                                VALUES
                                                                    ( @EmployeeID, @MemberID, @TransactionDate, @ReturnDate )
                                                                ;";

                    int newRentalID = -1;

                    using (SqlCommand cmd = new SqlCommand(rentalTransactionInsertStatement, connection, transaction))
                    {
                        cmd.Parameters.Add("EmployeeID", SqlDbType.Int);
                        cmd.Parameters["EmployeeID"].Value = employeeID;

                        cmd.Parameters.Add("MemberID", SqlDbType.Int);
                        cmd.Parameters["MemberID"].Value = memberID;

                        cmd.Parameters.Add("TransactionDate", SqlDbType.DateTime);
                        cmd.Parameters["TransactionDate"].Value = DateTime.Now;

                        cmd.Parameters.Add("ReturnDate", SqlDbType.Date);
                        cmd.Parameters["ReturnDate"].Value = returnDate;

                        newRentalID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    foreach (FurnitureInventory furniture in rentalFurnitureList)
                    {
                        string furnitureRentedInsertStatement = @"INSERT INTO [furnitureRented]
	                                                                    (furnitureID, rental_transactionID, quantity)
                                                                    VALUES
	                                                                    (@FurnitureID, @RentalID, @Quantity)
                                                                    ;";

                        using (SqlCommand cmd = new SqlCommand(furnitureRentedInsertStatement, connection, transaction))
                        {
                            cmd.Parameters.Add("FurnitureID", SqlDbType.Int);
                            cmd.Parameters["FurnitureID"].Value = furniture.FurnitureID;

                            cmd.Parameters.Add("RentalID", SqlDbType.Int);
                            cmd.Parameters["RentalID"].Value = newRentalID;

                            cmd.Parameters.Add("Quantity", SqlDbType.Int);
                            cmd.Parameters["Quantity"].Value = furniture.Quantity;

                            cmd.ExecuteNonQuery();
                        }

                        string furnitureInventoryUpdateStatement = @"UPDATE [inventory]
                                                                     SET [quantity] = [quantity] - @Quantity
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
            return true;
        }

        #endregion
    }
}
