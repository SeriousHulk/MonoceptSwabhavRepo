using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPSolutionApp.HighLevel;

namespace DIPSolutionApp.LowLevel
{
    internal class TextErrorLogger : IErrorLogger
    {
        public void Log(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Writing the Text File");
            Console.WriteLine(ex.StackTrace);
            Console.ResetColor();
        }
    }
}
