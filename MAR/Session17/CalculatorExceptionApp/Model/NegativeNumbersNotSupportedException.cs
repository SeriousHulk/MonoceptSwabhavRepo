using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExceptionApp.Model
{
    public class NegativeNumbersNotSupportedException : Exception
    {
        public NegativeNumbersNotSupportedException(int number1, int number2)
            : base(GetExceptionMessage(number1, number2))
        {
        }

        private static string GetExceptionMessage(int number1, int number2)
        {
            if (number1 < 0 && number2 < 0)
            {
                return $"Both {number1} and {number2} are negative numbers,and Negative numbers are not supported.";
            }
            else if (number1 < 0)
            {
                return $"{number1} is a negative number, and Negative numbers are not supported.";
            }
            else if (number2 < 0)
            {
                return $"{number2} is a negative number, and Negative numbers are not supported.";
            }
            else
            {
                return "Negative numbers are not supported.";
            }
        }
    }
}
