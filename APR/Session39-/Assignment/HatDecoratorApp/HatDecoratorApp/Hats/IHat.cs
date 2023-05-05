using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorApp.Hats
{
    public interface IHat
    {
        public string GetName();
        public decimal GetPrice();
        public string GetDescription();
    }
}
