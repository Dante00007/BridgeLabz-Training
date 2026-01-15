using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace address_book {
    internal class AddressBook {
        static void Main() {
            Contact contact = new Contact(
                    "Bhanu",
                    "Dagur",
                    "JADANA",
                    "Mathura",
                    "U.P",
                    "1234567890",
                    "9t5Qm@example.com",
                    "202148"
                );
            Console.WriteLine(contact);
        }
    }
}
