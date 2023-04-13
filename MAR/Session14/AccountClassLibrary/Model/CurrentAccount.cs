using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClassLibrary.Model
{
    public class CurrentAccount : Account
    {
        private const double OVER_DRAFT_LIMIT = -5000;
        public CurrentAccount(int accountNo, double balance, string name) 
            : base(accountNo, balance, name)
        {
        }
        public override void Withdraw(double amount)
        {
            if (IsInOverDraftLimit(amount))
                _balance -= amount;
            else throw new Exception();
        }
        private bool IsInOverDraftLimit(double amount)
        {
            return _balance - amount >= OVER_DRAFT_LIMIT;
        }
    }
}