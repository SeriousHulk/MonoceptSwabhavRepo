using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArgsApp
{
    internal class Program
    {
        static void Main(string[] argsOfNames)
        {
            Console.WriteLine("Entered Main...");
            Console.WriteLine("Total arguments entered: "+argsOfNames.Length);
            foreach (string name in argsOfNames)
            {
                Console.WriteLine("Hello I am  "+name);
            }
            Console.WriteLine("Main Ended Here!");
        }
    }
}
