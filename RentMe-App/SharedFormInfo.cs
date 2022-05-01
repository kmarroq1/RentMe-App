using RentMe_App.View;

namespace RentMe_App
{
    /// <summary>
    /// static class for shared form info used like a session
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public static class SharedFormInfo
    {
        /// <summary>
        /// form username
        /// </summary>
        public static string UsernameForm;

        /// <summary>
        /// form employee name
        /// </summary>
        public static string EmployeeNameForm;

        /// <summary>
        /// form employeeID
        /// </summary>
        public static int EmployeeIDForm;

        /// <summary>
        /// login form instance
        /// </summary>
        public static LoginForm LoginForm;

        /// <summary>
        /// main employee form instance
        /// </summary>
        public static MainEmployeeForm MainEmployeeForm;

        /// <summary>
        /// form memberID
        /// </summary>
        public static int MemberIDForm;

        public static string MemberName;
    }
}
