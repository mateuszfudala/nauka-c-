using System;

namespace Lekcja29
{
    class Program
    {
        static void Main(string[] args)
        {
            Postac p1 = new Postac("Elf", 200);
            IAtakMagiczny atak = (IAtakMagiczny)p1;
            atak.Atak(25);
            IAtakMieczem atak2 = (IAtakMieczem)p1;
            atak2.Atak(25);
        }
    }

    interface IAtakMagiczny
    {
        void Atak(int pkt);
    }

    interface IAtakMieczem
    {
        void Atak(int pkt);
    }

    class Postac : IAtakMagiczny, IAtakMieczem
    {
        public Postac(string imie, int punktyHP)
        {
            this.imie = imie;
            this.punktyHP = punktyHP;
        }
        public string imie;
        public int punktyHP;

        void IAtakMagiczny.Atak(int pkt)
        {
            Console.WriteLine("IAtakMagiczny");
        }

        void IAtakMieczem.Atak(int pkt)
        {
            Console.WriteLine("IAtakMieczem");
        }
    }
}
