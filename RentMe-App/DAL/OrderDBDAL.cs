using RentMe_App.Model;
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
            List<Furniture> furnitureList = new List<Furniture>();

            var selectOrderTotalStatement = "SELECT transactionID, SUM(quantity * daily_rental_rate) as orderTotal " +
                "FROM rentalTransaction rt" +
                "LEFT JOIN furnitureRented fr ON rt.transactionID = fr.rental_transactionID" +
                "LEFT JOIN furniture ON furniture.furnitureID = fr.furnitureID " +
                "GROUP BY transactionID";

            // add conditional statemnent for order type i.e. if rental, join rental table, etc..
            string furnitureSelectStatement = "SELECT furniture.furnitureID, name, description, daily_rental_rate, daily_fine_rate " +
                "FROM furniture ";
            if (currentOrder.OrderType == "rental")
            {
                furnitureSelectStatement += "LEFT JOIN furnitureRented ON furnitureRented.furnitureID = furniture.furnitureID " +
                    "WHERE rental_transactionID = @transactionID";
            }
            else
            {
                furnitureSelectStatement += "LEFT JOIN furnitureReturned ON furnitureReturned.furnitureID = furniture.furnitureID " +
                    "WHERE return_transactionID = @transactionID";
            }

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(furnitureSelectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@transactionID", currentOrder.TransactionID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture
                            {
                                FurnitureID = (int)reader["rentalTransactionId"],
                                Name = "",
                                Daily_Rental_Rate = 0,
                                Daily_Fine_Rate = 0,
                                Description = "",
                            };
                            furnitureList.Add(furniture);
                        }
                    }
                }

                using (SqlCommand selectCommand = new SqlCommand(selectOrderTotalStatement, connection))
                {

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        currentOrder.OrderTotal = (int)reader["orderTotal"];
                    }
                }

            }
            currentOrder.FurnitureList = furnitureList;
            return currentOrder;
        }

        #endregion

    }
}
