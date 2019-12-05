
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    interface IZarzadzanieKatalogiem
    {
        void WyszukajPoTytule(string tytul);
        void WyszukajPoId(int id);
        void WypiszWszystko();

    }
}