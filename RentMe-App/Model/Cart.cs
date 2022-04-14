using System;

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
    }
}
