using System;

namespace RentMe_App.Model
{
    /// <summary>
    /// Class for defining an employee.
    /// </summary>
    public class Employee
    {
        #region Data Members

        /// <summary>
        /// employee ID
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// employee first name
        /// </summary>
        public string FName { get; set; }

        /// <summary>
        /// employee lst name
        /// </summary>
        public string LName { get; set; }

        /// <summary>
        /// employee full name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// employee phone number
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// employee address1
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// employee address2
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// employee full address
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
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// employment status
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// employee sex
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// employee password
        /// </summary>
        public string Password { get; set; }

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
