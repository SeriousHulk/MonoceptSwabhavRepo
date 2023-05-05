using CarServiceApp.CarService;
using CarServiceApp.Decorators;

namespace CarServiceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService car1 = new OilChange(new TyreRotation(new OilChange(new CarInspection())));
            PrintDetails(car1);
        }
        private static void PrintDetails(ICarService car)
        {
            Console.WriteLine($"Total cost of car Inspection is {car.GetCost()}");
        }
    }
}