using System.Collections.Generic;

namespace Assignment7
{
    public interface IContext
    {
         void AddMovie(Movie movie);
         List<Movie> ReadMovies();
    }
}