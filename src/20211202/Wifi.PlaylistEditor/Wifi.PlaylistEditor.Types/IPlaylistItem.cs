using System;
using System.Drawing;

namespace Wifi.PlaylistEditor.Types
{
    public interface IPlaylistItem : IFileIdentifier
    {
        string Title { get; }

        string Artist { get; }

        TimeSpan Duration { get; }

        string Path { get; }

        Image Thumbnail { get; }
    }
}