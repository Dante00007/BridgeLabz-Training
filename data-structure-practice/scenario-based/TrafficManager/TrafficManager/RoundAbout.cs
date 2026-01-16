using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficManager {
    internal class RoundAbout {
        private VehicleNode? Head;
        private int Limit;
        private int Count;

        public RoundAbout(int limit) { 
            Head = null;
            Limit = limit;
            Count = 0;
        }
        public int AddVehicle(int vehicleNumber) {
            if (Count == Limit)
                return -1;
         
            VehicleNode vehicle = new VehicleNode(vehicleNumber);
            if (Head == null) {
                Head = vehicle;
            }

            VehicleNode? temp = Head;
            while (temp != null && temp.Next != Head)
                temp = temp.Next;
            temp.Next = vehicle;
            vehicle.Next = Head;
            Count++;
            return 1;
        }



        public int RemoveVehicle(int vehicleNumber) {
           
            if (Head == null || Count==0) {
                Console.WriteLine("No Vehicle available in Roundabout");
                return -1;
            }


            if (Head.Next == Head && Head.VehicleNumber == vehicleNumber) {
                Head = null;
                Count--;
                return 1;
            }
            else if (Head.VehicleNumber == vehicleNumber) {
                VehicleNode temp = Head;
                while (temp.Next != Head)
                    temp = temp.Next;
                temp.Next = Head.Next;
                temp = Head;
                Head = Head.Next;

                temp.Next = null;
                temp = null;
                Count--;
                return 1;
            } else {
                VehicleNode prev = null, temp = Head;
                while (temp.Next != Head && temp.VehicleNumber != vehicleNumber) {
                    prev = temp;
                    temp = temp.Next;
                }

                if (prev != null && temp != null && temp.VehicleNumber == vehicleNumber) {
                    prev.Next = temp.Next;
                    temp.Next = null;
                 
                    Count--;
                    return 1;
                } else {
                    Console.WriteLine($"Vehicle {vehicleNumber} Not Found");
                    Count--;
                    return -1;
                }
            }
        }

        public void Display() {
            if (Head == null) {
                Console.WriteLine("No Vehicle is available in Roundabout");
                return;
            }
            Console.WriteLine($"Total Vehicles :{Count}");
            
            VehicleNode temp = Head;
            do {
                Console.WriteLine(temp);
                temp = temp.Next;
            } while (temp != Head);
            
        }
 
        
    }
}
