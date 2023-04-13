using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterfaceApp.Model
{
    internal class Car : IMovable
    {
        string name;

        public Car(string name)
        {
            this.name = name;
        }
        public string Name { get { return name; } set { name = value; } }


        public void Move()
        {
            Console.WriteLine($"{this.Name} is moving");
        }
    }
}
