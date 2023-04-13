using DIPSolutionApp.HighLevel;
using DIPSolutionApp.LowLevel;

namespace DIPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XMLErrorLogger xmlErrorLogger = new XMLErrorLogger();
            var calculate = new TaxCalculator(xmlErrorLogger);
            Console.WriteLine(calculate.CalulateTax(11, 3));
            Console.WriteLine(calculate.CalulateTax(11, 0));
            var textOutput = new TaxCalculator(new TextErrorLogger());
            Console.WriteLine(textOutput.CalulateTax(20, 0));
        }
    }
}