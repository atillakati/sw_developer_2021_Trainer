using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
             *  - ISBN
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
            string isbn = string.Empty;
            decimal preis = 0.0m;
            string dataline = string.Empty;
            string filename = string.Empty;

            do
            {
                UIHelper.PrintHeader("Buchverwaltung v1.0");
                Console.WriteLine("\nBitte geben Sie nun die Buchdaten ein(E für ENDE): ");

                //Buchdaten einlesen inkl. E für Abbruch der Eingabe
                titel  = UIHelper.GetString("\tTitel: ");
                if (titel == "E")
                {
                    break;
                }
                autor =  UIHelper.GetString("\tAutor: ");
                isbn = GetIsbn_10("\tISBN:  ");
                erscheinungsJahr = UIHelper.GetInt("\tErscheinungsjahr(yyyy): ");
                preis = UIHelper.GetDecimal("\tPreis (in Euro): ");

                //Datensatz string aus Buchdaten erzeugen
                dataline = CreateDataLine(titel, autor, erscheinungsJahr, isbn, preis);

                //Dateiname erzeugen
                filename = CreateFileName(titel);

                //Buchdaten in eine Datei speichern
                WriteDataToFile(dataline, filename);
                Console.WriteLine($"Daten wurden in die Datei '{filename}' geschrieben.");

                //check: sollen weitere Buchdaten erfasst werden? = Abbruchbedingung
            }
            while (CheckForFurtherBooks());

            //existierende Buchdaten einlesen und darstellen
            ReadAndDisplayFoundBookData();
        }


        static string GetIsbn_10(string inputPrompt)
        {
            bool inputIsValid = false;
            string inputValue = string.Empty;

            do
            {
                inputValue = UIHelper.GetString(inputPrompt);
                inputIsValid = IsbnValidator.TryValidate(inputValue);
            }
            while (!inputIsValid);

            return inputValue;
        }

        static void ReadAndDisplayFoundBookData()
        {
            string basePath = Assembly.GetEntryAssembly().Location;
            basePath = Path.GetDirectoryName(basePath);

            UIHelper.PrintHeader("Buchverwaltung v1.0");

            foreach (string bookFileName in Directory.GetFiles(basePath, "*.book"))
            {
                using(StreamReader sr = new StreamReader(bookFileName))
                {
                    if (sr.EndOfStream)
                    {
                        continue;
                    }
                    
                    DisplayBookData(sr.ReadLine());
                }
            }
        }

        static void DisplayBookData(string dataLine)
        {
            string[] parts;
            string titel = string.Empty;
            string autor = string.Empty;
            int erscheinungsJahr = 0;
            string isbn = string.Empty;
            decimal preis = 0.0m;

            parts = dataLine.Split(new char[] { ';' });

            titel = parts[0];
            autor = parts[1];
            isbn = parts[2];
            erscheinungsJahr = int.Parse(parts[3]);
            preis = decimal.Parse(parts[4]);

            UIHelper.PrintColoredMessage(titel, ConsoleColor.Yellow);            
            Console.Write($"({erscheinungsJahr})");
            Console.CursorLeft = 35;
            Console.Write($"     {autor}");
            Console.CursorLeft = 55;
            Console.Write($"     {isbn}");
            Console.CursorLeft = 75;
            Console.WriteLine($"     EUR {preis:f2}");
        }

        static bool CheckForFurtherBooks()
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

        static string CreateDataLine(string titel, string autor, int erscheinungsJahr, string isbn, decimal preis)
        {
            return $"{titel};{autor};{isbn};{erscheinungsJahr};{preis}";
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
