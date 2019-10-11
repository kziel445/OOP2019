using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=10;
            int[] tablica = new int[10];
            
            //1 i 2 linijka
            for(int i = 0;i<n;i++)          
            {
                tablica[i] = i;
                if(i==9) Console.Write(tablica[i] + "\n");
                else Console.Write(tablica[i] + ", ");
            }
            //3 linjka 
            for (int i = 0;i<n;i++)         
            {
                Console.WriteLine(tablica[i]);
            }
            Console.WriteLine();

            //4 linjka 
            for (int i = n-1;i>=0 ; i--) //4 linijka
            {
                Console.WriteLine(tablica[i]);       
            }
            Console.WriteLine();

            //5 linjka 
            int x, y, z;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (x==y) Console.WriteLine("Liczby są równe");
            else if(y>x) Console.WriteLine(y + "jest większa");
            else Console.WriteLine(x + "jest większa");
            Console.WriteLine();

            //6 linjka 
            Console.WriteLine("Podaj liczby na trójkąt");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if ((x+z>y) && (x+y>z) && y+z>x) Console.WriteLine("istnieje taki trojkat");
            else Console.WriteLine("NIE istnieje taki trojkat");
            Console.WriteLine();

            //7 linjka 
            Console.WriteLine("\nPodaj liczbe 5<x<15");
            x = Convert.ToInt32(Console.ReadLine());
            if(x<=5 || x>=15) Console.WriteLine("liczba nie jest w przedziale!");
            else
            {
                while(x!=0)
                {
                    x--;
                    Console.WriteLine(x);
                }
            }
            Console.WriteLine();

            //8 linjka 
            
            do
            {
                Console.WriteLine("\nPodaj liczbe 10");
                x = Convert.ToInt32(Console.ReadLine());
            } while (x != 10);
           
            Console.ReadKey();
        }
    }
}
