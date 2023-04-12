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
            Circle circle1 = new Circle();
            SetCircleDetails(circle1, 9 , "BluE", "dooted");
            PrintCircleDetails(circle1);
        }
        static void SetCircleDetails(Circle circle, int radius, string color, string borderStyle)
        {
            circle.SetParams(color, borderStyle);
            circle.SetRadius(radius);
        }
        static void PrintCircleDetails(Circle circle)
        {
            Console.WriteLine($"The Circle has radius {circle.GetRadius()}\n" +
                $" color, and Border style as :{circle.GetParams()}");
        }
    }
}
