using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace address_book {
    internal class AddressBook {
        public void OpenBook() {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBookMenu ab = new AddressBookMenu();
            ab.Menu();
        }
    }
}
