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

        private int memberID;
        private readonly OrderDBDAL orderDBDAL;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="memberID"></param>
        public OrdersController(int memberID)
        {
            this.memberID = memberID;
            this.orderDBDAL = new OrderDBDAL();
        }

        #endregion

        #region Methods

        internal List<Order> getOrderHistory()
        {
            return orderDBDAL.getOrderHistory(memberID);
        }

        internal List<Order> getOrdersByTransactionId(int currentMemberID, int transactionID)
        {
            return orderDBDAL.getOrdersByTransactionId(currentMemberID, transactionID);
        }

        internal List<Order> getOrdersByYear(string v)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}