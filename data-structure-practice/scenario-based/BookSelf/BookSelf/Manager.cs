using System;
using System.Collections.Generic;
using System.Text;

namespace BookSelf {
    internal class Manager {
        private GenreMap genreMap;

        public Manager() {
            genreMap = new GenreMap(20);
        }

        public void AddBook() {
            Console.WriteLine("Enter Genre : ");
            string genre = Console.ReadLine();
            Console.WriteLine("Enter book name : ");
            string bookName = Console.ReadLine();

            genreMap.AddBook(genre, bookName);

            genreMap(genre, bookName);
        }

    }
}
