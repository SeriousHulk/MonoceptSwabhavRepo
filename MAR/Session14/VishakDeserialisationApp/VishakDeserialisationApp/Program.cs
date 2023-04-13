using CustomerLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace VishakDeserialisationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("customer1.dump", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            Object obj = formatter.Deserialize(fs);
            Customer customer = obj as Customer;
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Id);
            fs.Close();
        }
    }
}
