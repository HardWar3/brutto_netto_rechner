using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using brutto_netto_rechner.classes;

namespace brutto_netto_rechner
{
    internal class Brotto_Netto_Rechner
    {
        static void Main(string[] args)
        {
            // TODO LOGGER
            Console.WriteLine("hello, world!");

            var keks = new Lohnsteuer_2024DEC();

            keks.Krv = 0;
            keks.Pkv = 0;
            keks.Kvz = 1.7m;
            keks.Pvz = 1;
            keks.Stkl = 6;

            keks.Ajahr = 1988;
            keks.Alter1 = 0;
            keks.Lzz = 1;
            keks.Re4 = 5500000m;
            keks.Jre4 = keks.Re4;

            keks.Start();

            keks.Gesamt_steuer = keks.Lstlzz + keks.Solzlzz + keks.Kirchensteuer;


            Console.WriteLine(keks.Gesamt_steuer);
            Console.WriteLine(keks.Lstlzz);
        }
    }
}
