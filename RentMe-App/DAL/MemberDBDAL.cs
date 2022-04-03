using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
                "memberID = @memberID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@memberID", SqlDbType.Int);
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
                "ORDER BY memberID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@fname", SqlDbType.VarChar);
                    selectCommand.Parameters["@fname"].Value = fname.ToLower();

                    selectCommand.Parameters.Add("@lname", SqlDbType.VarChar);
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
                "ORDER BY memberID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@phone", SqlDbType.VarChar);
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

        /// <summary>
        /// Adds a new Member to the Database based off of a Member model object.
        /// </summary>
        /// <param name="newMember">The new Member to add to the Members table.</param>
        /// <returns>Whether or not the insertion was successful.</returns>
        public bool AddMember(Member newMember)
        {
            string insertStatement = @"INSERT INTO [storeMember] ([Fname], [Lname], [BirthDate], [Address1], [Address2], [City], [State], [Zip], [Phone], [Active])
                                       VALUES (@Fname, @Lname, @BirthDate, @Address1, @Address2, @City, @State, @Zip, @Phone, @Active);";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    cmd.Parameters.Add("Fname", SqlDbType.VarChar);
                    cmd.Parameters["Fname"].Value = newMember.Fname;

                    cmd.Parameters.Add("Lname", SqlDbType.VarChar);
                    cmd.Parameters["Lname"].Value = newMember.Lname;

                    cmd.Parameters.Add("BirthDate", SqlDbType.Date);
                    cmd.Parameters["BirthDate"].Value = newMember.BirthDate;

                    cmd.Parameters.Add("Address1", SqlDbType.VarChar);
                    cmd.Parameters["Address1"].Value = newMember.Address1;

                    cmd.Parameters.Add("Address2", SqlDbType.VarChar);
                    if (newMember.Address2 == null) cmd.Parameters["Address2"].Value = DBNull.Value;
                    else cmd.Parameters["Address2"].Value = newMember.Address2;

                    cmd.Parameters.Add("City", SqlDbType.VarChar);
                    cmd.Parameters["City"].Value = newMember.City;

                    cmd.Parameters.Add("State", SqlDbType.Char);
                    cmd.Parameters["State"].Value = newMember.State;

                    cmd.Parameters.Add("Zip", SqlDbType.Char);
                    cmd.Parameters["Zip"].Value = newMember.Zip;

                    cmd.Parameters.Add("Phone", SqlDbType.Char);
                    cmd.Parameters["Phone"].Value = newMember.Phone;

                    cmd.Parameters.Add("Active", SqlDbType.Bit);
                    cmd.Parameters["Active"].Value = newMember.Active ? 1 : 0;

                    return cmd.ExecuteNonQuery() >= 1;
                }
            }
        }

        #endregion
    }
}
