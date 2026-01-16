using System;
using System.Collections.Generic;
using System.Text;

namespace BrowserBuddy {
    internal class Stack {
        private BrowserTab[] Tabs;
  
        private int Top;

        public Stack(int size) {
            Tabs = new BrowserTab[size];
            Top = -1;
        }

        public void Push(BrowserTab tab) {
            if (Top == Tabs.Length-1) {
                Console.WriteLine("Stack is full");
                return;
            }
            Top++;
            Tabs[Top] = tab;
        }
        public BrowserTab Pop() {
            if (Top == -1) {
                Console.WriteLine("Stack is empty");
                return null;
            }
            BrowserTab res = Tabs[Top];
            Top--;
            return res;
        }
        public BrowserTab Peek() {
            if (Top == -1) return null;
            return Tabs[Top];
        }

        public int Count() { 
            return Top+1;
        }


    }
}
