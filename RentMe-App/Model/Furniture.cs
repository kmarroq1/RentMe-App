using System;

namespace RentMe_App.Model
{
    /// <summary>
    /// model class used to define furniture
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class Furniture
    {
        #region Data Members

        /// <summary>
        /// getter/setter method for FurnitureID
        /// </summary>
        public int? FurnitureID { get; set; }

        /// <summary>
        /// getter/setter method for Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// getter/setter method for Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// getter/setter method for Daily_Rental_Rate
        /// </summary>
        public decimal Daily_Rental_Rate { get; set; }

        /// <summary>
        /// getter/setter method for Daily_Fine_Rate
        /// </summary>
        public decimal Daily_Fine_Rate { get; set; }

        /// <summary>
        /// getter/setter method for Style_Name
        /// </summary>
        public string Style_Name { get; set; }

        /// <summary>
        /// getter/setter method for Category_Name
        /// </summary>
        public string Category_Name { get; set; }

        /// <summary>
        /// getter/setter method for Image_Small_Url
        /// </summary>
        public string Image_Small_Url { get; set; }

        /// <summary>
        /// getter/setter method for Image_Large_Url
        /// </summary>
        public string Image_Large_Url { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public Furniture()
        {
        }

        /// <summary>
        /// constructor used to create furniture
        /// </summary>
        /// <param name="furnitureID">furnture furnitureID</param>
        /// <param name="name">furnture name</param>
        /// <param name="description">furniture description</param>
        /// <param name="daily_rental_rate">furniture daily_rental_rate</param>
        /// <param name="daily_fine_rate">furniture daily_fine_rate</param>
        /// <param name="style_name">furniture style_name</param>
        /// <param name="category_name">furniture category_name</param>
        /// <param name="image_small_url">furniture image_name of small url</param>
        /// <param name="image_large_url">furniture image_name of large url</param>
        public Furniture(int? furnitureID, string name, string description, decimal daily_rental_rate, 
            decimal daily_fine_rate, string style_name, string category_name, string image_small_url, string image_large_url)
        {
            if (furnitureID < 0)
            {
                throw new ArgumentOutOfRangeException("furnitureID", "FurnitureID has to be number greater than 0");

            }

            if (string.IsNullOrEmpty(name) || name.Length > 100)
            {
                throw new ArgumentException("Name cannot be null/empty or greater than 100", "name");

            }

            if (string.IsNullOrEmpty(description) || name.Length > 1500)
            {
                throw new ArgumentException("Description cannot be null/empty or greater than 1500", "description");

            }

            if (daily_rental_rate < 0)
            {
                throw new ArgumentOutOfRangeException("daily_rental_rate", "Daily_Rental_Rate has to be number greater than or equal to  0.0");

            }

            if (daily_fine_rate < 0)
            {
                throw new ArgumentOutOfRangeException("daily_fine_rate", "Daily_Fine_Rate has to be number greater than or equal to  0.0");

            }

            if (string.IsNullOrEmpty(style_name) || name.Length > 45)
            {
                throw new ArgumentException("Style_Name cannot be null/empty or greater than 45", "style_name");

            }

            if (string.IsNullOrEmpty(category_name) || name.Length > 45)
            {
                throw new ArgumentException("Category_Name cannot be null/empty or greater than 1500", "category_name");

            }

            if (image_small_url.Length > 200)
            {
                throw new ArgumentException("Image_Small_Url cannot be greater than 200", "image_small_url");

            }

            if (image_large_url.Length > 200)
            {
                throw new ArgumentException("Image_Large_Url cannot be greater than 200", "image_large_url");

            }

            this.FurnitureID = furnitureID;
            this.Name = name;
            this.Description = description;
            this.Daily_Rental_Rate = daily_rental_rate;
            this.Daily_Fine_Rate = daily_fine_rate;
            this.Style_Name = style_name;
            this.Category_Name = category_name;
            this.Image_Small_Url = image_small_url;
            this.Image_Large_Url = image_large_url;
        }

        #endregion
    }
}
