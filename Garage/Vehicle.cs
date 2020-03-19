using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Vehicle
    {
        public int Fuel { get; set; }
        public VehColor Color { get; set; }
        public int PassengerOccupancy { get; set; }

        public virtual void Refuel(int amtOfFuel) // <-- method signature
        {
            Console.WriteLine($"There are {amtOfFuel}s of fuel in this vehicle.");
        }
    }
}
