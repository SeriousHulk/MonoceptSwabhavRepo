using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritance.Model
{
    internal class Infant:Man
    {
        public override void Play()
        {
            Console.WriteLine("Infant is playing");
        }
    }
}
