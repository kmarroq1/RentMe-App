using RentMe_App.Model;
using System;
using System.Collections.Generic;

namespace RentMe_App.UserControls.MemberDashboardUCs
{
    /// <summary>
    /// Defines an Order
    /// </summary>
    public class Order
    {
        #region Data Members

        public int TransactionID { get; set; }
        public string OrderType { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DateReturned { get; set; }
        public double OrderTotal { get; set; }
        public bool Status { get; set; }
        public double Balance { get; set; }
        public List<Furniture> FurnitureList { get; set; }

        #endregion
    }
}