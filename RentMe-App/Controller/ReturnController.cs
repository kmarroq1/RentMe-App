using RentMe_App.DAL;
using RentMe_App.Model;

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
        public void CompleteReturn(Return returnToComplete)
        {
            _returnDataAccess.CompleteReturn(returnToComplete);
        }
    }
}
