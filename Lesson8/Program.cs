using System;

namespace Zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 4, y = 4, z = 0;
            int wynik=0;
            Wyjatek Kek = new Wyjatek();
            
            try
            {
                wynik = x / y;
                Kek.metoda23();
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Waj ju du dis");
            }
            finally
            {
                Console.WriteLine("Kanapka");
            }
            Console.WriteLine(wynik);

            //StackOverflowException - Wyjątek, który jest generowany 
            //w przypadku przepełnienia stosu wykonywania, ponieważ
            //zawiera zbyt wiele wywołań metod zagnieżdżonych.

            // NullReferenceException - Wyjątek jest zgłaszany podczas 
            //próby uzyskania dostępu do elementu członkowskiego typu, 
            //którego wartość to null

            //FileNotFoundException - Wyjątek, który jest zgłaszany, gdy 
            //nie powiedzie się próba uzyskania dostępu do pliku,
            //który nie istnieje na dysku.

            //AccessViolationException - Wyjątek, który jest zgłaszany, gdy 
            //istnieje podjęto próbę odczytu lub zapisu chronione pamięci.

            //IndexOutOfRangeException - Wyjątek, który jest generowany, 
            //gdy zostanie podjęta próba uzyskania dostępu do elementu 
            //tablicy lub kolekcji z indeksem, który znajduje się poza granicami.
            
        }
    }
}
