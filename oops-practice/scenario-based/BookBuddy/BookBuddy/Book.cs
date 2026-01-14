using System;
using System.Collections.Generic;
using System.Text;

namespace BookBuddy {
    internal class Book {
        private string TitleAndAuthor;
        private long Price;

        public Book(string titleAndAuthor,long price) {
            TitleAndAuthor = titleAndAuthor;
            Price = price;
        }

        public string GetTitleAndAuthor(){
            return TitleAndAuthor; 
        }
        public long GetPrice() {
            return Price;
        }

        public int CompareTo(Book other) {
            if (other == null) return 1;

            return string.Compare(this.TitleAndAuthor, other.TitleAndAuthor, StringComparison.OrdinalIgnoreCase);
        }
    }
}
