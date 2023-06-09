﻿using RectangleEncapsulation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(new Rectangle(width:10,height:20,color:"green"), "Anonymus Object");
            Rectangle rectangleA = new Rectangle(11, 22, "blue");
            PrintDetails(rectangleA,"Printing Rectangle A");
            rectangleA.SetColor("green");
            PrintDetails(rectangleA, "Printing Rectangle A after color change");
        }
        static void PrintDetails (Rectangle rectangle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"width :{rectangle.GetWidth()} \n" +
                $"height :{rectangle.GetHeight()}\n" +
                $"color :{rectangle.GetColor()}");
        }
    }
}
