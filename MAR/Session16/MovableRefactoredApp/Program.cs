using MovableInterfaceApp.Model;
using MovableRefactoredApp.Model;
using System;

namespace MovableRefactoredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable[] movables ={
            new Bike("BMW"),
            new Car("Maruti"),
            new Truck("Mahindra")
            };
            StartRace(movables);
        }
        static void StartRace(IMovable[] vehicle)
        {
            Console.WriteLine("race started");
            foreach (IMovable movable in vehicle )
                movable.Move();
            Console.WriteLine("race ended\n");
        }
    }
}