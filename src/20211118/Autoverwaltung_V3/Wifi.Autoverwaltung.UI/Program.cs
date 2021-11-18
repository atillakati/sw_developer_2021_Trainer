using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.Autoverwaltung.Core;
using Wifi.Autoverwaltung.VehicleTypes;

namespace Wifi.Autoverwaltung.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myVehicleList = new Fahrzeug[]
            {
                new Auto("Supermobil V8", VehicleType.Audi, 250, FuelType.Benzin),
                new Sportwagen("Henry 58", VehicleType.Opel, 150, 220),
                new EScooter("Roller 0815", VehicleType.Xiaomi, 30, 38.5)
            };

            CreatePriceList(myVehicleList, TimeSpan.FromHours(12));
        }

        private static void CreatePriceList(Fahrzeug[] vehicleList, TimeSpan duration)
        {
            Console.WriteLine("Preisliste:\n");

            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine($"{vehicle.Bezeichnung}\t Pro Stunde: {vehicle.PricePerHour} EUR");
                Console.WriteLine($"Preis 12h: {vehicle.CalculateRentCosts(duration)} EUR");
                Console.WriteLine(new string('-', Console.WindowWidth-1));
            }
        }
    }
}
