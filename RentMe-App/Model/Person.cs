using System;

namespace RentMe_App.Model
{
    /// <summary>
    /// Abstract base class to house common fields between Person subclasses.
    /// </summary>
    public abstract class Person
    {
        private int _ID;
        
        private string _firstName;
        private string _lastName;
        
        private DateTime _birthDate;
        
        private string _phone;
        
        private string _address1;
        // Address2 managed by property as allows null
        private string _city;
        private string _state;
        private string _zip;

        /// <summary>
        /// Property dictates how the Person's active field may be accessed and mutated.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Property dictates how the Person's ID field may be accessed and mutated.
        /// </summary>
        public int ID
        {
            get => _ID;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("ID", "ID must be greater than or equal to 0");

                _ID = value;
            }
        }

        /// <summary>
        /// Property dictates how the Person's first name field may be accessed and mutated.
        /// </summary>
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("FirstName", "First name cannot be empty");

                _firstName = value;
            }
        }

        /// <summary>
        /// Property dictates how the Person's last name field may be accessed and mutated.
        /// </summary>
        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("LastName", "Last name cannot be empty");

                _lastName = value;
            }
        }

        /// <summary>
        /// Property dictates how the Person's birth date field may be accessed and mutated.
        /// </summary>
        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                if (value == null)
                    throw new ArgumentNullException("BirthDate", "Date of birth cannot be empty");

                _birthDate = value;
            }
        }

        /// <summary>
        /// Property dictates how the Person's phone number field may be accessed and mutated.
        /// </summary>
        public string Phone
        {
            get => _phone;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Phone", "Phone number cannot be empty");

                _phone = value;
            }
        }

        /// <summary>
        /// Property dictates how the Person's address line 1 field may be accessed and mutated.
        /// </summary>
        public string Address1
        {
            get => _address1;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Address1", "Address line 1 cannot be empty");

                _address1 = value;
            }
        }

        /// <summary>
        /// Property dictates how the Person's address line 2 field may be accessed and mutated.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Property dictates how the Person's city field may be accessed and mutated.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Address1", "Address line 1 cannot be empty");

                _city = value;
            }
        }

        /// <summary>
        /// Property dictates how the Person's state field may be accessed and mutated.
        /// </summary>
        public string State
        {
            get => _state;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Address1", "Address line 1 cannot be empty");

                _state = value;
            }
        }

        /// <summary>
        /// Property dictates how the Person's zip field may be accessed and mutated.
        /// </summary>
        public string Zip
        {
            get => _zip;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Address1", "Address line 1 cannot be empty");

                _zip = value;
            }
        }
    }
}
