using System;

namespace RentMe_App.Model
{
    /// <summary>
    /// Represents the data stored in a row in the Employee table in the database.
    /// </summary>
    public class Employee : Person
    {
        private string _sex;

        /// <summary>
        /// Property dictates how the Employee's sex field may be accessed and mutated.
        /// </summary>
        public string Sex
        {
            get => _sex;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Sex", "Sex cannot be empty");

                _sex = value;
            }
        }
    }
}
