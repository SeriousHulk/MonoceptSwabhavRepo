using AccountPolymorphismUnitTestApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AccountPolymorphismUnitTestApp
{
    [TestClass]
    public class AccountPolymorphismUnitTest
    {
        //********Constructor Test*******
        //1.Test if the Account constructor sets the correct values for the account number, balance, and account holder name.
        [TestMethod]
        public void ShouldAccountConstructorSetCorrectValues()
        {
            Account account = new CurrentAccount(1001, 5665, "Rothschild");
            int expectedAccountNumber = 1001;
            double expectedBalance = 5665;
            string expectedName = "Rothschild";
            Assert.AreEqual(expectedName, account.Name);
            Assert.AreEqual(expectedBalance, account.Balance);
            Assert.AreEqual(expectedAccountNumber, account.AccountNo);
        }
        //2.Test if the Current Account constructor sets the correct values for the account number, balance, and account holder name.
        [TestMethod]
        public void ShouldCurrentAccountConstructorSetCorrectValues()
        {
            CurrentAccount currentAccount = new CurrentAccount(1001, 5665, "Rothschild");
            int expectedAccountNumber = 1001;
            double expectedBalance = 5665;
            string expectedName = "Rothschild";
            Assert.AreEqual(expectedName, currentAccount.Name);
            Assert.AreEqual(expectedBalance, currentAccount.Balance);
            Assert.AreEqual(expectedAccountNumber, currentAccount.AccountNo);
        }
        //3.Test if the Savings Account constructor sets the correct values for the account number, balance, and account holder name.
        [TestMethod]
        public void ShouldSavingsAccountConstructorSetCorrectValues()
        {
            SavingsAccount savingsAccount = new SavingsAccount(1001, 5665, "Rothschild");
            int expectedAccountNumber = 1001;
            double expectedBalance = 5665;
            string expectedName = "Rothschild";
            Assert.AreEqual(expectedName, savingsAccount.Name);
            Assert.AreEqual(expectedBalance, savingsAccount.Balance);
            Assert.AreEqual(expectedAccountNumber, savingsAccount.AccountNo);
        }

        //*********Deposite Test********
        //4.Test if the Deposit method increases the account balance by the deposited amount of current account.
        [TestMethod]
        public void ShouldCurrentAccountDepositeProduceCorrectValues()
        {
            CurrentAccount currentAccount = new CurrentAccount(1001, 5665, "Rothschild");
            currentAccount.Deposit(335);
            double expectedBalance = 6000;
            Assert.AreEqual(expectedBalance, currentAccount.Balance);
        }
        //5.Test if the Deposit method increases the account balance by the deposited amount of savings account.
        [TestMethod]
        public void ShouldSavingsAccountDepositeProduceCorrectValues()
        {
            SavingsAccount savingsAccount = new SavingsAccount(1001, 5665, "Rothschild");
            savingsAccount.Deposit(335);
            double expectedBalance = 6000;
            Assert.AreEqual(expectedBalance, savingsAccount.Balance);
        }

        //*********Deposite Exception********
        //6. Test if the Deposit method of current account throws an exception when the deposit amount is negative.
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldCurrentAccountThrowsExceptionIfDepositAmountNegative()
        {
            CurrentAccount currentAccount = new CurrentAccount(1001, 5665, "Rothschild");
            currentAccount.Deposit(-335);
        }
        //7. Test if the Deposit method of savings account throws an exception when the deposit amount is negative.
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldSavingsAccountThrowsExceptionIfDepositAmountNegative()
        {
            SavingsAccount savingsAccount = new SavingsAccount(1001, 5665, "Rothschild");
            savingsAccount.Deposit(-335);
        }
        //8. Test if the Deposit method of current account throws an exception when the deposit amount is zero.
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldCurrentAccountThrowsExceptionIfDepositAmountZero()
        {
            CurrentAccount currentAccount = new CurrentAccount(1001, 5665, "Rothschild");
            currentAccount.Deposit(0);
        }
        //9. Test if the Deposit method throws of savings account an exception when the deposit amount is zero.
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldSavingsAccountThrowsExceptionIfDepositAmountZero()
        {
            SavingsAccount savingsAccount = new SavingsAccount(1001, 5665, "Rothschild");
            savingsAccount.Deposit(0);
        }

        //********Testing Properties*******
        //10. Test if the Balance property returns the correct balance.
        [TestMethod]
        public void ShouldReturnBalanceWhenBalancePropertyIsCalled()
        {
            CurrentAccount currentAccount = new CurrentAccount(1001, 5875, "Rothschild");
            SavingsAccount savingsAccount = new SavingsAccount(1001, 5665, "Rothschild");
            double expectedCurrentBalance = currentAccount.Balance;
            double expectedSavingsBalance = savingsAccount.Balance;
            Assert.AreEqual(expectedSavingsBalance, 5665);
            Assert.AreEqual(expectedCurrentBalance, 5875);
        }
        //11. Test if the AccountNo property returns the correct account number.
        [TestMethod]
        public void ShouldReturnAccountNumberWhenAccountPropertyIsCalled()
        {
            CurrentAccount currentAccount = new CurrentAccount(1881, 5875, "Rothschild");
            SavingsAccount savingsAccount = new SavingsAccount(1234, 5665, "Rothschild");
            int expectedSavingsAccountNumber = savingsAccount.AccountNo;
            int expectedCurrentAccountNumber = currentAccount.AccountNo;
            Assert.AreEqual(expectedSavingsAccountNumber, 1234);
            Assert.AreEqual(expectedCurrentAccountNumber, 1881);
        }
        //12. Test if the Name property returns the correct account holder name.
        [TestMethod]
        public void ShouldReturnNameNumberWhenNamePropertyIsCalled()
        {
            CurrentAccount currentAccount = new CurrentAccount(1881, 5875, "Rockefeller");
            SavingsAccount savingsAccount = new SavingsAccount(1234, 5665, "Rothschild");
            string expectedSavingsAccountName = savingsAccount.Name;
            string expectedCurrentAccountName = currentAccount.Name;
            Assert.AreEqual(expectedCurrentAccountName, "Rockefeller");
            Assert.AreEqual(expectedSavingsAccountName, "Rothschild");
        }

        //********Test Withdraw **********
        //13. Test if the Withdraw method of Current Account decreases the account balance by the withdrawn amount.
        [TestMethod]
        public void ShouldCurrentAccountWithdrawProduceCorrectValues()
        {
            CurrentAccount currentAccount = new CurrentAccount(1001, 6000, "Rothschild");
            currentAccount.Withdraw(4);
            double expectedBalance = 5996;
            Assert.AreEqual(expectedBalance, currentAccount.Balance);
        }
        //14.Test if the Withdraw method of Savings Account decreases the account balance by the withdrawn amount.
        [TestMethod]
        public void ShouldSavingsAccountWithdrawProduceCorrectValues()
        {
            SavingsAccount savingsAccount = new SavingsAccount(1001, 5665, "Rothschild");
            savingsAccount.Withdraw(5);
            double expectedBalance = 5660;
            Assert.AreEqual(expectedBalance, savingsAccount.Balance);
        }

        //*******Withdraw Exception Test*******
        //15. Test if the Withdraw method of current account throws an exception when the deposit amount is negative.
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldCurrentAccountThrowExceptionIfWithdrawAmountNegative()
        {
            CurrentAccount currentAccount = new CurrentAccount(1001, 5665, "Rothschild");
            currentAccount.Withdraw(-335);
        }
        //16. Test if the Withdraw method of savings account throws an exception when the deposit amount is negative.
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldSavingsAccountThrowExceptionIfWithdrawAmountNegative()
        {
            SavingsAccount savingsAccount = new SavingsAccount(1001, 5665, "Rothschild");
            savingsAccount.Withdraw(-335);
        }
        //17. Test if the Withdraw method of current account throws an exception when the deposit amount is zero.
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldCurrentAccountThrowExceptionIfWithdrawAmountZero()
        {
            CurrentAccount currentAccount = new CurrentAccount(1001, 5665, "Rothschild");
            currentAccount.Withdraw(0);
        }
        //18. Test if the Withdraw method throws of savings account an exception when the deposit amount is zero.
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldSavingsAccountThrowExceptionIfWithdrawAmountZero()
        {
            SavingsAccount savingsAccount = new SavingsAccount(1001, 5665, "Rothschild");
            savingsAccount.Withdraw(0);
        }
        //19. Test if the Withdraw method throws an exception when trying to withdraw money beyond the overdraft limit.
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldCurrentAccountThrowExceptionIfWithdrawAmountBeyoundODL()
        {
            CurrentAccount currentAccount = new CurrentAccount(1001, 5000, "Rothschild");
            currentAccount.Withdraw(10100);
        }
        //20. Test if the Withdraw method throws an exception when trying to withdraw money beyond the minimum balance.
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ShouldSavingsAccountThrowExceptionIfWithdrawAmountBeyondMinimumBalance()
        {
            SavingsAccount savingsAccount = new SavingsAccount(1001, 5000, "Rothschild");
            savingsAccount.Withdraw(4100);
        }

        //*******Withdraw beyond Limits Test*********
        //21. Test if the Withdraw method correctly withdraws money within the overdraft limit.
        [TestMethod]
        public void ShouldCurrentAccountThrowExceptionIfWithdrawAmountIsGreaterThanBalance()
        {
            CurrentAccount currentAccount = new CurrentAccount(1001, 5000, "Rothschild");
            currentAccount.Withdraw(10000);
            double expectedBalance = -5000;
            Assert.AreEqual(expectedBalance, currentAccount.Balance);
        }
        //22. Test if the Withdraw method correctly withdraws money within the minimum balance.
        [TestMethod]
        public void ShouldSavingsAccountThrowExceptionIfWithdrawAmountIsGreaterThanBalance()
        {
            SavingsAccount savingsAccount = new SavingsAccount(1001, 5000, "Rothschild");
            savingsAccount.Withdraw(4000);
            double expectedBalance = 1000;
            Assert.AreEqual(expectedBalance, savingsAccount.Balance);
        }
    }
}