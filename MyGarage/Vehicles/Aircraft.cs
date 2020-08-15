using System;


namespace MyGarage
{
    class Aircraft : Vehicle
    {




        public Aircraft(string color, string name, string fuelCapacity, int passengerOccupancy)
        {
            // the capitalized one must be on left...ask why.

            Name = name;
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
         }







        public void Fly()
        {
            Console.WriteLine($"Can anyone fly a {Name}?");
        }


        public void Land()
        {
            Console.WriteLine($"We need to land and get {FuelCapacity} worth of gas.");
        }



    }
}
