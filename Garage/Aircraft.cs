using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Aircraft : Vehicle
    {
        public virtual void Flying(int numberOfPassengers)
            {
                Console.WriteLine($"There are {numberOfPassengers} passengers currently in the aircraft");
                Landing();
            }

        public virtual void Landing()
        {
            Console.WriteLine($"The aircraft has landed");
        }
    }
}
