using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsTel
{
    class PhoneBookItem
    {
        public string Name {get; set;}

        public string Number { get; set;}

        public string City { get; set; }

        public void NewEntry()
        {
            Console.WriteLine("Podaj nazwe kontaktu:");
            Name = Console.ReadLine();
            Console.WriteLine("Podaj numer:");
            Number = Console.ReadLine();
            Console.WriteLine("Podaj miasto:");
            City = Console.ReadLine();
        }



    }
}
