using AutoVerwaltung.Core.Base;

namespace AutoVerwaltung.Core
{
    public class Sportwagen : Auto
    {
        private int _ps;

        public Sportwagen(string bezeichnung, VehicleType hersteller, int maxSpeed, int ps)
            : base(bezeichnung, hersteller, maxSpeed, FuelType.Benzin)
        {
            _ps = ps;
        }

        public int Ps
        {
            get { return _ps; }
            set { _ps = value; }
        }

        public override string GetInfoString()
        {
            var infos = "(*)" + base.GetInfoString();
            infos += $"\nPS: {_ps}";

            return infos;
        }

        public override decimal PricePerHour
        {
            get
            {
                return 1.2m * base.PricePerHour;
            }
        }
    }
}
