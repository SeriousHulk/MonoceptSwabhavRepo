using AccountEventApp.Model;
using AccountEventApp.Notifiers;

namespace AccountEventApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Account user = new Account(10501, 8900, "Mahesh");
            user.OnBalanceChanged += new SMSNotifier().Notify;
            user.OnBalanceChanged += new EmailNotifier().Notify;
            user.Withdraw(900);
        }
    }

}