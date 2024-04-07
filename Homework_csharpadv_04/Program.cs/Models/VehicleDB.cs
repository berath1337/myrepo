using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Models
{
    public static class VehicleDB
    {
        public static List<Vehicle> Vehicles = new List<Vehicle>();
        static VehicleDB()
        {
            Vehicles.Add(new Car(0, "HatchBack",2015 ,0006, 50, new List<string> { "USA", "Canada" }));
            Vehicles.Add(new Bike(2, "Mountain Bike", 2006, 6898, "white"));
            Vehicles.Add(new Vehicle(6, "Boat", 0, 0009));
        }
    }

}
