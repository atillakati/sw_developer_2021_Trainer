using System;
using System.Drawing;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Items
{
    public class ImageItem : IPlaylistItem
    {

        public ImageItem()
        {
            Path = string.Empty;
        }

        public ImageItem(string filePath)
        {
            Path = filePath;

            if (!string.IsNullOrWhiteSpace(filePath))
            {
                ReadImageTags();
            }
        }

        public event EventHandler ItemUpdated;

        private void ReadImageTags()
        {
            var tfile = TagLib.File.Create(Path);

            Title = tfile.Tag.Title;
            if (string.IsNullOrWhiteSpace(Title))
            {
                Title = System.IO.Path.GetFileName(Path);
            }

            Artist = tfile.Tag.FirstPerformer;
            if (string.IsNullOrWhiteSpace(Artist))
            {
                Artist = "Unknown";
            }

            Duration = TimeSpan.FromSeconds(10);

            var tmp = LoadImage();
            Thumbnail = tmp.Resize(128, 128);
        }

        public string Title { get; set; }
        public string Path { get; set; }
        public string Artist { get; set; }
        public Image Thumbnail { get; set; }
        public TimeSpan Duration { get; set; }

        public string Extension => ".jpg";

        public string Description => "JPG picture file";

        

        private Image LoadImage()
        {            
            return Image.FromFile(Path);
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
