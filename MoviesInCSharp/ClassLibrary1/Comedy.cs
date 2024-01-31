using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Comedy : MovieGenre
    {

        // Change the visibility of Movies to protected
        protected List<string> Movies { get; set; } = new List<string>();

        public List<string> GetMovies()
        {
            return Movies;
        }

        public Comedy()
        {
            // Now you can access the Movies property
            Movies.Add("Dumb and Dumber");
            Movies.Add("Superbad");
            Movies.Add("Bridesmaids");
        }
    }
}
