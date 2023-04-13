using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPRefactoredWithDelegateApp.LowLevel
{
    internal class TXTErrorLogger
    {
        public static void Log(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Writing into Text File...");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
            Console.ResetColor();
        }
    }
}
