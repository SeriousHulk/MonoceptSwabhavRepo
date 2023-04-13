using CustomerLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSerializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer2 = new Customer(1002,"Vikrant",12,9872654251);
            FileStream fs = new FileStream("customer2.dump", FileMode.Create, 
                FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fs,customer2);
            fs.Close();
        }
    }
}
