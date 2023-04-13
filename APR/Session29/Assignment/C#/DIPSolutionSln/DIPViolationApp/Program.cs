using DIPViolationApp.HighLevel;

namespace DIPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculate = new TaxCalculator(ErrorLogOptions.XML);
            Console.WriteLine(calculate.CalulateTax(11,3));
            Console.WriteLine(calculate.CalulateTax(11, 0));
        }
    }
}