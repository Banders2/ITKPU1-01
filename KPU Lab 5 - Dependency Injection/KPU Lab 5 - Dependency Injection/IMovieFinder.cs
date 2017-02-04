using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KPU_Lab_5___Dependency_Injection
{
    public interface IMovieFinder
    {
        List<Movie> FindAll();
    }
}
