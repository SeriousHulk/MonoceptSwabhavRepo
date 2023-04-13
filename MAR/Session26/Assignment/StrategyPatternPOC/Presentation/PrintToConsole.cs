using StrategyPatternPOC.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternPOC.Presentation
{
    public class PrintToConsole
    {
        public void PaymentPrinter(IPaymentStrategy paymentStrategy)
        {
            Console.WriteLine(paymentStrategy.Print());
        }
    }
}
