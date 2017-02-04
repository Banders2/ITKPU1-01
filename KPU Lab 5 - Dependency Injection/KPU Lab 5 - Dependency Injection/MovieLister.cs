using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace KPU_Lab_5___Dependency_Injection
{
    public class MovieLister : IMovieLister
    {

        private readonly IMovieFinder _finder;

        public MovieLister(IMovieFinder finder)
        {
            // Add application services.
            _finder = finder;
        }

        public List<Movie> MoviesDirectedBy(string arg)
        {
            var allMovies = _finder.FindAll();

            return allMovies.Where(movie => movie.GetDirector() == arg).ToList();
        }
    }
}
