using System;

namespace KPU_Lab_5___Dependency_Injection
{
    public class Movie
    {
        public string GetDirector()
        {
            return Director;
        }

        public string Director { get; set; }
        public string Title { get; set; }
    }
}