using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 10;

            //Initialisierung; Abbruchbedingung; Reinitialisierung
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Ausgabe mit {i}");
                Console.WriteLine($"Ausgabe mit {i}");
                Console.WriteLine($"Ausgabe mit {i}");
            }                                    
        }
    }
}
