using MovieStoreV2.Model;

namespace MovieStoreV2

{
    class Program
    {
        static int movieCount = 0;
        static MovieManager movieManager = new MovieManager();
        static void Main(string[] args)
        {
            int choice;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nWelcome to MovieDatabase! What would you like to do?");
                Console.WriteLine($"Movie Count {movieCount}");
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
                    movieCount++;
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
                    Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        private static void DisplayMovieDetails(Movie[] movies)
        {
            Console.WriteLine("\n***Previously added movies:***");
            for (int i = 0; i < movieCount; i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i].Name} ({movies[i].Year}) directed by " +
                    $"{movies[i].Director}");
            }
        }

        private static void MovieNotFound()
        {
            Console.WriteLine("\n***No movies found.***");
            return;
        }
    }
}