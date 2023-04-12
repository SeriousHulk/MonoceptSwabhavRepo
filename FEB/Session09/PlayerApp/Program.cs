using PlayerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
        }
        private static void CaseStudy2()
        {
            Player playerB = new Player(2, "Virat Kohli");
            Player playerA = new Player(1, 37, "M.S.Dhoni");

            Player[] manyPlayers = new Player[5];

            manyPlayers[0] = playerA;
            manyPlayers[1] = playerB;
            manyPlayers[2] = new Player(3, 39, "Sehwag");
            manyPlayers[3] = new Player(4, 49, "Sachin");
            manyPlayers[4] = new Player(5, 29, "Draving");

            foreach (Player player in manyPlayers)
            {
                Console.WriteLine($"player Id: {player.Id}\n" +
                    $"Name     : {player.Name}\n" +
                    $"Age      : {player.Age}");
            }
                    PrintDetails(playerA, "Details of Player A");

            MethodForAgeCheck(playerB, playerA);
        }
        private static void CaseStudy1()
        {
            Player playerB = new Player(2, "Virat Kohli");
            PrintDetails(playerB, "Details of Player B");

        }
        private static void MethodForAgeCheck(Player playerB, Player playerA)
        {
            Player ElderPlayer = playerB.WhoIsElder(playerA);
            Console.WriteLine($"\nElder Player is : {ElderPlayer.Name}\n");
            Console.WriteLine($"Hashcode player A: {playerA.GetHashCode()}");
            Console.WriteLine($"Hashcode player B: {playerB.GetHashCode()}");
            Console.WriteLine($"Hashcode Elder player: {ElderPlayer.GetHashCode()}");
        }
        private static void PrintDetails(Player player, string description)
        {
            Console.WriteLine(description);
            Console.WriteLine($"player Id: {player.Id}\n" +
                $"Name     : {player.Name}\n" +
                $"Age      : {player.Age}");
        }
    }
}
