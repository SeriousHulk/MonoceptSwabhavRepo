using System;
using System.Threading;
using SingletonServiceApp.Model;

namespace SingletonServiceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService1 = DataService.Instance;
            Thread thread1 = new Thread(dataService1.DoSomething);
            thread1.Start();
            thread1.Start();
            thread1.Start();
        }
    }
}
