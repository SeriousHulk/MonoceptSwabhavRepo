using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternPOC.Strategy
{
    public interface IPaymentStrategy
    {
        string Print();
    }
}
