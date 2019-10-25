using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Szkola
    {
        public int liczbaUczniow;
        public int liczbaLawek;
        public int SprawdzLawki(int uczniowie, int lawki)
        {
            if (2 * uczniowie > lawki) return 0;
            return 1;
        }
    }
}
