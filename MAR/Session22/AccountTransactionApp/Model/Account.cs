using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransactionApp.Model
{
    internal class Account
    {
        private List<Transaction> _transactions;
        private readonly int _accountNo;
        protected double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 1000;
        public Account(int accountNo, double balance, string name)
        {
            _accountNo = accountNo;
            _balance = balance;
            _name = name;
            _transactions = new List<Transaction>();
            _transactions.Add(new Transaction { Type = 'D', Amount = _balance, Time = DateTime.Now });
        }
        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new Exception("Deposite Balance Cannot be negative");
            }
            else if (amount == 0) 
            {
                throw new Exception("Deposite Balance Cannot be Zero");
            }
            _balance += amount;
            _transactions.Add(new Transaction { Type = 'D', Amount = amount, Time = DateTime.Now }); 
        }
        public void Withdraw(double amount) {
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
            else if (HasSufficientBalance(amount))
                _balance -= amount;
            _transactions.Add(new Transaction { Type = 'W', Amount = amount, Time = DateTime.Now });
            return;
        }
        private bool HasSufficientBalance(double amount)
        {
            return _balance - amount >= MIN_BALANCE;
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
        public List<Transaction> Transactions
        {
            get { return _transactions; }
        }
    }
}