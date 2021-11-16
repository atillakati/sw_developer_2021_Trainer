using AutoVerwaltung.Core.Base;
using System;

namespace AutoVerwaltung.Core
{
    public class Auto : Fahrzeug
    {
        private FuelType _fuel;
        private decimal _pricePerHour;

        public Auto(string bezeichnung, VehicleType hersteller, int maxSpeed, FuelType fuelType)
            : base(bezeichnung, hersteller, maxSpeed)
        {
            _fuel = fuelType;
            _pricePerHour = 35.5m;
        }


        public FuelType Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public override decimal PricePerHour
        {
            get
            {
                return _pricePerHour;
            }
        }

        public override decimal CalculateRentCosts(TimeSpan rentDuration)
        {
            if(rentDuration.TotalDays < 1.0)
            {
                return PricePerHour * 24;
            } 

            //TotalDays = 2.78 Tage => 3 Tage werden bezahlt
            var daysToPay = rentDuration.Days;
            if(rentDuration.Hours > 0.0)
            {
                daysToPay++;
            }

            return daysToPay * 24 * PricePerHour;
        }

        public override string GetInfoString()
        {
            var infos = base.GetInfoString();
            infos += $"\nFuel Type: {_fuel}";

            return infos;
        }
        

    }
}
