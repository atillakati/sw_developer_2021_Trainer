
using System.Collections.Generic;

namespace Wifi.PlaylistEditor.Types
{
    public interface IPlaylistItemFactory
    {
        IEnumerable<IFileIdentifier> AvailableTypes { get; }

        IPlaylistItem Create(string filePath);
    }
}
