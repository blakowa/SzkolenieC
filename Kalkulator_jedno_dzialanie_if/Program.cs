using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_jedno_dzialanie_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza cyfre = ");
            var FirstIn = Console.ReadLine();
            Console.WriteLine("Podaj druga cyfre = ");
            var SecIn = Console.ReadLine();
            Console.WriteLine("Podaj rodzaj operacji...");
            string oper = Console.ReadLine().ToUpper();


            

            if ((String.IsNullOrWhiteSpace(FirstIn.ToString())) && (String.IsNullOrWhiteSpace(SecIn.ToString())))
            {
                Console.WriteLine("Podaj dwie liczby aby wykonac obliczenia.");
            }
            else
            {
                var First = double.Parse(FirstIn);
                var Sec = double.Parse(SecIn);

                var res1 = (First == Sec) ? "Liczby sa rowne." : "Liczby sa rozne.";
                Console.WriteLine(res1);


                var res2 = (First > Sec) ? "Pierwsza liczba jest wieksza." : "Druga liczba jest wieksza.";
                Console.WriteLine(res2);

                if (Sec == 0)
                {
                    Console.WriteLine("Druga liczba jest rowna zero - dzielnie i modulo nie jest mozliwe.");
                }
                else if (oper == "DIV")
                {

                    var div = First / Sec;
                    var mod = First % Sec;
                    Console.WriteLine(String.Concat("Dzielenie pierwszej przez druga = ", div));
                    Console.WriteLine("Reszta z dzielnia pierwszej przez druga = " + mod);
                }
                else if (oper == "SUM")
                {
                    var sum = First + Sec;
                    Console.WriteLine(String.Concat("Dodawanie = ", sum));

                }
                else if (oper == "MINUS")
                {
                    var minus = First - Sec;
                    Console.WriteLine(String.Concat("Odejmowanie drugiej od pierwszej = ", minus));

                }
                else if (oper == "MULTI")
                {
                    var multi = First * Sec;
                    Console.WriteLine(String.Concat("Mnozenie = ", multi));
                }


                //var inkFist = ++First;
                //var inkSec = ++Sec;
                //var decFirst = --First;
                //var decSec = --Sec;


               
                
                
                //Console.WriteLine(String.Concat("First ++ -przed = ", inkFist));
                //Console.WriteLine(String.Concat("Sec ++ -przed= ", inkSec));
                //Console.WriteLine(String.Concat("Firts --  -przed= ", decFirst));
                //Console.WriteLine(String.Concat("Sec -- -przed= ", decSec));

                //Console.WriteLine(String.Concat("Czy pierwsza cyfra = druga cyfra ", String.Compare(First.ToString(), Sec.ToString())));
            }
        }
    }
}
