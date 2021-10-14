using System;

namespace Exceptions_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int geburtsJahr = 0;
            int alter = 0;
            bool isInputValid = false;


            Console.Write("Bitte Geburtsjahr eingeben: ");

            try
            {              
                geburtsJahr = int.Parse(Console.ReadLine());
                isInputValid = true;
            }
            catch
            {
                Console.WriteLine("Ups! Leider ist was schief gegangen!");
                isInputValid = false;
            }

            if (isInputValid == true)
            {
                alter = DateTime.Now.Year - geburtsJahr;

                Console.WriteLine("Du bist " + alter + " Jahre alt.");
            }
        }
    }
}
