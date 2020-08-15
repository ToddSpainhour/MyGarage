using System;
using System.Collections.Generic;




namespace MyGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my garage!");
            Console.WriteLine(new string('-', 75));





            // aircraft
            var helicopter = new Aircraft("green", "Black Hawk", "360 gallons", 13);
            var glider = new Aircraft("yellow", "Skylark 2", "0 gallons", 1);
            var blimp = new Aircraft("white", "Skyship", "682 gallons", 12);


            List<Aircraft> AllMyAircraft = new List<Aircraft>();

            AllMyAircraft.Add(helicopter);
            AllMyAircraft.Add(glider);
            AllMyAircraft.Add(blimp);


            foreach (Aircraft Aircraft in AllMyAircraft)
            {
                Aircraft.Fly();
            }

            Console.WriteLine(new string('-', 75));





            // cars
            var hondaCivic = new Car ("grey", "Civic", "12 gallon", 4);
            var mazda3 = new Car("dark blue", "Mazda hatchback", "14 gallon", 5);
            var bmw = new Car("white", "BMW  1 Series", "12 gallons", 4);


            List<Car> AllMyCars = new List<Car>();

            AllMyCars.Add(hondaCivic);
            AllMyCars.Add(mazda3);
            AllMyCars.Add(bmw);


            foreach (Car Car in AllMyCars)
            {
                Car.Drive();
            }

            Console.WriteLine(new string('-', 75));





            // watercraft
            var canoe = new Watercraft("brown", "outrigger", "0 gallons", 2);
            var jetski = new Watercraft("blue", "WaveRunner", "16 gallons", 2);
            var submarine = new Watercraft("black", "U-Boat", "fuel cells", 25);


            List<Watercraft> AllMyWatercraft = new List<Watercraft>();

            AllMyWatercraft.Add(canoe);
            AllMyWatercraft.Add(jetski);
            AllMyWatercraft.Add(submarine);


            foreach (Watercraft Watercraft in AllMyWatercraft)
            {
                Watercraft.Drive();
            }



            Console.ReadKey();
        }
    }
}
