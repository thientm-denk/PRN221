using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using Demo_IoC.Model;
namespace Demo_IoC
{
    public class JSONMovieReader : IMovieReader
    {
        static string file = @"Data\MoviesDB.json";
        static List<Movie> movies = new List<Movie>();
        public List<Movie> ReadMovies()
        {
            var moviesText = File.ReadAllText(file);
            return JsonSerializer.Deserialize<List<Movie>>(moviesText);
        }
    }
}
