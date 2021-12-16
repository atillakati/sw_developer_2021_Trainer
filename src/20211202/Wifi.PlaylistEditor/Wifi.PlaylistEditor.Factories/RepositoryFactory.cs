using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Repositories;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Factories
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly IPlaylistItemFactory _playlistItemFactory;

        public RepositoryFactory(IPlaylistItemFactory playlistItemFactory)
        {
            _playlistItemFactory = playlistItemFactory;
        }

        public IEnumerable<IFileIdentifier> AvailableTypes => new IFileIdentifier[]
        {
            new M3uRepository(_playlistItemFactory),
            new PlsRepository(_playlistItemFactory)
        };

        public IRepository Create(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return null;
            }

            var extension = Path.GetExtension(fileName);

            return (IRepository)AvailableTypes.FirstOrDefault(x => x.Extension == extension);            
        }
    }
}
