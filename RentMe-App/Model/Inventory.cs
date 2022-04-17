using System;

namespace RentMe_App.Model
{
    /// <summary>
    /// model class used to define inventory
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class Inventory
    {
        #region Data Members

        /// <summary>
        /// getter/setter method for FurnitureID
        /// </summary>
        public int FurnitureID { get; set; }

        /// <summary>
        /// getter/setter method for Quantity
        /// </summary>
        public int Quantity { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public Inventory()
        {
        }

        /// <summary>
        /// constructor used to create inventory
        /// </summary>
        /// <param name="furnitureID">inventory furnitureID</param>
        /// <param name="quantity">inventory quantity</param>
        public Inventory(int furnitureID, int quantity)
        {
            if (furnitureID < 0)
            {
                throw new ArgumentOutOfRangeException("furnitureID", "FurnitureID has to be number greater than 0");

            }

            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException("quantity", "Quantity has to be number greater than or equal to  0");

            }

            FurnitureID = furnitureID;
            Quantity = quantity;
        }

        #endregion
    }
}
