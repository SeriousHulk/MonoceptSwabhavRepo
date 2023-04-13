using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPOC.Model
{
    public class MathOperations
    {
        public int Sum(int operand1, int operand2) {
            return operand1 + operand2;
        }
        public int Substract(int operand1, int operand2)
        {
            return operand1 - operand2;
        }
        public int divide(int operand1, int operand2) 
        {
            return operand1 / operand2;
        }
        public int Product(int operand1, int operand2)
        {
            return operand1 * operand2; 
        }
    }
}
