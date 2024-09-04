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

        public long Af { get; set; }
        public long Ajahr { get; set; }
        public long Alter1 {  get; set; }
        public double Entsch { get; set; }
        public double F { get; set; }
        public double Jfreib { get; set; }
        public double Jhinzu { get; set; }   
        public double Jre4 { get; set; }
        public double Jre4ent { get; set; }
        public double Jvbez { get; set; }
        public long Krv { get; set; }
        public double Kvz { get; set; }
        public long Lzz { get; set; }
        public double Lzzfreib { get; set; }
        public double Lzzhinzu { get; set; }
        public double Mbv { get; set; }
        public double Pkpv { get; set; }
        public long Pkv { get; set; }
        public long Pvs { get; set; }
        public long Pvz { get; set; }
        public long R { get; set; }
        public double Re4 { get; set; }
        public double Sonstb { get; set; }
        public double Sonstent { get; set; }
        public double Sterbe { get; set; }
        public long Stkl { get; set; }
        public double Vbez { get; set; }
        public double Vbezm { get; set; }
        public double Vbezs { get; set; }
        public double Vbs { get; set; }
        public long Vjahr { get; set; }
        public double Vkapa { get; set; }
        public double Vmt { get; set; }
        public double Zkf { get; set; }
        public long Zmvb { get; set; }

        // Ausgabeparameter

        public double Bk { get; set; }
        public double Bks { get; set; }
        public double Bkv { get; set; }
        public double Lstlzz { get; set; }
        public double Solzlzz { get; set; }
        public double Solzs { get; set; }
        public double Solzv { get; set; }
        public double Sts { get; set; }
        public double Stv { get; set; }
        public double Vkvlzz { get; set; }
        public double Vkvsonst { get; set; }

        // interne Felder or Ausgabeparamter DBA (Doppelbesterungsabkommen)

        public double Vfrb { get; set; }
        public double Vfrbs1 { get; set; }
        public double Vfrbs2 { get; set; }
        public double Wvfrb { get; set; }
        public double Wvfrbm { get; set; }
        public double Wvfrbo { get; set; }

        // interne Felder

        public double Alte { get; set; }
        public double Anp { get; set; }
        public double Anteil1 { get; set; }
        public double Bbgkvpv { get; set; }
        public double Bbgrv { get; set; }
        public double Bmg { get; set; }
        public double Diff { get; set; }
        public double Efa { get; set; }
        public double Fvb { get; set; }
        public double Fvbso { get; set; }
        public double Fvbz { get; set; }
        public double Fvbzso { get; set; }
        public double Gfb { get; set; }
        public double Hbalte { get; set; }
        public double Hfvb { get; set; }
        public double Hfvbz { get; set; }
        public double Hfvbzso { get; set; }
        public double Hoch { get; set; }
        public long J { get; set; }
        public double Jbmg { get; set; }
        public double Jlfreib { get; set; }
        public double Jlhinzu { get; set; }
        public double Jw { get; set; }
        public long K { get; set; }
        public long Kennvmt { get; set; }
        public double Kfb { get; set; }
        public double Kvsatzag { get; set; }
        public double Kvsatzan { get; set; }
        public long Kztab { get; set; }
        public double Lstjahr { get; set; }
        public double Lst1 { get; set; }
        public double Lst2 { get; set; }
        public double Lst3 { get; set; }
        public double Lstoso { get; set; }
        public double Lstso { get; set; }
        public double Mist { get; set; }
        public double Pvsatzag { get; set; }
        public double Pvsatzan { get; set; }
        public double Rvsatzan { get; set; }
        public double Rw { get; set; }
        public double Sap { get; set; }
        public double Solzfrei { get; set; }
        public double Solzj { get; set; }
        public double Solzmin { get; set; }
        public double Solzsbmg { get; set; }
        public double Solzszve { get; set; }
        public double Solzvbmg { get; set; }
        public double St { get; set; }
        public double St1 { get; set; }
        public double St2 { get; set; }
        public double Stovmt { get; set; }
        public double Tab1 { get; set; }
        public double Tab2 { get; set; }
        public double Tab3 { get; set; }
        public double Tab4 { get; set; }
        public double Tab5 { get; set; }
        public double Tbsvorv { get; set; }
        public double Vbezb { get; set; }
        public double Vbezbso { get; set; }
        public double Vergl { get; set; }
        public double Vhb { get; set; }
        public double Vkv { get; set; }
        public double Vsp { get; set; }
        public double Vspn { get; set; }
        public double Vsp1 { get; set; }
        public double Vsp2 { get; set; }
        public double Vsp3 { get; set; }
        public double W1stkl5 { get; set; }
        public double W2stkl5 { get; set; }
        public double W3stkl5 { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Zre4 { get; set; }
        public double Zre4j { get; set; }
        public double Zre4vp { get; set; }
        public double Ztabfb { get; set; }
        public double Zvbez { get; set; }
        public double Zvbezj { get; set; }
        public double Zve { get; set; }
        public double Zx { get; set; }
        public double Zzx { get; set; }

        // eigene Felder

        public double Rentenversicherung { get; set; }
        public double Arbeitslosenversicherung { get; set; }
        public double Krankenversicherung { get; set; }
        public double Pflegeversicherung_Arbeitnehmer { get; set; }
        public double Pflegeversicherung_Arbeitgeber { get; set; }
        public double Kirschensteuer { get; set; }
        public double Gesamt_steuer { get; set; }
        public double Summe_Socialversicherung_Aarbeitnehmer { get; set; }
        public double Summe_Socialversicherung_Aarbeitgeber { get; set; }
        public double Netto_lohn { get; set; }
        public double Gesamt_belastung_Arbeitgeber { get; set; }
    }
}
