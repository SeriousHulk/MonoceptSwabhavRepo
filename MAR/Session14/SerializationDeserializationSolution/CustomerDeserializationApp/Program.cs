using CustomerLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDeserializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("customer2.dump", 
                FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            Object obj = formatter.Deserialize(fs);
            Customer customer = obj as Customer;
            Console.WriteLine("Customer Name :" + customer.Name);
            Console.WriteLine("Customer ID :" + customer.Id);
            Console.WriteLine("Total Orders Placed :" + 
                customer.OrdersPlaced);
            fs.Close();
        }
    }
}
