using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Vehicle
    {

        public string Name { get; set; }
        public string FuelCapacity { get; set; }
        public string Color { get; set; }
        public int PassengerOccupancy { get; set; }
        


        public void Refuel()
        {
            Console.WriteLine($"Time to refuel my {Color} {Name}. It's got a {FuelCapacity} tank. It can fit up to {PassengerOccupancy} people.");
        }

        public void Drive()
        {
            Console.WriteLine($"Wanna take this {Name} for a spin?");
        }


    }
}
