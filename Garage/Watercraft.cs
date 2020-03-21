using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Watercraft : Vehicle
    {
        public virtual void Driving(int numberOfPassengers)
        {
            Console.WriteLine($"There are {numberOfPassengers} riding down the ocean hitting waves in the in the Watercraft");
        }
    }
}
