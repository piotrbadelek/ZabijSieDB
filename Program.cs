using System;

namespace ZBDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter command:");
            PoPierwszym();
        }

        private static void PoPierwszym()
        {
            string komenda = Console.ReadLine();
            if (komenda == "stwórz nową tabelę")
            {
                Console.WriteLine("Podaj nazwę:");
                komenda = Console.ReadLine();
                System.IO.File.WriteAllText(komenda + ".txt", "ZabijSięDB 1.0");
                Console.WriteLine("Zapisano!");
            }
            if (komenda == "przeczytaj tabele")
            {
                Console.WriteLine("Podaj nazwę:");
                komenda = Console.ReadLine();
                Console.WriteLine(System.IO.File.ReadAllText(komenda + ".txt"));
            }
            if (komenda == "dodaj do tabeli")
            {
                Console.WriteLine("Jakiej tabeli");
                komenda = Console.ReadLine();
                Console.WriteLine("co dodać do twojej marnej tabeli");
                string dodawanie = Console.ReadLine();
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(komenda + ".txt", true))
                {
                    file.WriteLine("\n" + dodawanie);
                }
                Console.WriteLine("Zapisano!");
            }
            PoPierwszym();
        }
    }
}
