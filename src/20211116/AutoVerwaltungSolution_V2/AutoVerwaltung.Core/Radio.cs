using AutoVerwaltung.Core.Base;
using System;


namespace AutoVerwaltung.Core
{
    class Radio
    {
        private string _bezeichnung;
        private PowerState _power;

        public Radio(string bezeichnung)
        {
            _bezeichnung = bezeichnung;
            _power = PowerState.Off;
        }

        public PowerState Power
        {
            get { return _power; }
        }

        public string Bezeichnung
        {
            get { return _bezeichnung; }
        }

        public void ChangePower(PowerState newPowerState)
        {
            _power = newPowerState;
        }

        public void MakeSound()
        {
            if (_power == PowerState.On)
            {
                Console.WriteLine($"Das Radio {_bezeichnung} spielt Musik..");
            }
        }
    }
}
