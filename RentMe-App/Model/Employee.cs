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
        /// employee date of birth
        /// </summary>
        public string Dob { get; set; }
        /// <summary>
        /// employment status
        /// </summary>
        public bool IsActive { get; set; }

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
