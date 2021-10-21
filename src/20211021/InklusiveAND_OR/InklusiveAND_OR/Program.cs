using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InklusiveAND_OR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Gandalf";
            string name2 = null;
            int charCount = 0;

            //if (name2 != null && name1 != null)
            //{
            //    charCount = name1.Length + name2.Length;
            //    Console.WriteLine($"Gesamtanzahl der Buchstaben: {charCount}");            
            //}

            name1 = null;

            if (name1 != null && name1.Length > 50)
            {

            }

            int zahl1 = 3;
            int zahl2 = 2;
            int zahl3 = 0;

            zahl3 = zahl1 + zahl2;

            //sieh auch https://docs.microsoft.com/en-us/cpp/c-language/precedence-and-order-of-evaluation?view=msvc-160
            if (zahl1 == 2 || zahl2 == 2 && zahl3 > 3)
            {

            }

            if ((zahl1 == 2 && zahl2 == 2) ||
                zahl3 > 3)
            {

            }




        }
    }
}
