using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating instances of movie genres
        Horror horror = new Horror();
        Comedy comedy = new Comedy();
        Romance romance = new Romance();

        while (true)
        {
            // User chooses a genre
            Console.WriteLine("Choose a movie genre:");
            Console.WriteLine("1. Horror");
            Console.WriteLine("2. Comedy");
            Console.WriteLine("3. Romance");
            Console.WriteLine("0. Exit");

            // Reading user input
            int userInput;
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                if (userInput == 0)
                {
                    Console.WriteLine("Exiting program. Goodbye!");
                    break; // Exit the loop if the user chooses to exit
                }

                // Displaying movies based on user's choice
                switch (userInput)
                {
                    case 1:
                        DisplayMovies(horror);
                        break;
                    case 2:
                        DisplayMovies(comedy);
                        break;
                    case 3:
                        DisplayMovies(romance);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a number between 0 and 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }


    // Helper method to display movies for a given genre
    static void DisplayMovies(MovieGenre genre)
            {
                Console.WriteLine($"Movies in {genre.GetType().Name} genre:");
                List<string> movies = genre.GetMovies();
                foreach (var movie in movies)
                {
                    Console.WriteLine(movie);
                }
            }
    

// Base class for MovieGenre
class MovieGenre
    {
        protected List<string> Movies { get; set; } = new List<string>();

        public List<string> GetMovies()
        {
            return Movies;
        }
    }

    // Horror class inheriting from MovieGenre
    class Horror : MovieGenre
    {
        public Horror()
        {
            // Adding horror movies
            Movies.Add("The Conjuring");
            Movies.Add("It");
            Movies.Add("A Nightmare on Elm Street");
        }
    }

    // Comedy class inheriting from MovieGenre
    class Comedy : MovieGenre
    {
        public Comedy()
        {
            // Adding comedy movies
            Movies.Add("Dumb and Dumber");
            Movies.Add("Superbad");
            Movies.Add("Bridesmaids");
        }
    }

    // Romance class inheriting from MovieGenre
    class Romance : MovieGenre
    {
        public Romance()
        {
            // Adding romance movies
            Movies.Add("The Notebook");
            Movies.Add("Pride and Prejudice");
            Movies.Add("Before Sunrise");
        }
    }
}

