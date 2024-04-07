using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program.cs.Models
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> Countries { get; set; }

        public Car(int id, string vtype, int yearOfProduction, int batchNumber, int fuelTank, List<string> countries) : base(id, vtype, yearOfProduction, batchNumber)
        {
            FuelTank = fuelTank;
            Countries = countries;
        }

        public override void PrintVehicle()
        {
            Console.WriteLine($"Type:{VType}, Countries:{string.Join(",  ", Countries)}");
        }
    }
}
