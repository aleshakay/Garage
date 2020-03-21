using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Watercrafts
{
    class JetSki :Watercraft
    {
        public JetSki(int fuel, VehColor color, int passengerOccupancy)
        {
            Fuel = fuel;
            PassengerOccupancy = passengerOccupancy;
            Color = color;
        }
    }
}
