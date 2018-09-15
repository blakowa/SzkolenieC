using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //decimal first, sec, res;

            //first = 3;
            //sec = 2.5m;

            //res = first + sec;
            //Console.WriteLine("Wynik dodawania to " + res);

            //res = first - sec;
            //Console.WriteLine("Wynik odejmowania to " + res);

            //res = first * sec;
            //Console.WriteLine("Wynik mnożenia to " + res);

            //res = first / sec;
            //Console.WriteLine("Wynik dzielenia to " + res);

            //Console.ReadKey();


            //double first, sec;

            Console.WriteLine("Podaj pierwsza cyfre = ");
            var first = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga cyfre = ");
            var sec = double.Parse(Console.ReadLine());

            var sum = first + sec;
            var minus = first - sec;
            var multi = first * sec;
            var div = first / sec;
            var inkFist = ++first;
            var inkSec = ++sec;
            var decFirst = --first;
            var decSec = --sec;
            var mod = first % sec;

            Console.WriteLine( String.Concat("Dodawanie = ",sum));
            Console.WriteLine(String.Concat("Odejmowanie drugiej od pierwszej = ",minus));
            Console.WriteLine(String.Concat("Mnozenie = ",multi));
            Console.WriteLine(String.Concat("Dzielenie pierwszej przez druga = ",div));
            Console.WriteLine(String.Concat("First ++ -przed = ",inkFist));
            Console.WriteLine(String.Concat("Sec ++ -przed= ", inkSec));
            Console.WriteLine(String.Concat("Firts --  -przed= ",decFirst));
            Console.WriteLine(String.Concat("Sec -- -przed= ",decSec));
            Console.WriteLine("Reszta z dzielnia pierwszej przez druga = " + mod);

            Console.WriteLine(String.Concat("Czy pierwsza cyfra = druga cyfra ",String.Compare(first.ToString(),sec.ToString())));
            //Console.WriteLine(String.Concat("Tu jest contains: ",String.Contains(first.ToString, sec)));

        }
    }
}
