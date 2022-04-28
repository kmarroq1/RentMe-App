using System;
using System.Collections.Generic;

namespace RentMe_App.Model
{
    /// <summary>
    /// Keeps track of a return and all of the furniture associated with it.
    /// </summary>
    /// <summary>
    /// Models a return transaction
    /// </summary>
    public class Return : Transaction
    {        
        #region Fields

        private int _memberID;
        private readonly List<FurnitureInventory> _returnedFurniture;
        private int _rentalID;

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes an empty List of Furniture to return.
        /// </summary>
        public Return() : base()
        {
            _returnedFurniture = new List<FurnitureInventory>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Dictates how MemberID can be accessed and mutated.
        /// </summary>
        public int MemberID
        {
            get => _memberID;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("MemberID", "MemberID must be a positive number");

                _memberID = value;
            }
        }

        /// <summary>
        /// Dictates how the TransactionDate can be accessed and mutated.
        /// </summary>
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// Dictates how the Returned Furniture List can be accessed.
        /// </summary>
        public List<FurnitureInventory> ReturnedFurniture
        {
            get => _returnedFurniture;
            /*TODO needs to update Furniture Inventory Quantity property when more than one of the same item is added to the cart in different sessions
            In other words, this list should consolidate the same items (same furnitureID and same rentalTransactionID)- Kim M. */
        }

        /// <summary>
        /// Dictates how RentalID can be accessed and mutated.
        /// </summary>
        public int RentalID
        {
            get => _rentalID;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("RentalID", "RentalID must be a positive number");

                _rentalID = value;
            }
        }

        /// <summary>
        /// Returns the total count of items (including quantities)
        /// </summary>
        public int TotalItems
        {
            get
            {
                int count = 0;

                foreach (FurnitureInventory furniture in _returnedFurniture) count += furniture.Quantity;

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

                foreach (FurnitureInventory furniture in _returnedFurniture) total += furniture.Daily_Rental_Rate;

                return total;
            }
        }

        #endregion
    }
}
