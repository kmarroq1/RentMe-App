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

            string returnSelectStatement = "SELECT MAX(rentals.transactionID) as rentalTransactionId, returns.transactionID as returnTransactionId, MAX(returns.employeeID) as employeeID, rentals.transaction_date as date_ordered , rentals.return_date as due_date, MAX(returns.return_date) as return_date, rentals.employeeID " +
                "FROM returnTransaction AS returns " +
                "LEFT JOIN furnitureReturned ON returns.transactionID = furnitureReturned.return_transactionID " +
                "LEFT JOIN furnitureRented ON furnitureReturned.rental_transactionID = furnitureRented.rental_transactionID AND furnitureReturned.furnitureID = furnitureRented.furnitureID " +
                "LEFT JOIN rentalTransaction AS rentals ON furnitureRented.rental_transactionID = rentals.transactionID " +
                "WHERE memberId = @memberId " +
                "GROUP BY returns.transactionID, rentals.transaction_date, rentals.return_date, rentals.employeeID ";

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
                                RentalTransactionID = (int?)reader["rentalTransactionId"],
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

                string rentalSelectStatement = "SELECT rentalTransaction.transactionID as rentalTransactionId, " +
                        "MAX(rentalTransaction.employeeID) as employeeID, transaction_date as date_ordered, " +
                        "MIN(rentalTransaction.return_date) as due_date, " +
                        "(CASE WHEN MAX(CASE WHEN returnTransaction.return_date IS NULL THEN 1 ELSE 0 END) = 0 THEN MAX(returnTransaction.return_date) END) as return_date, " +
                        "SUM(furnitureRented.quantity * furniture.daily_rental_rate) as order_total, " +
                        "MAX(CASE WHEN (furnitureRented.quantity - (CASE WHEN furnitureReturned.quantity IS NULL THEN 0 ELSE furnitureReturned.quantity END)) > 0 THEN 1 ELSE 0 END) as open_status " +
                    "FROM rentalTransaction " +
                    "LEFT JOIN furnitureRented ON furnitureRented.rental_transactionID = rentalTransaction.transactionID " +
                    "LEFT JOIN furnitureReturned ON furnitureReturned.rental_transactionID = rentalTransaction.transactionID AND furnitureReturned.furnitureID = furnitureRented.furnitureID AND furnitureReturned.quantity = furnitureRented.quantity " +
                    "LEFT JOIN returnTransaction ON returnTransaction.transactionID = furnitureReturned.return_transactionID " +
                    "LEFT JOIN furniture ON furnitureRented.furnitureID = furniture.furnitureID " +
                    "WHERE memberID = @memberID " +
                    "GROUP BY rentalTransaction.transactionID, transaction_date";

                using (SqlCommand selectCommand = new SqlCommand(rentalSelectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberID", memberID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double.TryParse(reader["order_total"].ToString(), out double result);
                            result *= (((DateTime)reader["due_date"]).Date - ((DateTime)reader["date_ordered"]).Date).Days;

                            Order order = new Order
                            {
                                TransactionID = (int)reader["rentalTransactionId"],
                                OrderType = "rental",
                                OrderDate = (DateTime)reader["date_ordered"],
                                DueDate = (DateTime)reader["due_date"],
                                DateReturned = reader["return_date"] == DBNull.Value ? null : (DateTime?)reader["return_date"],
                                OrderTotal = result,
                                Open = (int)reader["open_status"] == 1,
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

            string returnSelectStatement = "SELECT MAX(rentals.transactionID) as rentalTransactionId, returns.transactionID as returnTransactionId, MAX(returns.employeeID) as employeeID, rentals.transaction_date as date_ordered , rentals.return_date as due_date, MAX(returns.return_date) as return_date, rentals.employeeID " +
                "FROM returnTransaction AS returns " +
                "LEFT JOIN furnitureReturned ON returns.transactionID = furnitureReturned.return_transactionID " +
                "LEFT JOIN furnitureRented ON furnitureReturned.rental_transactionID = furnitureRented.rental_transactionID AND furnitureReturned.furnitureID = furnitureRented.furnitureID " +
                "LEFT JOIN rentalTransaction AS rentals ON furnitureRented.rental_transactionID = rentals.transactionID " +
                "WHERE memberId = @memberId AND returns.transactionID = @transactionID " +
                "GROUP BY returns.transactionID, rentals.transaction_date, rentals.return_date, rentals.employeeID ";

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
                                RentalTransactionID = (int?)reader["rentalTransactionId"],
                                TransactionID = (int)reader["returnTransactionId"],
                                OrderType = "return",
                                OrderDate = (DateTime)reader["date_ordered"],
                                DueDate = (DateTime)reader["due_date"],
                                DateReturned = (DateTime)reader["return_date"],
                                OrderTotal = 0,
                                Open = false,
                                MemberID = memberID,
                                EmployeeID = (int)reader["employeeID"],
                            };
                            orderList.Add(order);
                        }
                    }
                }

                string rentalSelectStatement = "SELECT rentalTransaction.transactionID as rentalTransactionId, " +
                        "MAX(rentalTransaction.employeeID) as employeeID, transaction_date as date_ordered, " +
                        "MIN(rentalTransaction.return_date) as due_date, " +
                        "(CASE WHEN MAX(CASE WHEN returnTransaction.return_date IS NULL THEN 1 ELSE 0 END) = 0 THEN MAX(returnTransaction.return_date) END) as return_date, " +
                        "SUM(furnitureRented.quantity * furniture.daily_rental_rate) as order_total, " +
                        "MAX(CASE WHEN (furnitureRented.quantity - (CASE WHEN furnitureReturned.quantity IS NULL THEN 0 ELSE furnitureReturned.quantity END)) > 0 THEN 1 ELSE 0 END) as open_status " +
                    "FROM rentalTransaction " +
                    "LEFT JOIN furnitureRented ON furnitureRented.rental_transactionID = rentalTransaction.transactionID " +
                    "LEFT JOIN furnitureReturned ON furnitureReturned.rental_transactionID = rentalTransaction.transactionID AND furnitureReturned.furnitureID = furnitureRented.furnitureID AND furnitureReturned.quantity = furnitureRented.quantity " +
                    "LEFT JOIN returnTransaction ON returnTransaction.transactionID = furnitureReturned.return_transactionID " +
                    "LEFT JOIN furniture ON furnitureRented.furnitureID = furniture.furnitureID " +
                    "WHERE memberId = @memberId AND rentalTransaction.transactionID = @transactionID " +
                    "GROUP BY rentalTransaction.transactionID, transaction_date";

                using (SqlCommand selectCommand = new SqlCommand(rentalSelectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberID", memberID);
                    selectCommand.Parameters.AddWithValue("@transactionID", transactionID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double.TryParse(reader["order_total"].ToString(), out double result);
                            result *= (((DateTime)reader["due_date"]).Date - ((DateTime)reader["date_ordered"]).Date).Days;

                            Order order = new Order
                            {
                                TransactionID = (int)reader["rentalTransactionId"],
                                OrderType = "rental",
                                OrderDate = (DateTime)reader["date_ordered"],
                                DueDate = (DateTime)reader["due_date"],
                                DateReturned = reader["return_date"] == DBNull.Value ? null : (DateTime?)reader["return_date"],
                                OrderTotal = result,
                                Open = (int)reader["open_status"] == 1,
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

            string furnitureSelectStatement = "SELECT furniture.furnitureID as furnitureID, name, description, style_name, category_name, daily_rental_rate, daily_fine_rate, image_small_url, image_large_url, furnitureRented.quantity as qty_rented, SUM(furnitureReturned.quantity) as qty_returned " +
                "FROM furniture ";
            if (currentOrder.OrderType == "rental")
            {
                furnitureSelectStatement += "LEFT JOIN furnitureRented ON furniture.furnitureID = furnitureRented.furnitureID " +
                    "LEFT JOIN furnitureReturned ON furnitureReturned.rental_transactionID = furnitureRented.rental_transactionID AND furnitureReturned.furnitureID = furnitureRented.furnitureID " +
                    "WHERE furnitureRented.rental_transactionID = @transactionID ";
            }
            else
            {
                furnitureSelectStatement += "LEFT JOIN furnitureReturned ON furnitureReturned.furnitureID = furniture.furnitureID " +
                    "LEFT JOIN furnitureRented ON furnitureRented.rental_transactionID = furnitureReturned.rental_transactionID AND furnitureReturned.furnitureID = furnitureRented.furnitureID " +
                    "WHERE return_transactionID = @transactionID ";
            }
            furnitureSelectStatement += "GROUP BY furnitureRented.rental_transactionID, furniture.furnitureID, name, description, style_name, category_name, daily_rental_rate, daily_fine_rate, image_small_url, image_large_url, furnitureRented.quantity ";

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
                                QuantityRented = reader["qty_rented"] == DBNull.Value ? null : (int?)reader["qty_rented"],
                                QuantityReturned = reader["qty_returned"] == DBNull.Value ? 0 : (int?)reader["qty_returned"],
                            };
                            furnitureList.Add(furniture);
                        }
                    }
                }

            }
            currentOrder.FurnitureList = furnitureList;
            return currentOrder;
        }

        /// <summary>
        /// Gets an order's pending status from the database
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool GetOrderStatus(Order order)
        {
            var isOpen = true;

            var stringStatusSelectStatement = "SELECT MAX(furnitureRented.quantity) - SUM(furnitureReturned.quantity) as pendingItems, MAX(returnTransaction.return_date) as return_date " +
                "FROM furnitureRented " +
                "JOIN furnitureReturned ON furnitureReturned.rental_transactionID = furnitureRented.rental_transactionID AND furnitureReturned.furnitureID = furnitureRented.furnitureID " +
                "JOIN rentalTransaction ON rentalTransaction.transactionID = furnitureRented.rental_transactionID " +
                "JOIN returnTransaction ON returnTransaction.transactionID = furnitureReturned.return_transactionID " +
                "WHERE furnitureRented.rental_transactionID = @transactionID " +
                "GROUP BY furnitureRented.rental_transactionID, rentalTransaction.transactionID, furnitureRented.quantity";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(stringStatusSelectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@transactionID", order.TransactionID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if ((int)reader["pendingItems"] > 0)
                            {
                                isOpen = true;
                            }
                            else
                            {
                                isOpen = false;
                            }
                            order.DateReturned = reader["return_date"] == DBNull.Value ? null : (DateTime?)reader["return_date"];

                        }
                    }
                }
            }
            return isOpen;
        }

        #endregion

    }
}
