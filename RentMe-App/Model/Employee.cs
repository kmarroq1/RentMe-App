using System;
using System.Text.RegularExpressions;

namespace RentMe_App.Model
{
    public class Employee
    {
        #region Fields
        private int _employeeID;
        private string _fname;
        private string _lname;
        private DateTime _birthDate;
        private string _sex;
        private string _phone;
        private bool _active;
        private string _address1;
        private string _address2;
        private string _city;
        private string _state;
        private string _zip;
        #endregion

        #region Properties
        /// <summary>
        /// Dictates the manner in which the Employee's ID can be accessed & mutated.
        /// </summary>
        public int EmployeeID
        {
            get => _employeeID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Employee ID cannot be negative");

                _employeeID = value;
            }
        }

        /// <summary>
        /// Dictates the manner in which the Employee's first name can be accessed & mutated.
        /// Fname label chosen to match db column name.
        /// </summary>
        public string Fname
        {
            get => _fname;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Fname", "Employee first name cannot be null or empty");

                _fname = value;
            }
        }

        /// <summary>
        /// Dictates the manner in which the Employee's last name can be accessed & mutated.
        /// Lname label chosen to match db column name.
        /// </summary>
        public string Lname
        {
            get => _lname;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Lname", "Employee last name cannot be null or empty");

                _lname = value;
            }
        }

        /// <summary>
        /// Dictates the manner in which the Employee's birth date can be accessed & mutated.
        /// </summary>
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }

        /// <summary>
        /// Dictates the manner in which the Employee's sex can be accessed & mutated.
        /// Property allows null values in case Employee doesn't have a sex.
        /// </summary>
        public string Sex { get => _sex; set => _sex = value; }

        /// <summary>
        /// Dictates the manner in which the Employee's phone number can be accessed & mutated.
        /// Requires that the number be in a supported format.
        /// Stores only the numbers.
        /// </summary>
        public string Phone
        {
            get => _phone;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Phone", "Phone cannot be empty or null");

                Regex phoneRegex = new Regex(@"(^\(\d{3}\) ?\d{3}-\d{4}$)|(^\d{10}$)|(^\d{3}[.-]\d{3}[.-]\d{4}$)");
                if (!phoneRegex.IsMatch(value))
                    throw new ArgumentException("Phone is not in viable format. Can be (###) ###-####, ##########, ###.###.####, or ###-###-####.");

                string storedFormat = "";

                // pulls numbers from propertly formatted string
                foreach (Match matchedNumber in (new Regex(@"\d+")).Matches(value))
                    storedFormat += matchedNumber.Value;

                _phone = storedFormat;
            }
        }

        /// <summary>
        /// Dictates the manner in which the Employee's active status can be accessed & mutated.
        /// </summary>
        public bool IsActive { get => _active; set => _active = value; }

        /// <summary>
        /// Dictates the manner in which the Employee's address' line 1 can be accessed & mutated.
        /// </summary>
        public string Address1
        {
            get => _address1;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Address1", "Address line 1 cannot be null or empty");

                _address1 = value;
            }
        }

        /// <summary>
        /// Dictates the manner in which the Employee's address' line 2 can be accessed & mutated.
        /// Allows for null values in the case the Employee does not have a line 2 in their address.
        /// </summary>
        public string Address2 { get => _address2; set => _address2 = value; }

        /// <summary>
        /// Dictates the manner in which the Employee's address' city can be accessed & mutated.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("City", "City cannot be null or empty");

                _city = value;
            }
        }

        /// <summary>
        /// Dictates the manner in which the Employee's address' state can be accessed & mutated.
        /// </summary>
        public string State
        {
            get => _state;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("State", "State cannot be null or empty");

                _state = value;
            }
        }

        /// <summary>
        /// Dictates the manner in which the Employee's address' zip code can be accessed & mutated.
        /// Requires zip code to be in supported format.
        /// </summary>
        public string Zip
        {
            get => _zip;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Zip", "Employee zip code cannot be null or empty");

                Regex zipCodeRegex = new Regex(@"(^\d{5}$)|(^\d{5}-\d{4}$)");

                if (!zipCodeRegex.IsMatch(value))
                    throw new ArgumentException("Not a valid zip code. Must be in format ##### or #####-####");

                _zip = value;
            }
        }
        #endregion
    }
}
