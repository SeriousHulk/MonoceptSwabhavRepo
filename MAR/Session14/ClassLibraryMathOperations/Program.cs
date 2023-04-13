using System;
using ClassLibraryPOC.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryPOC;

namespace ClassLibraryMathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations class1 = new MathOperations();
            class1.Sum(10,12);
            Console.WriteLine($"Sum is {class1.Sum(10, 12)}");
            Console.WriteLine($"Difference is {class1.Substract(10, 12)}");
            Console.WriteLine($"Product is {class1.Product(10, 12)}");
            Console.WriteLine($"Division is {class1.divide(10, 12)}");
        }
    }
}
