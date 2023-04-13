using DelegateSortingAlgorithms.Model;
using System.Text;

namespace DelegateSortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation add = Calculator.Add;
            Calculation subtract = Calculator.Subtract;
            Calculation multiply = Calculator.Multiply;
            Calculation divide = Calculator.Divide;

            Console.WriteLine(add(9, 10));       
            Console.WriteLine(subtract(110, 91));  
            Console.WriteLine(multiply(2, 90));  
            Console.WriteLine(divide(68, 17));    
        }
    }
}