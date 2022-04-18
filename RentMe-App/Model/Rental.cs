using System;
using System.Collections.Generic;

namespace RentMe_App.Model
{
    /// <summary>
    /// Models a Rental Transaction.
    /// </summary>
    public class Rental : Transaction
    {
        #region Fields
        private int _memberID;
        private readonly List<FurnitureInventory> _rentedFurniture;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes an empty List of Rental Furniture.
        /// </summary>
        public Rental() : base()
        {
            _rentedFurniture = new List<FurnitureInventory>();
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
        /// Dictates how the Rented Furniture List can be accessed.
        /// </summary>
        public List<FurnitureInventory> RentedFurniture
        {
            get => _rentedFurniture;
        }

        #endregion
    }
}
