using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Ride();
            Bicycle bicycle1 = new Bicycle();
            bicycle1.Ride();
            Osoba czlowiek = new Osoba();
            czlowiek.Graj();
            IGitarzysta gitarzysta = new Osoba();
            gitarzysta.Graj();
            ISkrzypek skrzypek = new Osoba();
            skrzypek.Graj();
        }
    }
}
