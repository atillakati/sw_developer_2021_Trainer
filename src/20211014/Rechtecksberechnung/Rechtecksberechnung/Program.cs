using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechtecksberechnung
{
    internal class Program
    {
        static void Main(string[] args)      
        {
            /*
             * Schreiben Sie eine Applikation, mit der der Umfang eines beliebigen Rechtecks
             * berechnet werden kann.
             * Dazu soll die Applikation die Seitenlängen vom User einlesen und anschliessend
             * den Umfang berechnen.
             * Ausgabe Ergebnis (Umfang) inklusive den Seitenlängen, schön formatiert.
             *             
             * */

            double seitenA = 0.0;
            double seitenB= 0.0;
            double umfang = 0.0;
            string eingabe = string.Empty;

            Console.WriteLine("Geben Sie die Seitenlängen ein:");

            //Eingabe der Seitenlänge A            
            Console.Write("\tSeite a: ");
            eingabe = Console.ReadLine();
            seitenA = double.Parse(eingabe);

            //Eingabe der Seitenlänge B
            Console.Write("\tSeite b: ");
            eingabe = Console.ReadLine();
            seitenB = double.Parse(eingabe);

            //Berechnung Umfang
            umfang = 2 * (seitenA + seitenB);

            //Ausgabe Ergebnisse
            Console.WriteLine("\nDer Umfang für das Rechteck mit:");
            Console.WriteLine("\tLänge: " + seitenA);
            Console.WriteLine("\tBeite: " + seitenB);
            Console.WriteLine("beträgt " + umfang + ".");
        }
    }
}
