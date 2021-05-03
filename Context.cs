using System.Collections.Generic;

namespace Assignment7
{
    public class Context : IContext
    {
        private readonly IFileRepository _fileRepository;

        public Context(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }
        public void AddMovie(Movie movie)
        {
            _fileRepository.Add(movie);
        }

        public List<Movie> ReadMovies()
        {
           return _fileRepository.Read();
        }
    }
}