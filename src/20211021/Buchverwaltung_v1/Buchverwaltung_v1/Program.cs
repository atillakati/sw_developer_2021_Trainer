using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.ConsoleTools;

namespace Buchverwaltung_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Die Applikation soll Buchdaten erfassen. Folgende Daten sollen 
             * dabei berücksichtigt werden:
             * 
             *  - Titel
             *  - Autor
             *  - Erscheinungsjahr
             *  - IBAN
             *  - Preis
             *  
             *  Dabei gilt:
             *  
             *  1. Verwende und schreibe Methoden!
             *  2. Realisiere fehlertolerante Eingaben!
             *  
             *  3. Speichere die Buchdaten in einer Datei, welcher so heisst wie der Titel
             *     Bsp: Buch Titel = "Die unendliche Geschichte" => DieunendlicheGeschichte.book
             *     
             *  4. Baue das Programm so um, dass der User beliebig viele Bücher eingeben kann und jedes
             *     Buch nach der Eingabe automatisch abgespeichert wird (als Datei).
             
             *  [Optional]
             *  5. Alle gespeicherten Bücher sollen eingelesen und dargestellt werden.
             *  */

            string titel = string.Empty;
            string autor = string.Empty;
            int erscheinungsJahr = 0;
            string iban = string.Empty;
            decimal preis = 0.0m;
            string dataline = string.Empty;
            string filename = string.Empty;

            do
            {
                UIHelper.PrintHeader("Buchverwaltung v1.0");
                Console.WriteLine("\nBitte geben Sie nun die Buchdaten ein: ");

                titel  = UIHelper.GetString("\tTitel: ");
                autor =  UIHelper.GetString("\tAutor: ");
                iban =   UIHelper.GetString("\tIBAN:  ");
                erscheinungsJahr = UIHelper.GetInt("\tErscheinungsjahr(yyyy): ");
                preis = UIHelper.GetDecimal("\tPreis (in Euro): ");

                dataline = CreateDataLine(titel, autor, erscheinungsJahr, iban, preis);

                filename = CreateFileName(titel);
                WriteDataToFile(dataline, filename);
                Console.WriteLine($"Daten wurden in die Datei '{filename}' geschrieben.");
            }
            while (CheckForFurtherBooks());

            Console.WriteLine();
        }

        private static bool CheckForFurtherBooks()
        {
            ConsoleKeyInfo keyInfo;
            bool inputIsValid = false;

            do
            {
                Console.Write("Wollen Sie Buchdaten eines weiteren Buches eingeben (j/n): ");
                keyInfo = Console.ReadKey(false);

                if (keyInfo.Key == ConsoleKey.J || keyInfo.Key == ConsoleKey.N)
                {
                    inputIsValid = true;
                }
                else
                {
                    inputIsValid = false;
                }
            }
            while (!inputIsValid);

            return keyInfo.Key == ConsoleKey.J;            
        }

        static string CreateDataLine(string titel, string autor, int erscheinungsJahr, string iban, decimal preis)
        {
            return $"{titel};{autor};{iban};{erscheinungsJahr};{preis}";
        }

        static string CreateFileName(string titel)
        {                        
            string filename = titel + ".book";
            filename = filename.Trim();
            filename = filename.Replace(" ", string.Empty);

            return filename;
        }

        static void WriteDataToFile(string dataline, string filename)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filename, false))
                {
                    sw.WriteLine(dataline);
                }
            }
            catch
            {
                UIHelper.PrintColoredMessage($"ERROR: Leider konnten die Daten nicht geschrieben werden: '{filename}'");
            }
        }
    }
}
