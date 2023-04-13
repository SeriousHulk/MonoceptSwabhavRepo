using SimpleFactoryWithSingleton.Factory;

namespace SimpleFactoryWithSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = AutoMobileFactory.Instance;
            var auto = factory.Make(AutoOptions.SUPRA);
            auto.Start();
            auto.Stop();
            var factory2 = AutoMobileFactory.Instance;
            var auto2 = factory2.Make(AutoOptions.BMW);
            auto2.Start();
            auto2.Stop();
            Console.WriteLine(factory == factory2);
        }
    }
}