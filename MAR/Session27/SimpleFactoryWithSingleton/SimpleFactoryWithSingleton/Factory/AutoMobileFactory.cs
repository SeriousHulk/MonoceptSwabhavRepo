using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryWithSingleton.Factory
{
    public class AutoMobileFactory
    {
        private static AutoMobileFactory _instance;
        private AutoMobileFactory() { }
        public IAutoMobile Make(AutoOptions auto)
        {
            if (auto == AutoOptions.BMW)
                return new Bmw();
            else if (auto == AutoOptions.AUDI)
                return new Audi();
            else return new Supra();
        }
        public static AutoMobileFactory Instance { get { if (_instance == null)
                {
                    _instance = new AutoMobileFactory();
                    return _instance;
                }
                else return _instance; } }
    }
}
