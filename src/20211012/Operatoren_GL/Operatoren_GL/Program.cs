using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatoren_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arithmetische Operatoren
            //+ - * /
            // % = Restwertdivision (Modulo)
            int z1 = 0;
            int z2 = 0;
            int z3 = 0;

            double radius = 15.321;
            double umfangKreis = 0.0;
            
            umfangKreis = 2 * radius * Math.PI;


            //z3 = z1 + 654.22;

            //vergleichs-Operatoren
            // < > >= <=
            // ==  !=
            bool erg = false;
            erg = z2 == z1;

            //binäre Operatoren
            // & |  && || !

            //zusammengesetzte Operatoren
            int einZahl = 5;

            einZahl = einZahl + 5;
            einZahl += 5;
            einZahl -= 8;
            einZahl *= 2;
            einZahl /= 3;

            einZahl += 1;

            //inkrementieren
            einZahl++;
            //dekrementieren
            einZahl--;


        }
    }
}
