using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie 2
            Szkola UWM = new Szkola();
            UWM.liczbaLawek = 40;
            UWM.liczbaUczniow = 81;
            int x = UWM.SprawdzLawki(UWM.liczbaUczniow, UWM.liczbaLawek);
            if (x == 1) Console.WriteLine("Jest wystarczajaco lawek dla uczniow");
            else Console.WriteLine("Lawek jest za malo");
        }
    }
}
