using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    public class Triangle
    {
        public int Height { get; set; }
        public int BaseLenght { get; set; }
        public int SideLenght { get; set; }
        double field;

        public void ShowDimesions()
        {

            Console.WriteLine($"Triangle height = {Height}");
            Console.WriteLine($"Triangle base = {BaseLenght}");
            Console.WriteLine($"Triangle side = {SideLenght}");
        }

        public double CalculateField()
        {

            field = 0.5 * BaseLenght * Height;
            return field; 
        }
    }
}
