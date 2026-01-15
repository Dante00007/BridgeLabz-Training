using System;
using System.Collections.Generic;
using System.Text;

namespace address_book {
    internal class Contact {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string phone;
        private string email;
        private string zip;

        public Contact(string firstName, string lastName, string address, string city, string state, string phone, string email, string zip) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.phone = phone;
            this.email = email;
            this.zip = zip;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Zip { get => zip; set => zip = value; }

        public override string ToString() {
            return $"Name : {FirstName} {LastName}\nAddress : {Address}\nCity : {City}\nState : {State}\nZip : {Zip}\nPhone : {Phone}\nEmail : {Email}";
        }
    }
}
