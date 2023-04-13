using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFactoryCoreLib.Factory
{
    public class AutoMobileFactory
    {
        public IAutoMobile Make(AutoOptions auto)
        {
            if (auto == AutoOptions.BMW)
                return new Bmw();
            else if (auto == AutoOptions.AUDI)
                return new Audi();
            else return new Supra();
        }
    }
}
