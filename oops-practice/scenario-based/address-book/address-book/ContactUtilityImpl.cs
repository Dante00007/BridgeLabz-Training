using System;
using System.Collections.Generic;
using System.Text;

namespace address_book {
    internal class ContactUtilityImpl : IContactManager {
        private Contact[] Contacts;

        public ContactUtilityImpl(int size) {
            this.Contacts = new Contact[size];
        }

        public bool CheckParameters(string firstName, string lastName, string address, string city, string state, string phone, string email, string zip) {
            return firstName == null || lastName == null || address == null || city == null || state == null || phone == null || email == null || zip == null;
        }
        public void AddContact() {
           Console.WriteLine("Enter the contact details");
            Console.WriteLine("Enter the first name");
            string? firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            string? lastName = Console.ReadLine();
            Console.WriteLine("Enter the address");
            string? address = Console.ReadLine();
            Console.WriteLine("Enter the city");
            string? phone = Console.ReadLine();
            Console.WriteLine("Enter the state");
            string? city = Console.ReadLine();
            Console.WriteLine("Enter the zip");
            string? zip = Console.ReadLine();
            Console.WriteLine("Enter the phone number");
            string? state = Console.ReadLine();
            Console.WriteLine("Enter the email");
            string? email = Console.ReadLine();

            if (CheckParameters(firstName, lastName, address, city, state, phone, email, zip)) {
                Console.WriteLine("Invalid input, Every field is required");
                return;
            }

            Contact contact = new Contact(firstName, lastName, address, city, state, phone, email, zip);

            for (int i = 0; i < Contacts.Length; i++) {
                if (Contacts[i] == null) {
                    Contacts[i] = contact;
                    Console.WriteLine("Contact added successfully");
                    return;
                }
            }
            Console.WriteLine("Contact list is full");
        }
        public void DisplayContacts() {
            for (int i = 0; i < Contacts.Length; i++) {
                if (Contacts[i] != null) {
                    Console.WriteLine(Contacts[i]);
                }
            }
        }
    }
}

