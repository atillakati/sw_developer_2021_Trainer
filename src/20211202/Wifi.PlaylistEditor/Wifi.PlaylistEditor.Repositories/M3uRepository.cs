using PlaylistsNET.Content;
using PlaylistsNET.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Repositories
{
    /// <summary>
    /// https://de.wikipedia.org/wiki/M3U
    /// </summary>
    public class M3uRepository : IRepository
    {
        public string Extension => ".m3u";

        public string Description => "M3U Playlist Format";


        public IPlaylist Load(string filePath)
        {
            var contentString = string.Empty;

            if (string.IsNullOrEmpty(filePath))
            {
                return null;
            }

            filePath = FixFilePathExtension(filePath);

            using (var stream = new StreamReader(filePath))
            {
                contentString = stream.ReadToEnd();
            }

            var content = new M3uContent();
            var m3uplaylist = content.GetFromString(contentString);

            //die Kommentare werden leider in einem Item abgelegt und nicht in der Playlist Ebene
            var comments = m3uplaylist.PlaylistEntries.SelectMany(e => e.Comments);
            if (!comments.Any())
            {
                return null;
            }

            var name = GetCommentValue<string>(comments, "Name: ");
            var autor = GetCommentValue<string>(comments, "Autor: ");
            var createDate = GetCommentValue<DateTime>(comments, "CreateDate: ");

            var playlist = new Playlist(name, autor, createDate);
            foreach (var m3uItem in m3uplaylist.PlaylistEntries)
            {
                //var item = //Instanz einer IPlaylistItem Implementierung, aber welche?
            }

            return playlist;
        }
      
        public bool Save(IPlaylist playlist, string filePath)
        {
            if (playlist == null || string.IsNullOrEmpty(filePath))
            {
                return false;
            }

            filePath = FixFilePathExtension(filePath);

            var m3uplaylist = new M3uPlaylist();
            m3uplaylist.IsExtended = true;

            m3uplaylist.Comments.Add($"Autor: {playlist.Author}");
            m3uplaylist.Comments.Add($"Name: {playlist.Name}");
            m3uplaylist.Comments.Add($"CreateDate: {playlist.CreateDate.ToString("yyyy-MM-dd")}");

            foreach (var item in playlist.Items)
            {
                var newM3uItem = new M3uPlaylistEntry
                {
                    AlbumArtist = item.Artist,
                    Title = item.Title,
                    Path = item.Path,
                    Duration = item.Duration,
                };

                m3uplaylist.PlaylistEntries.Add(newM3uItem);
            }

            var content = new M3uContent();
            var stringContent = content.ToText(m3uplaylist);

            using (var sw = new StreamWriter(filePath, false))
            {
                sw.WriteLine(stringContent);
            }

            return true;
        }


        private string FixFilePathExtension(string filePath)
        {
            var fi = new FileInfo(filePath);
            if (fi.Extension != Extension)
            {
                if (!string.IsNullOrEmpty(fi.Extension))
                {
                    filePath = filePath.Replace(fi.Extension, Extension);
                }
                else
                {
                    filePath = filePath + Extension;
                }
            }

            return filePath;
        }

        private T GetCommentValue<T>(IEnumerable<string> comments, string key)
        {
            T result = default(T);

            var value = comments.FirstOrDefault(x => x.StartsWith(key));
            if (value != null)
            {
                value = value.Replace(key, string.Empty);
                switch (typeof(T).Name)
                {
                    case "String":
                        result = (T)Convert.ChangeType(value, typeof(T));
                        break;

                    case "DateTime":
                        var convertedValue = DateTime.ParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                        result = (T)Convert.ChangeType(convertedValue, typeof(T));
                        break;
                }
            }

            return result;
        }
    }
}
