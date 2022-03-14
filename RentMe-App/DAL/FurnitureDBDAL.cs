using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;

namespace RentMe_App.DAL
{
    /// <summary>
    /// data layer class used to access the furniture
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class FurnitureDBDAL
    {
        #region Methods

        /// <summary>
        /// method used to connect to the database and run a query to return furniture
        /// </summary>
        /// <param name="furnitureID">furniture furnitureID</param>
        /// <returns>list of furniture objects</returns>
        public List<Furniture> GetFurnitureByID(int furnitureID)
        {
            List<Furniture> furnitureList = new List<Furniture>();

            string selectStatement =
                "SELECT * " +
                "FROM furniture " +
                "WHERE " +
                "furnitureID = @furnitureID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@furnitureID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@furnitureID"].Value = furnitureID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture
                            {
                                FurnitureID = (int)reader["furnitureID"],
                                Name = reader["name"].ToString(),
                                Description = reader["description"].ToString(),
                                Daily_Rental_Rate = (Decimal)reader["daily_rental_rate"],
                                Daily_Fine_Rate = (Decimal)reader["daily_fine_rate"],
                                Style_Name = reader["style_name"].ToString(),
                                Category_Name = reader["category_name"].ToString(),
                                Image_Small_Url = reader["image_small_url"].ToString(),
                                Image_Large_Url = reader["image_large_url"].ToString()
                            };
                            furnitureList.Add(furniture);
                        }
                    }
                }
            }
            return furnitureList;
        }

        /// <summary>
        /// method used to connect to the database and run a query to return furniture
        /// </summary>
        /// <param name="style_name">furniture style name</param>
        /// <returns>list of furniture objects</returns>
        public List<Furniture> GetFurnitureByStyle(string style_name)
        {
            List<Furniture> furnitureList = new List<Furniture>();

            string selectStatement =
                "SELECT * " +
                "FROM furniture " +
                "WHERE " +
                "style_name = @style_name " +
                "ORDER BY furnitureID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@style_name", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@style_name"].Value = style_name;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture
                            {
                                FurnitureID = (int)reader["furnitureID"],
                                Name = reader["name"].ToString(),
                                Description = reader["description"].ToString(),
                                Daily_Rental_Rate = (Decimal)reader["daily_rental_rate"],
                                Daily_Fine_Rate = (Decimal)reader["daily_fine_rate"],
                                Style_Name = reader["style_name"].ToString(),
                                Category_Name = reader["category_name"].ToString(),
                                Image_Small_Url = reader["image_small_url"].ToString(),
                                Image_Large_Url = reader["image_large_url"].ToString()
                            };
                            furnitureList.Add(furniture);
                        }
                    }
                }
            }
            return furnitureList;
        }

        /// <summary>
        /// method used to connect to the database and run a query to return furniture
        /// </summary>
        /// <param name="category_name">furniture category name</param>
        /// <returns>list of furniture objects</returns>
        public List<Furniture> GetFurnitureByCategory(string category_name)
        {
            List<Furniture> furnitureList = new List<Furniture>();

            string selectStatement =
                "SELECT * " +
                "FROM furniture " +
                "WHERE " +
                "category_name = @category_name " +
                "ORDER BY furnitureID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@category_name", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@category_name"].Value = category_name;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture
                            {
                                FurnitureID = (int)reader["furnitureID"],
                                Name = reader["name"].ToString(),
                                Description = reader["description"].ToString(),
                                Daily_Rental_Rate = (Decimal)reader["daily_rental_rate"],
                                Daily_Fine_Rate = (Decimal)reader["daily_fine_rate"],
                                Style_Name = reader["style_name"].ToString(),
                                Category_Name = reader["category_name"].ToString(),
                                Image_Small_Url = reader["image_small_url"].ToString(),
                                Image_Large_Url = reader["image_large_url"].ToString()
                            };
                            furnitureList.Add(furniture);
                        }
                    }
                }
            }
            return furnitureList;
        }

        /// <summary>
        /// method used to connect to the database and run a query to return furniture
        /// </summary>
        /// <param name="category_name">furniture category name</param>
        /// <param name="style_name">furniture style name</param>
        /// <returns>list of furniture objects</returns>
        public List<Furniture> GetFurnitureByCategoryStyle(string category_name, string style_name)
        {
            List<Furniture> furnitureList = new List<Furniture>();

            string selectStatement =
                "SELECT * " +
                "FROM furniture " +
                "WHERE " +
                "category_name = @category_name " +
                "AND style_name = @style_name " +
                "ORDER BY furnitureID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@category_name", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@category_name"].Value = category_name;

                    selectCommand.Parameters.Add("@style_name", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@style_name"].Value = style_name;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture
                            {
                                FurnitureID = (int)reader["furnitureID"],
                                Name = reader["name"].ToString(),
                                Description = reader["description"].ToString(),
                                Daily_Rental_Rate = (Decimal)reader["daily_rental_rate"],
                                Daily_Fine_Rate = (Decimal)reader["daily_fine_rate"],
                                Style_Name = reader["style_name"].ToString(),
                                Category_Name = reader["category_name"].ToString(),
                                Image_Small_Url = reader["image_small_url"].ToString(),
                                Image_Large_Url = reader["image_large_url"].ToString()
                            };
                            furnitureList.Add(furniture);
                        }
                    }
                }
            }
            return furnitureList;
        }

        #endregion
    }
}
