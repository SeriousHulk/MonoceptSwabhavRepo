using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStatsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum=0, avg, max=0;
            Console.WriteLine("Total arguments entered: " + args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                    sum += int.Parse(args[i]);
                    if (int.Parse(args[i]) > max)
                    {
                        max = int.Parse(args[i]);
                    }
            }
            avg = sum / args.Length;
            Console.WriteLine("Sum of all arguments is "+ sum);
            Console.WriteLine("Average of the Arguments is " + avg);
            Console.WriteLine("The Maximum of all arguments is " + max);
        }
    }
}
