using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficManager {
    internal class VehicleNode {

        private int vehicleNumber;
        private VehicleNode next;
        public VehicleNode(int VehicleNumber) {
            this.vehicleNumber = VehicleNumber;
            next = this;
        }

        
        public VehicleNode Next {
            get => next; 
            set => next = value; 
        }
        public int VehicleNumber { 
           get => vehicleNumber;
           set => vehicleNumber = value;
        }
        public override string ToString() {
            return $"Vehicle :{VehicleNumber}";
        }
    }
}
