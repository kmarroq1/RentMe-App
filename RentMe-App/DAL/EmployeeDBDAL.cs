using RentMe_App.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace RentMe_App.DAL
{
    /// <summary>
    /// Employee data access layer
    /// </summary>
    public class EmployeeDBDAL
    {
        #region Queries

        /// <summary>
        /// Query for getting the employee by their id
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public List<Employee> GetEmployeeById(int employeeId)
        {
            List<Employee> newList = new List<Employee>();

            string selectStatement =
                "SELECT employee.employeeID as employeeID, birthDate, fname, lname, sex, phone, address1, address2, city, state, zip, active, username, version, admin.employeeID as adminID " +
                "FROM employee " +
                "JOIN login ON login.employeeID = employee.employeeID " +
                "LEFT JOIN admin ON admin.employeeID = employee.employeeID " +
                "WHERE " +
                "employee.employeeID = @employeeID";

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
                                Username = reader["username"].ToString(),
                                Version = (byte[])reader["version"],
                                IsAdmin = reader["adminID"] == DBNull.Value ? false : true,
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
            List<Employee> newList = new List<Employee>();

            string selectStatement =
                "SELECT employee.employeeID as employeeID, birthDate, fname, lname, sex, phone, address1, address2, city, state, zip, active, username, version, admin.employeeID as adminID " +
                "FROM employee " +
                "JOIN login ON login.employeeID = employee.employeeID " +
                "LEFT JOIN admin ON admin.employeeID = employee.employeeID " +
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
                                Username = reader["username"].ToString(),
                                Version = (byte[])reader["version"],
                                IsAdmin = reader["adminID"] == DBNull.Value ? false : true,
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
            List<Employee> newList = new List<Employee>();

            string selectStatement =
                "SELECT employee.employeeID as employeeID, birthDate, fname, lname, sex, phone, address1, address2, city, state, zip, active, username, version, admin.employeeID as adminID " +
                "FROM employee " +
                "JOIN login ON login.employeeID = employee.employeeID " +
                "LEFT JOIN admin ON admin.employeeID = employee.employeeID " +
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
                                Username = reader["username"].ToString(),
                                Version = (byte[])reader["version"],
                                IsAdmin = reader["adminID"] == DBNull.Value ? false : true,
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
                                "Employee update failed - updated since last search");
                        }
                    }


                    if (!string.IsNullOrEmpty(editedEmployee.Password) || editedEmployee.Username != oldEmployee.Username)
                    {
                        var updateLoginStatement =
                        "UPDATE login " +
                        "SET ";

                        var usernameUpdate = "username = @username ";
                        var shouldUpdateUsername = editedEmployee.Username != oldEmployee.Username;

                        SHA256 hash = SHA256.Create();
                        var hashPassword = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(editedEmployee.Password));
                        var passwordUpdate = "password = @password ";
                        var shouldUpdatePassword = !string.IsNullOrEmpty(editedEmployee.Password);

                        if (shouldUpdatePassword && shouldUpdateUsername)
                        {
                            updateLoginStatement += usernameUpdate + ", " + passwordUpdate;
                        }
                        else if (shouldUpdateUsername)
                        {
                            updateLoginStatement += usernameUpdate;
                        }
                        else if (shouldUpdatePassword)
                        {
                            updateLoginStatement += passwordUpdate;
                        }


                        updateLoginStatement += "WHERE employeeID = @employeeID";

                        using (var command = new SqlCommand(updateLoginStatement, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@employeeID", oldEmployee.EmployeeId);
                            if (shouldUpdateUsername)
                            {
                                command.Parameters.AddWithValue("@username", editedEmployee.Username);
                            }
                            if (shouldUpdatePassword)
                            {
                                command.Parameters.AddWithValue("@password", hashPassword);
                            }

                            var rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected != 1)
                            {
                                throw new InvalidOperationException(
                                    "Login update failed"); // should only occur if no login for employee, so basically never
                            }
                        }
                    }

                    if (oldEmployee.IsAdmin != editedEmployee.IsAdmin)
                    {
                        var employeeStatusInsertStatement = "INSERT INTO ";
                        var employeeStatusDeleteStatement = "DELETE FROM ";
                        if (editedEmployee.IsAdmin)
                        {
                            employeeStatusInsertStatement += "admin (employeeID) ";
                            employeeStatusDeleteStatement += "regularEmployee ";
                        }
                        else
                        {
                            employeeStatusInsertStatement += "regularEmployee (employeeID) ";
                            employeeStatusDeleteStatement += "admin ";
                        }

                        employeeStatusDeleteStatement += "WHERE employeeID = @employeeID ";
                        using (SqlCommand statusDeleteCommand = new SqlCommand(employeeStatusDeleteStatement, connection, transaction))
                        {
                            statusDeleteCommand.Parameters.AddWithValue("@employeeID", oldEmployee.EmployeeId);

                            statusDeleteCommand.ExecuteNonQuery();
                        }

                        employeeStatusInsertStatement += "VALUES (@employeeID)";
                        using (SqlCommand statusInsertCommand = new SqlCommand(employeeStatusInsertStatement, connection, transaction))
                        {
                            statusInsertCommand.Parameters.AddWithValue("@employeeID", oldEmployee.EmployeeId);

                            statusInsertCommand.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Adds an employee to the database and returns their ID
        /// </summary>
        /// <param name="newEmployee"></param>
        /// <returns></returns>
        public int AddEmployee(Employee newEmployee)
        {

            using (SqlConnection connection = RentMeAppDBConnection.GetConnection())
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    var insertStatement =
                        "INSERT INTO employee (birthDate, fname, lname, phone, address1, address2, city, state, zip, active, sex) " +
                        "VALUES (@birthDate, @fname, @lname, @phone, @address1, @address2, @city, @state, @zip, @active, @sex)" +
                        "; SELECT SCOPE_IDENTITY()";
                    int insertedEmployeeID;
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection, transaction))
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

                        insertedEmployeeID = Convert.ToInt32(insertCommand.ExecuteScalar());
                    }

                    var loginInsertStatement =
                        "INSERT INTO login (employeeID, username, password) " +
                        "VALUES (@employeeID, @username, @password)";

                    SHA256 hash = SHA256.Create();
                    var hashPassword = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(newEmployee.Password));

                    using (SqlCommand loginInsertCommand = new SqlCommand(loginInsertStatement, connection, transaction))
                    {
                        loginInsertCommand.Parameters.AddWithValue("@employeeID", insertedEmployeeID);
                        loginInsertCommand.Parameters.AddWithValue("@username", newEmployee.Username);
                        loginInsertCommand.Parameters.AddWithValue("@password", hashPassword);

                        loginInsertCommand.ExecuteNonQuery();
                    }

                    var employeeStatusInsertStatement = "INSERT INTO ";
                    if (newEmployee.IsAdmin)
                    {
                        employeeStatusInsertStatement += "admin (employeeID) ";
                    }
                    else
                    {
                        employeeStatusInsertStatement += "regularEmployee (employeeID) ";
                    }

                    employeeStatusInsertStatement += "VALUES (@employeeID)";
                    using (SqlCommand statusInsertCommand = new SqlCommand(employeeStatusInsertStatement, connection, transaction))
                    {
                        statusInsertCommand.Parameters.AddWithValue("@employeeID", insertedEmployeeID);

                        statusInsertCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return insertedEmployeeID;
                }
            }
        }

    }

    #endregion
}

