using Wifi.ConsoleTools.Misc;

namespace Klassen_GL
{
    class Mitarbeiter
    {
        public string Name;

        public Gender Geschlecht;

        public void ChangeName(string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                Name = newName;
            }
        }
    }
}
