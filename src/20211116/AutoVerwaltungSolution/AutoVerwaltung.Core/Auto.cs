using AutoVerwaltung.Core.Base;

namespace AutoVerwaltung.Core
{
    public class Auto : Fahrzeug
    {
        private FuelType _fuel;

        public Auto(string bezeichnung, VehicleType hersteller, int maxSpeed, FuelType fuelType)
            : base(bezeichnung, hersteller, maxSpeed)
        {
            _fuel = fuelType;
        }

        public FuelType Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public override string GetInfoString()
        {
            var infos = base.GetInfoString();
            infos += $"\nFuel Type: {_fuel}";

            return infos;
        }


    }
}
