using SynchronyzedThreadsApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronyzedThreadsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataService1 = DataService.Instance;
            Thread thread = new Thread(dataService1.ExecuteInThread);
            var dataService2 = DataService.Instance;
            Thread thread2 = new Thread(dataService2.ExecuteInThread);
            thread.Start();
            thread2.Start();
        }
    }
}
