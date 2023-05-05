using HatDecoratorApp.Hats;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HatDecoratorApp.Decorators
{
    public class GoldenHat : IHat
    {
        private readonly IHat _hat;

        public GoldenHat(IHat hat)
        {
            _hat = hat;
        }

        public string GetName()
        {
            return "Golden " + _hat.GetName();
        }

        public decimal GetPrice()
        {
            return _hat.GetPrice() + 1000.00M;
        }

        public string GetDescription()
        {
            return _hat.GetDescription() + " \n     It also has a layer of gold plating.";
        }
    }
}
