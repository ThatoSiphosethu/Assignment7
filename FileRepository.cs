using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Assignment7
{
    public class FileRepository : IFileRepository
    {
        private string _file = Path.Combine(Environment.CurrentDirectory, "File", "movies.json");
        public void Add(Movie movie)
        {
            //calling all the movies
            var allMovies = Read(); 
            //looking the last id in order to add a new id inside the json file
            var lastMovie = allMovies.OrderBy(m => m.MovieId).Last();
            movie.MovieId = lastMovie.MovieId + 1;
            //add new movie
            allMovies.Add(movie);

            using(var jsonWriter = new StreamWriter(_file))
            {
                string movieWriter = JsonConvert.SerializeObject(allMovies, Formatting.Indented);
                
                jsonWriter.Write(movieWriter);
            }
        }

        public List<Movie> Read()
        {
            string listOfMovies;
            using(var jsonReader = new StreamReader(_file))
            {
                listOfMovies = jsonReader.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<List<Movie>>(listOfMovies);
        }
    }
}