using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        public int AddMember(Member newMember)
        {
            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("RegisterMember", connection) { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.Add("FirstName", SqlDbType.VarChar);
                    cmd.Parameters["FirstName"].Value = newMember.Fname;

                    cmd.Parameters.Add("LastName", SqlDbType.VarChar);
                    cmd.Parameters["LastName"].Value = newMember.Lname;

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

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Updates the given member row with the given values.
        /// Prevents race condition by checking against old values.
        /// </summary>
        /// <param name="oldValues">Old contents of the row</param>
        /// <param name="newValues">New contents to replace the old ones</param>
        public void UpdateMember(Member oldValues, Member newValues)
        {
            string updateStatement = @"update storeMember
                                       set fname = @new_fname
                                         , lname = @new_lname
                                         , birthDate = @new_birthDate
                                         , address1 = @new_address1
                                         , address2 = @new_address2
                                         , city = @new_city
                                         , [state] = @new_state
                                         , zip = @new_zip
                                         , phone = @new_phone
                                         , active = @new_active
                                       where memberID = @old_memberID
                                         and fname = @old_fname
                                         and lname = @old_lname
                                         and birthDate = @old_birthDate
                                         and address1 = @old_address1
                                         and ((address2 is null and @old_address2 is null) or (address2 = @old_address2))
                                         and city = @old_city
                                         and [state] = @old_state
                                         and zip = @old_zip
                                         and phone = @old_phone
                                         and active =  @old_active
                                       ;";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    #region Update: New Values
                    cmd.Parameters.Add("new_fname", SqlDbType.VarChar);
                    cmd.Parameters["new_fname"].Value = newValues.Fname;

                    cmd.Parameters.Add("new_lname", SqlDbType.VarChar);
                    cmd.Parameters["new_lname"].Value = newValues.Lname;

                    cmd.Parameters.Add("new_birthDate", SqlDbType.Date);
                    cmd.Parameters["new_birthDate"].Value = newValues.BirthDate;

                    cmd.Parameters.Add("new_address1", SqlDbType.VarChar);
                    cmd.Parameters["new_address1"].Value = newValues.Address1;

                    cmd.Parameters.Add("new_address2", SqlDbType.VarChar);
                    if (string.IsNullOrWhiteSpace(newValues.Address2)) cmd.Parameters["new_address2"].Value = DBNull.Value;
                    else cmd.Parameters["new_address2"].Value = newValues.Address2;

                    cmd.Parameters.Add("new_city", SqlDbType.VarChar);
                    cmd.Parameters["new_city"].Value = newValues.City;

                    cmd.Parameters.Add("new_state", SqlDbType.VarChar);
                    cmd.Parameters["new_state"].Value = newValues.State;

                    cmd.Parameters.Add("new_zip", SqlDbType.VarChar);
                    cmd.Parameters["new_zip"].Value = newValues.Zip;

                    cmd.Parameters.Add("new_phone", SqlDbType.VarChar);
                    cmd.Parameters["new_phone"].Value = newValues.Phone;

                    cmd.Parameters.Add("new_active", SqlDbType.Bit);
                    cmd.Parameters["new_active"].Value = newValues.Active ? 1 : 0;
                    #endregion

                    #region Update: Old Values
                    cmd.Parameters.Add("old_memberID", SqlDbType.Int);
                    cmd.Parameters["old_memberID"].Value = oldValues.MemberID;

                    cmd.Parameters.Add("old_fname", SqlDbType.VarChar);
                    cmd.Parameters["old_fname"].Value = oldValues.Fname;

                    cmd.Parameters.Add("old_lname", SqlDbType.VarChar);
                    cmd.Parameters["old_lname"].Value = oldValues.Lname;

                    cmd.Parameters.Add("old_birthDate", SqlDbType.Date);
                    cmd.Parameters["old_birthDate"].Value = oldValues.BirthDate;

                    cmd.Parameters.Add("old_address1", SqlDbType.VarChar);
                    cmd.Parameters["old_address1"].Value = oldValues.Address1;

                    cmd.Parameters.Add("old_address2", SqlDbType.VarChar);
                    if (string.IsNullOrWhiteSpace(oldValues.Address2)) cmd.Parameters["old_address2"].Value = DBNull.Value;
                    else cmd.Parameters["old_address2"].Value = oldValues.Address2;

                    cmd.Parameters.Add("old_city", SqlDbType.VarChar);
                    cmd.Parameters["old_city"].Value = oldValues.City;

                    cmd.Parameters.Add("old_state", SqlDbType.VarChar);
                    cmd.Parameters["old_state"].Value = oldValues.State;

                    cmd.Parameters.Add("old_zip", SqlDbType.VarChar);
                    cmd.Parameters["old_zip"].Value = oldValues.Zip;

                    cmd.Parameters.Add("old_phone", SqlDbType.VarChar);
                    cmd.Parameters["old_phone"].Value = oldValues.Phone;

                    cmd.Parameters.Add("old_active", SqlDbType.Bit);
                    cmd.Parameters["old_active"].Value = oldValues.Active ? 1 : 0;
                    #endregion

                    int effectedRows = cmd.ExecuteNonQuery();

                    if (effectedRows <= 0)
                        throw new Exception("Data changed via external source. Please reload Member.");

                    if (effectedRows > 1)
                        throw new Exception("Multiple rows were changed...");
                }
            }
        }
        #endregion
    }
}
