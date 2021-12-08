
namespace Wifi.PlaylistEditor.Types
{
    public interface IRepository : IFileIdentifier
    {
        IPlaylist Load(string filePath);

        bool Save(IPlaylist playlist, string filePath);
    }
}
