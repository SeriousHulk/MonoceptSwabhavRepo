using DIPSolutionApp.HighLevel;
using DIPSolutionApp.LowLevel;

namespace DIPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XMLErrorLogger xmlErrorLogger = new XMLErrorLogger();
            DLogger xmlLogger = new DLogger(xmlErrorLogger.Log);
            var calculate = new TaxCalculator(xmlLogger);
            xmlLogger(calculate.CalculateTax(11, 0));
            //Console.WriteLine(calculate.CalculateTax(11, 3));
            Console.WriteLine(calculate.CalculateTax(11, 0));
        }
    }
}
