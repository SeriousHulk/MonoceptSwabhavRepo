using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintName("Vikrant", 2);
            Console.WriteLine(" CheckIsEven1 :" + CheckIsEven1(1));
            Console.WriteLine(" CheckIsEven2 :" + CheckIsEven2(2));
            Console.WriteLine(" CheckIsEven3 :" + CheckIsEven3(3));
            Console.WriteLine(" CheckIsEven4 :" + CheckIsEven4(4));
            string[] developerNames = GetDeveloperNames();
            foreach(string name in developerNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Enter you name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello "+ userName.ToUpper());
            PrintTodaysDate();
            DisplayDiceNumber(10);


        }
        static string[] GetDeveloperNames()
        {

            string[] names = { "Raju", "Shyam", "Gopal", "Madhav", "Laxman", "Lucky" };
            return names;
        }

        private static void DisplayDiceNumber(int rollCount)
        {
            Random random = new Random();
            for(int roll=1; roll<= rollCount; roll++)
            {
                int diceValue = random.Next(1, 6);
                Console.WriteLine("after rolling dice "+roll+ " time you get: "+ diceValue);
            }

        }
        private static void PrintTodaysDate()
        {
            Console.WriteLine(DateTime.Now.ToString("M"));
        }
        static bool CheckIsEven1(int input)
        {
            if (input % 2 ==0)
                return true;
            else
                return false;  
        }
        static bool CheckIsEven2(int input)
        {
            if (input % 2 == 0)
                return true;
            
            return false;
        }
        static bool CheckIsEven3(int input)
        {
            return (input % 2 == 0);
        }

        static string CheckIsEven4(int input)
        {
            return (input % 2 == 0) ? "This is Even" : "This is Odd";
                
        }
        static void PrintName(string userName, int iterations)
        {
            for(int i = 0; i< iterations;i++)
            {
                Console.WriteLine("Printname :"+userName.ToUpper());
            }
        }
    }
}
