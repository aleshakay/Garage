using System;
using System.Collections.Generic;
using System.Text;

namespace Garage
{
    class Car : Vehicle
    {
        public virtual void Driving()
        {
            Console.WriteLine($"I am driving now");
        }

        public virtual void Braking()
        {
            Console.WriteLine($"The car has stopped");
        }
    }
}
