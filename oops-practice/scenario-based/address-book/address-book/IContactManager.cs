using System;
using System.Collections.Generic;
using System.Text;

namespace address_book {
    internal interface IContactManager { 
       
        void DisplayContacts();

        int AddContact();
        void EditContact();
        void DeleteContact();
        void AddMultipleContacts();
        bool CheckDuplication(string firstName, string lastName);
    }
}
