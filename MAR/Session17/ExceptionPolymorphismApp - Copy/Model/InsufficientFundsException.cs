using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPolymorphismApp.Model
{
    class InsufficientFundsException : Exception
    {
        private int _accountNo;
        private double _balance,_withdraw;
        private string _name;
        public InsufficientFundsException(Account account, double withdraw) 
        {
            _accountNo = account.AccountNo;
            _balance = account.Balance;
            _name = account.Name;
            _withdraw = withdraw;
        }
        public override string Message
        {
            get
            {
                string message = $"Kotak Bank Says" +
                    $"account No : {_accountNo}\n" +
                    $"owner name : {_name}\n" +
                    $"has balance :{_balance}\n" +
                    $"but min balance should be 500, so the transaction cannot be processed.";
                return message;
            }
        }
    }
}
