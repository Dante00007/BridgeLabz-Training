using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficManager {
    internal class TrafficManagerMain {
        static void Main(string[] args) { 
            TrafficManagerMenu menu = new TrafficManagerMenu();
            menu.Menu();
        }
    }
}
