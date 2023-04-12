using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            string number4;
            string message = "3B] This message will print number1 :{0}, number2 :{1} even it is stored in message variable ";
            Console.WriteLine("Enter the first number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number to demonstrate TryParse example: ");

            //1)
            ExampleForInOut(in number1, in number2, out int sum, out int product);
            
            //number4 is accepting a string value
            number4 = Console.ReadLine();
            //2) following fuction accepting number4 string and converting it as short, int and long.
            ExampleForIntTryParse(in number4, out short shortNumber, out int intNumber, out long longNumber);

            Console.WriteLine($"1] The sum of entered two numbers is {sum}, and product is {product}");
            Console.WriteLine($"2] Numbers we are getting from Int Try Parse method is \n 1. {shortNumber} and its type is {shortNumber.GetType()} \n 2. " +
                $"{intNumber} and its type is {intNumber.GetType()} \n 3. {longNumber} and its type is {longNumber.GetType()} ");
            
            //3) A)
            ExampleForParams(1,2,3,4,5,6,7);
            //3) B)
            ExampleForWriteLineParams(message, number1, number2);

        }
        static void ExampleForInOut(in int number1, in int number2, out int sum, out int product)
        {
            sum = number1 + number2;
            product = number1 * number2;
        }
        static void ExampleForIntTryParse(in string inputString, out short shortNumber, out int intNumber, out long longNumber)
        {
            Int16.TryParse(inputString, out shortNumber);
            Int32.TryParse(inputString, out intNumber);
            Int64.TryParse(inputString, out longNumber);
        }
        static void ExampleForParams(params int[] numbers)
        {
            Console.WriteLine("3A] Numbers are : ");
            foreach(int i in numbers) Console.WriteLine(i);

        }
        static void ExampleForWriteLineParams(string message, int number1, int number2)
        {
            Console.WriteLine(message,number1, number2);
        }
    }
}
