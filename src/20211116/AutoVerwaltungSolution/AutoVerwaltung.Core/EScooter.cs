using AutoVerwaltung.Core.Base;

namespace AutoVerwaltung.Core
{
    public class EScooter : Fahrzeug
    {
        private double _batKapacity;

        public EScooter(string bezeichnung, VehicleType marke, int maxSpeed, double batteryCap)
            : base(bezeichnung, marke, maxSpeed)
        {
            _batKapacity = batteryCap;
        }

        public double BatKapacity
        {
            get { return _batKapacity; }
            set { _batKapacity = value; }
        }

        public override string GetInfoString()
        {            
            return $"[{Marke}]{Bezeichnung.ToUpper()} - Batterie: {_batKapacity} kWh";
        }
        
    }
}
