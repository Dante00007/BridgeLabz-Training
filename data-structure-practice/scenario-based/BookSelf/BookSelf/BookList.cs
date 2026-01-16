using System;
using System.Collections.Generic;
using System.Text;

namespace BookSelf {
    internal class BookList {
        private BookNode Head;


        

        public void Addbook(BookNode node) {
           
            if (Head == null) {
                Head = node;
            } else {
                BookNode temp = Head;
                while (temp.Next != null) {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
        }

        public void RemoveBook() {
            Console.Write("Enter item ID to remove: ");
            string bookName = Console.ReadLine();
            if (Head == null) return;
            if (Head.Name == bookName) {
                Head = Head.Next;
            } else {
                BookNode temp = Head;
                while (temp.Next != null && temp.Next.Name != bookName) {
                    temp = temp.Next;
                }
                if (temp.Next != null) {
                    temp.Next = temp.Next.Next;
                } else if (temp.Next == null) {
                    Console.WriteLine("Item not found");
                }
            }
        }

    }
}
