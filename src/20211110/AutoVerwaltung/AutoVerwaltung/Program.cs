
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVerwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCars = new Fahrzeug[]
            {
                new Auto("Manta Revision", VehicleType.Opel, 140, FuelType.Diesel),
                new Sportwagen("Super Drift Car v1", VehicleType.Audi, 200, 480),
                new Auto("Badmobil V3 Black Edition", VehicleType.BadMobil, 240, FuelType.Elektro),                
                new Fahrzeug("Super E-Auto"),
                new EScooter("Speedy", VehicleType.Xiaomi, 25, 360.0)
            };

            //int[] meineLottoZahlen = new int[] { 5, 8, 13, 22, 39, 40 };

            //DisplayCars(myCars);            

            Fahrzeug aCar = myCars[0];

            //aCar.SoundMachine.ChangePower(PowerState.On);
            //aCar.SoundMachine.MakeSound();

            var eineGanzeZahl = 0;
            var meinFahrzeug = new EScooter("", VehicleType.Audi, 2, 2);

            //var analyseDaten = mbox.GetData();
        }

        private static void DisplayCars(Fahrzeug[] carsToDisplay)
        {
            foreach (Fahrzeug car in carsToDisplay)
            {
                car.SpeedUp(80);
                Console.WriteLine(car.GetInfoString());
                Console.WriteLine();
            }
        }
    }
}
