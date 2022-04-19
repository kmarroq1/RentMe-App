using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace RentMe_App.DAL
{
    /// <summary>
    /// data layer class used to access the rental tables
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class RentalDBDAL
    {
        #region Data Members

        private int transactionID;
        private string furnitureRentedValues;
        private string inventoryValues;

        #endregion

        #region Methods

        /// <summary>
        /// adds a rental transaction to the rental tables
        /// </summary>
        /// <param name="memberID">memberID of member renting</param>
        /// <param name="employeeID">employeeID of employee assisting</param>
        /// <param name="transactionDate">date transaction was made</param>
        /// <param name="returnDate">date customer will return</param>
        /// <param name="rentalFurnitureList">list of furniture to rent</param>
        /// <returns>returns bool to indicate completed</returns>
        public bool CreateRentalTransaction(int memberID, int employeeID, DateTime transactionDate,
            DateTime returnDate, List<FurnitureInventory> rentalFurnitureList)
        {
            bool transactionComplete = false;

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    //insert rental to create transaction
                    string insertRentalTransactionStatement =
                        "INSERT INTO rentalTransaction (employeeID, memberID, transaction_date, return_date) " +
                        "VALUES (@employeeID, @memberID, @transactionDate, @returnDate)" +
                        "; SELECT SCOPE_IDENTITY()";
                    int insertedRentalTransaction;
                    using (SqlCommand insertRentalTransactionCommand = new SqlCommand(insertRentalTransactionStatement, connection, transaction))
                    {
                        insertRentalTransactionCommand.Parameters.AddWithValue("@employeeID", employeeID);
                        insertRentalTransactionCommand.Parameters.AddWithValue("@memberID", memberID);
                        insertRentalTransactionCommand.Parameters.AddWithValue("@lname", transactionDate);
                        insertRentalTransactionCommand.Parameters.AddWithValue("@phone", returnDate);

                        insertedRentalTransaction = Convert.ToInt32(insertRentalTransactionCommand.ExecuteScalar());
                    }

                    

                    transaction.Commit();
                    transactionComplete = true;
                }
            }
            return transactionComplete;
        }

        #endregion
    }
}
