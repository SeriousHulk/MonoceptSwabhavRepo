using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorApp.Hats
{
    public class PremiumHat : IHat
    {
        public string GetName()
        {
            return "Premium Hat";
        }

        public decimal GetPrice()
        {
            return 700.00M;
        }

        public string GetDescription()
        {
            return "A high-quality hat made from the finest materials.";
        }
    }
}
