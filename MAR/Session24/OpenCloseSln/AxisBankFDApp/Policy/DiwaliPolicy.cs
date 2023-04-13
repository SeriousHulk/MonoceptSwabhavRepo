using FixedDepositLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxisBankFDApp.Policy
{
    internal class DiwaliPolicy:IRatePolicy
    {
        public double CalculateRate(){
            return 0.08;
        }
    }
}
