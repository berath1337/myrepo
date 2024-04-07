using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string VType { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }

        public Vehicle(int id, string vtype, int yearOfProduction, int batchNumber)
        {
            Id = id;
            VType = vtype;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNumber;

        }
        virtual public void  PrintVehicle()
        {
            Console.WriteLine($"ID: {Id}, Type: {VType}, Year of Production: {YearOfProduction}");
        }
    }
    
}
