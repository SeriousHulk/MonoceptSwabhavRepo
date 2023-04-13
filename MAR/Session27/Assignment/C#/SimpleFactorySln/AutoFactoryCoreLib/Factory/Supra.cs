using System;

namespace AutoFactoryCoreLib.Factory
{
    internal class Supra : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Supra started");
        }

        public void Stop()
        {
            Console.WriteLine("Supra stopped");
        }
    }
}