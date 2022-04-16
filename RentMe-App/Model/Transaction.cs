using System;

namespace RentMe_App.Model
{
    /// <summary>
    /// Acts as an abstract parent class for the Rental and Returns classes.
    /// </summary>
    public abstract class Transaction
    {
        #region Fields
        private int _transactionID;
        private int _employeeID;
        #endregion

        #region Properties
        /// <summary>
        /// Dictates how the TransactionID can be accessed and mutated.
        /// </summary>
        public int TransactionID
        {
            get => _transactionID;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("TransactionID", "TransactionID must be a positive number");

                _transactionID = value;
            }
        }

        /// <summary>
        /// Dictates how the EmployeeID can be accessed and mutated.
        /// </summary>
        public int EmployeeID
        {
            get => _employeeID;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("EmployeeID", "EmployeeID must be a positive number");

                _employeeID = value;
            }
        }

        /// <summary>
        /// Dictates how the ReturnDate can be accessed and mutated.
        /// </summary>
        public DateTime ReturnDate { get; set; }
        #endregion
    }
}
