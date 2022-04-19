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

            //insert rental to create transaction
            string insertTransactionStatement =
                "INSERT INTO rentalTransaction (employeeID, memberID, transaction_date, return_date) " +
                "VALUES (@employeeID, @memberID, @transactionDate, @returnDate)" +
                ";";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertTransactionStatement, connection))
                {
                    insertCommand.Parameters.Add("@employeeID", System.Data.SqlDbType.Int);
                    insertCommand.Parameters["@employeeID"].Value = employeeID;
                    insertCommand.Parameters.Add("@memberID", System.Data.SqlDbType.Int);
                    insertCommand.Parameters["@memberID"].Value = memberID;
                    insertCommand.Parameters.Add("@transactionDate", System.Data.SqlDbType.DateTime);
                    insertCommand.Parameters["@transactionDate"].Value = transactionDate;
                    insertCommand.Parameters.Add("@returnDate", System.Data.SqlDbType.DateTime);
                    insertCommand.Parameters["@returnDate"].Value = returnDate;

                    insertCommand.ExecuteNonQuery();
                }
            }

            //get transactionID from transaction
            string selectTransactionIDStatement =
                "SELECT " +
                "transactionID " +
                "FROM rentalTransaction " +
                "WHERE " +
                "employeeID = @employeeID " +
                "AND memberID = @memberID " +
                "AND transaction_date = @transactionDate " +
                "AND return_date = @returnDate";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectTransactionIDStatement, connection))
                {
                    selectCommand.Parameters.Add("@employeeID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@employeeID"].Value = employeeID;
                    selectCommand.Parameters.Add("@memberID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@memberID"].Value = memberID;
                    selectCommand.Parameters.Add("@transactionDate", System.Data.SqlDbType.DateTime);
                    selectCommand.Parameters["@transactionDate"].Value = transactionDate;
                    selectCommand.Parameters.Add("@returnDate", System.Data.SqlDbType.DateTime);
                    selectCommand.Parameters["@returnDate"].Value = returnDate;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            transactionID = (int)reader["transactionID"];
                        }
                    }
                }
            }

            //insert furniture into furnitureRented
            int rentalFurnitureCount = rentalFurnitureList.Count();
            furnitureRentedValues = "";
            for (int count = 0; count < rentalFurnitureCount; count++)
            {
                if (count != rentalFurnitureCount - 1)
                {
                    furnitureRentedValues += "(" + rentalFurnitureList[count].FurnitureID.ToString()
                    + ", "
                    + transactionID.ToString()
                    + ", "
                    + rentalFurnitureList[count].Quantity.ToString()
                    + "),";
                }
                else
                {
                    furnitureRentedValues += "(" + rentalFurnitureList[count].FurnitureID.ToString()
                    + ", "
                    + transactionID.ToString()
                    + ", "
                    + rentalFurnitureList[count].Quantity.ToString()
                    + ")";
                }
            }

            string insertFurnitureStatement =
                    "INSERT INTO furnitureRented (furnitureID, rental_transactionID, quantity) " +
                    "VALUES " +
                    furnitureRentedValues +
                    ";";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertFurnitureStatement, connection))
                {
                    insertCommand.ExecuteNonQuery();
                }
            }

            //update inventory
            inventoryValues = "";
            for (int count = 0; count < rentalFurnitureCount; count++)
            {
                inventoryValues += "UPDATE inventory "
                + "SET furnitureID = "
                + rentalFurnitureList[count].FurnitureID.ToString()
                + ", quantity = quantity - "
                + rentalFurnitureList[count].Quantity.ToString()
                + " "
                + "WHERE furnitureID = "
                + rentalFurnitureList[count].FurnitureID.ToString()
                + "; ";

            }

            string updateInventoryStatement = inventoryValues;

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateInventoryStatement, connection))
                {
                    updateCommand.ExecuteNonQuery();
                }
            }


            transactionComplete = true;
            return transactionComplete;
        }

        #endregion
    }
}
