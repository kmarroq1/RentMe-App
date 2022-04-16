using RentMe_App.UserControls.MemberDashboardUCs;
using System;
using System.Collections.Generic;

namespace RentMe_App.DAL
{
    /// <summary>
    /// Order history data access layer
    /// </summary>
    class OrderDBDAL
    {
        #region Queries

        internal List<Order> getOrderHistory(int memberID)
        {
            throw new NotImplementedException();
        }

        internal List<Order> getOrdersByTransactionId(int currentMemberID, int transactionID)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
