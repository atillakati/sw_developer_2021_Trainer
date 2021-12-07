using System;
using System.Collections.Generic;


namespace Wifi.PlaylistEditor.Types
{
    public class Playlist : IPlaylist
    {
        private string _name;
        private string _author;
        private DateTime _createDate;
        private List<IPlaylistItem> _items;


        public Playlist(string name, string author)
            : this(name, author, DateTime.Now)
        {
        }

        public Playlist(string name, string author, DateTime createDate)
        {
            _name = name;
            _author = author;
            _createDate = createDate;

            _items = new List<IPlaylistItem>();
        }


        public string Name
        {
            get { return _name; }
        }

        public string Author
        {
            get { return _author; }
        }

        public DateTime CreateDate
        {
            get { return _createDate; }
        }

        public TimeSpan Duration
        {
            get
            {
                var duration = TimeSpan.Zero;
                foreach (var item in _items)
                {
                    duration = duration.Add(item.Duration);
                }

                return duration;
            }
        }


        public IEnumerable<IPlaylistItem> Items
        {
            get { return _items; }
        }


        public void Add(IPlaylistItem newItem)
        {
            if (newItem == null)
            {
                return;
            }

            _items.Add(newItem);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public void Remove(IPlaylistItem itemToRemove)
        {
            _items.Remove(itemToRemove);
        }
    }
}
