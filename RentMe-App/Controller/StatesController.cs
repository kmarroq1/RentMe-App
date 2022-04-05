using RentMe_App.DAL;
using RentMe_App.Model;

namespace RentMe_App.Controller
{
    /// <summary>
    /// States controller class
    /// </summary>
    class StatesController
    {
        #region Data Members

        private readonly StatesDBDAL _statesDbDal;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for States class
        /// </summary>
        public StatesController()
        {
            _statesDbDal = new StatesDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets list of states
        /// </summary>
        /// <returns></returns>
        public States GetStatesList()
        {
            return _statesDbDal.GetStatesList();
        }

        #endregion
    }
}
