using InterfacePolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Boy boy = new Boy();
            AtThePartyHall(man);
            AtThePartyHall(boy);
            //AtTheCinemaHall(man);
            AtTheCinemaHall(boy);
            
        }
        public static void AtThePartyHall(IMannerable obj)
        {
            Console.WriteLine("\nAt the Party Hall");
            obj.Wish();
            obj.Depart();
            Console.WriteLine("Exiting Party Hall");
        }
        public static void AtTheCinemaHall(IEmotionable obj)
        {
            Console.WriteLine("\nAt the Cinema Hall");
            obj.Cry();
            obj.Laugh();
            Console.WriteLine("Exiting Cinema Hall");
        }
    }
}
