using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Test
    {
        public int liczba;
        public Test2 poleTestowe = new Test2();

        public Object Clone()
        {
            return MemberwiseClone();
        }
        public Test GlebokaKopia()
        {
            Test tempTest = new Test();
            tempTest.liczba = this.liczba;
            tempTest.poleTestowe.slowo = this.poleTestowe.slowo;
            return tempTest;
        }
    }
    class Test2
    {
        public string slowo;
    }

}
