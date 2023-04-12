using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingValuesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            CaseStudy4();
        }
        private static void CaseStudy1()
        {
            int mark = 100;
            UpdateMarkToZero(mark);
            Console.WriteLine("CaseStudy1: mark value is {0}", mark);
        }
        private static void UpdateMarkToZero(int mark)
        {
            mark = 0;
        }
        private static void CaseStudy2()
        {
            int salary = 1000;
            UpdateSalaryToZero(ref salary);
            Console.WriteLine("CaseStudy2: salary is {0}", salary);
        }
        private static void UpdateSalaryToZero(ref int psalary)
        {
            psalary = 0;
        }
        private static void CaseStudy3()
        {
            int[] scores = { 10, 20, 30};
            foreach(int score in scores)
            {
                Console.WriteLine(score);
            }
            UpdateScoresToZero(scores);
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
            Console.WriteLine("The HashCode is: {0}", scores.GetHashCode());
        }
        private static void UpdateScoresToZero(int[] pScores)
        {
            for (int i=0; i<pScores.Length; i++)
            {
                pScores[i] = 0;
            }
        }
        private static void CaseStudy4()
        {
            int sum, avg, product;
            Calculate(10 , 20, 30, out sum, out avg, out product);
            Console.WriteLine("Enter Only Number: ");
            string input = Console.ReadLine();
            int no = 0;
            if (int.TryParse(input, out no))
            {
                Console.WriteLine(no*no);
            }

            Console.WriteLine($"Sum is {sum}, average is {avg} and product is {product}");
        }
        private static void Calculate(int first, int second, int third, out int sum, out int avg, out int product)
        {
            sum = first + second + third;
            avg = sum / 3;
            product = first * second * third;
        }
        //private static void CaseStudy5()
        //{
        //    DisplayMultiplication(10,20,30,40,50,60);
        //}
        //private static void DisplayMultiplication()
        //{

        //}
    }
}
