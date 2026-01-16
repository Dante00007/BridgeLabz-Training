using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficManager {
    internal interface ITrafficManager {
        void AddVehicle();
        void RemoveVehicle();
        void CurrentTraffic();
    }
}
