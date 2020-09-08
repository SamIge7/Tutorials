using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class CalculationException : Exception
    {
        private static readonly string DefaultMessage = "An error occured during calculation. Ensure that the operation is supported and within the valid ranges for the requested operation.";

        /// <summary>
        /// Create a new CalculationException with a predefined message
        /// </summary>
        public CalculationException() : base(DefaultMessage)
        {

        }

        /// <summary>
        /// Creates a new CalculationException with a user-supplied message
        /// </summary>
        /// <param name="message"></param>
        public CalculationException(string message) : base(message)
        {

        }

        /// <summary>
        /// Creates a new CalculationException with a predefined message and a wrapped inner exception.
        /// </summary>
        /// <param name="innerException"></param>
        public CalculationException(Exception innerException) : base(DefaultMessage, innerException)
        {

        }

        /// <summary>
        /// Creates a new CalcualtionException with a user-suppled message and a wrapped inner exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public CalculationException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
