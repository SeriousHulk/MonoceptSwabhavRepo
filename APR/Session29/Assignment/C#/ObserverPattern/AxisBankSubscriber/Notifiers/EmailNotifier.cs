using PublisherCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxisBankSubscriber.Notifiers
{
    internal class EmailNotifier : IAccountNotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("Email Notification for Axis Bank Account:\n" +
                $"with Account Name : {account.Name}\n" +
                $"Account No.: {account.AccountNo}\n" +
                $"Current Balance :{account.Balance}\n");
        }
    }
}
