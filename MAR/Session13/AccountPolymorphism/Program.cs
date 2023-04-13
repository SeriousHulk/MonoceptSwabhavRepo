using AccountPolymorphism.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            CaseStudy4();
        }
        private static void CaseStudy1()
        {
            SavingsAccount vikrant = new SavingsAccount(987231289, 8762, "Vikrant");
            PrintDetails(vikrant);
        }
        private static void CaseStudy2()
        {
            CurrentAccount dinesh = new CurrentAccount(987256789, 711, "Dinesh");
            PrintDetails(dinesh);
        }
        private static void CaseStudy3()
        {
            SavingsAccount vikrant = new SavingsAccount(987231289, 8762, "Vikrant");
            vikrant.Withdraw(7000);
            PrintDetails(vikrant, "Vikrant WithDrawn 7000");
        }
        private static void CaseStudy4()
        {
            CurrentAccount dinesh = new CurrentAccount(987256789, 711, "Dinesh");
            dinesh.Withdraw(5000);
            PrintDetails(dinesh, "Dinesh Withdrawn 5000");
        }
        static void PrintDetails(Account account, string description = "Account Details")
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"Account Name is {account.Name}");
            Console.WriteLine($"Account Number is {account.AccountNo}");
            Console.WriteLine($"Account Balance is {account.Balance}");
            Console.WriteLine();
        }
    }
}