using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountCounterApp.Model;

namespace AccountCounterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy1()
        {
            Account account1 = new Account(101, "Aniket");
            Console.WriteLine("Account 1: " + account1.Instance_Count);
            Account account2 = new Account(102, "Baban");
            Console.WriteLine("Account 2: " + account2.Instance_Count);
            Account account3 = new Account(103, "Chintamani");
            Console.WriteLine("Account 3: " + account3.Instance_Count);
        }
        private static void CaseStudy2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Account account1 = new Account(101, "Aniket");
            Console.WriteLine("Account 1: " + Account.HeadCount());
            Account account2 = new Account(102, "Baban");
            Console.WriteLine("Account 2: " + Account.HeadCount());
            Account account3 = new Account(103, "Chintamani");
            Console.WriteLine("Account 3: " + Account.HeadCount());
            Console.ResetColor();
        } 
    }
}
