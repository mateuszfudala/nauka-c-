using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja31
{
    enum PoryRoku : sbyte
    {
        Wiosna = 15, Lato = 25, Jesień = 5, Zima = -5
    }

    class Program
    {
        static void Main(string[] args)
        {
            PoryRoku poraRoku = (PoryRoku)25;
            Console.WriteLine(poraRoku);
        }
    }
}
