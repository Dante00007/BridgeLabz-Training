using System;
using System.Collections.Generic;
using System.Text;

namespace BookSelf {
    internal class BookList {
        private BookNode Head;

        public void AddbookNode(string bookName) {
            BookNode node = new BookNode(bookName);
            if (Head == null) {
                Head = node;
            } else {
                BookNode temp = Head;
                while (temp.Next != null) {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("Item added");
        }

        public void RemoveBookNode(string bookName) {
            
            if (Head == null) return;
            if (Head.Name == bookName) {
                BookNode temp = Head;
                Head = Head.Next;
                temp.Next = null;
            } else {
                BookNode temp = Head;
                while (temp.Next != null && temp.Next.Name != bookName) {
                    temp = temp.Next;
                }
                if (temp.Next != null) {
                    temp.Next = temp.Next.Next;
                    Console.WriteLine("Item removed");
                } else if (temp.Next == null) {
                    Console.WriteLine("Item not found");
                }
            }
        }

        public void DisplayBooksNode() {
            if (Head == null) {
                Console.WriteLine("No books found");
                return;
            }
            BookNode temp = Head;
            while (temp != null) {
                Console.WriteLine(temp.Name);
                temp = temp.Next;
            }
        }

    }
}
