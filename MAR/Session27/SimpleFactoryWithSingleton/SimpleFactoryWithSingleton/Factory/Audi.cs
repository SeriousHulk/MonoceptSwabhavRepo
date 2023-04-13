using System;

namespace SimpleFactoryWithSingleton.Factory
{
    internal class Audi : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Audi started");
        }

        public void Stop()
        {
            Console.WriteLine("Audi stopped");
        }
    }
}