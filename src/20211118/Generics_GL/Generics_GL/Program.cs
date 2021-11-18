using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_GL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var elementCount = 50;
            var initValue = -1;

            int[] meineZahlen;

            meineZahlen = InitArray<int>(5, 0);
            var namen = InitArray<string>(5, "test");
            var datumswerte = InitArray<DateTime>(5, DateTime.MaxValue);
        }

        static T[] InitArray<T>(int elementCount, T initValue) 
        {
            T[] tmpArray = new T[elementCount];
            
            for (int i = 0; i < tmpArray.Length; i++)
            {
                tmpArray[i] = initValue;
            }

            return tmpArray;
        }

        private static string[] InitStringArray(int elementCount, string initValue)
        {
            string[] tmpArray = new string[elementCount];


            for (int i = 0; i < tmpArray.Length; i++)
            {
                tmpArray[i] = initValue;
            }

            return tmpArray;
        }

        private static int[] InitArray(int elementCount, int initValue)
        {
            int[] tmpArray = new int[elementCount];


            for (int i = 0; i < tmpArray.Length; i++)
            {
                tmpArray[i] = initValue;
            }

            return tmpArray;
        }
    }
}
