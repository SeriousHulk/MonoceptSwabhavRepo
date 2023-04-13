using AutoFactoryCoreLib.Factory;

namespace ApplicationLayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoMobileFactory mobileFactory = new AutoMobileFactory();
            IAutoMobile supra = mobileFactory.Make(AutoOptions.SUPRA);
            supra.Start();
            supra.Stop();
            Console.WriteLine(supra.GetType());
        }
    }
}