using RectangleEnumApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }
        public static void CaseStudy1()
        {
            Rectangle rectangleA = new Rectangle(50,60,ColorOption.RED);
            PrintDetails(rectangleA, "Printing rectangle A");
        }
        private static void CaseStudy2()
        {
            Rectangle rectangleB = new Rectangle(101, 91, ColorOption.RED, BorderOption.DOTTED);
            PrintDetails(rectangleB, "Printing rectangle B");
        }
        public static void PrintDetails(Rectangle rectangle, string message) 
        {
            Console.WriteLine("\n"+message);
            Console.WriteLine($"Width :{rectangle.Width}");
            Console.WriteLine($"Height :{rectangle.Height}");
            Console.WriteLine($"Color :{rectangle.Color}");
        }
    }
}
