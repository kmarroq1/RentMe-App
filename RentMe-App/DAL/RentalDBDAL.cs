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
        /// <returns>returns int transaction_id to indicate completed</returns>
        public int CreateRentalTransaction(int memberID, int employeeID,
            DateTime returnDate, List<FurnitureInventory> rentalFurnitureList)
        {
            int newRentalID;

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

                    newRentalID = -1;
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
            return newRentalID;
        }

        /// <summary>
        /// method used to get rental object by transactionID
        /// </summary>
        /// <param name="transactionID">transactionID of rental</param>
        /// <returns>rental transaction details</returns>
        public Rental GetRentalByID(int transactionID)
        {
            Rental rentalTransaction = new Rental();

            string selectStatement =
                "SELECT * " +
                "FROM rentalTransaction " +
                "WHERE " +
                "transactionID = @transactionID;";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@transactionID", SqlDbType.Int);
                    selectCommand.Parameters["@transactionID"].Value = transactionID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rentalTransaction = new Rental()
                            {
                                TransactionID = (int)reader["transactionID"],
                                EmployeeID = (int)reader["employeeID"],
                                MemberID = (int)reader["memberID"],
                                TransactionDate = (DateTime)reader["transaction_date"],
                                ReturnDate = (DateTime)reader["return_date"],
                            };
                        }
                    }
                }
            }
            return rentalTransaction;
        }

        public List<FurnitureInventory> GetRentalFurniture(int transactionID)
        {
            List<FurnitureInventory> rentalFurnitureList = new List<FurnitureInventory>();

            string selectStatement =
                "SELECT " +
                "FUR.furnitureID" +
                ", FUR.name " +
                ", FUR.description " +
                ", FUR.daily_rental_rate " +
                ", FUR.daily_fine_rate " +
                ", FUR.style_name " +
                ", FUR.category_name " +
                ", FUR.image_small_url " +
                ", FUR.image_large_url " +
                ", REN.quantity " +
                "FROM furniture FUR " +
                "JOIN furnitureRented REN " +
                "   ON FUR.furnitureID = REN.furnitureID " +
                "WHERE " +
                "REN.rental_transactionID = @transactionID " +
                "ORDER BY FUR.furnitureID;";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@transactionID", SqlDbType.Int);
                    selectCommand.Parameters["@transactionID"].Value = transactionID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FurnitureInventory furnitureInventory = new FurnitureInventory
                            {
                                FurnitureID = (int)reader["furnitureID"],
                                Name = reader["name"].ToString(),
                                Description = reader["description"].ToString(),
                                Daily_Rental_Rate = (decimal)reader["daily_rental_rate"],
                                Daily_Fine_Rate = (decimal)reader["daily_fine_rate"],
                                Style_Name = reader["style_name"].ToString(),
                                Category_Name = reader["category_name"].ToString(),
                                Image_Small_Url = reader["image_small_url"].ToString(),
                                Image_Large_Url = reader["image_large_url"].ToString(),
                                Quantity = (int)reader["quantity"]
                            };
                            rentalFurnitureList.Add(furnitureInventory);
                        }
                    }
                }
            }
            return rentalFurnitureList;
        }

        #endregion
    }
}
