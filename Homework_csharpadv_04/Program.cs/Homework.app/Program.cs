using Program.cs.Models;
using System;

namespace Program.cs

{
    class Program
    {
        static void Main()
        {
           
            foreach (var vehicle in VehicleDB.Vehicles)
            {
                vehicle.PrintVehicle();
            }
            //Car and vehicle objects have missing inputs(firstObj and thirdObj)
            Console.WriteLine();
            Vehicle firstObject=VehicleDB.Vehicles[0];
            Validator.Validate(firstObject);
            Vehicle secondObject = VehicleDB.Vehicles[1];
            Validator.Validate(secondObject);
            Vehicle thirdObject = VehicleDB.Vehicles[2];
            Validator.Validate(thirdObject);
        }
        
    }
}
