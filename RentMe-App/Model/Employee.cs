using System;

namespace RentMe_App.Model
{
    /// <summary>
    /// Class for defining an employee.
    /// </summary>
    class Employee
    {
        #region Data Members

        /// <summary>
        /// employee ID
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// employee name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// employee phone number
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// employee address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// employee city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// employee state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// employee zip code
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// employee date of birth
        /// </summary>
        public string BirthDate { get; set; }

        /// <summary>
        /// employment status
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// employee address
        /// </summary>
        public string Sex { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for employee class.
        /// </summary>
        public Employee()
        {

        }

        #endregion
    }
}
