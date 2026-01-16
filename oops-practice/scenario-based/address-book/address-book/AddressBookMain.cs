using System;
using System.Collections.Generic;
using System.Text;

namespace address_book {
    internal class AddressBookMain {
        static void Main(string[] args) {
            Console.WriteLine("Number of books to be created : ");
            int n = Convert.ToInt32(Console.ReadLine());
            AddressBook[] books = new AddressBook[n];

            Console.WriteLine("Each Book is represented by its Index : ");
            for (int i = 0; i < n; i++) {
                books[i] = new AddressBook();
            }

            int choice;
            do {
                Console.WriteLine("For exit enter -1 : ");
                Console.WriteLine($"Enter the index of book you want to work with (0 to {n-1}): ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice != -1) 
                    books[choice].OpenBook();
            }while( choice != -1 );
        }
    }
}
