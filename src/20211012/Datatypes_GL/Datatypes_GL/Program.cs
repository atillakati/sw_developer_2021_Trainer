using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datentyp Variablenbezeichnung
            //Deklaration
            int eineZahl;

            //Initialisierung
            eineZahl = 5;

            Console.WriteLine(eineZahl);
            Console.WriteLine("int-Min: " + int.MinValue);
            Console.WriteLine("int-Max: " + int.MaxValue);

            //Datentyp Variablenbezeichnung
            //Deklaration & Initialisierung
            string name = "\"Gandalf\" /(%&/%&3216\\543215";
            name = @"C:\myCode\Repos\sw_developer_2021_Trainer\src";

            Console.WriteLine(name);
            Console.WriteLine("Anzahl der Zeichen: " + name.Length);

            double gewicht = 0.0;

            Console.WriteLine("Das Gewicht ist: " + gewicht + "kg");

            decimal meinBudget = 455.3215m;
            Console.WriteLine(meinBudget);

            bool isPowerOn = true;

        }
    }
}
