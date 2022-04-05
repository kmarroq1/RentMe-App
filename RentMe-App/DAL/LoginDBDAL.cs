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

        #endregion
    }
}
