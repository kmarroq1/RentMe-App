using RentMe_App.UserControls.MemberDashboardUCs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe_App.DAL
{
    /// <summary>
    /// Order history data access layer
    /// </summary>
    class OrderDBDAL
    {
        #region Queries

        /// <summary>
        /// Gets all order history
        /// </summary>
        /// <param name="memberID"></param>
        /// <returns></returns>
        public List<Order> GetOrderHistory(int memberID)
        {
            List<Order> orderList = new List<Order>();

            string returnSelectStatement = "SELECT returns.transactionID as returnTransactionId, returns.employeeID, returns.return_date as return_date " +
                "FROM returnTransaction AS returns " +
                "JOIN furnitureReturned ON returns.transactionID = furnitureReturned.return_transactionID " +
                "JOIN rentalTransaction ON rentalTransaction.transactionID = furnitureReturned.rental_transactionID " +
                "WHERE rentalTransaction.memberId = @memberId";

            //some items that have been rented may have been returned - need to make sure DateReturned and status reflects that
            string rentalSelectStatement = "SELECT transactionID as rentalTransactionId, employeeID, memberID, transaction_date, return_date " +
                "FROM rentalTransaction " +
                "WHERE memberID = @memberID";

            //add error handling i.e. check to make sure you can't return more than what was rented out
            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(returnSelectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberID", memberID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Order order = new Order
                            {
                                TransactionID = (int)reader["returnTransactionId"],
                                OrderType = "return",
                                OrderDate = (DateTime)reader["return_date"],
                                DueDate = (DateTime)reader["return_date"],
                                DateReturned = (DateTime)reader["return_date"],
                                OrderTotal = 0,
                                Status = false,
                                Balance = 0,
                            };
                            orderList.Add(order);
                        }
                    }
                }

                using (SqlCommand selectCommand = new SqlCommand(rentalSelectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberID", memberID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Order order = new Order
                            {
                                TransactionID = (int)reader["rentalTransactionId"],
                                OrderType = "rental",
                                OrderDate = (DateTime)reader["transaction_date"],
                                DueDate = (DateTime)reader["return_date"],
                                DateReturned = null,
                                OrderTotal = 0,
                                Status = true,
                                Balance = 0,
                            };
                            orderList.Add(order);
                        }
                    }
                }

            }

            return orderList;
        }

        /// <summary>
        /// Gets all orders by given transaction id
        /// </summary>
        /// <param name="memberID"></param>
        /// <param name="transactionID"></param>
        /// <returns></returns>
        public List<Order> GetOrdersByTransactionId(int memberID, int transactionID)
        {
            List<Order> orderList = new List<Order>();

            string returnSelectStatement = "SELECT returns.transactionID as returnTransactionId, returns.employeeID, returns.return_date as return_date " +
                "FROM returnTransaction AS returns " +
                "JOIN furnitureReturned ON returns.transactionID = furnitureReturned.return_transactionID " +
                "JOIN rentalTransaction ON rentalTransaction.transactionID = furnitureReturned.rental_transactionID " +
                "WHERE rentalTransaction.memberId = @memberId AND returns.transactionID = @transactionID";

            //some items that have been rented may have been returned - need to make sure DateReturned and status reflects that
            string rentalSelectStatement = "SELECT transactionID as rentalTransactionId, employeeID, memberID, transaction_date, return_date " +
                "FROM rentalTransaction " +
                "WHERE memberID = @memberID AND transactionID = @transactionID";

            //add error handling i.e. check to make sure you can't return more than what was rented out
            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(returnSelectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberID", memberID);
                    selectCommand.Parameters.AddWithValue("@transactionID", transactionID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Order order = new Order
                            {
                                TransactionID = (int)reader["returnTransactionId"],
                                OrderType = "return",
                                OrderDate = (DateTime)reader["return_date"],
                                DueDate = (DateTime)reader["return_date"],
                                DateReturned = (DateTime)reader["return_date"],
                                OrderTotal = 0,
                                Status = false,
                                Balance = 0,
                            };
                            orderList.Add(order);
                        }
                    }
                }

                using (SqlCommand selectCommand = new SqlCommand(rentalSelectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberID", memberID);
                    selectCommand.Parameters.AddWithValue("@transactionID", transactionID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Order order = new Order
                            {
                                TransactionID = (int)reader["rentalTransactionId"],
                                OrderType = "rental",
                                OrderDate = (DateTime)reader["transaction_date"],
                                DueDate = (DateTime)reader["return_date"],
                                DateReturned = null,
                                OrderTotal = 0,
                                Status = true,
                                Balance = 0,
                            };
                            orderList.Add(order);
                        }
                    }
                }

            }

            return orderList;
        }

        /// <summary>
        /// Updates furniture list in a given order
        /// </summary>
        /// <param name="currentOrder"></param>
        /// <returns></returns>
        public Order GetOrderFurnitureList(Order currentOrder)
        {
            var selectStatement = "SELECT transactionID, SUM(quantity * daily_rental_rate) as price " +
                "FROM rentalTransaction rtLEFT " +
                "JOIN furnitureRented fr ON rt.transactionID = fr.rental_transactionIDLEFT " +
                "JOIN furniture ON furniture.furnitureID = fr.furnitureID " +
                "GROUP BY transactionID";
            throw new NotImplementedException();
        }

        #endregion

    }
}
