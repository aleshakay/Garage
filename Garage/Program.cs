using Garage.Aircrafts;
using Garage.Cars;
using Garage.Watercrafts;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            var boeing = new Airplane(200, VehColor.silver, 300);
            var heli = new Helicopters(100, VehColor.black, 8);
            var aircrafts = new List<Aircraft> { boeing, heli };
            foreach(var aircraft in aircrafts)
            {
                aircraft.Flying(4);
            }

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()
            var accord = new HondaCar(10, VehColor.pink, 4);
            var pilot = new HondaCar(20, VehColor.silver, 6);
            var cars= new List <Car> { accord, pilot };

            foreach (var car in cars)
            {
                car.Driving();
            }

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            var yamaha = new JetSki(25, VehColor.silver, 1);
            var topmaz = new JetSki(15, VehColor.blue, 2);
            var watercrafts = new List<Watercraft> { yamaha, topmaz };
            foreach (var watercraft in watercrafts)
            {
                watercraft.Driving(4);
            }
        }
    }
}
