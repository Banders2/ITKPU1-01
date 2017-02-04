using System.Collections.Generic;

namespace KPU_Lab_5___Dependency_Injection
{
    public interface IMovieLister
    {
        List<Movie> MoviesDirectedBy(string arg);
    }
}