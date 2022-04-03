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
                                IsActive = (bool)reader["active"],
                                Version = (byte[])reader["version"]
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
                                IsActive = (bool)reader["active"],
                                Version = (byte[])reader["version"]
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
                                IsActive = (bool)reader["active"],
                                Version = (byte[])reader["version"]
                            };
                            newList.Add(employee);
                        }
                    }
                }
            }

            return newList;
        }

        /// <summary>
        /// Updates the employee table
        /// </summary>
        /// <param name="oldEmployee"></param>
        /// <param name="editedEmployee"></param>
        public void UpdateEmployee(Employee oldEmployee, Employee editedEmployee)
        {
            _ = editedEmployee ?? throw new ArgumentNullException(nameof(editedEmployee));
            _ = oldEmployee ?? throw new ArgumentNullException(nameof(oldEmployee));


            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    var updateEmployeeStatement =
                        "UPDATE employee " +
                        "SET birthDate = @birthDate, fname = @fname, lname = @lname, phone = @phone, address1 = @address1, address2 = @address2, city = @city, state = @state, zip = @zip, active = @active, sex = @sex " +
                        "WHERE employeeID = @employeeID AND version = @expectedVersion";
                    using (var command = new SqlCommand(updateEmployeeStatement, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@birthDate", editedEmployee.BirthDate);
                        command.Parameters.AddWithValue("@fname", editedEmployee.FName);
                        command.Parameters.AddWithValue("@lname", editedEmployee.LName);
                        command.Parameters.AddWithValue("@phone", editedEmployee.Phone);
                        command.Parameters.AddWithValue("@address1", editedEmployee.Address1);
                        command.Parameters.AddWithValue("@address2", editedEmployee.Address2);
                        command.Parameters.AddWithValue("@city", editedEmployee.City);
                        command.Parameters.AddWithValue("@state", editedEmployee.State);
                        command.Parameters.AddWithValue("@zip", editedEmployee.Zip);
                        command.Parameters.AddWithValue("@active", editedEmployee.IsActive);
                        command.Parameters.AddWithValue("@sex", editedEmployee.Sex);
                        command.Parameters.AddWithValue("@employeeID", oldEmployee.EmployeeId);
                        command.Parameters.AddWithValue("@expectedVersion", oldEmployee.Version);

                        var rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected != 1)
                        {
                            throw new InvalidOperationException(
                                "Employee update failed - employee has been updated since last search");
                        }
                    }

                    if (!string.IsNullOrEmpty(editedEmployee.Password))
                    {
                        var updateLoginStatement =
                            "UPDATE login SET password = HASHBYTES('SHA2_256', @password) WHERE employeeID = @employeeID";
                        using (var command = new SqlCommand(updateLoginStatement, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@employeeID", oldEmployee.EmployeeId);
                            command.Parameters.AddWithValue("@password", editedEmployee.Password);

                            var rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected != 1)
                            {
                                throw new InvalidOperationException(
                                    "Login update failed"); // should only occur if no login for employee, so basically never
                            }
                        }
                    }

                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Adds an employee to the database
        /// </summary>
        /// <param name="newEmployee"></param>
        public void AddEmployee(Employee newEmployee)
        {
            try
            {
                _ = newEmployee ?? throw new ArgumentNullException(nameof(newEmployee));
                using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
                {
                    connection.Open();
                    var insertStatement =
                        "INSERT INTO employee (birthDate, fname, lname, phone, address1, address2, city, state, zip, active, sex) " +
                        "VALUES (@birthDate, @fname, @lname, @phone, @address1, @address2, @city, @state, @zip, @active, @sex)";
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@birthDate", newEmployee.BirthDate);
                        insertCommand.Parameters.AddWithValue("@fname", newEmployee.FName);
                        insertCommand.Parameters.AddWithValue("@lname", newEmployee.LName);
                        insertCommand.Parameters.AddWithValue("@phone", newEmployee.Phone);
                        insertCommand.Parameters.AddWithValue("@address1", newEmployee.Address1);
                        insertCommand.Parameters.AddWithValue("@address2", newEmployee.Address2);
                        insertCommand.Parameters.AddWithValue("@city", newEmployee.City);
                        insertCommand.Parameters.AddWithValue("@state", newEmployee.State);
                        insertCommand.Parameters.AddWithValue("@zip", newEmployee.Zip);
                        insertCommand.Parameters.AddWithValue("@active", newEmployee.IsActive);
                        insertCommand.Parameters.AddWithValue("@sex", newEmployee.Sex);

                        insertCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw new InvalidOperationException(
                    "Could not add employee");
            }

        }

        #endregion
    }
}
