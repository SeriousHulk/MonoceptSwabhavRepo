using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphism.Model
{
    internal abstract class Account
    {
        private readonly int _accountNo;
        protected double _balance;
        private readonly string _name;
        public Account(int accountNo, double balance, string name)
        {
            _accountNo = accountNo;
            _balance = balance;
            _name = name;
        }
        public void Deposit(double amount)
        {
            _balance += amount;
        }
        public abstract void Withdraw(double amount);

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