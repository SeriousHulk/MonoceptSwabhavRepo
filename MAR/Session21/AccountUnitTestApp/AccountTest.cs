using AccountApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AccountUnitTestApp
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void ShouldCreateAccountHolderWithMinimumBalance_500()
        {
            double expectedBalance = 500;
            Account account = new Account(1001, "Vikrant");
            double actualBalance = account.Balance;
            Assert.AreEqual(expectedBalance, actualBalance);
        }
        [TestMethod]
        public void ShouldCreateAccountHolderWithInitialBalance_1000()
        {
            double expectedBalance = 1000;
            Account account = new Account(1001,1000, "Vikrant");
            double actualBalance = account.Balance;
            Assert.AreEqual(expectedBalance, actualBalance);
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldNotCreateAccountHolderBalanceBelow_1000()
        {
            Account account = new Account(1001, 500, "Vikrant");
        }
        [TestMethod]
        public void CheckWhetherInputAccountNo_NameAreCorrect()
        {
            string expectedName = "Ravi";
            int expectedAccountNo = 1001;
            Account account = new Account(1001, "Ravi");
            Assert.AreEqual(account.Name,expectedName);
            Assert.AreEqual(expectedAccountNo,account.AccountNo);
        }
        [TestMethod]
        public void ShouldShowCorrectDepositedAmount()
        {
            double expectedBalance = 1500;
            Account account = new Account(1001, "Ravi");
            account.Deposit(1000);
            Assert.AreEqual(account.Balance,expectedBalance);
        }
        [TestMethod]
        public void ShouldBeAbleToWithdrawAmountIfBalanceNotBelow_500_AfterWithdraw()
        {
            double expectedBalance = 500;
            Account account = new Account(1001, 1000, "Ravi");
            account.Withdraw(500);
            Assert.AreEqual(account.Balance, expectedBalance);
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldNotBeAbleToWithdrawAmountIfBalanceBelow_500_AfterWithdraw()
        {
            Account account = new Account(1001,800, "Ravi");
            account.Withdraw(500);
        }
    }
}
