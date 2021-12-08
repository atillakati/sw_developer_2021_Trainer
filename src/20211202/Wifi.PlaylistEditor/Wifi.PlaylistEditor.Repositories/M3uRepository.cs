using System;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Repositories
{
    /// <summary>
    /// https://de.wikipedia.org/wiki/M3U
    /// </summary>
    public class M3uRepository : IRepository
    {
        public string Extension => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();


        public IPlaylist Load(string filePath)
        {
            throw new NotImplementedException();
        }


        public bool Save(IPlaylist playlist)
        {
            throw new NotImplementedException();
        }
    }
}
