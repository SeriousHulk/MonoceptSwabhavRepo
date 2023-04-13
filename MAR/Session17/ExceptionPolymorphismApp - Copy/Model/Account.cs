using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPolymorphismApp.Model
{
    internal class Account
    {
        private readonly int _accountNo;
        private double _balance;
        private readonly string _name;
        private const double MIN_BALANCE = 500;
        public Account(int accountNo, double balance, string name)
        {
            _accountNo = accountNo;
            _balance = balance;
            _name = name;
        }
        public Account(int accountNo, string name)
        {
            _accountNo = accountNo;
            _name = name;
            _balance = MIN_BALANCE;
        }
        public void Deposit(double amount)
        {
            _balance += amount;
        }
        public void Withdraw(double amount)
        {
            
            if (SufficientFundsAvailable(amount))
            {
                _balance -= amount;
            }
            else
            {
                throw new InsufficientFundsException(this ,amount);
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