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
        /// <returns>returns int transactionID to indicate completed</returns>
        public int CreateRentalTransaction(int memberID, int employeeID,
            DateTime returnDate, List<FurnitureInventory> rentalFurnitureList)
        {
            if (memberID < 0 || employeeID < 0)
            {
                throw new ArgumentException("MemberID and EmployeeID must be greater than 0 to return results");
            }

            if (!DateTime.TryParse(returnDate.ToString(), out _))
            {
                throw new ArgumentException("Return Date is not valid", "returnDate");

            }

            if (rentalFurnitureList.Count == 0)
            {
                throw new ArgumentException("Rental Furniture List needs values to execute");

            }
            return rentalDBDAL.CreateRentalTransaction(memberID, employeeID, returnDate, rentalFurnitureList);
        }

        /// <summary>
        /// get rental transaction by transactionID
        /// </summary>
        /// <param name="transactionID">rental transactionID</param>
        /// <returns>rental info</returns>
        public Rental GetRentalByID(int transactionID)
        {
            if (transactionID < 0)
            {
                throw new ArgumentException("TransactionID must be greater than 0 to return results");
            }
            return rentalDBDAL.GetRentalByID(transactionID);
        }

        /// <summary>
        /// get rental furniture by transactionID
        /// </summary>
        /// <param name="transactionID">rental transactionID</param>
        /// <returns>rented furniture</returns>
        public List<FurnitureInventory> GetRentalFurniture(int transactionID)
        {
            if (transactionID < 0)
            {
                throw new ArgumentException("TransactionID must be greater than 0 to return results");
            }
            return rentalDBDAL.GetRentalFurniture(transactionID);
        }

        #endregion
    }
}
