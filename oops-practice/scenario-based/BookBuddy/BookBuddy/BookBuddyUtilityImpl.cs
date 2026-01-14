using System;
using System.Collections.Generic;
using System.Text;

namespace BookBuddy {
    internal class BookBuddyUtilityImpl : IBooKManager {
        private Book[] Books;
        private int count = 0;  

        public BookBuddyUtilityImpl(int numberOfBooks) {
            Books = new Book[numberOfBooks];
        }
        public void AddBook(string title, string author,long price) {
            if (count == Books.Length) { 
                Console.WriteLine("No more books can be added");
                return;
            }
            string bookName = title + "-" + author;
            Book book = new Book(bookName, price);
            Books[count] = book;
            count++;
           
        }

        public void SearchByAuthor(string author) {
            Console.WriteLine("Author: "+author+"books are:");
            foreach (Book book in Books) {
                string [] temp = book.GetTitleAndAuthor().Split('-');
                string bookName = temp[0];
                string bookAuthor = temp[1];
                if(book!=null && bookName.ToLower().Contains(author.ToLower())){
                    Console.WriteLine(bookName+":"+book.GetPrice());
                }

            }
        }

        public void SortBooksAlphabetically() {
            Array.Sort(Books);
        }
    }
}
