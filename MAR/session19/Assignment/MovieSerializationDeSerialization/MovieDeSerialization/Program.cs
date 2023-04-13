using MovieStoreV2.Model;
using System.Runtime.Serialization.Formatters.Binary;

namespace MovieDeSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("DVD.dump",FileMode.Open,FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Object obj = binaryFormatter.Deserialize(fileStream);
            Movie[] movies = obj as Movie[];
            foreach(Movie movie in movies) 
            {
                if (movie.Year <= 2000) { Console.ForegroundColor = ConsoleColor.White; }
                else if(movie.Year > 2005) { Console.ForegroundColor = ConsoleColor.Red; }
                else { Console.ForegroundColor = ConsoleColor.Cyan; }
                
                Console.WriteLine($"Name of the Movie :{movie.Name}\n" +
                    $"Year of Release :{movie.Year}\n" +
                    $"Name of the Director :{movie.Director}\n");
                Console.ResetColor();
            }
            fileStream.Close();
        }
    }
}