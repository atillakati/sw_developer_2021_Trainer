using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenBeispiel_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Entwickeln Sie eine kleine Personalverwaltung für ihr Unternehmen!
             * Folgende Daten pro Mitarbeiter sollen eingelesen werden:
             * 
             * - Vorname
             * - Nachname
             * - Geburtsdatum
             * - Sozialversicherungsnummer
             * 
             * Dabei gilt:
             * - Realisieren Sie für alle Eingaben eine fehlertolerante Variante 
             *   (keine Exceptions, Fehleingaben beenden die Applikation)
             * - Eingaben sollen wie ein Formular gestaltet werden, d.h. User sieht im alle 
             *   einzugebenden Felder im Voraus.
             * - Alle Daten sollen am Schluss formatiert ausgegeben werden
             * 
             * Screenmockup Eingabe:
             * 
             * ########################################################################
             *                          Personalverwaltung v0.1
             * ########################################################################
             * 
             * Bitte geben Sie ein:
             * 
             *          Vorname: _
             *         Nachname:
             *     Geburtsdatum:
             *      Sozialv.Nr.:
             *      
             * Hints:
             * Console.Clear();
             * Console.SetCursorPosition(x, y); ODER Console.CursorLeft = 15;
             * 
             * 
             * Screenmockup Ausgabe:
             * 
             * ########################################################################
             *                          Personalverwaltung v0.1
             * ########################################################################
             * 
             *  Gandalf DERWEISE
             *  15.04.1915
             *  3216 15041915
             */

            string vorname = string.Empty;
            string nachname = string.Empty;
            DateTime gebDatum = DateTime.MinValue;
            int sozialVersNr = 0;
            const string header = "Personalverwaltung v0.1";
            int xPos = 0;
            bool isInputValid = false;

            //Eingabe Screen ausgeben
            Console.Clear();
            Console.WriteLine(new string('#', Console.WindowWidth - 1));
            xPos = Console.WindowWidth / 2 - header.Length / 2;
            Console.CursorLeft = xPos;
            Console.WriteLine(header);
            Console.WriteLine(new string('#', Console.WindowWidth - 1));

            Console.WriteLine("\nBitte geben Sie ein:");
            Console.WriteLine("\n\t\t     Vorname: __________________");
            Console.WriteLine("\t\t    Nachname: __________________");
            Console.WriteLine("\t\tGeburtsdatum: __________________");
            Console.WriteLine("\t\t  Sozialv.Nr: ____");

            //Daten einlesen
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(30, 6);
            vorname = Console.ReadLine();

            Console.SetCursorPosition(30, 7);
            nachname = Console.ReadLine();

            try
            {
                Console.SetCursorPosition(30, 8);
                gebDatum = DateTime.Parse(Console.ReadLine());

                Console.SetCursorPosition(30, 9);
                sozialVersNr = int.Parse(Console.ReadLine());

                isInputValid = true;
            }
            catch
            {
                Console.WriteLine("\aERROR: Leider fehlerhafte Eingabe entdeckt. Versuchen Sie es nochmal!");
                isInputValid = false;
            }

            if (!isInputValid)
            {
                return;
            }

            //Ausgabe der Daten
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine(new string('#', Console.WindowWidth - 1));
            xPos = Console.WindowWidth / 2 - header.Length / 2;
            Console.CursorLeft = xPos;
            Console.WriteLine(header);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + vorname + " " + nachname.ToUpper());
            Console.WriteLine($"\n{vorname} {nachname.ToUpper()}");

            Console.WriteLine(gebDatum.ToShortDateString());
            //Console.WriteLine(sozialVersNr + " " + gebDatum.Day + gebDatum.Month + gebDatum.Year);
            //Console.WriteLine($"{sozialVersNr} {gebDatum.Day}{gebDatum.Month}{gebDatum.Year}");
            //Console.WriteLine($"{sozialVersNr} {gebDatum.ToString("ddMMyy")}");
            
            string ausgabe = $"{sozialVersNr} {gebDatum.ToString("ddMMyy")}";
            Console.WriteLine(ausgabe);

            Console.ResetColor();
        }
    }
}
