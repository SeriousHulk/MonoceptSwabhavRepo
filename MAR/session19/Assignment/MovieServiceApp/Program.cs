using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreV2.Model;

namespace MovieServiceApp
{
    class Program
    {
        static MovieManager movieManager = new MovieManager();
        static void Main(string[] args)
        {
            int choice;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nWelcome to MovieDatabase! What would you like to do?");
                Console.WriteLine($"Movie Count {movieManager.movieCount}");
                Console.WriteLine("1. Add new movie");
                Console.WriteLine("2. Display previously added movies");
                Console.WriteLine("3. Exit app");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Please enter movie name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please enter movie year:");
                    int year = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter movie director name:");
                    string director = Console.ReadLine();
                    movieManager.AddMovie(name, year, director);
                }
                else if (choice == 2)
                {
                    if (movieManager.movieCount == 0)
                    {
                        MovieNotFound();
                        return;
                    }
                    DisplayMovieDetails(movieManager.movies);
                }
                else if (choice == 3)
                    exit = true;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ResetColor();
                }
            }
        }
        private static void DisplayMovieDetails(Movie[] movies)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n***Previously added movies:***");
            for (int i = 0; i < movieManager.movieCount; i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i].Name} ({movies[i].Year}) directed by " +
                    $"{movies[i].Director}");
            }
            Console.ResetColor();
        }
        private static void MovieNotFound()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n***No movies found.***");
            Console.ResetColor();
            return;
        }
    }
}
