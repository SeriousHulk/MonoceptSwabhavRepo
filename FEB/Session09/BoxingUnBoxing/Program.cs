using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int int1 = 300;
            Console.WriteLine($"Value of integer: {int1}");
            //boxing
            object obj = int1; 
            //unboxing
            int int2 = (int)obj;
            Console.WriteLine($"Value of object: {obj}");
            Console.WriteLine($"Value of unboxed obj: {int2}");
        }
    }
}
