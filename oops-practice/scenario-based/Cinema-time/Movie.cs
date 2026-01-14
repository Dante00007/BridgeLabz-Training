using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema_time {
    internal class Movie {
        //private int MovieID { get; }

        //private string MovieDescription { get; }
        //private string Genre {  get; }
        private string Title;
        private string[] shows;

        public Movie(string Title) {
            //this.MovieID = MovieID;

            //this.MovieDescription = MovieDescription;
            //this.Genre = Genre;
            this.Title = Title;
            this.shows = new string[3];
        }

        public void SetShows(string show) {
            for (int i = 0; i < shows.Length; i++) {
                if (shows[i] == null) {
                    shows[i] = show;
                    break;
                }
            }
        }

        public void GetShows() {
            foreach (string show in shows) {
                if (show != null) {
                    Console.WriteLine(show);
                }
            }
        }

        public string GetTitle() { 
            return this.Title;
        }
        public override string ToString() {
            return $"Title : {Title} ";
        }


    }
}
