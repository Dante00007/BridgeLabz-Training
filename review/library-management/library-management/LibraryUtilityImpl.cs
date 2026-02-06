using System;
using System.Collections.Generic;
using System.Text;

namespace library_management {
    internal class LibraryUtilityImpl : ILibrary {
        private Book[] books;
        private bool[] AvailableStatus;

        public LibraryUtilityImpl(int numberOfBooks) { 
            books = new Book[numberOfBooks];
            AvailableStatus = new bool[numberOfBooks];
        }

        private int Search(string title) {
 
            for (int i =0;i<books.Length;i++) {
                if (books[i]!= null && books[i].GetTitle().ToLower().Contains(title.ToLower())) {
                    return i;
                }
            }
            return -1;
        }

        public void AddBook() {
            Console.Write("Enter title of book : ");
            string title = Console.ReadLine();
            Console.Write("Enter author of book : ");
            string author = Console.ReadLine();
            Console.Write("Enter price of book : ");
            int price = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < books.Length; i++) {
                if (books[i] == null) {
                    books[i] = new Book(title, author, price);
                    AvailableStatus[i] = true;
                    return;
                }
            }
            Console.WriteLine("No Space in library");
        }
        public void SearchByTitle() {
            Console.Write("Enter title of book : ");
            string title = Console.ReadLine();

            if (title == null) {
                Console.WriteLine("Enter something");
                return;
            }

            int ind = Search(title);
            if (ind == -1) {
                Console.WriteLine($"No book found with title {title}");
                return;
            }
            Console.WriteLine(books[ind]);
        }
        public void Delete() {
            Console.Write("Enter title of book : ");
            string title = Console.ReadLine();

            if (title == null) {
                Console.WriteLine("Enter something");
                return;
            }

            int ind = Search(title);
            if (ind == -1) {
                Console.WriteLine($"No book found with title {title}, Therefore no book to delete");
                return;
            }

            books[ind] = null;
        }

        public void Update() {
            Console.Write("Enter title of book : ");
            string title = Console.ReadLine();
            Console.WriteLine("1.To Update title");
            Console.WriteLine("2.To Update author");
            Console.WriteLine("3.To Update price");
            Console.Write("Enter category to update : ");
            int categoryToUpdate = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter new value of book : ");
            string newValue = Console.ReadLine();
            

            if (title == null || newValue==null || categoryToUpdate==0) {
                Console.WriteLine("Enter something");
                return;
            }

            int ind = Search(title);
            if (ind == -1) {
                Console.WriteLine($"No book found with title {title}, Therefore no book to update");
                return;
            }

            if (categoryToUpdate == 1) {
                books[ind].SetTitle(newValue);
            } else if (categoryToUpdate == 2) {
                books[ind].SetAuthor(newValue);
            } else if(categoryToUpdate==3){
                books[ind].SetPrice(int.Parse(newValue));
            }
        }

        public void LendBook() {
            Console.Write("Enter title of book : ");
            string title = Console.ReadLine();

            if (title == null) {
                Console.WriteLine("Enter something");
                return;
            }

            int ind = Search(title);

            if (ind == -1) { 
                Console.WriteLine($"We don't hava any book with title {title}");
                return;
            }

            if (AvailableStatus[ind]) {
                Console.WriteLine($"Here is your book {title}");
                AvailableStatus[ind] = false;
            } else {
                Console.WriteLine($"Sorry, Book {title} is not available currently");
            }
        }

        public void ReturnBook() {
            Console.Write("Enter title of book : ");
            string title = Console.ReadLine();

            if (title == null) {
                Console.WriteLine("Enter something");
                return;
            }

            int ind = Search(title);

            if (ind == -1) {
                Console.WriteLine($"This book {title} is not from our library");
                return;
            }

            if (!AvailableStatus[ind]) {
                Console.WriteLine($"Thank you to return book {title}, Come again soon");
                AvailableStatus[ind] = true;
            } else {
                Console.WriteLine($"Sorry, Book {title} is not ours");
            }
        }
    }
}
