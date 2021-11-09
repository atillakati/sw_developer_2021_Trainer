
using System;
using Wifi.ConsoleTools;
using Wifi.ConsoleTools.Misc;

namespace Klassen_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanzierung
            Mitarbeiter ma = new Mitarbeiter();

            ma.DisplayInfos();

            //Klasse / Object = Instanz
            ma.Name = "Gandalf";
            ma.Geschlecht = Gender.Male;
            ma.ChangeName("Gandalf der Graue");
            ma.Id = Guid.NewGuid();


            ma.Name = string.Empty;
            ma.DisplayInfos();            
        }
    }
}
