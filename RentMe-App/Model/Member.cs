using System;
using System.Collections.Generic;

namespace RentMe_App.Model
{
    /// <summary>
    /// model class used to define customer
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class Member
    {
        #region Data Members

        /// <summary>
        /// getter/setter method for MemberID
        /// </summary>
        public int? MemberID { get; set; }

        /// <summary>
        /// getter/setter method for BirthDate
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// getter/setter method for Fname
        /// </summary>
        public string Fname { get; set; }

        /// <summary>
        /// getter/setter method for Lname
        /// </summary>
        public string Lname { get; set; }

        /// <summary>
        /// getter/setter method for Phone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// getter/setter method for Address1
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// getter/setter method for Address2
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// getter/setter method for City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// getter/setter method for State
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// getter/setter method for Zip
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// getter/setter method for Active
        /// </summary>
        public bool Active { get; set; }

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

            if (memberID < 0)
            {
                throw new ArgumentOutOfRangeException("memberID", "MemberID has to be number greater than 0");

            }

            if (!DateTime.TryParse(birthDate.ToString(), out _))
            {
                throw new ArgumentException("BirthDate is not valid", "birthDate");

            }

            if (string.IsNullOrEmpty(fname) || fname.Length > 45)
            {
                throw new ArgumentException("FName cannot be null/empty or greater than 45", "fname");

            }

            if (string.IsNullOrEmpty(lname) || lname.Length > 45)
            {
                throw new ArgumentException("LName cannot be null/empty or greater than 45", "lname");

            }

            if (string.IsNullOrEmpty(phone) || phone.Length > 45)
            {
                throw new ArgumentException("Phone cannot be null/empty or greater than 45", "phone");

            }

            if (string.IsNullOrEmpty(address1) || address1.Length > 45)
            {
                throw new ArgumentException("Address1 cannot be null/empty or greater than 45", "address1");

            }

            if (address2.Length > 45)
            {
                throw new ArgumentException("Address2 cannot be greater than 45", "address2");

            }

            if (string.IsNullOrEmpty(city) || city.Length > 45)
            {
                throw new ArgumentException("City cannot be null/empty or greater than 45", "city");

            }

            if (string.IsNullOrEmpty(state) || state.Length > 45)
            {
                throw new ArgumentException("State cannot be null/empty or greater than 45", "state");

            }

            if (string.IsNullOrEmpty(zip) || zip.Length > 20)
            {
                throw new ArgumentException("Zip cannot be null/empty or greater than 20", "zip");

            }

            if (!(bool)active)
            {
                throw new ArgumentException("Active must be a bit of 1 or 0", "active");

            }

            this.MemberID = memberID;
            this.BirthDate = birthDate;
            this.Fname = fname;
            this.Lname = lname;
            this.Phone = phone;
            this.Address1 = address1;
            this.Address2 = address2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Active = active;

        }

        #endregion
    }
}
