using AxisBankSubscriber.Notifiers;
using PublisherCoreLib.Model;

namespace AxisBankSubscriber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account user = new Account(10501, 8900, "Mahesh");
            user.AddSubscriber(new EmailNotifier());
            user.AddSubscriber(new SMSNotifier());
            user.Withdraw(900);
        }
    }
}