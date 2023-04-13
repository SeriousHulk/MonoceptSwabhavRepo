using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismApp.Model
{
    internal class Boy : IMannerable, IEmotionable
    {
        public void Cry()
        {
            Console.WriteLine("boy crys");
        }

        public void Depart()
        {
            Console.WriteLine("boy says goodbye");
        }

        public void Laugh()
        {
            Console.WriteLine("boy laughs");
        }

        public void Wish()
        {
            Console.WriteLine("boy says Hi");
        }
    }
}
