using System;

namespace RentMe_App.Model
{
    /// <summary>
    /// model class used to define category
    /// Author: cs6232-g5
    /// Version: Spring 2022
    /// </summary>
    public class Category
    {
        #region Data Members

        /// <summary>
        /// getter/setter method for Name
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public Category()
        {
        }

        /// <summary>
        /// constructor used to create category
        /// </summary>
        /// <param name="name">furnture style name</param>
        public Category(string name)
        {

            if (string.IsNullOrEmpty(name) || name.Length > 45)
            {
                throw new ArgumentException("Name cannot be null/empty or greater than 45", "name");

            }

            this.Name = name;

        }

        #endregion
    }
}
