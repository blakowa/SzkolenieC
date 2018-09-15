using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ify
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj pierwsza cyfre = ");
            var firstIn = Console.ReadLine();
            Console.WriteLine("Podaj druga cyfre = ");
            var secIn = Console.ReadLine();

            //Regex r = new Regex(pat, RegexOptions.IgnoreCase);

            if ((String.IsNullOrWhiteSpace(firstIn.ToString())) && (String.IsNullOrWhiteSpace(secIn.ToString())))
            {
                Console.WriteLine("Podaj dwie liczby aby wykonac obliczenia.");
            }
            else
            {
                var first = double.Parse(firstIn);
                var sec = double.Parse(secIn);

                var res1 = (first == sec) ? "Liczby sa rowne." : "Liczby sa rozne.";
                Console.WriteLine(res1);


                var res2 = (first > sec) ? "Pierwsza liczba jest wieksza." : "Druga liczba jest wieksza.";
                Console.WriteLine(res2);

                if (sec == 0)
                {
                    Console.WriteLine("Druga liczba jest rowna zero - dzielnie i modulo nie jest mozliwe.");
                }
                else
                {
                    var div = first / sec;
                    var mod = first % sec;
                    Console.WriteLine(String.Concat("Dzielenie pierwszej przez druga = ", div));
                    Console.WriteLine("Reszta z dzielnia pierwszej przez druga = " + mod);
                };

                var sum = first + sec;
                var minus = first - sec;
                var multi = first * sec;
                var inkFist = ++first;
                var inkSec = ++sec;
                var decFirst = --first;
                var decSec = --sec;


                Console.WriteLine(String.Concat("Dodawanie = ", sum));
                Console.WriteLine(String.Concat("Odejmowanie drugiej od pierwszej = ", minus));
                Console.WriteLine(String.Concat("Mnozenie = ", multi));
                Console.WriteLine(String.Concat("First ++ -przed = ", inkFist));
                Console.WriteLine(String.Concat("Sec ++ -przed= ", inkSec));
                Console.WriteLine(String.Concat("Firts --  -przed= ", decFirst));
                Console.WriteLine(String.Concat("Sec -- -przed= ", decSec));

                Console.WriteLine(String.Concat("Czy pierwsza cyfra = druga cyfra ", String.Compare(first.ToString(), sec.ToString())));
            }




        }
    }
}
