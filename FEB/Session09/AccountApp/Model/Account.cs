using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
    internal class Account
    {
        private decimal _balance;
        private readonly string _name;
        private readonly int _accountNo;
        private readonly long _contactNo;
        private const int MIN_ACCOUNT_NO = 0;
        private const int MAX_ACCOUNT_NO = 1000;
        private const long MIN_CONTACT_NO = 1000000000 ;
        private const long MAX_CONTACT_NO = 9999999999;
        private const long NULL_CONTACT_NO = 0;
        private const int MIN_STRING_LENGTH = 3;
        private const decimal MIN_BALANCE = 500;
        private const decimal NULL_BALANCE = 0;
        public Account(int accountNo, decimal balance, string name, long contactNo)
        {
            _accountNo = accountNo;
            _balance = balance;
            _name = name;
            _contactNo = contactNo;
        }

        public Account()
        {
        }

        public int AccountNo { get { return _accountNo;} }
        public decimal Balance { get { return _balance; } set { _balance = value; } }
        public string Name { get { return _name; } }
        public long ContactNo { get { return _contactNo;} }
        public int ValidateAccountNo(int accountNumber)
        {
            return accountNumber < MIN_ACCOUNT_NO || accountNumber> MAX_ACCOUNT_NO ? MIN_ACCOUNT_NO : accountNumber;
        }
        public string ValidateName(string name)
        {
            return name.Length < MIN_STRING_LENGTH ? null : name;
        }
        public long ValidateContactNo(long contactNumber)
        {
            return contactNumber > MAX_CONTACT_NO || contactNumber < MIN_CONTACT_NO ? NULL_CONTACT_NO : contactNumber;
        }
        public decimal ValidateBalance(decimal balance)
        {
            return balance < MIN_BALANCE ? throw new ArgumentOutOfRangeException(nameof(balance), "Balance cannot be less than minimum balance.") : balance;
        }
        public decimal Withdraw(decimal deduct)
        {
            return ValidateBalance(this.Balance -= deduct);
        }
        public decimal Deposit(decimal deposit)
        {
            return this.Balance += deposit;
        }
    }
}
