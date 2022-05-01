using RentMe_App.DAL;
using System;
using System.Collections.Generic;

namespace RentMe_App.UserControls.MemberDashboardUCs
{
    /// <summary>
    /// Controller for order history
    /// </summary>
    public class OrdersController
    {
        #region Data Members

        private readonly OrderDBDAL orderDBDAL;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="memberID"></param>
        public OrdersController()
        {
            orderDBDAL = new OrderDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets order history
        /// </summary>
        /// <returns></returns>
        public List<Order> GetOrderHistory(int memberID)
        {
            if (memberID < 0)
            {
                throw new Exception("Member ID must be a positive number");
            }
            return orderDBDAL.GetOrderHistory(memberID);
        }

        /// <summary>
        /// Gets the order history based on the given transaction id
        /// </summary>
        /// <param name="currentMemberID"></param>
        /// <param name="transactionID"></param>
        /// <returns></returns>
        public List<Order> GetOrdersByTransactionId(int currentMemberID, int transactionID)
        {
            if (currentMemberID < 0)
            {
                throw new Exception("Member ID must be a positive number");
            }
            if (transactionID < 0)
            {
                throw new Exception("Transaction ID must be a positive number");
            }
            return orderDBDAL.GetOrdersByTransactionId(currentMemberID, transactionID);
        }

        /// <summary>
        /// Gets the order history based on a given year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<Order> GetOrdersByYear(string year)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the furniture items rented in a given order
        /// </summary>
        /// <param name="currentOrder"></param>
        /// <returns></returns>
        public Order GetOrderFurnitureList(Order currentOrder)
        {
            if (currentOrder == null)
            {
                throw new Exception("Order does not exist");
            }
            return orderDBDAL.GetOrderFurnitureList(currentOrder);
        }

        #endregion
    }
}