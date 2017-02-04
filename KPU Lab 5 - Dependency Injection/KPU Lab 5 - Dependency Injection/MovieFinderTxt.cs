using System.Collections.Generic;

namespace KPU_Lab_5___Dependency_Injection
{
    internal class MovieFinderTxt : IMovieFinder
    {
        private string _movieName;

        public MovieFinderTxt(string movieName)
        {
            _movieName = movieName;
        }

        public List<Movie> FindAll()
        {
            var listOfMovies = new List<Movie>();
            listOfMovies.Add(new Movie() {Director = "Anders", Title = "1"});
            listOfMovies.Add(new Movie() { Director = "Anders", Title = "2" });
            listOfMovies.Add(new Movie() { Director = "Anders", Title = "3" });
            listOfMovies.Add(new Movie() { Director = "Anders", Title = "4" });
            listOfMovies.Add(new Movie() { Director = "Pernille", Title = "5" });
            listOfMovies.Add(new Movie() { Director = "Pernille", Title = "6" });
            listOfMovies.Add(new Movie() { Director = "Pernille", Title = "7" });
            return listOfMovies;
        }
    }
}