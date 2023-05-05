using HatDecoratorApp.Decorators;
using HatDecoratorApp.Hats;

namespace HatDecoratorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }
        private static void CaseStudy1()
        {
            IHat hat1 = new RibbionedHat(new GoldenHat(new PremiumHat()));
            PrintDetails(hat1);
        }
        private static void CaseStudy2()
        {
            IHat hat2 = new GoldenHat(new RibbionedHat(new GoldenHat(new StandardHat())));
            PrintDetails(hat2);
        }
        private static void PrintDetails(IHat hat)
        {
            Console.WriteLine("Hat Name: " + hat.GetName());
            Console.WriteLine("Hat Price: " + hat.GetPrice());
            Console.WriteLine("Hat Description: " + hat.GetDescription());
            Console.WriteLine();
        }
    }
}