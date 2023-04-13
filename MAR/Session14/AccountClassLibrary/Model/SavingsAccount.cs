using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClassLibrary.Model
{
    public class SavingsAccount : Account
    {
        private const double MIN_BALANCE = 1000;
        public SavingsAccount(int accountNo, double balance, string name)
            : base(accountNo, balance, name)
        {
        }
        public override void Withdraw(double amount)
        {
            if(HasSufficientBalance(amount))
                _balance -= amount;
            else throw new Exception();
        }
        private bool HasSufficientBalance(double amount)
        {
            return _balance - amount >= MIN_BALANCE;
        }
    }
}