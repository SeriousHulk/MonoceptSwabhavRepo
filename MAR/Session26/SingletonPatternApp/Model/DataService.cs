using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternAppV1.Model
{
    internal class DataService
    {
        public DataService()
        {
            Console.WriteLine("Data Service Created!");
        }
        public void DoProcessing()
        {
            Console.WriteLine($"Processing Data by {this.GetHashCode()}");
        }
        public static DataService GetInstance()
        {
            return new DataService();
        }
    }
}
