using System;
using System.Collections.Generic;
using System.Text;

namespace BrowserBuddy {
    internal class BrowserTab {

        private SearchHistoryNode current;
        public BrowserTab(string intialUrl) {
            current = new SearchHistoryNode(intialUrl);
            Console.WriteLine("Tab created with url: " + intialUrl);
        }

        public void NavigateTo(string url) {
            SearchHistoryNode newNode = new SearchHistoryNode(url);
            current.Next = newNode;
            newNode.Prev = current;
            current = newNode;
            Console.WriteLine("Navigated to: " + url);
        }

        public void GoBack() {
            if (current != null && current.Prev != null) {
                current = current.Prev;
                Console.WriteLine("Navigated back to: " + current.Url);
            } else {
                Console.WriteLine("Cannot go back further.");
            }
        }
        public void GoForward() {
            if (current != null && current.Next != null) {
                current = current.Next;
                Console.WriteLine("Navigated forward to: " + current.Url);
            } else {
                Console.WriteLine("Cannot go forward further.");
            }
        }

        public string GetCurrentUrl() { 
            return current.Url;
        }
    }
}
