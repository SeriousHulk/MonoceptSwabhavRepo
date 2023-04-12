using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangleEncapsulation.Model;


namespace RectangleEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleA = new Rectangle(); 
            SetDetails(rectangleA, 12, 112, "abdf");
            PrintDetails(rectangleA,"Details of Rectangle A");
            Rectangle rectangleB = new Rectangle();
            SetDetails(rectangleB, 72, 98, "bLuE");
            PrintDetails(rectangleB, "Details of Rectangle B");
        }
        static void SetDetails(Rectangle rectangle, int width, int height, string color)
        {
            rectangle.SetWidth(width);
            rectangle.SetHeight(height);
            rectangle.SetColor(color);
        }
        static void PrintDetails(Rectangle rectangle, string message)
        {
            Console.WriteLine(message.ToUpper());
            Console.WriteLine($"\tWidth and Height is {rectangle.GetSize()}");
            Console.WriteLine($"\tcolor is {rectangle.GetColor()}");
            Console.WriteLine($"\tArea is {rectangle.CalculateArea()}");
        }
    }
}
