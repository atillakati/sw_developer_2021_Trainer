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
            PrintMessage(Console.ReadLine());

        }

        static void PrintMessage(string message)
        {
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
