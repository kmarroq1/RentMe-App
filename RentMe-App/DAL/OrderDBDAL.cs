using RentMe_App.Model;
using RentMe_App.UserControls.MemberDashboardUCs;
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

        internal List<Order> GetOrderHistory(int memberID)
        {
            List<Order> orderList = new List<Order>();

            string selectStatement = "";
            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberID", memberID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return null;
                        }

                        while (reader.Read())
                        {
                            Order order = new Order
                            {
                                TransactionID = 0,
                                OrderType = "",
                                //OrderDate = 0,
                                //DueDate = 0,
                                //DateReturned = 0,
                                OrderTotal = 0,
                                Status = false,
                                Balance = 0,
                                FurnitureList = null,
                            };
                            orderList.Add(order);
                        }
                    }
                }
            }

            return orderList;
        }

        internal List<Order> GetOrdersByTransactionId(int memberID, int transactionID)
        {
            List<Order> orderList = new List<Order>();
            List<Furniture> furnitureList = new List<Furniture>();

            string selectStatement = "";
            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberID", memberID);
                    selectCommand.Parameters.AddWithValue("@transactionID", transactionID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return null;
                        }

                        while (reader.Read())
                        {
                            Order order = new Order
                            {
                                TransactionID = 0,
                                OrderType = "",
                                //OrderDate = 0,
                                //DueDate = 0,
                                //DateReturned = 0,
                                OrderTotal = 0,
                                Status = false,
                                Balance = 0,
                                FurnitureList = null,
                            };
                            orderList.Add(order);
                        }
                    }
                }
            }

            return orderList;
        }

        #endregion

    }
}
