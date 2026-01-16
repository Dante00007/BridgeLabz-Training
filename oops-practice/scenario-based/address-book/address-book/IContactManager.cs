using System;
using System.Collections.Generic;
using System.Text;

namespace address_book {
    internal interface IContactManager { 
       
        void DisplayContacts();

        void AddContact();
        void EditContact();
        void DeleteContact();
    }
}
