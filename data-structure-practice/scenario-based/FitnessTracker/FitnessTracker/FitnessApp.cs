using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker {
    internal class FitnessApp {

        public void ShowApp() {
            Console.WriteLine("Welcome to Fitness Tracker App");
            Console.Write("Enter the number of users: ");
            int n = Convert.ToInt32(Console.ReadLine());
            FitnessAppManaer manager = new FitnessAppManaer(n);
            for (int i = 0; i < n; i++) {
                manager.AddUser();
            }


            manager.SortUsers();
            manager.DisplayRanks();
        }
    }
}
