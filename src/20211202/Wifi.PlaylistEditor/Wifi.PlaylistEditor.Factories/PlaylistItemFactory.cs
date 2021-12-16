using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Items;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Factories
{
    public class PlaylistItemFactory : IPlaylistItemFactory
    {
        public IEnumerable<IFileIdentifier> AvailableTypes => new IFileIdentifier[] 
        { 
            new Mp3Item(string.Empty) ,
            new ImageItem(),
            //...
            //..
        };

        public IPlaylistItem Create(string filePath)
        {
            IPlaylistItem playlistItem = null;

            if (string.IsNullOrEmpty(filePath))
            {
                return null;
            }

            var extension = Path.GetExtension(filePath);
            switch (extension)
            {
                case ".mp3":
                    playlistItem = new Mp3Item(filePath);
                    break;

                case ".jpg":
                    playlistItem = new ImageItem(filePath);
                    break;
            }

            return playlistItem;
        }
    }
}
