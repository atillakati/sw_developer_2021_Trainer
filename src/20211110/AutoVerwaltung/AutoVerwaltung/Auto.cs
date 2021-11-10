namespace AutoVerwaltung
{
    public class Auto
    {
        private int _currentSpeed;
        private int _maxSpeed;
        private string _bezeichnung;
        private VehicleType _marke;
        

        public Auto(string bezeichnung)
        {
            Init(bezeichnung, VehicleType.Tesla, 160);
        }

        public Auto(string bezeichnung, VehicleType marke, int maxSpeed)
        {
            Init(bezeichnung, marke, maxSpeed);
        }      

        public VehicleType Marke
        {
            get { return _marke; }
        }

        public string Bezeichnung
        {
            get { return _bezeichnung; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _bezeichnung = value;
                }
            }
        }

        public int MaxSpeed
        {
            get { return _maxSpeed; }
        }

        public int CurrentSpeed
        {
            get { return _currentSpeed; }
        }


        public void SpeedUp(int delta)
        {
            if (delta + _currentSpeed <= _maxSpeed)
            {
                _currentSpeed += delta;
            }
        }

        public string GetInfoString()
        {
            string output = $"{_bezeichnung} - {_marke}\n";
            output += $"{_currentSpeed} / {_maxSpeed} km/h";

            return output;
        }


        private void Init(string bezeichnung, VehicleType marke, int maxSpeed)
        {
            _currentSpeed = 0;
            _maxSpeed = maxSpeed;
            _bezeichnung = bezeichnung;
            _marke = marke;
        }

    }
}