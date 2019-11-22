using System;
using System.Collections.Generic;

namespace Zad6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Figura figura1 = new Figura();
            Kwadrat kwadrat1 = new Kwadrat(2);
            Trojkat trojkat1 = new Trojkat();
            //Console.WriteLine (kwadrat1.ObliczPole());
            List<Figura> lista = new List<Figura>()
            {
                kwadrat1,
                trojkat1
            };
            foreach(Figura iguana in lista)
            {
                Console.WriteLine(iguana.ObliczPole ());
            }
        }
    }
}
