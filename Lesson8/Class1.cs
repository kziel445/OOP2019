using System;
using System.Collections.Generic;
using System.Text;

namespace Zad8
{
    class MojWlasnyWyjatek : ApplicationException
    {
        // Przekazujemy do klasy bazowej parametr naszego konstruktora
        public MojWlasnyWyjatek(string text) : base(text)
        {
        }
    }
    class Kanapka
    {
        public void Sprawdz()
        {
            throw (new MojWlasnyWyjatek("Bula"));
        }
    }
    public class NaszWyjatekException : System.Exception
    {
        string message;
        public NaszWyjatekException(string message) 
            : base(message)
        {

        }
        public NaszWyjatekException(String message, Exception innerException)
          : base(message, innerException)
        {

        }
        public NaszWyjatekException(SerializationInfo info, StreamingContext context)
    : base(info, context)
        {

        }
    }
    class Wyjatek
    {
        public void metoda23()
        {
            throw new NotImplementedException();
        }

    }
    
}
