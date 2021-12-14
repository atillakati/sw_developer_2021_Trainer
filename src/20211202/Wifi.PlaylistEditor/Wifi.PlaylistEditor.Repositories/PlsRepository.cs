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
    /// https://de.wikipedia.org/wiki/Pls
    /// </summary>
    public class PlsRepository : IRepository
    {
        private const string DATE_FORMAT_STRING = "yyyy-MM-dd";
        private const string NAME_COMMENT_KEY = "PLAYLIST-Name: ";
        private const string AUTHOR_COMMENT_KEY = "PLAYLIST-Autor: ";
        private const string CREATEDATE_COMMENT_KEY = "PLAYLIST-CreatedAt: ";
        private IPlaylistItemFactory _itemFactory;

        public PlsRepository(IPlaylistItemFactory itemFactory)
        {
            _itemFactory = itemFactory;
        }

        public string Extension => ".pls";            
        
        public string Description => "PLS Playlist Format";


        public IPlaylist Load(string filePath)
        {
            var contentString = string.Empty;

            if (string.IsNullOrEmpty(filePath))
            {
                return null;
            }

            filePath = FixFilePathExtension(filePath);
            
            //read file content and create a entity object
            using (var stream = new StreamReader(filePath))
            {
                contentString = stream.ReadToEnd();
            }
            var content = new PlsContent();
            var plsPlaylist = content.GetFromString(contentString);
            
            //convert
            IPlaylist playlist = MapToDomain(plsPlaylist, filePath);

            return playlist;
        }        

        public bool Save(IPlaylist playlist, string filePath)
        {
            if (playlist == null || string.IsNullOrEmpty(filePath))
            {
                return false;
            }

            filePath = FixFilePathExtension(filePath);

            //convert
            var plsPlaylist = MapToEntity(playlist);

            //create filecontent and write
            var content = new PlsContent();
            var stringContent = content.ToText(plsPlaylist);

            using (var sw = new StreamWriter(filePath, false))
            {
                sw.WriteLine(stringContent);
            }

            return true;
        }

        private IPlaylist MapToDomain(PlsPlaylist plsPlaylist, string fileName)
        {            
            var playlist = new Playlist(Path.GetFileNameWithoutExtension(fileName), "Wifi-PlaylistEditor");            

            foreach (var plsItem in plsPlaylist.PlaylistEntries)
            {            
                var item = _itemFactory.Create(plsItem.Path);
                if(item != null)
                {
                    playlist.Add(item);
                }
            }

            return playlist;
        }

        private static PlsPlaylist MapToEntity(IPlaylist playlist)
        {
            var plsPlaylist = new PlsPlaylist();
            int counter = 1;

            foreach (var item in playlist.Items)
            {
                var newPlsItem = new PlsPlaylistEntry
                {
                    Nr = counter++,
                    Title = item.Title,
                    Path = item.Path,
                    Length = item.Duration                   
                };

                plsPlaylist.PlaylistEntries.Add(newPlsItem);
            }

            return plsPlaylist;
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
                        var convertedValue = DateTime.ParseExact(value, DATE_FORMAT_STRING, CultureInfo.InvariantCulture);
                        result = (T)Convert.ChangeType(convertedValue, typeof(T));
                        break;
                }
            }

            return result;
        }
    }
}
