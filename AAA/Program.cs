using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    class Program
    {
        static void Main(string[] args)
        {

            var trojkat = new Triangle();
            trojkat.Height = 8;
            trojkat.BaseLenght = 4;

            trojkat.ShowDimesions();
            var field = trojkat.CalculateField();
            Console.WriteLine("Pole wynosi trojkata = " + field);
            


    }
    }
}
