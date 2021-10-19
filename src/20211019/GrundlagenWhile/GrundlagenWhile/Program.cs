using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GrundlagenWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl = 30;


            while(zahl < DateTime.Now.Second)
            {
                Console.WriteLine($"while: {DateTime.Now.Second}");
                Thread.Sleep(1000);
            }
           

            do
            {
                Console.WriteLine($"do-while: {DateTime.Now.Second}");
                Thread.Sleep(1000);
            }
            while (zahl < DateTime.Now.Second);


        }
    }
}
