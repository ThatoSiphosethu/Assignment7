using System;
using ConsoleTables;

namespace Assignment7
{
    public class Menu : IMenu
    {
        private IContext _context;
        public Menu(IContext context)
        {
            _context = context;
        }

        public Movie MovieDetails()
        {
            System.Console.WriteLine("Add title: ");
            string movieTitle = System.Console.ReadLine();

            System.Console.WriteLine("Add genre: ");
            string movieGenre = System.Console.ReadLine();

            return new Movie {Title = movieTitle, Genres = movieGenre};
        }

        public void Process()
        {
            System.Console.WriteLine("Choose an option/n");
            System.Console.WriteLine("1. Add movie");
            System.Console.WriteLine("2. Display movies");
            string choice = System.Console.ReadLine();

            switch(choice)
            {
                case "1":
                var addMovie = MovieDetails();
                _context.AddMovie(addMovie);
                break;
                case "2":
                ConsoleTable.From<Movie>(_context.ReadMovies()).Write();
                break;
            }
        }
    }
}