using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            string noNullException = operation ?? throw new ArgumentNullException(nameof(operation));

            if (noNullException == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                catch (ArithmeticException ex)
                {
                    throw new CalculationException("An error occured during division",ex);
                }
            }
            else
            {
                throw new CalculationOperationNotSupportedException(operation);
            }
        }
        
        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}

