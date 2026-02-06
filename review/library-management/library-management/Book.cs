using System;
using System.Collections.Generic;
using System.Text;

namespace library_management {
    internal class Book {
        private string Title;
        private string Author;
        private int Price;

        public Book(string title, string author,int price) {
            Title = title;
            Author = author;
            Price = price;
        }

        public void SetTitle(string title) {
            Title = title;
        }
        public string GetTitle() {
            return Title;
        }
        public string GetAuthor() {
            return Author;
        }
        public void SetAuthor(string author) {
            Author = author;
        }
        public int GetPrice() {
            return Price;
        }
        public void SetPrice(int price) {
            Price = price;
        }

        public override string ToString() {
            return $"Title : {Title} \nAuthor : {Author} \nPrice : {Price}";
        }
    }
}
