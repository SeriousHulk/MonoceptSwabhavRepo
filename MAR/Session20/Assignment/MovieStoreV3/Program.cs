using MovieStoreV3.Model;
using System.Runtime.Serialization.Formatters.Binary;

namespace MovieStoreV3
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieManager movieManager = new MovieManager();
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
                    AddMovie(movieManager);
                else if (choice == 2)
                    DisplayMovies(movieManager);
                else if (choice == 3)
                    exit = true;
                else
                    Console.WriteLine("Invalid choice. Please try again.");
            }
        }
        static void AddMovie(MovieManager movieManager)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Year of release: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Director name: ");
            string director = Console.ReadLine();
            movieManager.AddMovie(name, year, director);
            Console.WriteLine("\n***Movie added successfully!");
        }
        static void DisplayMovies(MovieManager movieManager)
        {
            Console.WriteLine("All movies in the store:");
            movieManager.ShowMovies();
        }
    }
}