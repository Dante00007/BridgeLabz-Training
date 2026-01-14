using System;
using System.Collections.Generic;
using System.Text;

namespace BookBuddy {
    internal class BookBuddyMain {
        static void Main(string[] args) { 
            BookBuddyUtilityImpl bookBuddyUtilityImpl = new BookBuddyUtilityImpl(5);
            
            bookBuddyUtilityImpl.AddBook("The Alchemist","Paulo Coelho",300);
        }
    }
}
