using System;
using System.Collections.Generic;

namespace Movie_List
{
    public class MovieManager
    {
        public static List<Movie> moviesList = new List<Movie>()
        {
            new Movie("Toy Story", "animated"),
            new Movie("Monsters University", "animated"),
            new Movie("Rio", "animated"),
            new Movie("Black Swan", "drama"),
            new Movie("The Artist", "drama"),
            new Movie("Escape Room", "horror"),
            new Movie("Children of the Corn", "horror"),
            new Movie("Alien", "sci-fi"),
            new Movie("Monsters", "sci-fi"),
            new Movie("I am Number Four", "sci-fi")
        };

        public static void DisplayDrama()
        {
            int count = 1;
            foreach (Movie movie in moviesList)
            {
                if(movie.Category == "drama")
                {
                    Console.WriteLine($"{count}. {movie.Title}");
                    count++;
                }
            }
        }

        public static void DisplayHorror()
        {
            int count = 1;
            foreach (Movie movie in moviesList)
            {
                if (movie.Category == "horror")
                {
                    Console.WriteLine($"{count}. {movie.Title}");
                    count++;
                }
            }

        }

        public static void DisplaySciFi()
        {
            int count = 1;
            foreach (Movie movie in moviesList)
            {
                if (movie.Category == "sci-fi")
                {
                    Console.WriteLine($"{count}. {movie.Title}");
                    count++;
                }
            }
        }

        public static void DisplayAnimated()
        {
            int count = 1;
            foreach (Movie movie in moviesList)
            {
                if (movie.Category == "animated")
                {
                    Console.WriteLine($"{count}. {movie.Title}");
                    count++;
                }
            }
        }

    }
}
