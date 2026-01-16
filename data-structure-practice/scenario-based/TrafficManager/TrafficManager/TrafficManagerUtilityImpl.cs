using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficManager {
    internal class TrafficManagerUtilityImpl : ITrafficManager {
        private RoundAbout rb;
        private Queue queue;

        public TrafficManagerUtilityImpl() {
            this.rb = new RoundAbout(4);
            this.queue = new Queue(4);
        }


        public void AddVehicle() { 
            Console.Write("Enter the Vehicle nuber to be added : ");
            int vehicleNumber = Convert.ToInt32(Console.ReadLine());
            if (rb.AddVehicle(vehicleNumber)!=-1) {
                Console.WriteLine("Vehicle added");
                return;
            }
            Console.WriteLine("Roundabout is full");

            if (queue.Push(vehicleNumber) != -1) {
                Console.WriteLine($"Vehicle {vehicleNumber} added to queue");
                return;
            }
            Console.WriteLine("Queue is full, sorry prefer some other ways");
            
        }

        public void RemoveVehicle() {
            Console.Write("Enter the number of Vehicle to be removed : ");
            int vehicleNumber = Convert.ToInt32(Console.ReadLine());

            if (rb.RemoveVehicle(vehicleNumber) == -1) {
                Console.WriteLine("No vehicle removed from roundabout");
                return;
            }
            Console.WriteLine($"Vehicle {vehicleNumber} is removed");

            int waitingVehicle = queue.Pop();

            if (waitingVehicle == -1) {
                Console.WriteLine("No vehicle is waiting in Queue");
                return;
            }
            
            
            if(rb.AddVehicle(waitingVehicle)!=-1)
                Console.WriteLine($"Vehicle {waitingVehicle} is removed from queue and added to roundabout");
            else
                Console.WriteLine("Some error occured");

        }

        public void CurrentTraffic() { 
            rb.Display();
        }
    }
}
