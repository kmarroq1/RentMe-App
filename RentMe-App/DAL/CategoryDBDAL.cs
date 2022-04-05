using RentMe_App.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe_App.DAL
{
    /// <summary>
    /// data layer class used to access the category
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class CategoryDBDAL
    {
        #region Methods

        /// <summary>
        /// method used to connect to the database and run a query to return category
        /// </summary>
        /// <returns>list of categories</returns>
        public List<Category> GetAllCategories()
        {
            List<Category> categoryList = new List<Category>();

            string selectStatement =
                "SELECT * " +
                "FROM category " +
                "ORDER BY Name";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Category category = new Category
                            {
                                Name = reader["name"].ToString()
                            };
                            categoryList.Add(category);
                        }
                    }
                }
            }
            return categoryList;
        }

        #endregion
    }
}
