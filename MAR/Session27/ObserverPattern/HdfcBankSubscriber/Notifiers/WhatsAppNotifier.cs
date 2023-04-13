using PublisherCoreLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HdfcBankSubscriber.Notifiers
{
    internal class WhatsAppNotifier:IAccountNotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("Whatsapp Notification for HDFC Bank Account:\n" +
                $"with Account Name : {account.Name}\n" +
                $"Account No.: {account.AccountNo}\n" +
                $"Current Balance :{account.Balance}");
        }
    }
}
