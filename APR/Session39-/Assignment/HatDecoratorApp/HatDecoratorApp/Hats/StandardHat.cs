using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorApp.Hats
{
    public class StandardHat : IHat
    {
        public string GetName()
        {
            return "Standard Hat";
        }

        public decimal GetPrice()
        {
            return 50.00M;
        }

        public string GetDescription()
        {
            return "A basic hat for everyday use.";
        }
    }
}
