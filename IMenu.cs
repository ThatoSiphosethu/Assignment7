using System.Collections.Generic;

namespace Assignment7
{
    public interface IMenu
    {
        Movie MovieDetails();
        void Process();
        List<Movie> SearchOption();
    }
}