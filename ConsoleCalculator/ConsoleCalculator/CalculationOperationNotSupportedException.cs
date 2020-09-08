using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class CalculationOperationNotSupportedException : CalculationException
    {
        public string Operation { get; }

        /// <summary>
        /// Create a new CalculationOperationNotSupportedException with a predefined message
        /// </summary>
        public CalculationOperationNotSupportedException() : base("Specified operation was out of the range of valid values")
        {

        }

        /// <summary>
        /// Create a new CalculationOperationNotSupportedException with the operation that is not supported
        /// </summary>
        /// <param name="operation"></param>
        public CalculationOperationNotSupportedException(string operation) : this()
        {
            Operation = operation;
        }

        /// <summary>
        /// Create a new CalculationOperationNotSupportedException with a user-defined message and a wrapped inner exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public CalculationOperationNotSupportedException(string message, Exception innerException) : base(message, innerException)
        {

        }

        /// <summary>
        /// Create a new CalculationOperationNotSupportedException with a user-defined message
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="message"></param>
        public CalculationOperationNotSupportedException(string operation, string message) : base(message)
        {
            Operation = operation;
        }

        public override string Message
        {
            get
            {
                string message = base.Message;

                if(Operation != null)
                {
                    return message + Environment.NewLine + $"Unsupported operation : {Operation}";
                }

                return message;
            }
        }
    }
}
