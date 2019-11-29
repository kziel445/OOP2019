using System;
using System.Collections.Generic;
using System.Text;

namespace zad7
{
    interface IZarzadzanieKatalogiem
    {
        void WyszukajPoTytule(string tytul);
        void WyszukajPoId(int id);
        void WypiszWszystko();

    }
}
