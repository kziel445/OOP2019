using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    class Osoba     //1
    {
        protected string imie;
        protected string nazwisko;
        public Osoba()
        {

        }
        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
    class Autor : Osoba     //2
    {
        private string narodowosc;
        public Autor()
        {

        }
        public Autor(string imie, string nazwisko, string narodowosc)//:base(imie,nazwisko)
        {
            base.imie = imie;
            base.nazwisko = nazwisko;
            this.narodowosc = narodowosc;
        }
    }
    class Katalog : IZarzadzanieKatalogiem//8
    {
        private string dzialTematyczny;
        List<Pozycja> listaPozycji = new List<Pozycja>();
        public Katalog()        //9
        {

        }
        public Katalog(string dzial)
        {
            this.dzialTematyczny = dzial;
            
        }
        public void DodajPozycje(Pozycja pozycja)
        {
            listaPozycji.Add(pozycja);
        }
        //interfejs IZarzadzanieKatalogiem//
        public void WypiszWszystko()
        {
            Console.WriteLine("id\ttytul\twyd.\trok\tstrony/numer");
            foreach (Pozycja element in listaPozycji)
            {
                element.WypiszInfo();
            }
        }
        public void WyszukajPoId(int id)
        {
            foreach(Pozycja element in listaPozycji)
            {
                if(element.WyszukajId()==id)
                {
                    element.WypiszInfo();
                }
            }
        }
        public void WyszukajPoTytule(string tytul)
        {
            foreach (Pozycja element in listaPozycji)
            {
                if (element.WyszukajTytul() == tytul)
                {
                    element.WypiszInfo();
                }
            }
        }
        ///////////////////
    }
    abstract class Pozycja      //3
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;
        public Pozycja()    //4
        {

        }
        public Pozycja(int id, string tytul, string wydawnictwo, int rokWydania)
        {
            this.id = id;
            this.tytul = tytul;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }
        abstract public void WypiszInfo();//5
        public int WyszukajId()
        {
            return id;
        }
        public string WyszukajTytul()
        {
            return tytul;
        }

    }
    class Ksiazka : Pozycja //6
    {
        private int liczbaStron;
        Autor autor = new Autor();
        public Ksiazka()
        {

        }
        public Ksiazka(int id,string tytul,string wydawnictwo,int rokWydania,int liczba)
        {
            this.liczbaStron = liczba;
            base.id = id;
            base.tytul = tytul;
            base.wydawnictwo = wydawnictwo;
            base.rokWydania = rokWydania;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine(id + "\t" + tytul + "\t" + wydawnictwo + "\t" + rokWydania + "\t" + liczbaStron);
        }
    }
    class Czasopismo : Pozycja      //7
    {
        private int numer;
        public Czasopismo()
        {

        }
        public Czasopismo(int id, string tytul, string wydawnictwo, int rokWydania, int liczbaStron)
        {
            this.numer = liczbaStron;
            base.id = id;
            base.tytul = tytul;
            base.wydawnictwo = wydawnictwo;
            base.rokWydania = rokWydania;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine(id + "\t" + tytul + "\t" + wydawnictwo + "\t" + rokWydania + "\t" + numer);
        }
    }

}