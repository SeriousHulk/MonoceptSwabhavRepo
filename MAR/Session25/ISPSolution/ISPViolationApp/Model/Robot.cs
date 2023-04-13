using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp.Model
{
    internal class Robot : IWorker
    {
        public void StartWork()
        {
            Console.WriteLine("Robot Started Working.");
        }
        public void StopWork()
        {
            Console.WriteLine("Robot Stopped Working.");
        }
        public void StartEat()
        {
            throw new NotImplementedException();
        }
        public void StopEat()
        {
            throw new NotImplementedException();
        }
    }
}
