using System;
using System.Collections.Generic;
using System.Text;

namespace BookSelf {
    internal class BookShelfMenu {

        public void Menu() {
            
            Manager manager = new Manager();

            int choice = -1;
            do {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display Book");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("----Processing----");
                switch(choice) {
                    case 1:
                        manager.AddBook();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine();
            }while(choice != 0);
        }
    }
}
