using RentMe_App.Model;
using System;
using System.Collections.Generic;
using RentMe_App.DAL;

namespace RentMe_App.Controller
{
    /// <summary>
    /// Controller class for employee data.
    /// </summary>
    class EmployeeController
    {
        #region Data Members

        private readonly EmployeeDBDAL _employeeDbdal;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for Employee controller class.
        /// </summary>
        public EmployeeController()
        {
            _employeeDbdal = new EmployeeDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the employee by their ID and returns the employee
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public List<Employee> GetEmployeeById(int employeeID)
        {
            if (employeeID < 0)
            {
                throw new ArgumentException("Employee ID must be a positive number");
            }
            return _employeeDbdal.GetEmployeeById(employeeID);
        }

        /// <summary>
        /// Gets the employee by their name and returns the employee
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <returns></returns>
        public List<Employee> GetEmployeeByName(string fName, string lName)
        {
            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName))
            {
                throw new ArgumentException("Must enter first AND last name");
            }
            return _employeeDbdal.GetEmployeeByName(fName, lName);
        }

        /// <summary>
        /// Gets the employee by their phone number and returns the employee
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public List<Employee> GetEmployeeByPhone(string phone)
        {
            if (phone == null)
            {
                throw new ArgumentException("Invalid phone number");
            }
            return _employeeDbdal.GetEmployeeByPhone(phone);
        }

        #endregion

    }
}
