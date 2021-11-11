using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVerwaltung
{
    public class Sportwagen : Auto
    {
        private int _ps;

        public Sportwagen(string bezeichnung, VehicleType hersteller, int maxSpeed, int ps)
            :base(bezeichnung, hersteller, maxSpeed, FuelType.Benzin)
        {
            _ps = ps;   
        }


        public int Ps
        {
            get { return _ps; }
            set { _ps = value; }
        }

    }
}
