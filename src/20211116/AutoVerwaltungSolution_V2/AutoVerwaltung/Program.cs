using AutoVerwaltung.Core;
using AutoVerwaltung.Core.Base;
using System;

namespace AutoVerwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define some cars
            var myVehicles = new Fahrzeug[]
            {
                new Auto("Tesla Model F", VehicleType.Tesla, 231, FuelType.Elektro),
                new EScooter("SuperRoller v2", VehicleType.Segway, 25, 15.987),
                new Sportwagen("KITT 2000", VehicleType.Opel, 180, 250)
                
            };

            //process them
            PowerOnMusicProvider(myVehicles);
            DisplayInfos(myVehicles);
            CreateTheBill(myVehicles, TimeSpan.FromHours(12.0));
        }

        static void CreateTheBill(Fahrzeug[] vehicleList, TimeSpan rentDuration)
        {
            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine($"{vehicle.Bezeichnung} - {vehicle.PricePerHour} EUR/h");
                Console.WriteLine($"Preis 1/2 Tag: {vehicle.CalculateRentCosts(rentDuration)} EUR");
                Console.WriteLine();
            }
        }

        private static void DisplayInfos(Fahrzeug[] vehicleList)
        {
            foreach (var vehicle in vehicleList)
            {                
                Console.WriteLine(vehicle.GetInfoString());
                Console.WriteLine();
            }
        }

        static void PowerOnMusicProvider(Fahrzeug[] vehicleList)
        {
            foreach (var vehicle in vehicleList)
            {
                vehicle.ChangeRadioState(PowerState.On);
            }
        }
    }
}
