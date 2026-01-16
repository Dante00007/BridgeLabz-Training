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

        private int Search(string firstName, string lastName) { 
            for (int i = 0; i < Contacts.Length; i++) {
                if (Contacts[i] != null && Contacts[i].FirstName.ToLower().Contains(firstName.ToLower()) && Contacts[i].LastName.ToLower( ).Contains(lastName.ToLower())) {
                    return i;
                }
            }
            return -1;
        }
        public bool CheckDuplication(string firstName, string lastName) { 
            for (int i = 0; i < Contacts.Length; i++) {
                if (Contacts[i] != null && Contacts[i].FirstName.ToLower().Contains(firstName.ToLower()) && Contacts[i].LastName.ToLower( ).Contains(lastName.ToLower())) 
                    return true;
            }
            return false;
        }
        public int AddContact() {
           Console.WriteLine("Enter the contact details");
            Console.Write("Enter the first name : ");
            string? firstName = Console.ReadLine();
            Console.Write("Enter the last name : ");
            string? lastName = Console.ReadLine();
            Console.Write("Enter the address : ");
            string? address = Console.ReadLine();
            Console.Write("Enter the city : ");
            string? phone = Console.ReadLine();
            Console.Write("Enter the state : ");
            string? city = Console.ReadLine();
            Console.Write("Enter the zip : ");
            string? zip = Console.ReadLine();
            Console.Write("Enter the phone number : ");
            string? state = Console.ReadLine();
            Console.Write("Enter the email : ");
            string? email = Console.ReadLine();

            if (CheckParameters(firstName, lastName, address, city, state, phone, email, zip)) {
                Console.WriteLine("Invalid input, Every field is required");
                return 0; 
            }
            if (CheckDuplication(firstName, lastName)) {
                Console.WriteLine("Contact already exists with same name");
                return 0;
            }
            Contact contact = new Contact(firstName, lastName, address, city, state, phone, email, zip);

            for (int i = 0; i < Contacts.Length; i++) {
                if (Contacts[i] == null) {
                    Contacts[i] = contact;
                    Console.WriteLine("Contact added successfully");
                    return 1;
                }
            }
            Console.WriteLine("Contact list is full");
            return 0;
        }

        public void EditContact() { 
            Console.WriteLine("Enter the contact details to be edited");
            Console.WriteLine("Enter the first name");
            string? firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            string? lastName = Console.ReadLine();

            int idx = Search(firstName, lastName);

            if (idx == -1) {
                Console.WriteLine("Contact not found");
                return;
            }
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
            Contacts[idx].Address = address;
            Contacts[idx].City = city;
            Contacts[idx].State = state;
            Contacts[idx].Phone = phone;
            Contacts[idx].Zip = zip;
            Contacts[idx].State = state;
            Contacts[idx].Email = email;
   
            Console.WriteLine("Contact edited successfully");
      
           
        }

        public void DeleteContact() {
            Console.WriteLine("Enter the first name");
            string? firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            string? lastName = Console.ReadLine();
            int idx = Search(firstName, lastName);

            if (idx == -1) {
                Console.WriteLine("Contact not found");
                return;
            }
            Contacts[idx] = null;
            Console.WriteLine("Contact deleted successfully");
        }
        public void AddMultipleContacts() {
            Console.WriteLine("Enter the number of contacts to be added");
            int count = Convert.ToInt32(Console.ReadLine());

            int check = -1;
            do {
                AddContact();
                count--;
            }while(count > 0 && check == 1);
        }
        public void DisplayContacts() {
            bool flag = false;
            for (int i = 0; i < Contacts.Length; i++) {
                if (Contacts[i] != null) {
                    flag = true;
                    Console.WriteLine(Contacts[i]);
                }
            }
            if (!flag) {
                Console.WriteLine("Contact list is empty");
            }
        }
    }
}

