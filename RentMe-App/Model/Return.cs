using System;
using System.Collections.Generic;

namespace RentMe_App.Model
{
    /// <summary>
    /// Models a return transaction
    /// </summary>
    public class Return : Transaction
    {
        #region Fields

        private int _memberID;
        private readonly List<FurnitureInventory> _returnedFurniture;

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
        }

        #endregion
    }
}
