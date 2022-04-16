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

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="memberID"></param>
        public OrdersController(int memberID)
        {
            this.memberID = memberID;
        }

        #endregion

        #region Methods

        internal List<Order> getOrderHistory()
        {
            throw new NotImplementedException();
        }

        internal List<Order> getOrdersByTransactionId(int currentMemberID, int v)
        {
            throw new NotImplementedException();
        }

        internal List<Order> getOrdersByYear(string v)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}