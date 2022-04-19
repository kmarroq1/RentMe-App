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

            string returnSelectStatement = "SELECT returns.transactionID as returnTransactionId, returns.employeeID as employeeID, rentals.transaction_date as date_ordered , rentals.return_date as due_date, returns.return_date, returns.employeeID " +
                "FROM returnTransaction AS returns " +
                "LEFT JOIN furnitureReturned ON returns.transactionID = furnitureReturned.return_transactionID " +
                "LEFT JOIN furnitureRented ON furnitureReturned.rental_transactionID = furnitureRented.rental_transactionID AND furnitureReturned.furnitureID = furnitureRented.furnitureID " +
                "LEFT JOIN rentalTransaction AS rentals ON furnitureRented.rental_transactionID = rentals.transactionID " +
                "WHERE memberId = @memberId";

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
                                OrderDate = (DateTime)reader["date_ordered"],
                                DueDate = (DateTime)reader["due_date"],
                                DateReturned = (DateTime)reader["return_date"],
                                OrderTotal = 0,
                                Open = false,
                                Balance = 0,
                                MemberID = memberID,
                                EmployeeID = (int)reader["employeeID"],
                            };
                            orderList.Add(order);
                        }
                    }
                }

                string rentalSelectStatement = "SELECT rentalTransaction.transactionID as rentalTransactionId, rentalTransaction.employeeID as employeeID, transaction_date as date_ordered, rentalTransaction.return_date as due_date, returnTransaction.return_date as return_date, furnitureRented.quantity - furnitureReturned.quantity as openQuantity " +
                    "FROM rentalTransaction " +
                    "LEFT JOIN furnitureReturned ON furnitureReturned.rental_transactionID = rentalTransaction.transactionID " +
                    "LEFT JOIN returnTransaction ON furnitureReturned.return_transactionID = returnTransaction.transactionID " +
                    "LEFT JOIN furnitureRented ON returnTransaction.transactionID = furnitureRented.rental_transactionID " +
                    "WHERE memberID = @memberID";

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
                                OrderDate = (DateTime)reader["date_ordered"],
                                DueDate = (DateTime)reader["due_date"],
                                DateReturned = reader["return_date"] == DBNull.Value ? null : (DateTime?)reader["return_date"],
                                OrderTotal = 0,
                                Open = reader["openQuantity"] == DBNull.Value ? true : (int)reader["openQuantity"] > 0,
                                Balance = 0,
                                MemberID = memberID,
                                EmployeeID = (int)reader["employeeID"],
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

            string returnSelectStatement = "SELECT returns.transactionID as returnTransactionId, returns.employeeID as employeeID, rentals.transaction_date as date_ordered , rentals.return_date as due_date, returns.return_date, returns.employeeID " +
                "FROM returnTransaction AS returns " +
                "LEFT JOIN furnitureReturned ON returns.transactionID = furnitureReturned.return_transactionID " +
                "LEFT JOIN furnitureRented ON furnitureReturned.rental_transactionID = furnitureRented.rental_transactionID AND furnitureReturned.furnitureID = furnitureRented.furnitureID " +
                "LEFT JOIN rentalTransaction AS rentals ON furnitureRented.rental_transactionID = rentals.transactionID " +
                "WHERE memberId = @memberId AND returns.transactionID = @transactionID";

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
                                OrderDate = (DateTime)reader["date_ordered"],
                                DueDate = (DateTime)reader["due_date"],
                                DateReturned = (DateTime)reader["return_date"],
                                OrderTotal = 0,
                                Open = false,
                                Balance = 0,
                                MemberID = memberID,
                                EmployeeID = (int)reader["employeeID"],
                            };
                            orderList.Add(order);
                        }
                    }
                }

                string rentalSelectStatement = "SELECT rentalTransaction.transactionID as rentalTransactionId, rentalTransaction.employeeID as employeeID, transaction_date as date_ordered, rentalTransaction.return_date as due_date, returnTransaction.return_date as return_date, furnitureRented.quantity - furnitureReturned.quantity as openQuantity " +
                    "FROM rentalTransaction " +
                    "LEFT JOIN furnitureReturned ON furnitureReturned.rental_transactionID = rentalTransaction.transactionID " +
                    "LEFT JOIN returnTransaction ON furnitureReturned.return_transactionID = returnTransaction.transactionID " +
                    "LEFT JOIN furnitureRented ON returnTransaction.transactionID = furnitureRented.rental_transactionID " +
                    "WHERE memberId = @memberId AND rentalTransaction.transactionID = @transactionID";

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
                                OrderDate = (DateTime)reader["date_ordered"],
                                DueDate = (DateTime)reader["due_date"],
                                DateReturned = reader["return_date"] == DBNull.Value ? null : (DateTime?)reader["return_date"],
                                OrderTotal = 0,
                                Open = reader["openQuantity"] == DBNull.Value ? true : (int)reader["openQuantity"] > 0,
                                Balance = 0,
                                MemberID = memberID,
                                EmployeeID = (int)reader["employeeID"],
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
            List<FurnitureInventory> furnitureList = new List<FurnitureInventory>();

            /* var selectOrderTotalStatement = "SELECT rt.transactionID, SUM(quantity * daily_rental_rate) as orderTotal " +
                 "FROM rentalTransaction rt" +
                 "LEFT JOIN furnitureRented fr ON rt.transactionID = fr.rental_transactionID " +
                 "LEFT JOIN furniture ON furniture.furnitureID = fr.furnitureID " +
                 "WHERE rt.transactionID = @transactionID " +
                 "GROUP BY rt.transactionID";*/

            // need to get quantities
            string furnitureSelectStatement = "SELECT furniture.furnitureID as furnitureID, name, description, style_name, category_name, daily_rental_rate, daily_fine_rate, image_small_url, image_large_url, quantity " +
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
                            FurnitureInventory furniture = new FurnitureInventory
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
                                Quantity = (int)reader["quantity"],
                            };
                            furnitureList.Add(furniture);
                        }
                    }
                }
                //Figure out order total query bug. Maybe make it its own query
                /* using (SqlCommand selectCommand = new SqlCommand(selectOrderTotalStatement, connection))
                   {
                       selectCommand.Parameters.AddWithValue("@transactionID", currentOrder.TransactionID);

                       using (SqlDataReader reader = selectCommand.ExecuteReader())
                       {
                           currentOrder.OrderTotal = (int)reader["orderTotal"];
                       }
                   }*/

            }
            currentOrder.FurnitureList = furnitureList;
            return currentOrder;
        }

        #endregion

    }
}
