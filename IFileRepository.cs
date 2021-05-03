using System.Collections.Generic;

namespace Assignment7
{
    public interface IFileRepository
    {
         //declare the functions that this program will perform
         void Add(Movie movie);
         List<Movie> Read();

    }
}