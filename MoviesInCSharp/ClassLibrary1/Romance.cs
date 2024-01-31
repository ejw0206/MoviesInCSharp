using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Romance : MovieGenre
    {

        // Change the visibility of Movies to protected
        protected List<string> Movies { get; set; } = new List<string>();

        public List<string> GetMovies()
        {
            return Movies;
        }

        public Romance()
        {
            // Now you can access the Movies property
            Movies.Add("The Notebook");
            Movies.Add("Pride and Prejudice");
            Movies.Add("Before Sunrise");
        }
    }
}
