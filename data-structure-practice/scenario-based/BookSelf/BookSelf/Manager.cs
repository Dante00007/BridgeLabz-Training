using System;
using System.Collections.Generic;
using System.Text;

namespace BookSelf {
    internal class Manager: IManager {
        private GenreMap genreMap;

        public Manager() {
            genreMap = new GenreMap(3);
        }

        public void AddBook() {
            Console.Write("Enter Genre : ");
            string genre = Console.ReadLine();
            Console.Write("Enter book name : ");
            string bookName = Console.ReadLine();

            genreMap.Add(genre, bookName);
      
        }
        public void RemoveBook() { 
            Console.Write("Enter Genre from which to remove book: ");
            string genre = Console.ReadLine();
            Console.Write("Enter book name to remove: ");
            string bookName = Console.ReadLine();
            genreMap.Remove(genre,bookName);
        }

        public void DisplayBook() {
            Console.Write("Enter Genre: ");
            string genre = Console.ReadLine();
            genreMap.Get(genre);
        }

    }
}
