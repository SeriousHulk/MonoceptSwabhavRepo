using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreV3.Model
{
    [Serializable]
    public class MovieManager
    {
        
        public Movie[] movies = new Movie[5];
        public int movieCount = 0;

        public MovieManager()
        {
            LoadMovies();
        }

        public void AddMovie(string name, int year, string director)
        {
            CheckIfArrayFull();
            movies[movieCount] = new Movie(name, year, director);
            movieCount++;
            SaveMovies();
        }
        public void AddMovie(Movie movie)
        {
            CheckIfArrayFull();
            movies[movieCount] = new Movie(movie.Name, movie.Year, movie.Director);
            movieCount++;
            SaveMovies();
        }
        public void CheckIfArrayFull()
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
        public void SaveMovies()
        {
            FileStream fileStream = new FileStream("DVD.dump", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, movies);
            fileStream.Close();
        }
        public void LoadMovies()
        {
            if (File.Exists("DVD.dump"))
            {
                FileStream fileStream = new FileStream("DVD.dump", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                movies = (Movie[])binaryFormatter.Deserialize(fileStream);
                movieCount = movies.Length;
                fileStream.Close();
            }
        }
        public void ShowMovies()
        {
            foreach (Movie movie in movies)
            {
                if (movie == null)
                {
                    break;
                }
                if (movie.Year <= 2000) { Console.ForegroundColor = ConsoleColor.White; }
                else if (movie.Year > 2005) { Console.ForegroundColor = ConsoleColor.Red; }
                else { Console.ForegroundColor = ConsoleColor.Cyan; }

                Console.WriteLine($"Name of the Movie :{movie.Name}\n" +
                    $"Year of Release :{movie.Year}\n" +
                    $"Name of the Director :{movie.Director}\n");
                Console.ResetColor();
            }
        }
    }
}