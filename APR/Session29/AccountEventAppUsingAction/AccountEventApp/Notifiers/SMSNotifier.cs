using AccountEventActionApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEventActionApp.Notifiers
{
    internal class SMSNotifier : IAccountNotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("SMS Notification for Axis Bank Account:\n" +
                $"with Account Name : {account.Name}\n" +
                $"Account No.: {account.AccountNo}\n" +
                $"Current Balance :{account.Balance}\n");
        }
    }
}
