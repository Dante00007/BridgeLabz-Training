using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema_time {
    internal class CinemaTimeMain {
        static void Main(string[] args) { 
            IMovie movieUtilityImple = new MovieUtilityImple(10);

            movieUtilityImple.AddMovie("Avengers", "9:00 12:00 15:00 ");
            movieUtilityImple.AddMovie("Avengers Age Of Ultron", "18:00 20:00 22:00 ");

            movieUtilityImple.DisplayAllMovies();
            Console.WriteLine();

            movieUtilityImple.SearchMovie("Avengers");


        }
    }
}
