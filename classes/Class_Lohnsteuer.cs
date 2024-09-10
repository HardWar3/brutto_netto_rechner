using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brutto_netto_rechner.classes
{
    internal class Class_Lohnsteuer
    {
        // Eingabeparameter

        public long Af { get; set; } = 0;
        public long Ajahr { get; set; } = 0;
        public long Alter1 { get; set; } = 0;
        public decimal Entsch { get; set; } = decimal.Zero;
        public decimal F { get; set; } = decimal.Zero;
        public decimal Jfreib { get; set; } = decimal.Zero;
        public decimal Jhinzu { get; set; } = decimal.Zero;
        public decimal Jre4 { get; set; } = decimal.Zero;
        public decimal Jre4ent { get; set; } = decimal.Zero;
        public decimal Jvbez { get; set; } = decimal.Zero;
        public long Krv { get; set; } = 0;
        public decimal Kvz { get; set; } = decimal.Zero;
        public long Lzz { get; set; } = 0;
        public decimal Lzzfreib { get; set; } = decimal.Zero;
        public decimal Lzzhinzu { get; set; } = decimal.Zero;
        public decimal Mbv { get; set; } = decimal.Zero;
        public decimal Pkpv { get; set; } = decimal.Zero;
        public long Pkv { get; set; } = 0;
        public long Pva { get; set; } = 0;
        public long Pvs { get; set; } = 0;
        public long Pvz { get; set; } = 0;
        public long R { get; set; } = 0;
        public decimal Re4 { get; set; } = decimal.Zero;
        public decimal Sonstb { get; set; } = decimal.Zero;
        public decimal Sonstent { get; set; } = decimal.Zero;
        public decimal Sterbe { get; set; } = decimal.Zero;
        public long Stkl { get; set; } = 0;
        public decimal Vbez { get; set; } = decimal.Zero;
        public decimal Vbezm { get; set; } = decimal.Zero;
        public decimal Vbezs { get; set; } = decimal.Zero;
        public decimal Vbs { get; set; } = decimal.Zero;
        public long Vjahr { get; set; } = 0;
        public decimal Vkapa { get; set; } = decimal.Zero;
        public decimal Vmt { get; set; } = decimal.Zero;
        public decimal Zkf { get; set; } = decimal.Zero;
        public long Zmvb { get; set; } = 0;

        // Ausgabeparameter

        public decimal Bk { get; set; } = decimal.Zero;
        public decimal Bks { get; set; } = decimal.Zero;
        public decimal Bkv { get; set; } = decimal.Zero;
        public decimal Lstlzz { get; set; } = decimal.Zero;
        public decimal Solzlzz { get; set; } = decimal.Zero;
        public decimal Solzs { get; set; } = decimal.Zero;
        public decimal Solzv { get; set; } = decimal.Zero;
        public decimal Sts { get; set; } = decimal.Zero;
        public decimal Stv { get; set; } = decimal.Zero;
        public decimal Vkvlzz { get; set; } = decimal.Zero;
        public decimal Vkvsonst { get; set; } = decimal.Zero;

        // interne Felder or Ausgabeparamter DBA (Doppelbesterungsabkommen)

        public decimal Vfrb { get; set; } = decimal.Zero;
        public decimal Vfrbs1 { get; set; } = decimal.Zero;
        public decimal Vfrbs2 { get; set; } = decimal.Zero;
        public decimal Wvfrb { get; set; } = decimal.Zero;
        public decimal Wvfrbm { get; set; } = decimal.Zero;
        public decimal Wvfrbo { get; set; } = decimal.Zero;

        // interne Felder

        public decimal Alte { get; set; } = decimal.Zero;
        public decimal Anp { get; set; } = decimal.Zero;    
        public decimal Anteil1 { get; set; } = decimal.Zero;
        public decimal Bbgkvpv { get; set; } = decimal.Zero;
        public decimal Bbgrv { get; set; } = decimal.Zero;
        public decimal Bmg { get; set; } = decimal.Zero;
        public decimal Diff { get; set; } = decimal.Zero;
        public decimal Efa { get; set; } = decimal.Zero;
        public decimal Fvb { get; set; } = decimal.Zero;
        public decimal Fvbso { get; set; } = decimal.Zero;
        public decimal Fvbz { get; set; } = decimal.Zero;
        public decimal Fvbzso { get; set; } = decimal.Zero;
        public decimal Gfb { get; set; } = decimal.Zero;
        public decimal Hbalte { get; set; } = decimal.Zero;
        public decimal Hfvb { get; set; } = decimal.Zero;
        public decimal Hfvbz { get; set; } = decimal.Zero;
        public decimal Hfvbzso { get; set; } = decimal.Zero;
        public decimal Hoch { get; set; } = decimal.Zero;
        public long J { get; set; } = 0;
        public decimal Jbmg { get; set; } = decimal.Zero;
        public decimal Jlfreib { get; set; } = decimal.Zero;
        public decimal Jlhinzu { get; set; } = decimal.Zero;
        public decimal Jw { get; set; } = decimal.Zero;
        public decimal Jwlsta { get; set; } = decimal.Zero;
        public decimal Jwlstn { get; set; } = decimal.Zero;
        public decimal Jwsolza { get; set; } = decimal.Zero;
        public decimal Jwsolzn { get; set; } = decimal.Zero;
        public decimal Jwbka { get; set; } = decimal.Zero;
        public decimal Jwbkn { get; set; } = decimal.Zero;
        public long K { get; set; } = 0;
        public long Kennvmt { get; set; } = 0;
        public decimal Kfb { get; set; } = decimal.Zero;
        public decimal Kvsatzag { get; set; } = decimal.Zero;
        public decimal Kvsatzan { get; set; } = decimal.Zero;
        public long Kztab { get; set; } = 0;
        public decimal Lstjahr { get; set; } = decimal.Zero;
        public decimal Lst1 { get; set; } = decimal.Zero;
        public decimal Lst2 { get; set; } = decimal.Zero;
        public decimal Lst3 { get; set; } = decimal.Zero;
        public decimal Lstoso { get; set; } = decimal.Zero;
        public decimal Lstso { get; set; } = decimal.Zero;
        public decimal Mist { get; set; } = decimal.Zero;
        public decimal Pvsatzag { get; set; } = decimal.Zero;
        public decimal Pvsatzan { get; set; } = decimal.Zero;
        public decimal Rvsatzan { get; set; } = decimal.Zero;
        public decimal Rw { get; set; } = decimal.Zero;
        public decimal Sap { get; set; } = decimal.Zero;
        public decimal Schleifz { get; set; } = decimal.Zero;
        public decimal Solzfrei { get; set; } = decimal.Zero;
        public decimal Solzj { get; set; } = decimal.Zero;
        public decimal Solzmin { get; set; } = decimal.Zero;
        public decimal Solzsbmg { get; set; } = decimal.Zero;
        public decimal Solzszve { get; set; } = decimal.Zero;
        public decimal Solzvbmg { get; set; } = decimal.Zero;
        public decimal St { get; set; } = decimal.Zero;
        public decimal St1 { get; set; } = decimal.Zero;
        public decimal St2 { get; set; } = decimal.Zero;
        public decimal Stovmt { get; set; } = decimal.Zero;
        public decimal Tab1 { get; set; } = decimal.Zero;
        public decimal Tab2 { get; set; } = decimal.Zero;
        public decimal Tab3 { get; set; } = decimal.Zero;
        public decimal Tab4 { get; set; } = decimal.Zero;
        public decimal Tab5 { get; set; } = decimal.Zero;
        public decimal Vbezb { get; set; } = decimal.Zero;
        public decimal Vbezbso { get; set; } = decimal.Zero;
        public decimal Vergl { get; set; } = decimal.Zero;
        public decimal Vhb { get; set; } = decimal.Zero;
        public decimal Vkv { get; set; } = decimal.Zero;
        public decimal Vsp { get; set; } = decimal.Zero;
        public decimal Vspn { get; set; } = decimal.Zero;
        public decimal Vsp1 { get; set; } = decimal.Zero;
        public decimal Vsp2 { get; set; } = decimal.Zero;
        public decimal Vsp3 { get; set; } = decimal.Zero;
        public decimal W1stkl5 { get; set; } = decimal.Zero;
        public decimal W2stkl5 { get; set; } = decimal.Zero;
        public decimal W3stkl5 { get; set; } = decimal.Zero;
        public decimal X { get; set; } = decimal.Zero;
        public decimal Y { get; set; } = decimal.Zero;
        public decimal Zre4 { get; set; } = decimal.Zero;
        public decimal Zre4j { get; set; } = decimal.Zero;
        public decimal Zre4vp { get; set; } = decimal.Zero;
        public decimal Zre4vpm { get; set; } = decimal.Zero;
        public decimal Ztabfb { get; set; } = decimal.Zero;
        public decimal Zvbez { get; set; } = decimal.Zero;
        public decimal Zvbezj { get; set; } = decimal.Zero;
        public decimal Zve { get; set; } = decimal.Zero;
        public decimal Zx { get; set; } = decimal.Zero;
        public decimal Zzx { get; set; } = decimal.Zero;

        // eigene Felder

        public decimal Rentenversicherung { get; set; } = decimal.Zero;
        public decimal Arbeitslosenversicherung { get; set; } = decimal.Zero;
        public decimal Krankenversicherung { get; set; } = decimal.Zero;
        public decimal Pflegeversicherung_Arbeitnehmer { get; set; } = decimal.Zero;
        public decimal Pflegeversicherung_Arbeitgeber { get; set; } = decimal.Zero;
        public decimal Kirschensteuer { get; set; } = decimal.Zero;
        public decimal Gesamt_steuer { get; set; } = decimal.Zero;
        public decimal Summe_Socialversicherung_Aarbeitnehmer { get; set; } = decimal.Zero;
        public decimal Summe_Socialversicherung_Aarbeitgeber { get; set; } = decimal.Zero;
        public decimal Netto_lohn { get; set; } = decimal.Zero;
        public decimal Gesamt_belastung_Arbeitgeber { get; set; } = decimal.Zero;

        public void Start()
        {
            // CODE HERE LATER
        }
        public void Mpara()
        {
            if (Krv < 2)
            {
                if (Krv == 0)
                {
                    Bbgrv = 90600;
                }
                else
                {
                    Bbgrv = 89400;
                }
                Rvsatzan = 0.093m;
            }

            Bbgkvpv = 62100;
            Kvsatzan = Kvz / 2 / 100 + 0.07m;
            Kvsatzag = 0.0085m + 0.07m;

            if (Pvs == 1)
            {
                Pvsatzan = 0.022m;
                Pvsatzag = 0.012m;
            }
            else
            {
                Pvsatzan = 0.017m;
                Pvsatzag = 0.017m;
            }
            if (Pvs == 1)
            {
                Pvsatzan += 0.006m;
            }
            else
            {
                Pvsatzan -= Pva * 0.0025m;
            }
            W1stkl5 = 13279;
            W2stkl5 = 33380;
            W3stkl5 = 222260;
            Gfb = 11604;
            Solzfrei = 18130;
        }
        public void Mre4jl()
        {
            switch (Lzz)
            {
                case 1:
                    Zre4j = Re4 / 100;
                    Zvbezj = Vbez / 100;
                    Jlfreib = Lzzfreib / 100;
                    Jlhinzu = Lzzhinzu / 100;
                    break;
                case 2:
                    Zre4j = Re4 * 12 / 100;
                    Zvbezj = Vbez * 12 / 100;
                    Jlfreib = Lzzfreib * 12 / 100;
                    Jlhinzu = Lzzhinzu * 12 / 100;
                    break;
                case 3:
                    Zre4j = Re4 * 360 / 7 / 100;
                    Zvbezj = Vbez * 360 / 7 / 100;
                    Jlfreib = Lzzfreib * 360 / 7 / 100;
                    Jlhinzu = Lzzhinzu * 360 / 7 / 100;
                    break;
                default:
                    Zre4j = Re4 * 360 / 100;
                    Zvbezj = Vbez * 360 / 100;
                    Jlfreib = Lzzfreib * 360 / 100;
                    Jlhinzu = Lzzhinzu * 360 / 100;
                    break;
            }
            if (Af == 0)
            {
                F = 1;
            }
        }
        public void Mre4()
        {
            if (Zvbezj == 0)
            {
                Fvbz = 0;
                Fvb = 0;
                Fvbzso = 0;
                Fvbso = 0;
            } else {
                if (Vjahr < 2006) 
                {
                    J = 1;
                } else if (Vjahr < 2040)
                {
                    J = Vjahr - 2004;
                } 
                else
                {
                    J = 36;
                }

                // CODE HERE

            }
        }
    }
}