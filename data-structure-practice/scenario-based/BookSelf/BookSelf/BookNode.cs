using System;
using System.Collections.Generic;
using System.Text;

namespace BookSelf {
    internal class BookNode {
        private string name;
        private BookNode? next;
        public BookNode(string name) {
            this.name = name;
            this.next = null;
        }

        public string Name { get => name; set => name = value; }
        public BookNode Next { get => next; set => next = value; }

        public override string ToString() {
            return $"Book Name: {Name}"; 
        }
    }
}
