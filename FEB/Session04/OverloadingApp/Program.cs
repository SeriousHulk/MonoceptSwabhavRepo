using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(10);
            PrintDetails(10.50);
            PrintDetails(10.55f);
            PrintDetails("Monocept");
            PrintDetails('a');
            PrintDetails(9>10);
        }

        private static void PrintDetails(int input)
        {
            Console.WriteLine("Printing integer value {0}", input);
        }

        private static void PrintDetails(double input)
        {
            Console.WriteLine("Printing double value {0}", input);
        }

        private static void PrintDetails(float input)
        {
            Console.WriteLine("Printing float value {0}", input);
        }

        private static void PrintDetails(string input)
        {
            Console.WriteLine("Printing String value {0}",input);
        }

        private static void PrintDetails(char input)
        {
            Console.WriteLine("Printing Char value {0} and ascii value {1}", input, (int)input);
        }

        private static void PrintDetails(bool input)
        {
            Console.WriteLine("Printing boolean value {0}", input);
        }
    }
}
