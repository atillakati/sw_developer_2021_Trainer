using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int geburtsJahr;            

            //Deklaration
            int[] listeVonGeburtsjahren;

            //Dimensionierung
            listeVonGeburtsjahren = new int[20];

            //Initialisierung
            listeVonGeburtsjahren[0] = 5;
            listeVonGeburtsjahren[1] = 5;
            listeVonGeburtsjahren[2] = 5;
            listeVonGeburtsjahren[3] = 5;
            listeVonGeburtsjahren[4] = 5;
            listeVonGeburtsjahren[5] = 5;
            listeVonGeburtsjahren[6] = 5;

            for (int i = 0; i < listeVonGeburtsjahren.Length; i++)
            {
                listeVonGeburtsjahren[i] = 5;
            }

            Console.WriteLine(listeVonGeburtsjahren[2]);

        }
    }
}
