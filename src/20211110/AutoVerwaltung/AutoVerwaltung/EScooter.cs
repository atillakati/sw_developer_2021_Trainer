
namespace AutoVerwaltung
{
    public class EScooter : Auto
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

    }
}
