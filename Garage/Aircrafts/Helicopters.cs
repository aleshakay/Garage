using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Aircrafts
{
    class Helicopters : Aircraft
    {
        public Helicopters(int fuel, VehColor color, int passengerOccupancy)
        {
            Fuel = fuel;
            PassengerOccupancy = passengerOccupancy;
            Color = color;
        }
        public void SmoothFlight(string weather)
        {
            Console.WriteLine("Always turbulance!");
        }
    }
}
