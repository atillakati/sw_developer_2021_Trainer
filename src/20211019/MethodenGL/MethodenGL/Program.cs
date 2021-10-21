using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodenGL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHelloWorld();

            string name = "Gandalf";

            PrintMessage("Test");

            PrintMessage(name);

            PrintColoredMessage("PAUSE!\n", ConsoleColor.Yellow);
            PrintColoredMessage("PAUSE!\n", ConsoleColor.Red);
            PrintColoredMessage("PAUSE!\n", ConsoleColor.Green);

            double gesamtGewicht = CalculateWeight(5, 1.3215);

            Console.WriteLine($"{gesamtGewicht}");
            //Console.WriteLine($"{CalculateWeight(50, 1.3215)}");

            PrintColoredMessage("Error: Hier ist was passiert.\n");
            PrintColoredMessage("Error: Hier ist was passiert.\n", ConsoleColor.Blue);            
        }

        //Signatur
        //RückgabeTyp MethodenBezeichnung(Parameter)
        static double CalculateWeight(int count, double weightPerPice)
        {
            double result = 0.0;

            result = weightPerPice * count;
            
            return result;     
        }


        /// <summary>
        /// Prints a red colored message with (no automatic newline) to default Output-Stream on the console.
        /// </summary>
        /// <param name="message">The message which should displayed</param>        
        static void PrintColoredMessage(string message)
        {
            PrintColoredMessage(message, ConsoleColor.Red);
        }

        /// <summary>
        /// Prints a colored message with (no automatic newline) to default Output-Stream on the console.
        /// </summary>
        /// <param name="message">The message which should displayed</param>
        /// <param name="messageColor">The color the provided message should be displayed in.</param>        
        static void PrintColoredMessage(string message, ConsoleColor messageColor)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = messageColor;

            Console.Write(message);
            
            Console.ForegroundColor = oldColor;
        }

        //Signatur
        //RückgabeTyp MethodenBezeichnung(Parameter)
        static void PrintMessage(string message)
        {
            message += " ©Atilla";
            Console.WriteLine(message);
        }

        //Signatur
        //RückgabeTyp MethodenBezeichnung(Parameter)
        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
