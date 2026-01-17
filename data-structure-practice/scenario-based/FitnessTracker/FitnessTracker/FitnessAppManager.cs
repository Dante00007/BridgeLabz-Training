using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker {
    internal class FitnessAppManaer {
        private User[] users;

        public FitnessAppManaer(int numberOfUsers) { 
            users = new User[numberOfUsers];
          
        }

        private User CreateUser() {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter stepCount: ");
            int stepCount = Convert.ToInt32(Console.ReadLine());

            return new User(name, stepCount);
        }
        public void AddUser() {
            for (int i = 0; i < users.Length; i++) { 
                if(users[i] == null) 
                    users[i] = CreateUser();
            }
        }

        public void SortUsers() {

            for (int i = 0; i < users.Length-1; i++) { 
                bool swapped = false;
                for (int j = 0; j < users.Length - i- 1; j++) { 
                    if (users[j].StepCount < users[j + 1].StepCount) {
                        User temp = users[j];
                        users[j] = users[j + 1];
                        users[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) {
                    break;
                }
            }
        }

        public void DisplayRanks() {
            int rank = 1;
            foreach (User user in users) {
                if (user != null) {
                    Console.WriteLine(rank + ". " + user);
                    rank++;
                }
            }
        }
    }
}
