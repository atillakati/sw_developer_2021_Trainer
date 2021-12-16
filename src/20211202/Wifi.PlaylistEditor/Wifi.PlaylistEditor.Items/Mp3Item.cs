using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Items
{
    public class Mp3Item : IPlaylistItem
    {
        private readonly string _filePath;
        private string _title;
        private TimeSpan _duration;
        private string _artist;
        private Image _thumbnail;

        public Mp3Item(string filePath)
        {
            _filePath = filePath;

            if (File.Exists(_filePath))
            {
                ReadIdv3TagFromFile(_filePath);
            }
        }       

        public string Title => _title;

        public string Artist => _artist;

        public TimeSpan Duration => _duration;

        public string Path => _filePath;

        public Image Thumbnail => _thumbnail;

        public string Extension => ".mp3";

        public string Description => "MP3 Music File";

        private void ReadIdv3TagFromFile(string filePath)
        {
            var tfile = TagLib.File.Create(filePath);

            _title = tfile.Tag.Title;
            _duration = tfile.Properties.Duration;
            _artist = tfile.Tag.FirstPerformer;

            if (tfile.Tag.Pictures != null && tfile.Tag.Pictures.Length > 0)
            {
                //https://stackoverflow.com/questions/10247216/c-sharp-mp3-id-tags-with-taglib-album-art
                _thumbnail = Image.FromStream(new MemoryStream(tfile.Tag.Pictures[0].Data.Data));
            }
            else
            {
                _thumbnail = null;
            }
        }
    }
}
