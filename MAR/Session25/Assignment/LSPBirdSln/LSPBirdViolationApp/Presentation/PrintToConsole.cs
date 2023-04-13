using LSPBirdsSolutionApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPBirdsSolutionApp.Presentation
{
    internal class PrintToConsole
    {
        public void PrintAction(Bird bird) 
        {
            Console.WriteLine($"{bird.GetName()} is Flying");
        }
    }
}
