using EventPOC.Model;

namespace EventPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventManager = new AddUserEvent();
            var user1 = new User("Virat");
            var user2 = new User("Rohit");
            var user3 = new User("Hardik");
            eventManager.AddUser += user1.HandleEvent;
            eventManager.AddUser += user2.HandleEvent;
            eventManager.TriggerEvent();
            Console.WriteLine();
            eventManager.AddUser += user3.HandleEvent;
            eventManager.TriggerEvent();
        }
    }
}