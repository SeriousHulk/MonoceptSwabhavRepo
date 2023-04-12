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
            /* Rectangle rectangleA = new Rectangle(); 
             SetDetails(rectangleA, 12, 112, "abdf");
             PrintDetails(rectangleA,"Details of Rectangle A");
             Rectangle rectangleB = new Rectangle();
             SetDetails(rectangleB, 72, 98, "bLuE");
             PrintDetails(rectangleB, "Details of Rectangle B");*/
            PrintDetails(new Rectangle(), "Details of anonymus Rectangle");
            Rectangle rect;
            rect = new Rectangle();
            rect.SetColor("red");
            rect.SetWidth(68);
            rect.SetHeight(65);
            PrintDetails(rect, "Null pointer example");
            rect = null;
            PrintDetails(rect, "Second null pointer example");
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
            Console.WriteLine($"\tWidth {rectangle.GetWidth()}" +
                $" and Height is {rectangle.GetHeight()}");
            Console.WriteLine($"\tcolor is {rectangle.GetColor()}");
            Console.WriteLine($"\tArea is {rectangle.CalculateArea()}");
        }
    }
}
