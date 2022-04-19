using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RentMe_App.Model
{
    /// <summary>
    /// A global static Cart which can be accessed from anywhere in the application.
    /// We really should look into making this a Singleton.
    /// </summary>
    public static class Cart
    {
        static Cart()
        {
            RentalList = new List<FurnitureInventory>();
            ReturnList = new List<FurnitureInventory>();
            Return = new Return();
        }

        #region Properties
        /// <summary>
        /// Obtains the Rental Transaction from the cart.
        /// </summary>
        public static Rental Rental { get; set; }

        /// <summary>
        /// Obtains the list of Rental Transactions currently in cart.
        /// </summary>
        public static List<FurnitureInventory> RentalList { get; set; }

        /// <summary>
        /// Obtains the list of Return Transactions currently in cart.
        /// </summary>
        public static List<FurnitureInventory> ReturnList { get; set; }

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

        /// <summary>
        /// Method used to create return cart list
        /// </summary>
        /// <param name="returnItem">item to add to return cart</param>
        /// <returns>boolean if added</returns>
        public static bool AddReturnItem(FurnitureInventory returnItem, int quantityInStock)
        {
            try
            {
                bool addedToCart = false;
                if (returnItem != null && ReturnList.Count == 0)
                {
                    ReturnList.Add(returnItem);
                    addedToCart = true;
                }
                else if (ReturnList.Count > 0)
                {
                    if (ItemInReturnCart(returnItem.FurnitureID))
                    {
                        var cartItem = ReturnList.FirstOrDefault(o => o.FurnitureID == returnItem.FurnitureID);
                        if (cartItem != null && returnItem.Quantity <= quantityInStock - cartItem.Quantity)
                        {
                            cartItem.Quantity = cartItem.Quantity + returnItem.Quantity;
                            addedToCart = true;
                        }
                    }
                    else
                    {
                        ReturnList.Add(returnItem);
                        addedToCart = true;
                    }
                }
                return addedToCart;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed: did not add to return cart");
                return false;
            }
        }

        /// <summary>
        /// check if item exists in return cart already
        /// </summary>
        /// <param name="furnitureID">furniture ID of item to check in cart already</param>
        /// <returns>boolean if item exists in cart</returns>
        public static bool ItemInReturnCart(int furnitureID)
        {
            return ReturnList.Any(item => item.FurnitureID == furnitureID);
        }

        /// <summary>
        /// Removes all items from the return transaction.
        /// </summary>
        public static void ClearReturns()
        {
            Return = new Return();
        }

        /// <summary>
        /// method used to create rental cart list
        /// </summary>
        /// <param name="rentalItem">item to add to rental cart</param>
        /// <returns>boolean if added</returns>
        public static bool AddRentalItem(FurnitureInventory rentalItem, int quantityInStock)
        {
            try
            {
                bool addedToCart = false;
                if (rentalItem != null && RentalList.Count == 0)
                {
                    RentalList.Add(rentalItem);
                    addedToCart = true;
                    Console.WriteLine(RentalList[0].Quantity.ToString());
                }
                else if (RentalList.Count > 0)
                {
                    if (RentalList.Any(item => item.FurnitureID == rentalItem.FurnitureID))
                    {
                        var cartItem = RentalList.FirstOrDefault(o => o.FurnitureID == rentalItem.FurnitureID);
                        if (cartItem != null && rentalItem.Quantity <= quantityInStock - cartItem.Quantity)
                        {
                            cartItem.Quantity = cartItem.Quantity + rentalItem.Quantity;
                            addedToCart = true;
                        }
                    }
                    else
                    {
                        RentalList.Add(rentalItem);
                        addedToCart = true;
                    }
                }
                return addedToCart;
            }
            catch (Exception)
            {
                MessageBox.Show("bad update");
                return false;
            }
        }

        /// <summary>
        /// check if item exists in cart already
        /// </summary>
        /// <param name="furnitureID">furniture ID of item to check in cart already</param>
        /// <returns>boolean if item exists in cart</returns>
        public static bool ItemInCart(int furnitureID)
        {
            return RentalList.Any(item => item.FurnitureID == furnitureID);
        }

        #endregion
    }
}