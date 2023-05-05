using HatDecoratorApp.Hats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HatDecoratorApp.Decorators
{
    public class RibbionedHat : IHat
    {
        private readonly IHat _hat;

        public RibbionedHat(IHat hat)
        {
            _hat = hat;
        }

        public string GetName()
        {
            return "Ribbioned " + _hat.GetName();
        }

        public decimal GetPrice()
        {
            return _hat.GetPrice() + 200.00M;
        }

        public string GetDescription()
        {
            return _hat.GetDescription() + " \n     It also has a ribbon wrapped around it.";
        }
    }
}
