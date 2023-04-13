using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDelegateApp.Model
{
    public delegate void DAddition(int a, int b, string result);
    internal class Calculator
    {
        private int _num1;
        private int _num2;
        public event DAddition AdditionCompleted;
        public event DAddition SubtractionCompleted;
        public Calculator(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }

        public Calculator()
        {
        }

        public void Addition(int num1, int num2)
        {
            string result = $"{num1 + num2} is the Addition";
            Console.WriteLine(result);
            if (AdditionCompleted != null)
            {
                AdditionCompleted(num1,num2,result);
            }
        }
        public void Subtraction(int num1, int num2)
        {
            string result = $"{num1 - num2} is the Addition";
            Console.WriteLine(result);
            if (SubtractionCompleted != null)
            {
                SubtractionCompleted(num1, num2, result);
            }
        }
    }
}
