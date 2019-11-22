using System;
using System.Collections.Generic;
using System.Text;

namespace Zad6
{
    class Osoba
    {
        string imie;
        string nazwisko;
        public Osoba()
        {
            imie = "brak";
            nazwisko = "brak";
        }
        public Osoba(string imie = " brak ",string nazwisko="brak")
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public virtual void WypiszInfo()
        {
            Console.WriteLine(this.imie + " "+ this.nazwisko);
        }
    }
    class Student:Osoba
    {
        int rokStudiow;
        int numerGrupy;
        int numerAlbumu;
        public Student()
        {
            rokStudiow=1;
            numerGrupy=1;
            numerAlbumu = 1;
        }
        public Student(string imie,string nazwisko, int rokStudiow,int numerGrupy,int numerAlbumu):base(imie,nazwisko )
        {
            this.rokStudiow= rokStudiow;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }
        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine(this.rokStudiow  + " " + this.numerGrupy + " " + this.rokStudiow);
        }
    }
}
