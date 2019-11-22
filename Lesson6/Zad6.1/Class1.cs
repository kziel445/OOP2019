using System;
using System.Collections.Generic;
using System.Text;

namespace Zad6._1
{
    abstract class  Figura
    {
        protected int a;
        protected int b;
        protected int c;
        public abstract int ObliczPole();
    }

    class Kwadrat : Figura
    {
        public Kwadrat()
        {
            this.a = 1;
        }
        public Kwadrat(int a)
        {
            this.a = a;

        }
        public override int ObliczPole()
        {
            return this.a * this.a;
        }
    }
    class Trojkat : Figura
    {
        public Trojkat(int a,int b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Trojkat()
        {
            this.a = 1;
            this.b = 1;
            this.c = 1;

        }
        public override int ObliczPole()
        {
            return 1;
        }
    }
}
