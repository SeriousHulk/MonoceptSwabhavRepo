using MovableInterfaceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable[] movable = new IMovable[5];
            movable[0] = new Car("Audi");
            movable[1] = new Bike("Pulsar");
            movable[2] = new Car("BMW");
            movable[3] = new Truck("Mahindra Layland");
            movable[4] = new Bike("Honda");
            StartRace(movable);
        }
        public static void StartRace(IMovable[] movables)
        {
            Console.WriteLine("Race Started");
            foreach (IMovable movable in movables)
                movable.Move();
            Console.WriteLine("Race Ended");
        }
    }
}
