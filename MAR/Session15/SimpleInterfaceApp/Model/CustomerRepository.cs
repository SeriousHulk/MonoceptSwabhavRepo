using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Model
{
    internal class CustomerRepository : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Customer Record created");
        }
        public void Read()
        {
            Console.WriteLine("Customer Record Selected");
        }
        public void Update()
        {
            Console.WriteLine("Customer Record Updated");
        }
        public void Delete()
        {
            Console.WriteLine("Customer Record Deleted");
        }
    }
}
