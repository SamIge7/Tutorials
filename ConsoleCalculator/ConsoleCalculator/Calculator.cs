using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            //throw new ArgumentNullException(nameof(number1));

            string noNullException = operation ?? throw new ArgumentNullException(nameof(operation));

            //if(operation == null)
            //{
            //    throw new ArgumentNullException(nameof(operation));
            //}

            if (noNullException == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                catch (DivideByZeroException ex)
                {
                    //throw;

                    throw new ArithmeticException("An error occured during calculation", ex);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(operation), "The mathematical error is not supported");

                //Console.WriteLine("Unknown operation.");
                //return 0;
            }
        }
        
        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}

