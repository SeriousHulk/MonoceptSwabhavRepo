using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp.Model
{
    internal class FixedDeposit
    {
        private int _accountNo;
        private string _name;
        private double _principleAmount;
        private int _duration;
        private FestivalOptions _festival;
        public FixedDeposit(int accountNo, string name, double principleAmount, int duration, FestivalOptions festival)
        {
            _accountNo = accountNo;
            _name = name;
            _principleAmount = principleAmount;
            _duration = duration;
            _festival = festival;
        }
        public double CalulateRate()
        {
            if (_festival == FestivalOptions.Diwali)
                return 0.09;
            else if (_festival == FestivalOptions.NewYear)
                return 0.08;
            else if (_festival == FestivalOptions.Normal)
                return 0.07;
            else throw new Exception(" ");
        }
        public void CalculateSimpleInteresrt()
        {
            double var = _principleAmount * _duration * CalulateRate();
            Console.WriteLine($"Simple interest would be :{var}"); 
        }
    }
}
