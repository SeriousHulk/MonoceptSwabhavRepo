using DIPRefactoredWithDelegateApp.HighLevel;
using DIPRefactoredWithDelegateApp.LowLevel;

namespace DLoggerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DLogger xmlDLogger = new DLogger(XMLErrorLogger.Log);
            var xml = new TaxCalculator(xmlDLogger);
            Console.WriteLine(xml.CalculateTax(10, 3));
            Console.WriteLine(xml.CalculateTax(10, 0));
            DLogger textDLogger = new DLogger(TXTErrorLogger.Log);
            var txt = new TaxCalculator(textDLogger);
            Console.WriteLine(txt.CalculateTax(10, 5));
            Console.WriteLine(txt.CalculateTax(10, 0));
        }
    }
}