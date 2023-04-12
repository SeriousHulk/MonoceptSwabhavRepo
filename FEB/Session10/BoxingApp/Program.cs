using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            Object[] boxedItems = new Object[4];
            boxedItems[0] = 10d;
            boxedItems[1] = 20d;
            boxedItems[2] = 30d;
            boxedItems[3] = 40d;
            double sum = 0;
            foreach (object item in boxedItems)
            {
                double unboxedItem = (double)item;
                sum += unboxedItem;
            }
            Console.WriteLine($"sum of all boxed items: {sum}");
        }

        private static void CaseStudy1()
        {
            Object box = null;
            box = new Object();
            Console.WriteLine(box.GetType());

            Console.WriteLine(box.GetHashCode());
            box = 100.555;
            Console.WriteLine(box);
            Console.WriteLine(box.GetType());
            Console.WriteLine(box.GetHashCode());
            box = (double)box + 10;
            Console.WriteLine(box);
            Console.WriteLine(box.GetType());
            Console.WriteLine(box.GetHashCode());
        }
    }
}
