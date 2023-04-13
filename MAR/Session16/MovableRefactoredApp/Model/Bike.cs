using MovableRefactoredApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterfaceApp.Model
{
    internal class Bike : Vehicle
    {
        public Bike(string name):base (name)
        {
        }
        public override void Move()
        {
            Console.WriteLine($"{this.Name} is moving");
        }
    }
}
