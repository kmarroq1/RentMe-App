using System.Collections.Generic;

namespace RentMe_App.Model
{
    /// <summary>
    /// A global static Cart which can be accessed from anywhere in the application.
    /// We really should look into making this a Singleton.
    /// </summary>
    public static class Cart
    {
        #region Fields
        private static readonly List<Rental> _rentals = new List<Rental>();
        private static readonly List<Return> _returns = new List<Return>();
        #endregion

        #region Properties
        /// <summary>
        /// Obtains the list of Rentals from the cart.
        /// </summary>
        public static List<Rental> Rentals { get => _rentals; }

        /// <summary>
        /// Obtains the list of Returns from the cart.
        /// </summary>
        public static List<Return> Returns { get => _returns; }
        #endregion

        #region Methods
        /// <summary>
        /// Add a new Rental to the Rentals portion of the cart.
        /// </summary>
        /// <param name="newRental">The new Rental</param>
        public static void AddRental(Rental newRental)
        {
            _rentals.Add(newRental);
        }

        /// <summary>
        /// Add a new Return to the Returns portion of the cart.
        /// </summary>
        /// <param name="newReturn">The new Return</param>
        public static void AddReturn(Return newReturn)
        {
            _returns.Add(newReturn);
        }
        #endregion
    }
}
