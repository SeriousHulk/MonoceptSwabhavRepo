using CalculatorExceptionApp.Model;

namespace CalculatorExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculate = new Calculator();
            int num1 = 10;
            int num2 = 20;
            try { Console.WriteLine($"The sum is {calculate.Add(num1, num2)}"); ; }
            catch(Exception ex) { Console.WriteLine(ex.Message); }

        }
    }
}