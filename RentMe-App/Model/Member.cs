using System;

namespace RentMe_App.Model
{
    /// <summary>
    /// model class used to define customer
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class Member
    {
        #region Fields
        private int? _memberID;
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private string _phone;
        private string _address1;
        private string _address2;
        private string _city;
        private string _state;
        private string _zip;
        private bool _active;
        #endregion

        #region Data Members

        /// <summary>
        /// getter/setter method for MemberID
        /// </summary>
        public int? MemberID {
            get => _memberID;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("memberID", "MemberID has to be number greater than 0");

                _memberID = value;
            }
        }

        /// <summary>
        /// getter/setter method for BirthDate
        /// </summary>
        public DateTime BirthDate {
            get => _birthDate;
            set
            {
                if (!DateTime.TryParse(value.ToString(), out _))
                    throw new ArgumentException("BirthDate is not valid", "birthDate");

                _birthDate = value;
            }
        }

        /// <summary>
        /// getter/setter method for Fname
        /// </summary>
        public string Fname {
            get => _firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 45)
                    throw new ArgumentException("FName cannot be null/empty or greater than 45", "fname");
                
                _firstName = value;
            }
        }

        /// <summary>
        /// getter/setter method for Lname
        /// </summary>
        public string Lname {
            get => _lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 45)
                    throw new ArgumentException("LName cannot be null/empty or greater than 45", "lname");

                _lastName = value;
            }
        }

        /// <summary>
        /// getter/setter method for Phone
        /// </summary>
        public string Phone {
            get => _phone;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 45)
                    throw new ArgumentException("Phone cannot be null/empty or greater than 45", "phone");

                _phone = value;
            }
        }

        /// <summary>
        /// getter/setter method for Address1
        /// </summary>
        public string Address1 {
            get => _address1;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 45)
                    throw new ArgumentException("Address1 cannot be null/empty or greater than 45", "address1");

                _address1 = value;
            }
        }

        /// <summary>
        /// getter/setter method for Address2
        /// </summary>
        public string Address2 {
            get => _address2;
            set
            {
                if (value.Length > 45)
                    throw new ArgumentException("Address2 cannot be greater than 45", "address2");

                _address2 = value;
            }
        }

        /// <summary>
        /// getter/setter method for City
        /// </summary>
        public string City {
            get => _city;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 45)
                    throw new ArgumentException("City cannot be null/empty or greater than 45", "city");

                _city = value;
            }
        }

        /// <summary>
        /// getter/setter method for State
        /// </summary>
        public string State {
            get => _state;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 45)
                    throw new ArgumentException("State cannot be null/empty or greater than 45", "state");

                _state = value;
            }
        }

        /// <summary>
        /// getter/setter method for Zip
        /// </summary>
        public string Zip {
            get => _zip;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 20)
                    throw new ArgumentException("Zip cannot be null/empty or greater than 20", "zip");

                _zip = value;
            }
        }

        /// <summary>
        /// getter/setter method for Active
        /// </summary>
        public bool Active {
            get => _active;
            set => _active = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public Member()
        {
        }

        /// <summary>
        /// constructor used to create Member
        /// </summary>
        /// <param name="name">furnture style name</param>
        public Member(int? memberID, DateTime birthDate, string fname, string lname, 
            string phone, string address1, string address2, string city, string state, string zip, bool active)
        {
            MemberID = memberID;
            BirthDate = birthDate;
            Fname = fname;
            Lname = lname;
            Phone = phone;
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            Zip = zip;
            Active = active;
        }

        #endregion
    }
}
