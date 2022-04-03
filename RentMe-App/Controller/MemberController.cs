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

        public void AddMember(Member newMember)
        {
            Console.WriteLine("adding member " + newMember.ToString());
            //memberDBSource.AddMember(newMember);
        }

        #endregion
    }
}
