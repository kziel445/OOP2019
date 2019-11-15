using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Vehicle
    {
    }
    class Car : Vehicle , IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Jadę samochodem");
        }
    }
    class Bicycle : Vehicle , IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Jadę rowerem");
        }
    }
    class Osoba : ISkrzypek, IGitarzysta
    {
        public void Graj()
        {
            Console.WriteLine("Gram ale kto wie na czym");
        }
        void ISkrzypek.Graj()
        {
            Console.WriteLine("Gram na skrzypcach");
        }
        void IGitarzysta.Graj()
        {
            Console.WriteLine("Gram ma gitarce");
        }
    }


}
