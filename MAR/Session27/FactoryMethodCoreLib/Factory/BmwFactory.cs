using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodCoreLib.Factory
{
    public class BmwFactory : IAutoMobileFactory
    {
        private static BmwFactory _instance;
        private BmwFactory() { }
        public IAutoMobile Make()
        {
            return new Bmw();
        }
        public static BmwFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BmwFactory();
                    return _instance;
                }
                else return _instance;
            }
        }
    }
}
