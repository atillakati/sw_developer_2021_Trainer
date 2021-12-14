namespace Wifi.PlaylistEditor.Types
{
    public interface IRepositoryFactory
    {
        IRepository Create(string fileName);
    }
}