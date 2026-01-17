using System;
using System.Collections.Generic;
using System.Text;

namespace BookSelf {
    internal class BookShelfMenu {

        public void Menu() {
            
            Console.WriteLine("\n----Welcome to BookShelf----\n");

            Manager manager = new Manager();

            int choice = -1;
            do {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Display Book");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("\n----Processing----\n");
                switch(choice) {
                    case 1:
                        manager.AddBook();
                        break;
                    case 2:
                        manager.RemoveBook();
                        break;
                    case 3:
                        manager.DisplayBook();
                        break;
                    case 0:
                        Console.WriteLine("----Exiting----");
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
