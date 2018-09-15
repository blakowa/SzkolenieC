using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cw1 = new List <int> {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine("Czwarty obiekt na liscie to " + cw1[3]);
            Console.WriteLine("Liczba elementow w liscie = " + cw1.Count());

            int[] arrayCopy = new int[20];
            cw1.CopyTo(arrayCopy, 20);

            cw1.Reverse();

            cw1.Add(11);

            cw1.AddRange(new int[] {12,13,14});

            cw1.RemoveAt(13);

            cw1.RemoveRange(7,3);

            Console.WriteLine("Liczba elementow w liscie = " + cw1.Count());


        }
    }
}
