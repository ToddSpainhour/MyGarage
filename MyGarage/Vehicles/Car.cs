using System;


namespace MyGarage
{
    class Car : Vehicle
    {
        
 
        public Car(string color, string name, string fuelCapacity, int passengerOccupancy)
        {
            // the capitalized one must be on left...ask why.

            Color = color;
            Name = name;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
        }



        public void Brake()
        {
            Console.WriteLine("Hit the brakes!");
        }





    }
}
