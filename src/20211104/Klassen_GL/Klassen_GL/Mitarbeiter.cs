using System;
using Wifi.ConsoleTools.Misc;

namespace Klassen_GL
{
    class Mitarbeiter
    {
        public Guid Id;

        public string Name;

        public Gender Geschlecht;

        public void ChangeName(string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                Name = newName;
            }
        }

        public void DisplayInfos()
        {
            Console.WriteLine($"    ID: [{Id}]");
            Console.WriteLine($"  Name: {Name}");
            Console.WriteLine($"Gender: {Geschlecht}");
        }
    }
}
