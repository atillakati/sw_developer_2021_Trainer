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
            Auto[] myCars = new Auto[]
            {
                new Auto("Manta Revision", VehicleType.Opel, 140),
                new Auto("Super Drift Car v1", VehicleType.Audi, 200),
                new Auto("Bodmobil V3 Black Edition", VehicleType.BadMobil, 240),
                new Auto("A6 Kombi Familienkutsche", VehicleType.Audi, 180),
                new Auto("Super E-Auto"),
                new EScooter("Speedy", VehicleType.Xiaomi, 25, 360.0)
            };

            //int[] meineLottoZahlen = new int[] { 5, 8, 13, 22, 39, 40 };

            DisplayCars(myCars);            
        }

        private static void DisplayCars(Auto[] carsToDisplay)
        {
            foreach (Auto car in carsToDisplay)
            {
                car.SpeedUp(80);
                Console.WriteLine(car.GetInfoString());
                Console.WriteLine();
            }
        }
    }
}
