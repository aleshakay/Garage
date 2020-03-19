using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Aircrafts
{
    class Airplane : Aircraft
    {
        public Airplane(int fuel, VehColor color, int passengerOccupancy)
        {
            Fuel = fuel;
            PassengerOccupancy = passengerOccupancy;
            Color = color;
        }

        public void SmoothFlight(string weather)
        {
            if (weather == "smooth")
            {
                Console.WriteLine("No turbulance!");
            }
            else
            {
                Console.WriteLine("Bumpy ride!");
            }
        }
    }
}
