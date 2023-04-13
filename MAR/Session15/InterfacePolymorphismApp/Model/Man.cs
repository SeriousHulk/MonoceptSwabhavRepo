using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismApp.Model
{
    internal class Man : IMannerable
    {
        public void Wish()
        {
            Console.WriteLine("person says Hi");
        }
        public void Depart()
        {
            Console.WriteLine("person says goodbye");
        }
    }
}
