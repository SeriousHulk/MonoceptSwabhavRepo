using StrategyPatternPOC.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternPOC.Strategy
{
    internal class UPI : IPaymentStrategy
    {
        public string Print()
        {
            return "paid using UPI";
        } 
    }
}
