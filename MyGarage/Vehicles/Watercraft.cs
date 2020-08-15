using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    class Watercraft : Vehicle
    {


        public Watercraft(string color, string name, string fuelCapacity, int passengerOccupancy)
        {
            Color = color;
            Name = name;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
        }

    }
}
