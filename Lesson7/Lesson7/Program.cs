using System;
using System.Collections.Generic;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie: " + (150542 % 3 + 1));      //  :)

            Katalog Dramat = new Katalog("dramat");
            Dramat.DodajPozycje(new Ksiazka(1, "Troll", "Miech", 1, 4));
            Dramat.DodajPozycje(new Czasopismo(1, "Pudelek", "Ogon", 1, 4));
            Dramat.WypiszWszystko();
            Console.WriteLine();
            Dramat.WyszukajPoId(2);
            Dramat.WyszukajPoTytule("Troll");




        }
    }
}