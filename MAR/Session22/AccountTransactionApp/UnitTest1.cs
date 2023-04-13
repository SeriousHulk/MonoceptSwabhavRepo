using AccountTransactionApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace AccountTransactionApp
{
    [TestClass]
    public class UnitTest1
    {
        public object IEnummerator { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            Account account = new Account(1001,5001,"Vikarant");
            account.Deposit(6700);
            account.Withdraw(7900);
            foreach(Transaction transaction in account.Transactions)
            {
                Debug.WriteLine(transaction.ToString());
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            Account account = new Account(1001, 5001, "Vikarant");
            account.Deposit(6700);
            account.Withdraw(7900);
            IEnumerator<Transaction> enumerator = account.Transactions.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}