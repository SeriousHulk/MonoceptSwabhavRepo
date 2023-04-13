using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynchronyzedThreadsApp.Model
{
    public class DataService
    {
        private static DataService _instance=null;
        private object lockObject = new object();
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
        public void ExecuteInThread()
        {
            lock (lockObject)
            {
                DoSomething();
            }
        }
        public void DoSomething()
        {
            Console.WriteLine("SomeMethod() called on DataService instance from synchronyzedThreadsApp.");
        }
    }
}
