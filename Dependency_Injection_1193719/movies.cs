using System;
using System.Collections.Generic;

namespace Dependency_Injection_1193719
{
    public class movies : ImovieService
    {
        public string Name { get; set; }
        public bool status { get; set; }

        public List<movies> GetMovies()
        {
            string[] movies = new string[] { "Avatar", "Pinocho", "Argylle", "Scream", "Morbius", "Moonfall" };
            List<movies> listOfMovies = new List<movies>();

            for (int i = 0; i < 2; i++)
            {
                movies newMovie = new movies();
                newMovie.Name = movies[new Random().Next(movies.Length)];
                newMovie.status = GetStatus();
                listOfMovies.Add(newMovie);
            }

            return listOfMovies;
        }

        public bool GetStatus()
        {
            return Convert.ToBoolean(new Random().Next(2));
        }
    }
}
