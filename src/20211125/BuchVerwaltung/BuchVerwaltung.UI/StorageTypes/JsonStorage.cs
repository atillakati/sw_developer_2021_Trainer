using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace BuchVerwaltung.UI.StorageTypes
{
    public class JsonStorage : IStorage
    {
        public IEnumerable<IBook> Load(string filename)
        {
            string jsonString = string.Empty;

            using(var sr = new StreamReader(filename))
            {
                jsonString = sr.ReadToEnd();
            }

            var bookList = JsonConvert.DeserializeObject<IEnumerable<Book>>(jsonString);

            return bookList;
        }

        public bool Save(IEnumerable<IBook> dataToSave, string filename)
        {
            var jsonString = JsonConvert.SerializeObject(dataToSave);            

            using (var sw = new StreamWriter(filename, false))
            {
                sw.WriteLine(jsonString);
            }

            return true;    
        }
    }
}
