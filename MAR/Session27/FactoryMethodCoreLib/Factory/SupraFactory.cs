using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCoreLib.Factory
{
    public class SupraFactory : IAutoMobileFactory
    {
        private static SupraFactory _instance;
        private SupraFactory() { }
        public IAutoMobile Make()
        {
            return new Supra();
        }
        public static SupraFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SupraFactory();
                    return _instance;
                }
                else return _instance;
            }
        }
    }
}
