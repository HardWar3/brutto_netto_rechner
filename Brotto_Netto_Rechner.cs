using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using brutto_netto_rechner.classes;
using Serilog;

namespace brutto_netto_rechner
{
    internal class Brotto_Netto_Rechner
    {
        static void Main(string[] args)
        {
#if DEBUG
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/debug_log.txt")
                .CreateLogger();
#else
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("logs/log.txt")
                .CreateLogger();
#endif

            //var keks = new Lohnsteuer_2024DEC();
            var keks = new Lohnsteuer_2025();

            keks.Krv = 0;
            keks.Pkv = 0;
            //keks.Pkpv = 0m;
            //keks.Kvz = 1.7m; // 2024
            keks.Kvz = 2.5m; // 2025
            //keks.Kvz = 0m;
            keks.Pvz = 0;
            keks.Stkl = 1;

            keks.Ajahr = 1988;
            keks.Alter1 = 0;
            keks.Lzz = 2;
            keks.Re4 = 400000m;
            keks.Jre4 = keks.Re4 * 12m;

            keks.Start();

            keks.Gesamt_steuer = keks.Lstlzz + keks.Solzlzz + keks.Kirchensteuer;


            Console.WriteLine(keks.Gesamt_steuer / 100 + " gesamt Steuer");
            Console.WriteLine(keks.Summe_Socialversicherung_Arbeitnehmer / 100 + " Summe SV");
            Console.WriteLine(keks.Lstlzz / 100 + " Lohnsteuer");
            Console.WriteLine(keks.Netto_lohn / 100 + " NETTO");
        }
    }
}
