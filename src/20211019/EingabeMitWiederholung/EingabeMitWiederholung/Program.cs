using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EingabeMitWiederholung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alter = 0;
            bool isInputValid = false;


            do
            {
                try
                {
                    Console.Write("Bitte das Alter eingeben: ");
                    alter = int.Parse(Console.ReadLine());

                    isInputValid = true;
                }
                catch
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    isInputValid = false;
                }
            }
            while (!isInputValid);

            Console.WriteLine($"Sie sind {alter} Jahre alt.");
        }
    }
}
