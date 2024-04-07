using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Models
{
    public static class Validator
    {
        public static bool Validate(Vehicle vehicle)
        {
            if (vehicle.Id == 0 || string.IsNullOrEmpty(vehicle.VType) || vehicle.YearOfProduction == 0)
            {
                Console.WriteLine("Error: Invalid vehicle details.");
                return false;
            }
            Console.WriteLine("Inputs are valid");
            return true;
        }

    }
}
