using System;
using System.Collections.Generic;
using System.Text;

namespace BrowserBuddy {
    internal class BrowserMenu {
        public void Menu() {
            Browser browser = new Browser();

            int choice;
            do {
                Console.WriteLine("1.Open New Tab");
                Console.WriteLine("2.Close Tab");
                Console.WriteLine("3.Restore Tab");
                Console.WriteLine("4.Choose Current Tab");
                Console.WriteLine("5.Navigate to new Url in current Tab");
                Console.WriteLine("6.Navigate to next Url in current Tab");
                Console.WriteLine("7.Navigate to previous Url in current Tab");
                Console.WriteLine("8.Display all tabs");
                Console.WriteLine("9.Display current tab");
                Console.WriteLine("0.Close Browser");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n-----Processing-----\n");

                switch (choice) { 
                    case 1: browser.OpenNewTab();
                        break;
                    case 2: browser.CloseTab();
                        break;
                    case 3: browser.RestoreTab();
                        break;
                    case 4: browser.ChooseCurrentTab();
                        break;
                    case 5: browser.VistNewUrlInCurrentTab();
                        break;
                    case 6: browser.VisitNext();
                        break;
                    case 7: browser.VisitPrevious();
                        break;
                    case 8: browser.DisplayTabs();
                        break;
                    case 9:
                        browser.DisplayCurrentTab();
                        break;
                    case 0: Console.WriteLine("----Closing----");
                        break;
                    default: Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine();
            } while (choice != 0);
        }
    }
}
