using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountApp.Model;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();
        }
        private static void CaseStudy1()
        {
            Account acccountA = new Account(21001, "Mahendra");
            PrintDetails(acccountA,"Details of Account A");
        }
        private static void CaseStudy2()
        {
            Account acccountB = new Account(21002, 3233, "Virat");
            PrintDetails(acccountB, "Details of Account B");
        }
        private static void CaseStudy3()
        {
            Account acccountB = new Account(21002, 3233, "Virat");
            acccountB.Withdraw(500);
            PrintDetails(acccountB, "Details of Account B after withdrawing 500");
        }
        private static void CaseStudy4()
        {
            Account acccountA = new Account(21001, "Mahendra");
            acccountA.Deposit(1000);
            PrintDetails(acccountA, "Details of Account A after depositing 1000");
        }
        static void PrintDetails(Account account, string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Name :" + account.Name);
            Console.WriteLine("balance :" + account.Balance);
            Console.WriteLine("account No.:" + account.AccountNo);
        }
    }
}
