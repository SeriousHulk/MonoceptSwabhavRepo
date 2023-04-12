using CircleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(radius: 0, color: "burgendy",
                borderStyle: "blue");
            circle1.Radius = 19;
            PrintCircleDetails(circle1,"This is Circle 1");
        }
        static void PrintCircleDetails(Circle circle, string message)
        {
            Console.WriteLine(message.ToUpper());
            Console.WriteLine($"Its radius is {circle.Radius}\n" +
                $"color is :{circle.Color}\n" +
                $"and Border style as :{circle.BorderStyle}");
        }
    }
}
