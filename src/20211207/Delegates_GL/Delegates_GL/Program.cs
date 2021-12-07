using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_GL
{

    public delegate void MeinSuperDelegate();
    public delegate void MyFunction(string data);
    //public delegate double OperationDelegate(double z1, double z2);

    internal class Program
    {
        static void Main(string[] args)
        {
            //int zahl = 5;
            //MeinSuperDelegate eineMethode = HelloWorld;

            //eineMethode();

            //OperationDelegate op = Addition;

            //Console.WriteLine( op(15.2, 8.2) );

            //OperationDelegate[] operations = new OperationDelegate[]
            //{
            //    Addition,
            //    Multiplikation
            //};

            //Anonyme Methode
            //MeinSuperDelegate meinSuperDelegate = delegate
            //{
            //    Console.WriteLine("Dies ist ein Test");
            //};

            ////Lambda Expression
            //meinSuperDelegate = () => 
            //{
            //    Console.WriteLine("Dies ist ein kurzer Methoden-Test");
            //};

            ////Lambda Expression
            //meinSuperDelegate = () => Console.WriteLine("Dies ist eine sehr kurzer Methode..");

            //meinSuperDelegate();


            //Anonyme Methode
            MyFunction eineFunktion = delegate (string data)
            {
                var tmpData = data.ToLower();
                Console.WriteLine(tmpData);
            };

            eineFunktion("Hallo liebe Leute...");

            //Lambda Expression
            eineFunktion = (string data) =>
            {
                var tmpData = data.ToUpper();
                Console.WriteLine(tmpData);
            };

            eineFunktion("Hallo liebe Leute...");

            //Lambda Expression
            eineFunktion = x => Console.WriteLine(x);

            eineFunktion("Hallo liebe Leute...");


            // MAIN CONTENT IS HERE!
            int[] zahlenList = new[] { 1, 5, 6, 8, 9, 15, 22, 35, 42 };

            Console.WriteLine("Gerade Zahlen:");
            DisplaySpecificNumbersOnly(zahlenList, x => x % 2 == 0);

            Console.WriteLine("Zahlen > 10:");
            DisplaySpecificNumbersOnly(zahlenList, x => x > 10);
            
            Console.WriteLine("Ungerade Zahlen::");
            DisplaySpecificNumbersOnly(zahlenList, CheckOdd);
            // MAIN CONTENT IS HERE!
        }

        private static bool CheckOdd(int number)
        {
            return number % 2 != 0;
        }

        public delegate bool FilterDelegate(int number);

        static void DisplaySpecificNumbersOnly(IEnumerable<int> numberList, FilterDelegate filter)
        {
            foreach (var eineZahl in numberList)
            {
                if(filter(eineZahl))
                {
                    Console.WriteLine(eineZahl);
                }
            }
        }


        private static double Addition(double z1, double z2)
        {
            return z1 + z2;
        }

        private static double Multiplikation(double z1, double z2)
        {
            return z1 * z2;
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
