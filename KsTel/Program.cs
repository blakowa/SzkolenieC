using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsTel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ksiazka telefoniczna");
            Console.WriteLine("Aby zobaczyc komendy wpisz HELP");
            Console.WriteLine("Aby zakonczyc wpisz EXIT");
            string oper;

            do
            {
                Console.Write("...");
                oper = Console.ReadLine().ToUpper();
                switch (oper)
                {
                    case "HELP":
                        Commands();
                        break;
                    case "EXIT":
                        Environment.Exit(0);
                        break;
                   /* case "ADD":
                        string name = new name PhoneBookItem;
                        
                              break;
                    case "DEL":

                        break;

                    case "EDIT":

                        break;
                    case "SEARCH":

                        break;*/




                }

            }
            while (oper.ToUpper() != "EXIT");

        }

        private static void Commands()
        {
            Console.Clear();
            StringBuilder sb = new StringBuilder();
            sb.Append("Mozliwe operacje:\n");
            sb.Append("help: \t Wyswietla pomoc\n");
            sb.Append("exit: \t Wyjscie z ksiazki\n");
            sb.Append("cls: \t Wyczyszczenie ekranu\n");

            sb.Append("add: \t Dodaje wpis\n");
            sb.Append("del: \t Usuwa wpis\n");
            sb.Append("edit: \t Edytuje wpis\n");
            sb.Append("search: \t Szuka wpisu\n");
            Console.WriteLine(sb.ToString());
        }

    }
}
