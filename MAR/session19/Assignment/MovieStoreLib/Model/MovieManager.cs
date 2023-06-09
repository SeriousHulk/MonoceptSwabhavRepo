﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreV2.Model
{
    [Serializable]
    public class MovieManager
    {
        public Movie[] movies = new Movie[5];
        public int movieCount = 0;

        public void AddMovie(string name,int year,string director)
        {
            CheckIfArrayFull();            
            movies[movieCount] = new Movie(name, year, director);
            movieCount++;
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
    }
}
