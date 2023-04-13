using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    internal class Robot : IWork
    {
        public void StartWork()
        {
            Console.WriteLine("Robot Started Working.");
        }
        public void StopWork()
        {
            Console.WriteLine("Robot Stopped Working.");
        }
    }
}
