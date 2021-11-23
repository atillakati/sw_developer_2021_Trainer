using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenTypArten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Buch b1 = new Buch();
            Buch b2 = new Buch();

            b1.Titel = "Test Buch No 1";
            b1.Preis = 15.80m;

            b2.Titel = "Die Nadel";
            b2.Preis = 35.20m;

            b1 = b2;
            b1.Titel = "Eine Änderung!";

            ConsoleKeyInfo info = Console.ReadKey();

            Buch meinBuch = null;

            //Vergleiche!
            //if(b1 == b2)
            //{

            //}

            Console.WriteLine($"Buch 1:\n\tTitel: {b1.Titel}\n\tPreis: {b1.Preis}");
            Console.WriteLine($"Buch 2:\n\tTitel: {b2.Titel}\n\tPreis: {b2.Preis}");

            DisplayData(b1);

        }

        private static void DisplayData(Buch bookToDisplay)
        {
            bookToDisplay.Titel = "2";
        }
    }
}
