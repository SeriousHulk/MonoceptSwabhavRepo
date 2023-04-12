using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp.Model
{
    internal class Player
    {
        private readonly int id;
        private readonly string name;
        private readonly int age;
        private const int MIN_AGE = 18;
        public Player(int id, int age, string name)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            Console.WriteLine("inside 3 params constructor");
        }
        public Player(int id, string name) : this(id,MIN_AGE, name)
        {
            Console.WriteLine("inside 2 params constructor") ;
        }
        public int Id
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
        public Player WhoIsElder(Player secondPlayer) 
        {
            return secondPlayer.Age < this.Age ? this : secondPlayer;
        }
    }
}
