using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema_time {
    internal interface IMovie {
        void AddMovie(string title, string time);
        void SearchMovie(string keyword);
        void DisplayAllMovies();

    }
}
