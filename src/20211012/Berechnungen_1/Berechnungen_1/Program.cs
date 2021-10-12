using System;

namespace Berechnungen_1
{
    internal class Program
    {
        static void Main()
        {
            int laenge = 3;
            int breite = 5;
            int umfang = 0;

            //berechnung des umfanges
            umfang = (laenge + breite) * 2;            

            //Ausgabe der Ergebnisse
            Console.WriteLine("Der Umfang beträgt: " + umfang);
        }
    }
}
