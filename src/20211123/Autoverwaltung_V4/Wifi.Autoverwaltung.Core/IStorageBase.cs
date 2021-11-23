namespace Wifi.Autoverwaltung.Core
{
    public interface IStorageBase 
    {
        string Filename { get; }                
    
        bool Write(IVehicleType[] vehiclesToStore);

        IVehicleType[] Read();
    }
}
