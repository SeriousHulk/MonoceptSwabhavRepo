using CustomerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customerA = new Customer("Vikrant");
            Console.WriteLine(customerA.OrderCount);
            Console.WriteLine(customerA.Id);

            Customer customerB = new Customer("Dinesh");
            Console.WriteLine(customerB.OrderCount);
            Console.WriteLine(customerB.Id);

            Console.WriteLine(customerA.Id);
        }
    }
}
