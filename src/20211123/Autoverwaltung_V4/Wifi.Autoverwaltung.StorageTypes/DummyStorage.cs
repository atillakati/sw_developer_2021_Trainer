using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.Autoverwaltung.Core;
using Wifi.Autoverwaltung.VehicleTypes;

namespace Wifi.Autoverwaltung.StorageTypes
{
    public class DummyStorage : IStorageBase
    {
        public string Filename
        {
            get { return "dummy.car"; }
        }

        public IVehicleType[] Read()
        {
            var myVehicleList = new Fahrzeug[]
            {
                new Auto("Supermobil V8", VehicleType.Audi, 250, FuelType.Benzin),
                new Sportwagen("Henry 58", VehicleType.Opel, 150, 220),
                new EScooter("Roller 0815", VehicleType.Xiaomi, 30, 38.5)
            };

            return myVehicleList;
        }

        public bool Write(IVehicleType[] vehiclesToStore)
        {
            return true;
        }
    }
}
