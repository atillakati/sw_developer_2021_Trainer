using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEingaben_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string geburtsJahrEingabe = string.Empty;
            int alter = 0;
            int geburtsJahr = 0;


            Console.Write("Bitte Name eingeben: ");
            name = Console.ReadLine();

            Console.WriteLine("\nHallo " + name + ", wie geht's?");

            Console.Write(name + ", bitte gib dein Geburtsjahr ein: ");
            geburtsJahrEingabe = Console.ReadLine();

            //Konvertierung Zeichenkette nach int
            geburtsJahr = int.Parse(geburtsJahrEingabe);

            //Alter vom User berechnen
            alter = DateTime.Now.Year - geburtsJahr;

            Console.WriteLine(name + ", du bist " + alter + " Jahre alt.");
        }
    }
}
