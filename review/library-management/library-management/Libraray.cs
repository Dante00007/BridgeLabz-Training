using System;
using System.Collections.Generic;
using System.Text;

namespace library_management {
    internal class Libraray {
        static void Main(string[] args) {
            Console.WriteLine("Maximum Number of books this library can hold");
            int sz = Convert.ToInt32(Console.ReadLine());
            LibraryUtilityImpl libUtil = new LibraryUtilityImpl(sz);

            int choice = -1;
            do {
                Console.WriteLine("1.To Add books");
                Console.WriteLine("2.To Search by title");
                Console.WriteLine("3.To Delete by title");
                Console.WriteLine("4.To Update book");
                Console.WriteLine("5.To Lend book");
                Console.WriteLine("6.To Return book");
                Console.WriteLine("0.To Exit");
                Console.Write("Your Choice :");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) {
                    case 1: libUtil.AddBook(); break;
                    case 2: libUtil.SearchByTitle(); break;
                    case 3: libUtil.Delete(); break;
                    case 4: libUtil.Update(); break;
                    case 5: libUtil.LendBook(); break;
                    case 6: libUtil.ReturnBook(); break;

                    case 0: break;
                    default: Console.WriteLine("Enter valid chice"); break;
                }
            }while(choice != 0);

        }
    }
}
