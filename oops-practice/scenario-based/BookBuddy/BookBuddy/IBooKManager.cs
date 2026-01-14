using System;
using System.Collections.Generic;
using System.Text;

namespace BookBuddy {
    internal interface IBooKManager {
        void AddBook(string title,string author,long price);
        void SortBooksAlphabetically();
        void SearchByAuthor(string author);
    }
}
