using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonServiceApp.Model
{
    internal class DataService
    {
        private static DataService _instance = null;
        private DataService()
        {
        }
        public static DataService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataService();
                }
                return _instance;
            }
        }
        public void DoSomething()
        {
            Console.WriteLine($"Executing method from DataService.Instance.DoSomething");
        }
    }
}
