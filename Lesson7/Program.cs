using System;
using System.Collections.Generic;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 150542 % 3 + 1;      :>
            List<Pozycja> listaPozycji = new List<Pozycja>();
            Ksiazka Ser = new Ksiazka(1,"ser","www",4,4);
            listaPozycji.Add(1, new Ksiazka(1,"ser","ser",2));
            
        }
    }
}
