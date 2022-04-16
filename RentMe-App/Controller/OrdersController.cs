using RentMe_App.DAL;
using RentMe_App.Model;
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

        internal List<Order> GetOrderHistory()
        {
            return orderDBDAL.GetOrderHistory(memberID);
        }

        internal List<Order> GetOrdersByTransactionId(int currentMemberID, int transactionID)
        {
            return orderDBDAL.GetOrdersByTransactionId(currentMemberID, transactionID);
        }

        internal List<Order> GetOrdersByYear(string year)
        {
            throw new NotImplementedException();
        }

        internal Order GetOrderFurnitureList(Order currentOrder)
        {
            return orderDBDAL.GetOrderFurnitureList(currentOrder);
        }

        #endregion
    }
}