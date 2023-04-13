using System;

namespace FactoryMethodCoreLib.Factory
{
    internal class Bmw : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("BMW started");
        }

        public void Stop()
        {
            Console.WriteLine("BMW stopped");
        }
    }
}