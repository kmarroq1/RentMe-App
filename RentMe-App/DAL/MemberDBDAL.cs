using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe_App.DAL
{
    /// <summary>
    /// data layer class used to access the member
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class MemberDBDAL
    {
        #region Methods

        /// <summary>
        /// method used to connect to the database and run a query to return member by id
        /// </summary>
        /// <param name="memberID">member memberID</param>
        /// <returns>list of member objects</returns>
        public List<Member> GetMemberByID(int memberID)
        {
            List<Member> memberList = new List<Member>();

            string selectStatement =
                "SELECT * " +
                "FROM storeMember " +
                "WHERE " +
                "memberID = @memberID " +
                "AND active = 1";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@memberID", System.Data.SqlDbType.Int);
                    selectCommand.Parameters["@memberID"].Value = memberID;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member member = new Member
                            {
                                MemberID = (int)reader["memberID"],
                                BirthDate = (DateTime)reader["birthDate"],
                                Fname = reader["fname"].ToString(),
                                Lname = reader["lname"].ToString(),
                                Phone = reader["phone"].ToString(),
                                Address1 = reader["address1"].ToString(),
                                Address2 = reader["address2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                Zip = reader["zip"].ToString(),
                                Active = (bool)reader["active"]
                            };
                            memberList.Add(member);
                        }
                    }
                }
            }
            return memberList;
        }

        /// <summary>
        /// method used to connect to the database and run a query to return member by fname and lname
        /// </summary>
        /// <param name="fname">member first name</param>
        /// <param name="lname">member last name</param>
        /// <returns>list of member objects</returns>
        public List<Member> GetMemberByName(string fname, string lname)
        {
            List<Member> memberList = new List<Member>();

            string selectStatement =
                "SELECT * " +
                "FROM storeMember " +
                "WHERE " +
                "LOWER(fname) = @fname " +
                "AND LOWER(lname) = @lname " +
                "AND active = 1 " +
                "ORDER BY memberID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@fname", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@fname"].Value = fname.ToLower();

                    selectCommand.Parameters.Add("@lname", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@lname"].Value = lname.ToLower();

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member member = new Member
                            {
                                MemberID = (int)reader["memberID"],
                                BirthDate = (DateTime)reader["birthDate"],
                                Fname = reader["fname"].ToString(),
                                Lname = reader["lname"].ToString(),
                                Phone = reader["phone"].ToString(),
                                Address1 = reader["address1"].ToString(),
                                Address2 = reader["address2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                Zip = reader["zip"].ToString(),
                                Active = (bool)reader["active"]
                            };
                            memberList.Add(member);
                        }
                    }
                }
            }
            return memberList;
        }

        /// <summary>
        /// method used to connect to the database and run a query to return member by phone
        /// </summary>
        /// <param name="phone">member phone</param>
        /// <returns>list of member objects</returns>
        public List<Member> GetMemberByPhone(string phone)
        {
            List<Member> memberList = new List<Member>();

            string selectStatement =
                "SELECT * " +
                "FROM storeMember " +
                "WHERE " +
                "phone = @phone " +
                "AND active = 1 " +
                "ORDER BY memberID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@phone", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@phone"].Value = phone;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member member = new Member
                            {
                                MemberID = (int)reader["memberID"],
                                BirthDate = (DateTime)reader["birthDate"],
                                Fname = reader["fname"].ToString(),
                                Lname = reader["lname"].ToString(),
                                Phone = reader["phone"].ToString(),
                                Address1 = reader["address1"].ToString(),
                                Address2 = reader["address2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                Zip = reader["zip"].ToString(),
                                Active = (bool)reader["active"]
                            };
                            memberList.Add(member);
                        }
                    }
                }
            }
            return memberList;
        }

        #endregion
    }
}
