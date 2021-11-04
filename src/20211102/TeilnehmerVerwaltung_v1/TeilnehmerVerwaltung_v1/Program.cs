using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeilnehmerVerwaltung_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[] listOfNames;

            //Eingabe der Anzahl von Teilnehmern
            Console.Write("Bitte Anzahl der Teilnehmer eingeben: ");
            count = int.Parse(Console.ReadLine());

            //Dimensionierung der Liste
            listOfNames = new string[count];

            //Eingabe der Daten
            for (int i = 0; i < count; i++)
            {
                Console.Write($"\tName Teilnehmer {i + 1}: ");
                listOfNames[i] = Console.ReadLine();
            }

            //Ausgabe der Daten
            foreach(string name in listOfNames)
            {               
                Console.WriteLine(name);
            }
        }
    }
}
