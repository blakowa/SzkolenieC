using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dogs;

namespace ListyZPasmi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogsList = new List<Dog>()
           {
               new Dog("Spiky","gray","terrier"),   // nie ma wieku
               new Dog("Lassie","brown and white", "collie"),  // ma dwa lata 2
               new Dog() // nie ma wieku


           };

            var whiteFang = new Dog("Fang", "white", "wolf"); // nie ma wieku

            dogsList.Add(whiteFang);

            var Reksio = new Dog("Reksio","black","kundel",true,13); // ma 13 lat

            dogsList.Add(Reksio);

            var Pyza = new Dog("Pyza", "brown", "kundel",true,20); // ma 20 lat

            dogsList.Add(Pyza);

            Console.WriteLine("Imie piatego psa " + dogsList[5].NameProperty);
            Console.WriteLine("Ile jest psow na liscie " + dogsList.Count());
            Console.WriteLine("Suma wieku 3 psow - bo pozostale 3 byly zrobione bez wieku 2 13 20 =");
            Console.WriteLine(dogsList[0].AgeProperty + dogsList[1].AgeProperty + dogsList[2].AgeProperty + dogsList[3].AgeProperty
                + dogsList[4].AgeProperty + dogsList[5].AgeProperty); // w sumie 35 lat

            dogsList.RemoveAt(5);
            Console.WriteLine("Liczba psow po usunieciu ostatniego z listy = ");
            Console.WriteLine(dogsList.Count());






        }
    }
}
