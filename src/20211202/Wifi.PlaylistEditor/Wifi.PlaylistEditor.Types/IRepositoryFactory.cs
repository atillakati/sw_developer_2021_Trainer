using System.Collections.Generic;

namespace Wifi.PlaylistEditor.Types
{
    public interface IRepositoryFactory
    {
        IEnumerable<IFileIdentifier> AvailableTypes { get; }

        IRepository Create(string fileName);
    }
}