using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AccountEventActionApp.Model
{
    public class Account
    {
        private readonly int _accountNo;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;
        public event Action<Account> OnBalanceChanged;
        private readonly List<IAccountNotifier> _notifierList;

        public Account(int accountNo, double balance, string name)
        {
            _accountNo = accountNo;
            _balance = balance;
            _name = name;
            _notifierList = new List<IAccountNotifier>();
        }
        public Account(int accountNo, string name) 
        {
            _accountNo = accountNo;
            _name = name;
            _balance = MIN_BALANCE;
        }
        public void AddSubscriber(IAccountNotifier notifier) 
        {
            _notifierList.Add(notifier);
        }
        public void Deposit(double amount)
        {
            _balance += amount;
            if (OnBalanceChanged != null)
            {
                OnBalanceChanged(this);
            }
            Notification();
        }

        private void Notification()
        {
            foreach (IAccountNotifier notifier in _notifierList)
            {
                notifier.Notify(this);
                
            }
        }

        public void Withdraw(double amount)
        {
            
            if (SufficientFundsAvailable(amount))
            {
                _balance -= amount;
                if (OnBalanceChanged != null)
                {
                    OnBalanceChanged(this);
                }
                Notification();
            }
            else
            {
                Console.WriteLine("ERROR: No sufficient Funds");
            }
        }

        private bool SufficientFundsAvailable(double amount)
        {
            double amountAfterWithdraw = _balance - amount;
            return (amountAfterWithdraw >= MIN_BALANCE);
        }

        public double Balance
        {
            get { return _balance; }
        }
        public int AccountNo
        {
            get { return _accountNo; }
        }
        public string Name
        {
            get { return _name; }  
        }
    }
    

}
