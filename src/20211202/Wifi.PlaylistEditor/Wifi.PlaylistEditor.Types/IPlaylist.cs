using System;
using System.Collections.Generic;

namespace Wifi.PlaylistEditor.Types
{
    public interface IPlaylist
    {        
        string Name { get; }

        string Author { get; }

        DateTime CreateDate { get; }

        TimeSpan Duration { get; }

        IEnumerable<IPlaylistItem> Items { get; }


        void Add(IPlaylistItem newItem);

        void Remove(IPlaylistItem itemToRemove);

        void Clear();
    }
}
