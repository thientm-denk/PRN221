 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

 namespace Demo_IoC.Model{
    public interface IMovieReader{
        List<Movie> ReadMovies();
    }
 }
