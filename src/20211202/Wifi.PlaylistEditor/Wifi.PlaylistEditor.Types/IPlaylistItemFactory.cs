
namespace Wifi.PlaylistEditor.Types
{
    public interface IPlaylistItemFactory
    {
        IPlaylistItem Create(string filePath);
    }
}
