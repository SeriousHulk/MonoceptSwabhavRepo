using System;
using SimpleRectangleApp.Model;

namespace SimpleRectangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleA = new Rectangle();
            PrintDetails(rectangleA, "empty rectangle A");
            rectangleA.width = 10;
            rectangleA.height = 20;
            rectangleA.color = "black";
            PrintDetails(rectangleA,"after assigning values to rectangle A");
            //Console.WriteLine($"width :{rectangleA.width}, height :{rectangleA.height} and " +
            //    $"color :{rectangleA.color} area is {rectangleA.CalculateArea()}");
            Rectangle rectangleB = new Rectangle();
            rectangleB = rectangleA;
            PrintDetails(rectangleB, "after copying from RecA, the values in Rectangle B");
            //Console.WriteLine($"width :{rectangleB.width}, height :{rectangleB.height} and " +
            //    $"color :{rectangleB.color} area is {rectangleB.CalculateArea()}");
            rectangleB.color = "red";
            PrintHashDetails(rectangleA);
            PrintHashDetails(rectangleB);
            /*Console.WriteLine($"RectangleB width :{rectangleB.width}, height :{rectangleB.height} and " +
                $"color :{rectangleB.color} area is {rectangleB.CalculateArea()} hashcode={rectangleB.GetHashCode()}");
            Console.WriteLine($"RectangleA width :{rectangleB.width}, height :{rectangleB.height} and " +
                $"color :{rectangleB.color} area is {rectangleB.CalculateArea()} hashcode={rectangleA.GetHashCode()}"); */
        }
        static void PrintDetails(Rectangle rectangle, string message)
        {
            Console.WriteLine(message.ToUpper());
            Console.WriteLine($"The Width :{rectangle.width}, " +
                $"Height :{rectangle.height} " +
                $"color :{rectangle.color} and Area :{rectangle.CalculateArea()}\n");
        }
        static void PrintHashDetails(Rectangle rectangle)
        {
            Console.WriteLine($"The Width :{rectangle.width}, " +
                $"Height :{rectangle.height} " +
                $"color :{rectangle.color} and Area :{rectangle.CalculateArea()}" +
                $" hashcode :{rectangle.GetHashCode()}\n");
        }
    }
}
