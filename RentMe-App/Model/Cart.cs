namespace RentMe_App.Model
{
    /// <summary>
    /// A global static Cart which can be accessed from anywhere in the application.
    /// We really should look into making this a Singleton.
    /// </summary>
    public static class Cart
    {
        #region Properties
        /// <summary>
        /// Obtains the Rental Transaction from the cart.
        /// </summary>
        public static Rental Rental { get; set; }

        /// <summary>
        /// Obtains the Return Transaction from the cart.
        /// </summary>
        public static Return Return { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Returns whether or not the Cart contains a Rental Transaction.
        /// </summary>
        /// <returns>True if is has a Rental Transation; false otherwise.</returns>
        public static bool HasRental() { return Rental != null; }

        /// <summary>
        /// Returns whether of not the Cart contains a Return Transaction.
        /// </summary>
        /// <returns>True if it has a Return Transaction; false otherwise.</returns>
        public static bool HasReturn() { return Return != null; }
        #endregion
    }
}
