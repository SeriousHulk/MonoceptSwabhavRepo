using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber;
            string playAgain;

            do
            {
                randomNumber = random.Next(1, 101);
                int guess = 0;
                int numberOfGuesses = 0;

                Console.WriteLine("**************** Welcome to the Random Number Guesser Game ****************");
                Console.WriteLine("Guess a number between 1 and 100.");

                while (guess != randomNumber)
                {
                    Console.Write("Enter your guess: ");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid Number.(between 1 to 100)");
                        continue;
                    }
                    numberOfGuesses++;
                    if (guess < randomNumber)
                    {
                        Console.WriteLine("Your guess is too low. Try again.");
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Your guess is too high. Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You guessed the number in {0} attempts.", numberOfGuesses);
                    }
                }

                Console.Write("Would you like to play again? (y/n): ");
                playAgain = Console.ReadLine().ToLower();
                while (playAgain != "y" && playAgain != "n")
                {
                    Console.Write("Wrong Input!!!. Would you like to play again? Please enter 'y' or 'n': ");
                    playAgain = Console.ReadLine().ToLower();
                }

            } while (playAgain == "y");
        }
    }
}
