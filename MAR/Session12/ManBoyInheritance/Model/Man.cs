using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritance.Model
{
    internal class Man
    {
        public virtual void Play()
        {
            Console.WriteLine("Man plays Chess");
        }
        public void Read()
        {
            Console.WriteLine("Man Read Books");
        }
    }
}
