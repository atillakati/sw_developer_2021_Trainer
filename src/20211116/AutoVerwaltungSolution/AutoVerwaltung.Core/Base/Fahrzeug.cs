namespace AutoVerwaltung.Core.Base
{
    public class Fahrzeug
    {
        private int _currentSpeed;
        private int _maxSpeed;
        private string _bezeichnung;
        private VehicleType _marke;
        private Radio _soundMachine;

        public Fahrzeug(string bezeichnung)
            : this(bezeichnung, VehicleType.BadMobil, 160)
        {
        }

        public Fahrzeug(string bezeichnung, VehicleType marke, int maxSpeed)
        {
            //Init(bezeichnung, marke, maxSpeed);
            _soundMachine = new Radio(bezeichnung + "-Radio");
            _currentSpeed = 0;
            _maxSpeed = maxSpeed;
            _bezeichnung = bezeichnung;
            _marke = marke;
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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="delta"></param>
        public void SpeedUp(int delta)
        {
            if (delta + _currentSpeed <= _maxSpeed)
            {
                _currentSpeed += delta;
            }
        }

        public virtual string GetInfoString()
        {
            string output = $"{_bezeichnung} - {_marke}\n";
            output += $"{_currentSpeed} / {_maxSpeed} km/h";

            return output;
        }

        public void ChangeRadioState(PowerState newPowerState)
        {
            _soundMachine.ChangePower(newPowerState);
        }

        public void PlayMusik()
        {
            _soundMachine.MakeSound();
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