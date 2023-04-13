using FixedDepositLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp.Model
{
    public class FixedDeposit
    {
        private int _accountNo;
        private string _name;
        private double _principleAmount;
        private int _duration;
        private IRatePolicy _ratePolicy;
        public FixedDeposit(int accountNo, string name, double principleAmount, int duration, IRatePolicy ratePolicy)
        {
            _accountNo = accountNo;
            _name = name;
            _principleAmount = principleAmount;
            _duration = duration;
            _ratePolicy = ratePolicy;
        }
        public void CalculateSimpleInteresrt(Object obj)
        {
            double var = _principleAmount * _duration * _ratePolicy.CalculateRate();
            Console.WriteLine($"Simple interest of {this._name} would be :{var}"); 
        }
    }
}
