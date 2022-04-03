using RentMe_App.DAL;
using RentMe_App.Model;
using System;
using System.Collections.Generic;

namespace RentMe_App.Controller
{
    /// <summary>
    /// class controller used to access the DAL for member
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class MemberController
    {
        #region Data Members

        private readonly MemberDBDAL memberDBSource;

        #endregion

        #region Constructors

        /// <summary>
        /// create a MemberController object
        /// </summary>
        public MemberController()
        {
            memberDBSource = new MemberDBDAL();
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to get member by id
        /// </summary>
        /// <param name="memberID">member id</param>
        /// <returns>list of member objects</returns>
        public List<Member> GetMemberByID(int memberID)
        {
            return memberDBSource.GetMemberByID(memberID);
        }

        /// <summary>
        /// method used to get member by fname and lname
        /// </summary>
        /// <param name="fname">member first name</param>
        /// <param name="lname">member last name</param>
        /// <returns>list of member objects</returns>
        public List<Member> GetMemberByName(string fname, string lname)
        {
            return memberDBSource.GetMemberByName(fname, lname);
        }

        /// <summary>
        /// method used to get member by phone
        /// </summary>
        /// <param name="phone">member phone</param>
        /// <returns>list of member objects</returns>
        public List<Member> GetMemberByPhone(string phone)
        {
            return memberDBSource.GetMemberByPhone(phone);
        }

        /// <summary>
        /// Delegates adding a new member to the MemberDAL.
        /// </summary>
        /// <param name="newMember">The new member to add.</param>
        public void AddMember(Member newMember)
        {
            memberDBSource.AddMember(newMember);
        }

        /// <summary>
        /// Updates the selected member in the db with the new values.
        /// </summary>
        /// <param name="oldMember">The member to be updated. (also used to prevent race condiditons)</param>
        /// <param name="newMember">The new values to use in the member.</param>
        public void UpdateMember(Member oldMember, Member newMember)
        {
            if (oldMember == null || newMember == null)
                throw new InvalidOperationException("Something went wrong. One of the members was null.");

            if (newMember.Equals(oldMember))
                throw new Exception("No fields have been updated.");
        }
        #endregion
    }
}
