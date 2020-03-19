using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Cars
{
    class HondaCar : Car 
    {
        public HondaCar(int fuel, VehColor color, int passengerOccupancy)
        {
            Fuel = fuel;
            PassengerOccupancy = passengerOccupancy;
            Color = color;
        } 
    }
    
}
