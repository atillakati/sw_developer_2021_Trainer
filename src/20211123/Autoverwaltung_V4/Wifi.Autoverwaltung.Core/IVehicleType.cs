using System;

namespace Wifi.Autoverwaltung.Core
{
    public interface IVehicleType
    {
        string Bezeichnung { get; set; }
        int CurrentSpeed { get; }
        VehicleType Marke { get; }
        int MaxSpeed { get; }
        decimal PricePerHour { get; }

        decimal CalculateRentCosts(TimeSpan rentDuration);
        void ChangeRadioState(PowerState newPowerState);
        string GetInfoString();
        void PlayMusik();
        void SpeedUp(int delta);
    }
}