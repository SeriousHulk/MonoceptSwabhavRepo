using OddEven.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
        }

        private static void CaseStudy1()
        {
            Even constructor1 = new Even(60);
            Console.WriteLine("Even numbers after Passing single value: ");
            PrintEven(constructor1);
        }
        private static void CaseStudy2()
        {
            Even even = new Even(0, 100);
            Console.WriteLine("\n\nEven numbers:\n");
            PrintEven(even);
        }

        private static void CaseStudy3()
        {
            Odd odd = new Odd(0, 100);
            Console.WriteLine("\n\nOdd numbers:\n");
            PrintOdds(odd);
        }

        private static void PrintEven(Even evenNumbers)
        {
            foreach (int number in evenNumbers.GetEven)
            {
                Console.Write(number + " ");
            }
        }

        private static void PrintOdds(Odd oddNumbers)
        {
            foreach (int number in oddNumbers.GetOdd)
            {
                Console.Write(number + " ");
            }
        }
    }
}
