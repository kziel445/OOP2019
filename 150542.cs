using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double C, F;
            C = Convert.ToDouble(Console.ReadLine());
            F = (C * 1.8) + 32;
            Console.WriteLine(C.ToString() +" "+ F.ToString() );
            Console.ReadKey();
        }
    }
}
