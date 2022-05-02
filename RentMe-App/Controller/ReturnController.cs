using RentMe_App.DAL;
using RentMe_App.Model;
using System;

namespace RentMe_App.Controller
{
    /// <summary>
    /// Communicates between the Return DAL, models, and views.
    /// </summary>
    public class ReturnController
    {
        private ReturnDBDAL _returnDataAccess;

        /// <summary>
        /// Initializes the associated ReturnDBDAL
        /// </summary>
        public ReturnController()
        {
            _returnDataAccess = new ReturnDBDAL();
        }

        /// <summary>
        /// Delegates to the DAL to write the Return Transaction
        /// to the appropriate tables.
        /// </summary>
        /// <param name="returnToComplete">The Return to write to the DB</param>
        /// <returns>The ID of the new return transaction.</returns>
        public int CompleteReturn(Return returnToComplete)
        {
            if (returnToComplete == null)
                throw new ArgumentNullException("Return", "Return object non-existant");

            if (returnToComplete.ReturnedFurniture.Count < 1)
                throw new EmptyTransactionException("Nothing to return");

            return _returnDataAccess.CompleteReturn(returnToComplete);
        }
    }
}
