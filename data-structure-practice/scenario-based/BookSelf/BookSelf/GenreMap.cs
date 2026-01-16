using System;
using System.Collections.Generic;
using System.Text;

namespace BookSelf {
    internal class GenreMap {
        private string[] keys;
        private BookList[] values;
        public GenreMap(int size) {
            keys = new string[size];
            values = new BookList[size];
        }

        private int GetIndex(string key) {
            for (int i = 0; i < keys.Length; i++) { 
                if (keys[i].Equals(key)) {
                    return i;
                }
            }
            return -1;
        }

        public void AddBook(string key, string book) {
            string tempKey = key.Trim().ToLower();

            int idx = GetIndex(tempKey);
            
            BookNode bookNode = new BookNode(book);
            if (idx == -1) {
                for (int i = 0; i < keys.Length; i++) {
                    if (keys[i] == null) {
                        keys[i] = tempKey;
                        BookList bookList = new BookList();
                        bookList.Addbook(bookNode);
                        values[i] = bookList;
                        break;
                    }
                }
            }
            else {
                values[idx].Addbook(bookNode);
            }
        }

        public BookList Get(string key) {
            string tempKey = key.Trim().ToLower();
            int idx = GetIndex(tempKey);
            if (idx == -1) {
                Console.WriteLine("Genre not found");
                return null;
            }
            return values[idx];
        }
    }
}
