using HdfcBankSubscriber.Notifiers;
using PublisherCoreLib.Model;

namespace HdfcBankSubscriber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account mahesh = new Account(10501, 8900, "Mahesh");
            mahesh.AddSubscriber(new FaxNotifier());
            mahesh.AddSubscriber(new WhatsAppNotifier());
            mahesh.Withdraw(123);
        }
    }
}