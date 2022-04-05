using RentMe_App.Model;
using System.Data;
using System.Data.SqlClient;

namespace RentMe_App.DAL
{
    /// <summary>
    /// data layer class used to access the login
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class LoginDBDAL
    {
        #region Methods

        /// <summary>
        /// method used to call the stored function sfGetAuthorizedEmployeeLoginInfo
        /// </summary>
        /// <param name="username">employee username</param>
        /// <param name="password">employee password</param>
        /// <returns>string with login info for regular employees if authorized or null if not</returns>
        public string GetAuthorizedEmployeeLoginInfo(string username, string password)
        {
            string loginInfo = string.Empty;
            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "sfGetAuthorizedEmployeeLoginInfo",
                    CommandType = CommandType.StoredProcedure
                })
                {
                    selectCommand.Parameters.Add("@username", SqlDbType.VarChar);
                    selectCommand.Parameters["@username"].Value = username;
                    selectCommand.Parameters.Add("@password", SqlDbType.VarChar);
                    selectCommand.Parameters["@password"].Value = password;

                    SqlParameter output = new SqlParameter("@info", SqlDbType.VarChar)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    selectCommand.Parameters.Add(output);
                    selectCommand.ExecuteNonQuery();
                    loginInfo = output.Value.ToString();
                }
            }
            return loginInfo;
        }

        /// <summary>
        /// method used to call the stored function sfGetAuthorizedAdminLoginInfo
        /// </summary>
        /// <param name="username">employee username</param>
        /// <param name="password">employee password</param>
        /// <returns>string with login info for admin employees if authorized or null if not</returns>
        public string GetAuthorizedAdminLoginInfo(string username, string password)
        {
            string loginInfo = string.Empty;
            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand
                {
                    Connection = connection,
                    CommandText = "sfGetAuthorizedAdminLoginInfo",
                    CommandType = CommandType.StoredProcedure
                })
                {
                    selectCommand.Parameters.Add("@username", SqlDbType.VarChar);
                    selectCommand.Parameters["@username"].Value = username;
                    selectCommand.Parameters.Add("@password", SqlDbType.VarChar);
                    selectCommand.Parameters["@password"].Value = password;

                    SqlParameter output = new SqlParameter("@info", SqlDbType.VarChar)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    selectCommand.Parameters.Add(output);
                    selectCommand.ExecuteNonQuery();
                    loginInfo = output.Value.ToString();
                }
            }
            return loginInfo;
        }

        /// <summary>
        /// Adds username and password to login
        /// </summary>
        /// <param name="newEmployee"></param>
        public void AddLogin(Employee newEmployee)
        {

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();
                var insertStatement =
                    "INSERT INTO login (employeeID, username, password) " +
                    "VALUES (@employeeID, @username, HASHBYTES('SHA2_256', @password))";
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@employeeID", newEmployee.EmployeeId);
                    insertCommand.Parameters.AddWithValue("@username", newEmployee.Username);
                    insertCommand.Parameters.AddWithValue("@password", newEmployee.Password);

                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Adds username and password to login
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>boolean value if successfully updated</returns>
        public bool UpdateLogin(Employee employee)
        {

            string updateStatement =
                "UPDATE login SET " +
                "employeeID = @employeeID " +
                ", IIF(TRIM(@username) != NULL, @username, username) AS username " +
                ", IIF(TRIM(@password) != NULL, HASHBYTES('SHA2_256', @password), password) AS password " +
                "WHERE " +
                "@username NOT IN ( " +
                "   SELECT DISTINCT " +
                "   username " +
                "   FROM login " +
                ") ";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.Add("@employeeID", System.Data.SqlDbType.Int);
                    updateCommand.Parameters["@employeeID"].Value = employee.EmployeeId;

                    if (employee.Username == null)
                    {
                        updateCommand.Parameters.Add("@username", SqlDbType.VarChar);
                        updateCommand.Parameters["@username"].Value = System.DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
                        updateCommand.Parameters["@username"].Value = employee.Username;
                    }

                    if (employee.Password == null)
                    {
                        updateCommand.Parameters.Add("@password", SqlDbType.VarChar);
                        updateCommand.Parameters["@password"].Value = System.DBNull.Value;
                    }
                    else
                    {
                        updateCommand.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
                        updateCommand.Parameters["@password"].Value = employee.Password;
                    }

                    int count = updateCommand.ExecuteNonQuery();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        #endregion
    }
}
