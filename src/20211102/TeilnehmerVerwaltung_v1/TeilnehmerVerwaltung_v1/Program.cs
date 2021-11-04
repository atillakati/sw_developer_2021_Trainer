using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.ConsoleTools;


namespace TeilnehmerVerwaltung_v1
{
    internal class Program
    {
        /*
         * Teilnehmer Verwaltung v0.2
         * 
         *  - Name
         *  - Geburtsdatum
         *  - PLZ          
         * 
         */

        static void Main(string[] args)
        {
            int count = 0;
            Teilnehmer[] listOfAttendees;
          

            //Eingabe der Anzahl von Teilnehmern            
            count = UIHelper.GetInt("Bitte Anzahl der Teilnehmer eingeben: ");

            //Dimensionierung der Liste
            listOfAttendees = new Teilnehmer[count];

            //Eingabe der Daten
            for (int i = 0; i < count; i++)
            {
                listOfAttendees[i] = new Teilnehmer();

                Console.Write($"\tName Teilnehmer {i + 1}: ");
                listOfAttendees[i].Name = Console.ReadLine();
                listOfAttendees[i].GeburtsDatum = UIHelper.GetDateTime("Geburtsdatum: ");
                listOfAttendees[i].Plz = UIHelper.GetInt("Plz: ");
            }

            //Ausgabe der Daten
            foreach(Teilnehmer oneAttendee in listOfAttendees)
            {               
                Console.WriteLine($"{oneAttendee.Name} ({oneAttendee.GeburtsDatum.Year}) kommt aus {oneAttendee.Plz}");
            }
        }
    }
}
