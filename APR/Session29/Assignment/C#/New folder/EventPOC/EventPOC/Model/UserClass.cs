namespace EventPOC.Model
{
    public class User
    {
        private readonly string _name;
        public User(string name)
        {
            _name = name;
        }
        public void HandleEvent()
        {
            Console.WriteLine($"{_name} received the event.");
        }
    }
}