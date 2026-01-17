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
                if (keys[i] != null && keys[i].Equals(key)) {
                    return i;
                }
            }
            return -1;
        }

        public void Add(string key, string bookName) {
            string tempKey = key.Trim().ToLower();

            int idx = GetIndex(tempKey);
            

            if (idx == -1) {
                for (int i = 0; i < keys.Length; i++) {
                    if (keys[i] == null) {
                        keys[i] = tempKey;

                        BookList bookList = new BookList();
                        bookList.AddbookNode(bookName);
                        values[i] = bookList;

                        Console.WriteLine("Book added successfully");
                        break;
                    }
                }
            }
            else {
                values[idx].AddbookNode(bookName);
            }
        }

        public void Get(string key) {
            string tempKey = key.Trim().ToLower();
            int idx = GetIndex(tempKey);
            if (idx == -1) {
                Console.WriteLine("Genre not found");
                return;
            }
            Console.WriteLine("Genre : " + key);
            values[idx].DisplayBooksNode();
        }

        public void Remove(string key,string bookName) {
            string tempKey = key.Trim().ToLower();
            int idx = GetIndex(tempKey);
            if (idx == -1) {
                Console.WriteLine("Genre not found");
                return;
            }
            values[idx].RemoveBookNode(bookName);
        }
    }
}
