using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace brutto_netto_rechner.classes
{
    internal abstract class Lohnsteuer_Basic
    {

        // Eingabeparameter

        protected long Af { get; set; } = 0;
        protected long Ajahr { get; set; } = 0;
        protected long Alter1 { get; set; } = 0;
        protected decimal Entsch { get; set; } = decimal.Zero;
        protected decimal F { get; set; } = decimal.Zero;
        protected decimal Jfreib { get; set; } = decimal.Zero;
        protected decimal Jhinzu { get; set; } = decimal.Zero;
        protected decimal Jre4 { get; set; } = decimal.Zero;
        protected decimal Jre4ent { get; set; } = decimal.Zero;
        protected decimal Jvbez { get; set; } = decimal.Zero;
        protected long Krv { get; set; } = 0;
        protected decimal Kvz { get; set; } = decimal.Zero;
        protected long Lzz { get; set; } = 0;
        protected decimal Lzzfreib { get; set; } = decimal.Zero;
        protected decimal Lzzhinzu { get; set; } = decimal.Zero;
        protected decimal Mbv { get; set; } = decimal.Zero;
        protected decimal Pkpv { get; set; } = decimal.Zero;
        protected long Pkv { get; set; } = 0;
        protected long Pva { get; set; } = 0;
        protected long Pvs { get; set; } = 0;
        protected long Pvz { get; set; } = 0;
        protected long R { get; set; } = 0;
        protected decimal Re4 { get; set; } = decimal.Zero;
        protected decimal Sonstb { get; set; } = decimal.Zero;
        protected decimal Sonstent { get; set; } = decimal.Zero;
        protected decimal Sterbe { get; set; } = decimal.Zero;
        protected long Stkl { get; set; } = 0;
        protected decimal Vbez { get; set; } = decimal.Zero;
        protected decimal Vbezm { get; set; } = decimal.Zero;
        protected decimal Vbezs { get; set; } = decimal.Zero;
        protected decimal Vbs { get; set; } = decimal.Zero;
        protected long Vjahr { get; set; } = 0;
        protected decimal Vkapa { get; set; } = decimal.Zero;
        protected decimal Vmt { get; set; } = decimal.Zero;
        protected decimal Zkf { get; set; } = decimal.Zero;
        protected long Zmvb { get; set; } = 0;

        // Ausgabeparameter

        protected decimal Bk { get; set; } = decimal.Zero;
        protected decimal Bks { get; set; } = decimal.Zero;
        protected decimal Bkv { get; set; } = decimal.Zero;
        protected decimal Lstlzz { get; set; } = decimal.Zero;
        protected decimal Solzlzz { get; set; } = decimal.Zero;
        protected decimal Solzs { get; set; } = decimal.Zero;
        protected decimal Solzv { get; set; } = decimal.Zero;
        protected decimal Sts { get; set; } = decimal.Zero;
        protected decimal Stv { get; set; } = decimal.Zero;
        protected decimal Vkvlzz { get; set; } = decimal.Zero;
        protected decimal Vkvsonst { get; set; } = decimal.Zero;

        // interne Felder or Ausgabeparamter DBA (Doppelbesterungsabkommen)

        protected decimal Vfrb { get; set; } = decimal.Zero;
        protected decimal Vfrbs1 { get; set; } = decimal.Zero;
        protected decimal Vfrbs2 { get; set; } = decimal.Zero;
        protected decimal Wvfrb { get; set; } = decimal.Zero;
        protected decimal Wvfrbm { get; set; } = decimal.Zero;
        protected decimal Wvfrbo { get; set; } = decimal.Zero;

        // interne Felder

        protected decimal Alte { get; set; } = decimal.Zero;
        protected decimal Anp { get; set; } = decimal.Zero;
        protected decimal Anteil1 { get; set; } = decimal.Zero;
        protected decimal Bbgkvpv { get; set; } = decimal.Zero;
        protected decimal Bbgrv { get; set; } = decimal.Zero;
        protected decimal Bmg { get; set; } = decimal.Zero;
        protected decimal Diff { get; set; } = decimal.Zero;
        protected decimal Efa { get; set; } = decimal.Zero;
        protected decimal Fvb { get; set; } = decimal.Zero;
        protected decimal Fvbso { get; set; } = decimal.Zero;
        protected decimal Fvbz { get; set; } = decimal.Zero;
        protected decimal Fvbzso { get; set; } = decimal.Zero;
        protected decimal Gfb { get; set; } = decimal.Zero;
        protected decimal Hbalte { get; set; } = decimal.Zero;
        protected decimal Hfvb { get; set; } = decimal.Zero;
        protected decimal Hfvbz { get; set; } = decimal.Zero;
        protected decimal Hfvbzso { get; set; } = decimal.Zero;
        protected decimal Hoch { get; set; } = decimal.Zero;
        protected long J { get; set; } = 0;
        protected decimal Jbmg { get; set; } = decimal.Zero;
        protected decimal Jlfreib { get; set; } = decimal.Zero;
        protected decimal Jlhinzu { get; set; } = decimal.Zero;
        protected decimal Jw { get; set; } = decimal.Zero;
        protected decimal Jwlsta { get; set; } = decimal.Zero;
        protected decimal Jwlstn { get; set; } = decimal.Zero;
        protected decimal Jwsolza { get; set; } = decimal.Zero;
        protected decimal Jwsolzn { get; set; } = decimal.Zero;
        protected decimal Jwbka { get; set; } = decimal.Zero;
        protected decimal Jwbkn { get; set; } = decimal.Zero;
        protected long K { get; set; } = 0;
        protected long Kennvmt { get; set; } = 0;
        protected decimal Kfb { get; set; } = decimal.Zero;
        protected decimal Kvsatzag { get; set; } = decimal.Zero;
        protected decimal Kvsatzan { get; set; } = decimal.Zero;
        protected long Kztab { get; set; } = 0;
        protected decimal Lstjahr { get; set; } = decimal.Zero;
        protected decimal Lst1 { get; set; } = decimal.Zero;
        protected decimal Lst2 { get; set; } = decimal.Zero;
        protected decimal Lst3 { get; set; } = decimal.Zero;
        protected decimal Lstoso { get; set; } = decimal.Zero;
        protected decimal Lstso { get; set; } = decimal.Zero;
        protected decimal Mist { get; set; } = decimal.Zero;
        protected decimal Pvsatzag { get; set; } = decimal.Zero;
        protected decimal Pvsatzan { get; set; } = decimal.Zero;
        protected decimal Rvsatzan { get; set; } = decimal.Zero;
        protected decimal Rw { get; set; } = decimal.Zero;
        protected decimal Sap { get; set; } = decimal.Zero;
        protected decimal Schleifz { get; set; } = decimal.Zero;
        protected decimal Solzfrei { get; set; } = decimal.Zero;
        protected decimal Solzj { get; set; } = decimal.Zero;
        protected decimal Solzmin { get; set; } = decimal.Zero;
        protected decimal Solzsbmg { get; set; } = decimal.Zero;
        protected decimal Solzszve { get; set; } = decimal.Zero;
        protected decimal Solzvbmg { get; set; } = decimal.Zero;
        protected decimal St { get; set; } = decimal.Zero;
        protected decimal St1 { get; set; } = decimal.Zero;
        protected decimal St2 { get; set; } = decimal.Zero;
        protected decimal Stovmt { get; set; } = decimal.Zero;
        protected decimal Tab1 { get; set; } = decimal.Zero;
        protected decimal Tab2 { get; set; } = decimal.Zero;
        protected decimal Tab3 { get; set; } = decimal.Zero;
        protected decimal Tab4 { get; set; } = decimal.Zero;
        protected decimal Tab5 { get; set; } = decimal.Zero;
        protected decimal Vbezb { get; set; } = decimal.Zero;
        protected decimal Vbezbso { get; set; } = decimal.Zero;
        protected decimal Vergl { get; set; } = decimal.Zero;
        protected decimal Vhb { get; set; } = decimal.Zero;
        protected decimal Vkv { get; set; } = decimal.Zero;
        protected decimal Vsp { get; set; } = decimal.Zero;
        protected decimal Vspn { get; set; } = decimal.Zero;
        protected decimal Vsp1 { get; set; } = decimal.Zero;
        protected decimal Vsp2 { get; set; } = decimal.Zero;
        protected decimal Vsp3 { get; set; } = decimal.Zero;
        protected decimal W1stkl5 { get; set; } = decimal.Zero;
        protected decimal W2stkl5 { get; set; } = decimal.Zero;
        protected decimal W3stkl5 { get; set; } = decimal.Zero;
        protected decimal X { get; set; } = decimal.Zero;
        protected decimal Y { get; set; } = decimal.Zero;
        protected decimal Zre4 { get; set; } = decimal.Zero;
        protected decimal Zre4j { get; set; } = decimal.Zero;
        protected decimal Zre4vp { get; set; } = decimal.Zero;
        protected decimal Zre4vpm { get; set; } = decimal.Zero;
        protected decimal Ztabfb { get; set; } = decimal.Zero;
        protected decimal Zvbez { get; set; } = decimal.Zero;
        protected decimal Zvbezj { get; set; } = decimal.Zero;
        protected decimal Zve { get; set; } = decimal.Zero;
        protected decimal Zx { get; set; } = decimal.Zero;
        protected decimal Zzx { get; set; } = decimal.Zero;

        // eigene Felder

        protected decimal Rentenversicherung { get; set; } = decimal.Zero;
        protected decimal Arbeitslosenversicherung { get; set; } = decimal.Zero;
        protected decimal Krankenversicherung { get; set; } = decimal.Zero;
        protected decimal Pflegeversicherung_Arbeitnehmer { get; set; } = decimal.Zero;
        protected decimal Pflegeversicherung_Arbeitgeber { get; set; } = decimal.Zero;
        protected decimal Kirschensteuer { get; set; } = decimal.Zero;
        protected decimal Gesamt_steuer { get; set; } = decimal.Zero;
        protected decimal Summe_Socialversicherung_Aarbeitnehmer { get; set; } = decimal.Zero;
        protected decimal Summe_Socialversicherung_Aarbeitgeber { get; set; } = decimal.Zero;
        protected decimal Netto_lohn { get; set; } = decimal.Zero;
        protected decimal Gesamt_belastung_Arbeitgeber { get; set; } = decimal.Zero;

        protected decimal Tab(int tab, long j)
        {
            if (j <= 15)
            {
                if (tab == 1 || tab == 4)
                {
                    return 0.400m - (j - 1) * 0.016m;
                } else if (tab == 2)
                {
                    return 3000m - (j - 1) * 120m;
                } else if (tab == 3)
                {
                    return 900m - (j - 1) * 36m;
                } else if (tab == 5)
                {
                    return 1900 - (j - 1) * 76;
                }
            } else if (j >= 36)
            {
                return 0;
            } else if (j >= 16)
            {
                if (tab == 1 || tab == 4)
                {
                    return 0.160m - (j - 16) * 0.008m; 
                } else if (tab == 2)
                {
                    return 1200m - (j - 16) * 60;
                } else if (tab == 3)
                {
                    return 360m - (j - 16) * 18;
                } else if (tab == 5)
                {
                    return 760m - (j - 16) * 38;
                }
            }
            return 0;
        }
    }
}
