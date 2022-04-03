using RentMe_App.DAL;
using System.Collections.Generic;

namespace RentMe_App.Controller
{
    /// <summary>
    /// Acts as a bridge bewteen the models, views, and StateDAL.
    /// </summary>
    public class StateController
    {
        #region Fields
        private readonly StateDAL _stateData;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the StateDAL.
        /// </summary>
        public StateController()
        {
            _stateData = new StateDAL();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Delegates to the StateDAL to collect the State abbreviations from the db.
        /// </summary>
        /// <returns>The State abbreviations in the states table.</returns>
        public List<string> GetStateAbbreviations()
        {
            return _stateData.GetStateAbbreviations();
        }
        #endregion
    }
}
