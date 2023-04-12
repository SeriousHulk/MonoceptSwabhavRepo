using RectangleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle small = new Rectangle
            {
                height = 12,
                width = 23
            };
            Dry rectangle = new Dry(12, 13);
            int perimeter = rectangle.CalculatePerimeter();
            Console.WriteLine($"height:{small.height}, width:{small.width} Area is : {small.CalculateArea()}");
            Console.WriteLine($"height:{rectangle.length}, width:{rectangle.width} Perimeter is : {perimeter}");
        }
    }
}
