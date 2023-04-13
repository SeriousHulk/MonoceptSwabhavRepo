using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternPOC.Strategy
{
    internal class DebitCard : IPaymentStrategy
    {
        public string Print()
        {
            return "paid using DebitCard";
        }
    }
}
