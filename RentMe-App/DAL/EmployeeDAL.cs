using System;
using System.Data;
using System.Data.SqlClient;
using RentMe_App.Model;

namespace RentMe_App.DAL
{
    public class EmployeeDAL
    {
        /// <summary>
        /// Creates a new Employee row based off of the given Employee object,
        /// and inserts it into the database.
        /// </summary>
        /// <param name="newEmployee">The new Employee to add to the Employees table.</param>
        /// <returns>Whether or not the insertion was successful.</returns>
        public bool AddEmployee(Employee newEmployee)
        {
            string insertStatement = @"INSERT INTO [Employees] ([Fname], [Lname], [BirthDate], [Sex], [Phone], [Address1], [Address2], [City], [State], [Zip], [Active])
                                       VALUES (@Fname, @Lname, @BirthDate, @Sex, @Phone, @Address1, @Address2, @City, @State, @Zip, @Active);";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(insertStatement, connection))
                {
                    cmd.Parameters.Add("Fname", SqlDbType.VarChar);
                    cmd.Parameters["Fname"].Value = newEmployee.Fname;

                    cmd.Parameters.Add("Lname", SqlDbType.VarChar);
                    cmd.Parameters["Lname"].Value = newEmployee.Lname;

                    cmd.Parameters.Add("BirthDate", SqlDbType.Date);
                    cmd.Parameters["BirthDate"].Value = newEmployee.BirthDate;

                    cmd.Parameters.Add("Sex", SqlDbType.VarChar);
                    if (newEmployee.Sex != null)
                        cmd.Parameters["Sex"].Value = newEmployee.Sex;
                    else
                        cmd.Parameters["Sex"].Value = DBNull.Value;

                    cmd.Parameters.Add("Phone", SqlDbType.VarChar);
                    cmd.Parameters["Phone"].Value = newEmployee.Phone;

                    cmd.Parameters.Add("Address1", SqlDbType.VarChar);
                    cmd.Parameters["Address1"].Value = newEmployee.Address1;

                    cmd.Parameters.Add("Address2", SqlDbType.VarChar);
                    if (newEmployee.Address2 != null)
                        cmd.Parameters["Address2"].Value = newEmployee.Address2;
                    else
                        cmd.Parameters["Address2"].Value = DBNull.Value;

                    cmd.Parameters.Add("City", SqlDbType.VarChar);
                    cmd.Parameters["City"].Value = newEmployee.City;

                    cmd.Parameters.Add("State", SqlDbType.VarChar);
                    cmd.Parameters["State"].Value = newEmployee.State;

                    cmd.Parameters.Add("Zip", SqlDbType.VarChar);
                    cmd.Parameters["Zip"].Value = newEmployee.Zip;

                    cmd.Parameters.Add("Active", SqlDbType.Bit);
                    cmd.Parameters["Active"].Value = newEmployee.IsActive ? 1 : 0;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
