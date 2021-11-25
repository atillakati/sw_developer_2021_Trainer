using System.Collections.Generic;

namespace BuchVerwaltung.UI
{
    public interface IStorage
    {
        IEnumerable<IBook> Load(string filename);
        
        bool Save(IEnumerable<IBook> dataToSave, string filename);
    }
}
