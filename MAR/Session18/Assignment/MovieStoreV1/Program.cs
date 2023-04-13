using MovieStoreV1.Model;

namespace MovieStoreV1
{
    class Program
    {
        static Movie[] movies = new Movie[5];
        static int movieCount = 0;
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
                    AddMovie();
                else if (choice == 2)
                    DisplayMovies();
                else if (choice == 3)
                    exit = true;
                else
                    Console.WriteLine("Invalid choice. Please try again.");
            }
        }
        static void AddMovie()
        {
            CheckIfArrayFull();
            Console.WriteLine("Please enter movie name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter movie year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter movie director name:");
            string director = Console.ReadLine();
            movies[movieCount] = new Movie(name, year, director);
            movieCount++;
            Console.WriteLine("\n***Movie added successfully!");
        }

        private static void CheckIfArrayFull()
        {
            if (movieCount == movies.Length)
            {
                Movie[] newArr = new Movie[movies.Length * 2];
                for (int i = 0; i < movies.Length; i++)
                {
                    newArr[i] = movies[i];
                }
                movies = newArr;
            }
        }

        static void DisplayMovies()
        {
            if (movieCount == 0)
            {
                Console.WriteLine("\n***No movies found.***");
                return;
            }
            Console.WriteLine("\n***Previously added movies:***");
            for (int i = 0; i < movieCount; i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i].Name} ({movies[i].Year}) directed by {movies[i].Director}");
            }
        }
    }
}