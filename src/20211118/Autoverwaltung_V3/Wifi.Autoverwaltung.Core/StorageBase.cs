namespace Wifi.Autoverwaltung.Core
{
    public abstract class StorageBase
    {
        public abstract string Filename { get; }        


        public abstract bool Write(Fahrzeug[] vehiclesToStore);

        public abstract Fahrzeug[] Read();
    }    
}
