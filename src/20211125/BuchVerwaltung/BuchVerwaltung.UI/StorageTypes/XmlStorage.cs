using BuchVerwaltung.UI.StorageTypes.XmlHelperTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BuchVerwaltung.UI.StorageTypes
{
    public class XmlStorage : IStorage
    {
        public IEnumerable<IBook> Load(string filename)
        {
            throw new NotImplementedException();
        }

        public bool Save(IEnumerable<IBook> dataToSave, string filename)
        {
            var items = new List<Item>();
            var xmlRoot = new ItemListRoot();

            foreach (var book in dataToSave)
            {
                var item = new Item
                {
                    Titel = book.Title,
                    Autor = book.Author,
                    Verlag = book.Publisher,
                    ErscheinungsJahr = book.YearOfPublishing.Year
                };

                items.Add(item);
            }

            xmlRoot.Item = items.ToArray();

            using (var sw = new StreamWriter(filename, false))
            {
                var serializer = new XmlSerializer(typeof(ItemListRoot));
                serializer.Serialize(sw, xmlRoot);
            }

            return true;
        }
    }
}
