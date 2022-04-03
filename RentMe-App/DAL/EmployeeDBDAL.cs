using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RentMe_App.DAL
{
    /// <summary>
    /// Employee data access layer
    /// </summary>
    class EmployeeDBDAL
    {
        #region Queries

        /// <summary>
        /// Query for getting the employee by their id
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public List<Employee> GetEmployeeById(int employeeId)
        {
            if (employeeId < 0)
            {
                throw new ArgumentException("Employee ID must be a positive number");
            }

            List<Employee> newList = new List<Employee>();

            string selectStatement =
                "SELECT * " +
                "FROM employee " +
                "WHERE " +
                "employeeID = @employeeID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@employeeID", employeeId);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return null;
                        }

                        while (reader.Read())
                        {
                            Employee employee = new Employee
                            {
                                EmployeeId = (int)reader["employeeID"],
                                BirthDate = ((DateTime)reader["birthDate"]),
                                Name = reader["fname"] + " " + reader["lname"],
                                FName = reader["fname"].ToString(),
                                LName = reader["lname"].ToString(),
                                Sex = reader["sex"].ToString(),
                                Phone = reader["phone"].ToString(),
                                Address = reader["address1"] + " " + reader["address2"],
                                Address1 = reader["address1"].ToString(),
                                Address2 = reader["address2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                Zip = reader["zip"].ToString(),
                                IsActive = (bool)reader["active"]
                            };
                            newList.Add(employee);
                        }
                    }
                }
            }

            return newList;
        }

        /// <summary>
        /// Query for getting the employee by their name
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <returns></returns>
        public List<Employee> GetEmployeeByName(string fName, string lName)
        {
            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName))
            {
                throw new ArgumentException("Must enter first AND last name");
            }

            List<Employee> newList = new List<Employee>();

            string selectStatement =
                "SELECT * " +
                "FROM employee " +
                "WHERE " +
                "LOWER(fname) = @fName " +
                "AND LOWER(lname) = @lName " +
                "ORDER BY employeeID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@fName", fName);
                    selectCommand.Parameters.AddWithValue("@lName", lName);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return null;
                        }

                        while (reader.Read())
                        {
                            Employee employee = new Employee
                            {
                                EmployeeId = (int)reader["employeeID"],
                                BirthDate = ((DateTime)reader["birthDate"]),
                                Name = reader["fname"] + " " + reader["lname"],
                                FName = reader["fname"].ToString(),
                                LName = reader["lname"].ToString(),
                                Sex = reader["sex"].ToString(),
                                Phone = reader["phone"].ToString(),
                                Address = reader["address1"] + " " + reader["address2"],
                                Address1 = reader["address1"].ToString(),
                                Address2 = reader["address2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                Zip = reader["zip"].ToString(),
                                IsActive = (bool)reader["active"]
                            };
                            newList.Add(employee);
                        }
                    }
                }
            }

            return newList;
        }

        /// <summary>
        /// Query for getting the employee by their phone number
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public List<Employee> GetEmployeeByPhone(string phone)
        {
            if (phone == null)
            {
                throw new ArgumentException("Invalid phone number");
            }

            List<Employee> newList = new List<Employee>();

            string selectStatement =
                "SELECT * " +
                "FROM employee " +
                "WHERE " +
                "phone = @phone " +
                "ORDER BY employeeID";

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@phone", phone);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return null;
                        }

                        while (reader.Read())
                        {
                            Employee employee = new Employee
                            {
                                EmployeeId = (int)reader["employeeID"],
                                BirthDate = ((DateTime)reader["birthDate"]),
                                Name = reader["fname"] + " " + reader["lname"],
                                FName = reader["fname"].ToString(),
                                LName = reader["lname"].ToString(),
                                Sex = reader["sex"].ToString(),
                                Phone = reader["phone"].ToString(),
                                Address = reader["address1"] + " " + reader["address2"],
                                Address1 = reader["address1"].ToString(),
                                Address2 = reader["address2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                Zip = reader["zip"].ToString(),
                                IsActive = (bool)reader["active"]
                            };
                            newList.Add(employee);
                        }
                    }
                }
            }

            return newList;
        }

        public void UpdateEmployee(Employee oldEmployee, Employee editedEmployee)
        {
            if (oldEmployee == null || editedEmployee == null)
            {
                throw new ArgumentNullException("Invalid employees");
            }
            //Make sure employee wasn't changed before updating
            throw new NotImplementedException();
        }

        #endregion
    }
}
