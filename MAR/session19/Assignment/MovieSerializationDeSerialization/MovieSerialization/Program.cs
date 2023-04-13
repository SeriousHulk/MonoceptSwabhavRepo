using MovieStoreV2.Model;
using System.Runtime.Serialization.Formatters.Binary;

namespace MovieSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie[] movies = CreateMovieObjects();
            FileStream fileStream = new FileStream("DVD.dump", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, movies);
            fileStream.Close();
            Console.WriteLine("DVD dump created successfully!");
        }

        private static Movie[] CreateMovieObjects()
        {
            Movie[] movies = new Movie[5];
            movies[0] = new Movie("Namak Halal", 1982, "Prakash Mehra");
            movies[1] = new Movie("Dil Chahta Hai", 2000, "Farhan Akhtar");
            movies[2] = new Movie("Magadheera", 2009, "S.S.Rajamauli");
            movies[3] = new Movie("Amelie", 2001, "Jean-Piere Jeunet");
            movies[4] = new Movie("Before Sunset", 2004, "Richard Linklater");
            return movies;
        }
    }
}