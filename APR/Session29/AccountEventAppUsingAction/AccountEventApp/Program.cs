using AccountEventActionApp.Model;
using AccountEventActionApp.Notifiers;
using System.Security.Principal;

namespace AccountEventActionApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Account user = new Account(10501, 9000, "Mahesh");
            user.OnBalanceChanged += new SMSNotifier().Notify;
            user.OnBalanceChanged += new EmailNotifier().Notify;
            user.OnBalanceChanged += (account) =>
        {
            Console.WriteLine("WhatsApp Notification for Axis Bank Account:\n" +
                $"with Account Name : {account.Name}\n" +
                $"Account No.: {account.AccountNo}\n" +
                $"Current Balance :{account.Balance}\n");
        };
            user.Withdraw(888);
        }
    }

}