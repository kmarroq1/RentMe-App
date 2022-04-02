using RentMe_App.DAL;
using System;

namespace RentMe_App.Controller
{
    /// <summary>
    /// class controller used to access the DAL for login
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class LoginController
    {
        #region Data Members

        private readonly LoginDBDAL loginDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// create a LoginController object
        /// </summary>
        public LoginController()
        {
            loginDBSource = new LoginDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to call stored function and return non null login string if employee authorized
        /// </summary>
        /// <param name="username">employee username</param>
        /// <param name="password">employee password</param>
        /// <returns>string with login info for regular employees if authorized or null if not</returns>
        public string GetAuthorizedEmployeeLoginInfo(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("Username cannot be null or empty");
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Password cannot be null or empty");
            }
            return loginDBSource.GetAuthorizedEmployeeLoginInfo(username, password);
        }

        /// <summary>
        /// method used to call stored function and return non null login string if admin authorized
        /// </summary>
        /// <param name="username">employee username</param>
        /// <param name="password">employee password</param>
        /// <returns>string with login info for admin employees if authorized or null if not</returns>
        public string GetAuthorizedAdminLoginInfo(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("Username cannot be null or empty");
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Password cannot be null or empty");
            }
            return loginDBSource.GetAuthorizedAdminLoginInfo(username, password);
        }

        #endregion
    }
}
