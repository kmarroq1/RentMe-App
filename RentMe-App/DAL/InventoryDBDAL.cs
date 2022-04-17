using RentMe_App.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RentMe_App.DAL
{
    /// <summary>
    /// Inventory data access layer
    /// </summary>
    public class InventoryDBDAL
    {
        #region Queries

        /// <summary>
        /// Query for getting the furniture with inventory by ID
        /// </summary>
        /// <param name="furnitureID">furniture furnitureID</param>
        /// <returns>list of furniture with inventory</returns>
        public List<FurnitureInventory> GetInventoryByID(int furnitureID)
        {
            List<FurnitureInventory> inventoryList = new List<FurnitureInventory>();

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
                ", INV.quantity " +
                "FROM furniture FUR " +
                "JOIN inventory INV " +
                "   ON FUR.furnitureID = INV.furnitureID " +
                "WHERE " +
                "INV.quantity > 0 " +
                "AND FUR.furnitureID = @furnitureID " +
                "ORDER BY FUR.furnitureID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@furnitureID", SqlDbType.Int);
                    selectCommand.Parameters["@furnitureID"].Value = furnitureID;

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
                            inventoryList.Add(furnitureInventory);
                        }
                    }
                }
            }
            return inventoryList;
        }

        /// <summary>
        /// Query for getting the furniture with inventory by style
        /// </summary>
        /// <param name="style_name">furniture style name</param>
        /// <returns>list of furniture with inventory</returns>
        public List<FurnitureInventory> GetInventoryByStyle(string style_name)
        {
            List<FurnitureInventory> inventoryList = new List<FurnitureInventory>();

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
                ", INV.quantity " +
                "FROM furniture FUR " +
                "JOIN inventory INV " +
                "   ON FUR.furnitureID = INV.furnitureID " +
                "WHERE " +
                "INV.quantity > 0 " +
                "AND FUR.style_name = @style_name " +
                "ORDER BY FUR.furnitureID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@style_name", SqlDbType.VarChar);
                    selectCommand.Parameters["@style_name"].Value = style_name;

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
                            inventoryList.Add(furnitureInventory);
                        }
                    }
                }
            }
            return inventoryList;
        }

        /// <summary>
        /// Query for getting the furniture with inventory by category
        /// </summary>
        /// <param name="category_name">furniture category name</param>
        /// <returns>list of furniture with inventory</returns>
        public List<FurnitureInventory> GetInventoryByCategory(string category_name)
        {
            List<FurnitureInventory> inventoryList = new List<FurnitureInventory>();

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
                ", INV.quantity " +
                "FROM furniture FUR " +
                "JOIN inventory INV " +
                "   ON FUR.furnitureID = INV.furnitureID " +
                "WHERE " +
                "INV.quantity > 0 " +
                "AND FUR.category_name = @category_name " +
                "ORDER BY FUR.furnitureID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@category_name", SqlDbType.VarChar);
                    selectCommand.Parameters["@category_name"].Value = category_name;

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
                            inventoryList.Add(furnitureInventory);
                        }
                    }
                }
            }
            return inventoryList;
        }

        /// <summary>
        /// Query for getting the furniture with inventory by category
        /// </summary>
        /// <param name="category_name">furniture category name</param>
        /// <param name="style_name">furniture style name</param>
        /// <returns>list of furniture with inventory</returns>
        public List<FurnitureInventory> GetInventoryByCategoryStyle(string category_name, string style_name)
        {
            List<FurnitureInventory> inventoryList = new List<FurnitureInventory>();

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
                ", INV.quantity " +
                "FROM furniture FUR " +
                "JOIN inventory INV " +
                "   ON FUR.furnitureID = INV.furnitureID " +
                "WHERE " +
                "INV.quantity > 0 " +
                "AND FUR.category_name = @category_name " +
                "AND FUR.style_name = @style_name " +
                "ORDER BY FUR.furnitureID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@category_name", SqlDbType.VarChar);
                    selectCommand.Parameters["@category_name"].Value = category_name;

                    selectCommand.Parameters.Add("@style_name", SqlDbType.VarChar);
                    selectCommand.Parameters["@style_name"].Value = style_name;

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
                            inventoryList.Add(furnitureInventory);
                        }
                    }
                }
            }
            return inventoryList;
        }
    }

    #endregion
}