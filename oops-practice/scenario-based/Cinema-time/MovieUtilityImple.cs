using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema_time {
    internal class MovieUtilityImple : IMovie {

        private Movie[] Movies;
        int count;
        public MovieUtilityImple(int numberOfMovies) {
            Movies = new Movie[numberOfMovies];
            count = 0;
        }
        public void AddMovie(string title, string time) {
            if(count == Movies.Length) {
                Console.WriteLine("No more movies can be added");
                return;
            }

            Movie movie = new Movie(title);
            string[] times = time.Split(' ');
            for (int i = 0; i < times.Length; i++) {
                movie.SetShows(times[i]);
            }
            Movies[count++] = movie;

        }

        public void DisplayAllMovies() {
            foreach (Movie movie in Movies) {
                if (movie == null) break;
                Console.WriteLine(movie);
            }
        }

        public void SearchMovie(string keyword) {
            foreach (Movie movie in Movies) {
               if (movie != null && movie.GetTitle().ToLower().Contains(keyword.ToLower())) {
                    Console.WriteLine(movie);
                    movie.GetShows();                 
               }
            }
        }
    }
}
