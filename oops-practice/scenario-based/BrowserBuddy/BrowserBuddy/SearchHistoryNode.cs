using System;
using System.Collections.Generic;
using System.Text;

namespace BrowserBuddy {
    internal class SearchHistoryNode {
        private string url;
        private SearchHistoryNode next;
        private SearchHistoryNode prev;

        public SearchHistoryNode(string url) {
            this.url = url;
        }

        public string Url { get => url; set => url = value; }
        public SearchHistoryNode Next { get => next; set => next = value; }
        public SearchHistoryNode Prev { get => prev; set => prev = value; }

        public override string ToString() {
            return $"url {url}";
        } 
    }
}
