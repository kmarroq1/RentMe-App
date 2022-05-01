using System;

namespace RentMe_App.Model
{
    /// <summary>
    /// To be thrown if a transaction tries to complete while empty.
    /// </summary>
    public class EmptyTransactionException : Exception
    {
        /// <summary>
        /// Creates the exception with it's modified message.
        /// </summary>
        /// <param name="message">The message to modify.</param>
        public EmptyTransactionException(string message) : base($"Empty cart. {message}") { }
    }
}
