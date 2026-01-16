using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace address_book {
    internal class AddressBookMenu {
        public void Menu() {
            IContactManager contactManager = new ContactUtilityImpl(10);
            Console.WriteLine("Read following instruction on how to use address book");
           

            int choice = -1;
            do {
                Console.WriteLine("1. Add contact");
                Console.WriteLine("2. Edit contact");
                Console.WriteLine("3. Delete contact");
                Console.WriteLine("4. Display contact");
                Console.WriteLine("5. Add Multiple contact");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice :");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----Processing-----");
                switch (choice) {
                    case 1:
                        contactManager.AddContact();
                        break;
                    case 2:
                        contactManager.EditContact();
                        break;
                    case 3:
                        contactManager.DeleteContact();
                        break;
                    case 4:
                        contactManager.DisplayContacts();
                        break;
                    case 5:
                        contactManager.AddMultipleContacts();
                        break;
                    case 0:
                        Console.WriteLine("...Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 0);
        }
    }
}
