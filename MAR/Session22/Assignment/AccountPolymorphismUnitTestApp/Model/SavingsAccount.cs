using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismUnitTestApp.Model
{
    internal class SavingsAccount : Account
    {
        private const double MIN_BALANCE = 1000;
        public SavingsAccount(int accountNo, double balance, string name)
            : base(accountNo, balance, name)
        {
        }
        public override void Withdraw(double amount)
        {
            if (_balance - amount < MIN_BALANCE)
            {
                throw new Exception("Withdraw is beyond Available Balance");
            }
            else if (amount < 0)
            {
                throw new Exception("Withdraw Balance Cannot be negative");
            }
            else if (amount == 0)
            {
                throw new Exception("Withdraw Balance Cannot be Zero");
            }
            else if(HasSufficientBalance(amount))
                _balance -= amount;

           
            return;
        }
        private bool HasSufficientBalance(double amount)
        {
            return _balance - amount >= MIN_BALANCE;
        }
    }
}