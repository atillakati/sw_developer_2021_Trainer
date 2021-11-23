using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.Autoverwaltung.Core;
using Wifi.Autoverwaltung.StorageTypes;
using Wifi.Autoverwaltung.VehicleTypes;

namespace Wifi.Autoverwaltung.UI
{
    internal class Program
    {
        static void Main()
        {            
            string filename = string.Empty;

            Console.Write("Bitte Dateiname mit Fahrzeugen eingeben: ");
            filename = Console.ReadLine();

            //storage objekt erzeugen
            StorageBase storage = new DummyStorage();

            var myVehicleList = storage.Read();
            if (myVehicleList.Length > 0)
            {
                CreatePriceList(myVehicleList, TimeSpan.FromHours(12));
            }

            //hier sollen/können nun neue Fahrzeugtypen erfasst werden

            var erg = storage.Write(myVehicleList);
            if (erg)
            {
                Console.WriteLine($"Daten wurden in Datei '{storage.Filename}' gespeichert.");
            }
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
