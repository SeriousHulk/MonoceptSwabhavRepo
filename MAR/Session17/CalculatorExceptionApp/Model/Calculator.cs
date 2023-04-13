using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExceptionApp.Model
{
    internal class Calculator
    {
        public int Add(int number1, int number2)
        {
            if (number1 < 0 || number2 < 0)
            {
                throw new NegativeNumbersNotSupportedException(number1, number2);
            }

            return number1 + number2;
        }
    }
}
