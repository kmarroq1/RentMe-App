using RentMe_App.DAL;
using RentMe_App.Model;
using System;
using System.Collections.Generic;

namespace RentMe_App.Controller
{
    /// <summary>
    /// class controller used to access the DAL for rentals
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class RentalController
    {
        #region Data Members

        private readonly RentalDBDAL rentalDBDAL;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for Rentals
        /// </summary>
        public RentalController()
        {
            rentalDBDAL = new RentalDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// creates the rental transactions
        /// </summary>
        /// <param name="memberID">memberID of member renting</param>
        /// <param name="employeeID">employeeID of employee assisting</param>
        /// <param name="transactionDate">date transaction was made</param>
        /// <param name="returnDate">date customer will return</param>
        /// <param name="rentalFurnitureList">list of furniture to rent</param>
        /// <returns>returns bool to indicate completed</returns>
        public bool CreateRentalTransaction(int memberID, int employeeID, DateTime transactionDate, 
            DateTime returnDate, List<FurnitureInventory> rentalFurnitureList)
        {
            return rentalDBDAL.CreateRentalTransaction(memberID, employeeID, returnDate, rentalFurnitureList);
        }

        #endregion
    }
}
