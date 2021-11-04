using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklaration
            PowerState status;

            //Initialisierung
            status = PowerState.Hibernate;

            Console.WriteLine($"Wert von Status: {status}");

            if(status == PowerState.Exploded)
            {
                return;
            }
            
        }
    }
}
