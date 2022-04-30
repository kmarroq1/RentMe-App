using System;

namespace RentMe_App.Model
{
    /// <summary>
    /// model class used to define report
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class Report
    {
        #region Data Members

        /// <summary>
        /// getter/setter method for FurnitureID
        /// </summary>
        public int FurnitureID { get; set; }

        /// <summary>
        /// getter/setter method for Name
        /// </summary>
        public string FurnitureName { get; set; }

        /// <summary>
        /// getter/setter method for Category
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// getter/setter method for Times_Rented_Out
        /// </summary>
        public int TimesRentedOut { get; set; }

        /// <summary>
        /// getter/setter method for Total_All_Rentals
        /// </summary>
        public int TotalAllRentals { get; set; }

        /// <summary>
        /// getter/setter method for Percentage
        /// </summary>
        public decimal Percentage { get; set; }

        /// <summary>
        /// getter/setter method for Percentage inside 18-29
        /// </summary>
        public decimal PercentInside18_29 { get; set; }

        /// <summary>
        /// getter/setter method for Percentage outside 18-29
        /// </summary>
        public decimal PercentOutside18_29 { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public Report()
        {
        }

        /// <summary>
        /// constructor used to create report
        /// </summary>
        /// <param name="furniture_id">furniture ID</param>
        /// <param name="furniture_name">furniture name</param>
        /// <param name="category">category</param>
        /// <param name="times_rented_out">times furniture rented</param>
        /// <param name="total_all_rentals">total of all rentals</param>
        /// <param name="percentage">percentage of times or total</param>
        /// <param name="perc_in_18_29">percentage inside 18-29 age</param>
        /// <param name="perc_out_18_29">percentage outside 18-29 age</param>
        public Report(int furniture_id, string furniture_name, string category, int times_rented_out, int total_all_rentals, 
            decimal percentage, decimal perc_in_18_29, decimal perc_out_18_29)
        {
            if (furniture_id < 0)
            {
                throw new ArgumentOutOfRangeException("furniture_id", "FurnitureID has to be number greater than 0");

            }

            if (string.IsNullOrEmpty(furniture_name) || furniture_name.Length > 100)
            {
                throw new ArgumentException("Furniture Name cannot be null/empty or greater than 100", "name");

            }

            if (string.IsNullOrEmpty(category) || category.Length > 45)
            {
                throw new ArgumentException("Category cannot be null/empty or greater than 45", "description");

            }

            if (times_rented_out < 0)
            {
                throw new ArgumentOutOfRangeException("times_rented_out", "Times Rented Out has to be number greater than or equal to 0");

            }

            if (total_all_rentals < 0)
            {
                throw new ArgumentOutOfRangeException("total_all_rentals", "Total All Rentals has to be number greater than or equal to 0");

            }

            if (percentage < 0)
            {
                throw new ArgumentOutOfRangeException("percentage", "Percentage has to be number greater than or equal to  0.0");

            }

            if (perc_in_18_29 < 0)
            {
                throw new ArgumentOutOfRangeException("perc_in_18_29", "Percentage Inside 18-29 has to be number greater than or equal to 0.0");

            }

            if (perc_out_18_29 < 0)
            {
                throw new ArgumentOutOfRangeException("perc_out_18_29", "Percentage Outside 18-29 has to be number greater than or equal to 0.0");

            }

            FurnitureID = furniture_id;
            FurnitureName = furniture_name;
            Category = category;
            TimesRentedOut = times_rented_out;
            TotalAllRentals = total_all_rentals;
            Percentage = percentage;
            PercentInside18_29 = perc_in_18_29;
            PercentOutside18_29 = perc_out_18_29;
        }

        #endregion
    }
}
