using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp.Model
{
    public class Manager : IWorker
    {
        public void StartWork()
        {
            Console.WriteLine("Manager Started Working.");
        }
        public void StopWork()
        {
            Console.WriteLine("Manager Stopped Working.");
        }
        public void StartEat()
        {
            Console.WriteLine("Manager Started Eating.");
        }
        public void StopEat()
        {
            Console.WriteLine("Manager Stopped Eating.");
        }
    }
}
