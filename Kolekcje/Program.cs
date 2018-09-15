using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 3, 5, 7, 11, 13, 17, 19, 23, 27, 29 };
            Console.WriteLine("Dlugosc tablicy = " + array.Length);
            Console.WriteLine("Czwarty element tablicy = " + array[3]);
            




            int[] arrayCopy = new int[11];
            Array.Copy(array, arrayCopy, 11);

            

            int[] arraySort = new int[] { 23, 4, 7, 1, 12 };
            Array.Sort(arraySort);
           
          








        }
    }
}
