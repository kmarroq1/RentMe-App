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
        public decimal Balance
        {
            get
            {
                decimal balance = 0.0M;

                foreach (FurnitureInventory furniture in _returnedFurniture)
                {
                    int DateDiff(DateTime later, DateTime former) => Math.Abs(later.Date.Subtract(former.Date).Days);

                    int numberDaysPaid = DateDiff(furniture.DueDate, furniture.RentalDate);
                    balance += furniture.Daily_Rental_Rate * numberDaysPaid;

                    int numberDaysPosessed = DateDiff(DateTime.Today, furniture.RentalDate);
                    balance -= furniture.Daily_Rental_Rate * numberDaysPosessed;
                }

                return balance;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the Item with the given FurnitureID if it exists.
        /// </summary>
        /// <param name="id">The FurnitureID to search for.</param>
        /// <returns>The matching Item</returns>
        public FurnitureInventory GetItemByID(int id)
        {
            return _returnedFurniture.Find(new Predicate<FurnitureInventory>(item => item.FurnitureID == id));
        }

        #endregion
    }
}
