using System;
using System.Collections.Generic;
using System.Text;

namespace BrowserBuddy {
    internal class Browser : IBrowser {
        private Stack closedTabs;
        private BrowserTab[] Tabs;
        private BrowserTab currentTab;
        public Browser() {
            closedTabs = new Stack(20);
            Tabs = new BrowserTab[20];
            currentTab = null;
        }

        public void OpenNewTab() { 
            Console.Write("Opened new tab. Enter Url: ");
            string url = Console.ReadLine();

            BrowserTab tab = new BrowserTab(url);
            
            for (int i = 0; i < Tabs.Length; i++) {
                if (Tabs[i] == null) {
                    Tabs[i] = tab;
                    Console.WriteLine($"Opened tab: {url}");
                    currentTab = tab;
                    return;
                }
            }
            
            Console.WriteLine("No more cane be opened.");
        }
        public void CloseTab() {
            DisplayTabs();
            Console.WriteLine("0 to cancel: ");
            int choice = -1;
            do {
                Console.Write("Enter tab number to close: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice > 0 && choice <= Tabs.Length) { 
                    BrowserTab tab = Tabs[choice - 1];
                    Tabs[choice - 1] = null;
                    if (currentTab == tab) 
                        currentTab = null;
                    closedTabs.Push(tab);
                    Console.WriteLine($"Closed tab: {tab.GetCurrentUrl()}");
                }
            }while(choice != 0);
            if (currentTab == null) {
                ChooseCurrentTab();
            }
        }

        public void RestoreTab() {
            if (closedTabs.Count() > 0) {
                for (int i = 0; i < Tabs.Length; i++) {
                    if (Tabs[i] == null) {
                        BrowserTab restored = closedTabs.Pop();
                        Console.WriteLine($"Restored tab: {restored.GetCurrentUrl()}");
                        Tabs[i] = restored;
                        return;
                    }
                }

            } else {
                Console.WriteLine("No tabs to restore.");
            }
            Console.WriteLine("No more space to restoration");
        }

          public void ChooseCurrentTab() {
            DisplayTabs();

            Console.WriteLine("0 if no tab is available: ");
            Console.Write("Current tab number: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice > 0 && choice <= Tabs.Length)
                currentTab = Tabs[choice - 1];
            else
                currentTab = null;
          }

        public void VistNewUrlInCurrentTab() { 
           if (currentTab != null) {
                Console.Write("Enter next url:");
                string url = Console.ReadLine();
                currentTab.NavigateTo(url);
            } else {
                Console.WriteLine("No tab selected");}
        }

        public void VisitNext() {
            if (currentTab != null) 
                currentTab.GoForward();
            else 
                Console.WriteLine("No tab selected");
        }
        public void VisitPrevious() {
            if (currentTab != null)
                currentTab.GoBack();
            else
                Console.WriteLine("No tab selected");
        }

        public void DisplayCurrentTab() {
            if (currentTab != null)
                Console.WriteLine($"Current tab: {currentTab.GetCurrentUrl()}");
            else
                Console.WriteLine("No tab selected");
        }
        public void DisplayTabs() {
            for (int i = 0; i < Tabs.Length; i++) {
                if (Tabs[i] != null) {
                    Console.WriteLine($"{i + 1}. {Tabs[i].GetCurrentUrl()}");
                }
            }
        }
    }
}
