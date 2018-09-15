using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Dogs;


namespace Dogs
{
    class Program
    {
        static void Main(string[] args)
        {

            string json = FilesOperations.ReadFile("dogsList.json");
            List<Dog> dogsList2 = JsonConvert.DeserializeObject<List<Dog>>(json);

            /*int sumage = 0;
            for (int i = dogsList2.Count()-1; i > dogsList2.Count() - 4; i--)
            {
                sumage = sumage + dogsList2[i].AgeProperty;
            }

            
            Console.WriteLine("Sumaryczny wiek psow = " + sumage);*/

            /*for (int i = dogsList2.Count() - 1 ; i > 0; i--)
            {

                if ((i % 2) != 0)
                {

                    dogsList2[i].Bark();

                }
                else
                {

                    dogsList2[i].WagTail();

                }
                foreach (var item in collection)
                {

                }*/
            int sumage = 0;
            foreach (var dog in dogsList2)
            {
                sumage = sumage + dog.AgeProperty;
            }

            Console.WriteLine("Sumaryczny wiek psow = " + sumage);

            foreach (var dog in dogsList2)
            {

                int index = dogsList2.IndexOf(dog);

                if ((index % 2) != 0)
                {

                    dogsList2[index].Bark();

                }
                else
                {

                    dogsList2[index].WagTail();

                }

            }

        }


    }
}

