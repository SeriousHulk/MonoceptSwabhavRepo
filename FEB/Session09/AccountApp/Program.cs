using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaskeStudy1();
            CaseStudy2();
        }

        //private static void CaseStudy1()
        //{
        //    Account accountA = new Account(213, 4450, "Vikrant", 8472048392);
        //    PrintDetails(accountA, "This is Account A");
        //    Console.WriteLine("Amount after 3000 deposited into Account A :"+accountA.Deposit(3000));
        //}

        private static void CaseStudy2()
        {
            Account[] manyAccounts = new Account[5];
            manyAccounts[0] = new Account(111, 5000, "Ajay", 7823456901);
            manyAccounts[1] = new Account(112, 6000, "Akshay", 7828493726);
            manyAccounts[2] = new Account(113, 4000, "Shahrukh", 7823748301);
            manyAccounts[3] = new Account(114, 7000, "Salman", 9999332846);
            manyAccounts[4] = new Account(115, 8000, "Aamir", 8873629348);

            foreach (Account account in manyAccounts) { PrintDetails(account); }

            Account[] longNamedAccountHolders = FindAccountHoldersWithLongNames(manyAccounts);
            foreach (Account account in longNamedAccountHolders) { Console.WriteLine("account with 7 or more charecters in the name :"+account.Name); }
            
            PrintRichest(manyAccounts);
        }

        private static void PrintDetails(Account accountA, string description="")
        {
            Console.WriteLine(description);
            Console.WriteLine($"account no. :{accountA.AccountNo}");
            Console.WriteLine($"Balance :{accountA.Balance}");
            Console.WriteLine($"Name is :{accountA.Name}");
            Console.WriteLine($"Contact no :{accountA.ContactNo}\n");
        }
        public static void PrintRichest(Account[] accounts)
        {
            Account max = new Account();
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].Balance > max.Balance)
                {
                    max = accounts[i];
                }
            }
            Console.WriteLine($"{max.Name} is the richest among account holders");
        }
        public static Account[] FindAccountHoldersWithLongNames(Account[] accounts)
        {
            int count = 0;
            foreach (Account account in accounts)
            {
                if (account.Name.Length >= 7)
                {
                    count++;
                }
            }
            Account[] longNamedAccounts = new Account[count];
            int index = 0;
            foreach (Account account in accounts)
            {
                if (account.Name.Length >= 7)
                {
                    longNamedAccounts[index] = account;
                    index++;
                }
            }
            return longNamedAccounts;
        }
    }
}
