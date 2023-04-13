using StrategyPatternPOC.Presentation;
using StrategyPatternPOC.Strategy;

namespace StrategyPatternPOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintToConsole p = new PrintToConsole();

            UPI upi = new UPI();
            CreditCard cc = new CreditCard();
            DebitCard dc = new DebitCard();


            p.PaymentPrinter(dc);
            p.PaymentPrinter(upi);
            p.PaymentPrinter(cc);
        }
    }
}