using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritance.Model
{
    internal class Boy : Man
    {
        public void Eat()
        {
            Console.WriteLine("Boy Eats Pizza");
        }
        public override void Play()
        {
            Console.WriteLine("Boy plays Cricket");
        }
    }
}
