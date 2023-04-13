using FactoryMethodCoreLib.Factory;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAutoMobileFactory factory1 = BmwFactory.Instance;
            IAutoMobile auto = factory1.Make();
            auto.Start();
            auto.Stop();
        }
    }
}