using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RentMe_App.Model
{
    /// <summary>
    /// Class for defining an employee.
    /// </summary>
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
        private readonly string _username;
        #endregion

        #region Properties
        /// <summary>
        /// Dictates the manner in which the Employee's ID can be accessed & mutated.
        /// </summary>
        public int EmployeeId
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
        public string FName
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
        public string LName
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
        /// employee full name
        /// </summary>
        public string Name { get; set; }

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
                    throw new ArgumentException("Phone is not in valid format.\nPlease use either (###) ###-#### or ###-###-####.");

                string storedFormat = "";

                // pulls numbers from propertly formatted string
                foreach (Match matchedNumber in (new Regex(@"\d+")).Matches(value))
                    storedFormat += matchedNumber.Value;

                _phone = storedFormat;
            }
        }

        /// <summary>
        /// employee full address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Dictates the manner in which the Employee's active status can be accessed & mutated.
        /// </summary>
        public bool IsActive { get => _active; set => _active = value; }

        /// <summary>
        /// employee admin status
        /// </summary>
        public bool IsAdmin { get; set; }

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
        /// employee's password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Employee username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The row version - auto incremented when a row is updated
        /// </summary>
        public byte[] Version { get; set; }

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
                    throw new ArgumentException("Zip code not in valid format.\nPlease use either ##### or #####-####.");

                _zip = value;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Checks to see if two Employee objects have identical fields.
        /// Cannot check passwords due to hashing strangeness.
        /// </summary>
        /// <param name="obj">The other object to compare this Employee to.</param>
        /// <returns>Whether or not the two "Employees" are identical.</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Employee)) return false;

            Employee otherEmployee = (Employee)obj;

            return EmployeeId == otherEmployee.EmployeeId
                && FName == otherEmployee.FName
                && LName == otherEmployee.LName
                && BirthDate == otherEmployee.BirthDate
                && Sex == otherEmployee.Sex
                && Phone == otherEmployee.Phone
                && IsActive == otherEmployee.IsActive
                && Address1 == otherEmployee.Address1
                && Address2 == otherEmployee.Address2
                && City == otherEmployee.City
                && State == otherEmployee.State
                && Zip == otherEmployee.Zip
                && Username == otherEmployee.Username
                && Version == otherEmployee.Version
                ;
        }

        /// <summary>
        /// Gets the hash code generated from the Employee fields for identity checking.
        /// </summary>
        /// <returns>The hashed value of the Employee object.</returns>
        public override int GetHashCode()
        {
            int hashCode = -712575131;
            hashCode = hashCode * -1521134295 + _employeeID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_fname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_lname);
            hashCode = hashCode * -1521134295 + _birthDate.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_sex);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_phone);
            hashCode = hashCode * -1521134295 + _active.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_address1);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_address2);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_city);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_state);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_zip);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_username);
            hashCode = hashCode * -1521134295 + EmployeeId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + BirthDate.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Sex);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Phone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + IsActive.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address1);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address2);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(City);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Username);
            hashCode = hashCode * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(Version);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(State);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Zip);
            return hashCode;
        }
        #endregion
    }
}
