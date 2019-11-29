using System;
using System.Collections.Generic;
using System.Text;

namespace zad7
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        public Osoba()
        {
            imie = "Brak imienia";
            nazwisko = "Brak nazwiska";
        }
        public Osoba(string imie,string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
    class Autor:Osoba
    {
        private string narodowosc;
        public Autor()
        {
            base.imie = "Brak";
            base.nazwisko = "Brak";
            this.narodowosc = "Brak";
        }
        public Autor(string imie,string nazwisko,string narodowosc)//:base(imie,nazwisko)
        {
            base.imie = imie;
            base.nazwisko = nazwisko;
            this.narodowosc = narodowosc;
        }
    }
    class Katalog:IZarzadzanieKatalogiem 
    {
        private string dzialTematyczny;
        List<Pozycja> listaPozycji = new List<Pozycja>();
        public Katalog()
        {
            this.dzialTematyczny = "brak";
            this.listaPozycji = null;
        }
        public Katalog (string dzial)
        {
            this.dzialTematyczny = dzial;
            this.listaPozycji = null;
        }
        public void DodajPozycje(Pozycja pozycja)
        {

           listaPozycji.Add(pozycja);
        }
        //interfejs IZarzadzanieKatalogiem//
        public void WypiszWszystko()
        {
            throw new NotImplementedException();
        }

        public void WyszukajPoId(int id)
        {
            throw new NotImplementedException();
        }

        public void WyszukajPoTytule(string tytul)
        {
            throw new NotImplementedException();
        }
        ///////////////////
    }
    abstract class Pozycja
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;
        public Pozycja()
        {
            this.id = 0;
            this.tytul = "-";
            this.wydawnictwo = "-";
            this.rokWydania = 0;
        }
        public Pozycja(int id, string tytul, string wydawnictwo, int rokWydania)
        {
            this.id = id;
            this.tytul = tytul;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }
        abstract public void WypiszInfo();

    }
    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        Autor autor = new Autor();
        public Ksiazka()
        {
            
        }
        public Ksiazka(int id, string tytul, string wydawnictwo, int rokWydania,int liczba)
        {
            this.liczbaStron = liczba;
            base.id = id;
            base.tytul = tytul;
            base.wydawnictwo = wydawnictwo;
            base.rokWydania = rokWydania;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine(liczbaStron);
        }
    }
    class Czasopismo : Pozycja
    {
        private int numer;
        public Czasopismo()
        {
            this.numer = 0;
        }
        public Czasopismo(int liczbaStron)
        {
            this.numer = liczbaStron;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine(numer);
        }
    }
    
}
