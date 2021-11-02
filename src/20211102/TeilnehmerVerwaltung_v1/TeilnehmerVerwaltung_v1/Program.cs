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

            Console.Write("Bitte Anzahl der Teilnehmer eingeben: ");
            count = int.Parse(Console.ReadLine());

            listOfNames = new string[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write($"\tName Teilnehmer {i + 1}: ");
                listOfNames[i] = Console.ReadLine();
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Teilnehmer {i + 1}: {listOfNames[i]}");
            }

            foreach(string name in listOfNames)
            {               
                Console.WriteLine(name);
            }
        }
    }
}
