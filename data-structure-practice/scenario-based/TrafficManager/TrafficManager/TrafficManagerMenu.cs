using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficManager {
    internal class TrafficManagerMenu {
        public void Menu() { 

            TrafficManagerUtilityImpl tm = new TrafficManagerUtilityImpl();
            Console.WriteLine("----Traffic Manager----");
            Console.WriteLine("----Drive Safe----");

            int choice = -1;
            do {
                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. Remove Vehicle");
                Console.WriteLine("3. Current Traffic");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----Processing----");
                Console.WriteLine();
                switch (choice) {
                    case 1:
                        tm.AddVehicle();
                        break;
                    case 2:
                        tm.RemoveVehicle();
                        break; 
                    case 3:
                        tm.CurrentTraffic();
                        break;
                    case 0:
                        Console.WriteLine("----Exiting----");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine();
            } while (choice != 0);

        } 
    }
}
