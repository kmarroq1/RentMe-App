using System;
using System.Text.RegularExpressions;

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
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Fname", "Member missing required field(s)");
                if(value.Length > 45)
                    throw new ArgumentException("FName cannot greater than 45 characters long", "fname");
                
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
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Lname", "Member missing required field(s)");
                if (value.Length > 45)
                    throw new ArgumentException("LName cannot greater than 45 characters long", "lname");

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
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Phone", "Member missing required field(s)");
                if (value.Length > 45)
                    throw new ArgumentException("Phone cannot greater than 45 characters long", "phone");

                Regex phoneRegex = new Regex(@"(^\(\d{3}\) ?\d{3}-\d{4}$)|(^\d{10}$)|(^\d{3}[.-]\d{3}[.-]\d{4}$)");
                if (!phoneRegex.IsMatch(value))
                    throw new ArgumentException("Phone is not in viable format. Can be (###) ###-####, ##########, ###.###.####, or ###-###-####.");

                string storedFormat = "";

                // pulls numbers from propertly formatted string
                foreach (Match matchedNumber in (new Regex(@"\d+")).Matches(value))
                    storedFormat += matchedNumber.Value;

                _phone = storedFormat;

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
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Address1", "Member missing required field(s)");
                if (value.Length > 45)
                    throw new ArgumentException("Address1 cannot be than 45 characters long", "address1");

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
                    throw new ArgumentException("Address2 cannot be greater than 45 characters long", "address2");

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
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("City", "Member missing required field(s)");
                if (value.Length > 45)
                    throw new ArgumentException("City cannot be greater than 45 characters long", "city");

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
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("State", "Member missing required field(s)");
                if (value.Length > 45)
                    throw new ArgumentException("State cannot be greater than 45 characters long", "state");

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
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Zip", "Member missing required field(s)");
                if (value.Length > 20)
                    throw new ArgumentException("Zip cannot be greater than 20 characters long", "zip");

                Regex zipCodeRegex = new Regex(@"(^\d{5}$)|(^\d{5}-\d{4}$)");

                if (!zipCodeRegex.IsMatch(value))
                    throw new ArgumentException("Not a valid zip code. Must be in format ##### or #####-####");

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

        #region Methods
        /// <summary>
        /// Overrides ToString to display Member fields.
        /// </summary>
        /// <returns>The string representation of the Member</returns>
        public override string ToString()
        {
            return "Member:\n"
                + $"\tName: {Fname} {Lname}\n"
                + $"\tDOB: {BirthDate}\n"
                + $"\tPhone: {Phone}\n"
                + $"\tAddress:\n\t\t{Address1}\n\t\t{Address2}\n\t\t{City}, {State} {Zip}";
        }

        /// <summary>
        /// Checks if two Member objects have identical fields.
        /// </summary>
        /// <param name="obj">The other Member to compare against.</param>
        /// <returns>Whether or not all fields match between the two objects.</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Member)) return false;

            Member otherMember = (Member)obj;

            return (MemberID == otherMember.MemberID)
                && (Fname == otherMember.Fname)
                && (Lname == otherMember.Lname)
                && (BirthDate.ToString() == otherMember.BirthDate.ToString())
                && (Phone == otherMember.Phone)
                && (Address1 == otherMember.Address1)
                && (Address2 == otherMember.Address2)
                && (City == otherMember.City)
                && (State == otherMember.State)
                && (Zip == otherMember.Zip)
                && (Active == otherMember.Active);
        }
        #endregion
    }
}
