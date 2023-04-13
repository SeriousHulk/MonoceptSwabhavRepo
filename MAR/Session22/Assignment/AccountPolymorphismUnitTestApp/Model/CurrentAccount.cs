using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismUnitTestApp.Model
{
    internal class CurrentAccount : Account
    {
        private const double OVER_DRAFT_LIMIT = -5000;
        public CurrentAccount(int accountNo, double balance, string name) 
            : base(accountNo, balance, name)
        {
        }
        public override void Withdraw(double amount)
        {
            if (_balance - amount < OVER_DRAFT_LIMIT)
            {
                throw new Exception("Withdraw is beyond Overdraft Limit");
            }
            else if (amount < 0)
            {
                throw new Exception("Withdraw Balance Cannot be negative");
            }
            else if (amount == 0)
            {
                throw new Exception("Withdraw Balance Cannot be Zero");
            }
            else if (IsInOverDraftLimit(amount))
                _balance -= amount;
            return;
        }
        private bool IsInOverDraftLimit(double amount)
        {
            return _balance - amount >= OVER_DRAFT_LIMIT;
        }
    }
}