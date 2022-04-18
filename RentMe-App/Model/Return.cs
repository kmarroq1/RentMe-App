using System.Collections.Generic;

namespace RentMe_App.Model
{
    /// <summary>
    /// Keeps track of a return and all of the furniture associated with it.
    /// </summary>
    public class Return : Transaction
    {
        public List<FurnitureInventory> ReturnItems { get; set; }

        /// <summary>
        /// Initializes the list of return items.
        /// </summary>
        public Return()
        {
            ReturnItems = new List<FurnitureInventory>();
        }

        /// <summary>
        /// Returns the total count of items (including quantities)
        /// </summary>
        public int TotalItems
        {
            get
            {
                int count = 0;

                foreach (FurnitureInventory furniture in ReturnItems) count += furniture.Quantity;

                return count;
            }
        }

        /// <summary>
        /// Returns the total daily rental rate of items
        /// </summary>
        public decimal TotalRate
        {
            get
            {
                decimal total = 0.0M;

                foreach (FurnitureInventory furniture in ReturnItems) total += furniture.Daily_Rental_Rate;

                return total;
            }
        }
    }
}
