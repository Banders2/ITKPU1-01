using System;
using Microsoft.Extensions.DependencyInjection;

namespace KPU_Lab_5___Dependency_Injection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IMovieFinder>(provider => new MovieFinderTxt("Anders"))
                .BuildServiceProvider();

            var finder = serviceProvider.GetService<IMovieFinder>();
            var lister = new MovieLister(finder); // serviceProvider.GetService<IMovieLister>();
            var listOfMoviesDirectedByAnders = lister.MoviesDirectedBy("Anders");
            
            foreach (var movies in listOfMoviesDirectedByAnders)
            {
                Console.WriteLine($"The title of the movie is: {movies.Title}");
                Console.WriteLine($"The director of the movie is: {movies.Director}");
                Console.WriteLine("-------------------------------------------------------------");
            }
        }
    }
}