using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPSolutionApp.HighLevel;

namespace DIPSolutionApp.LowLevel
{
    internal class XMLErrorLogger:IErrorLogger
    {
        public void Log(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Writing the XML File");
            Console.WriteLine(ex.StackTrace);
            Console.ResetColor();
        }
    }
}
