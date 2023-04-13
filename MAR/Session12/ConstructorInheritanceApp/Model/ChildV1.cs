using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceApp.Model
{
    internal class ChildV1 : ParentV1
    {
        public ChildV1() : base() 
        {
            Console.WriteLine("child Created");
        }
    }
}
