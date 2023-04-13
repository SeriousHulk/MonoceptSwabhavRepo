using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.LowLevel
{
    internal class TextErrorLogger
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
