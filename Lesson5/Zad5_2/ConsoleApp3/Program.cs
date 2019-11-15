using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obiekt1 = new Test();
            Test obiekt2 = new Test();
            Test obiekt3 = new Test();
            Test obiekt4 = new Test();

            obiekt1.liczba = 255; //1 = 255
            
            obiekt2 = obiekt1; //obiekt2 jest od teraz rowny obiekt1
            obiekt3 = (Test)obiekt1.Clone(); //3 = 255
            obiekt1.liczba = 347; //1 = 347
            
            Console.WriteLine(obiekt1.liczba + " " + obiekt2.liczba  + " "+ obiekt3.liczba );

            
            obiekt1.poleTestowe.slowo = "owo";
            obiekt1.poleTestowe.slowo = "kaa";
            Console.WriteLine(obiekt1.poleTestowe.slowo);
            Console.WriteLine(obiekt1.poleTestowe.slowo);
            obiekt3 = obiekt1.GlebokaKopia();
        }
    }
    
    
    
}
