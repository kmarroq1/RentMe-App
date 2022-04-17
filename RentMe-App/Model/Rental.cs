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
        private readonly List<Furniture> _rentedFurniture;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes an empty List of Rental Furniture.
        /// </summary>
        public Rental() : base()
        {
            _rentedFurniture = new List<Furniture>();
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
        public List<Furniture> RentedFurniture { get => _rentedFurniture; }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the total number of items in the cart.
        /// </summary>
        public int TotalItemsInCart
        {
            get
            {
                return _rentedFurniture.Count;
            }
        }

        /// <summary>
        /// Returns the total rental rate of the items in the cart.
        /// </summary>
        public decimal TotalRentalRate
        {
            get
            {
                decimal totalRentalRate = 0.0M;

                foreach (Furniture furniture in _rentedFurniture) totalRentalRate += furniture.Daily_Rental_Rate;

                return totalRentalRate;
            }
        }
        #endregion
    }
}
