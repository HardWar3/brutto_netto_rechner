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
        public decimal Entsch { get; set; }
        public decimal F { get; set; }
        public decimal Jfreib { get; set; }
        public decimal Jhinzu { get; set; }   
        public decimal Jre4 { get; set; }
        public decimal Jre4ent { get; set; }
        public decimal Jvbez { get; set; }
        public long Krv { get; set; }
        public decimal Kvz { get; set; }
        public long Lzz { get; set; }
        public decimal Lzzfreib { get; set; }
        public decimal Lzzhinzu { get; set; }
        public decimal Mbv { get; set; }
        public decimal Pkpv { get; set; }
        public long Pkv { get; set; }
        public long Pva { get; set; }
        public long Pvs { get; set; }
        public long Pvz { get; set; }
        public long R { get; set; }
        public decimal Re4 { get; set; }
        public decimal Sonstb { get; set; }
        public decimal Sonstent { get; set; }
        public decimal Sterbe { get; set; }
        public long Stkl { get; set; }
        public decimal Vbez { get; set; }
        public decimal Vbezm { get; set; }
        public decimal Vbezs { get; set; }
        public decimal Vbs { get; set; }
        public long Vjahr { get; set; }
        public decimal Vkapa { get; set; }
        public decimal Vmt { get; set; }
        public decimal Zkf { get; set; }
        public long Zmvb { get; set; }

        // Ausgabeparameter

        public decimal Bk { get; set; }
        public decimal Bks { get; set; }
        public decimal Bkv { get; set; }
        public decimal Lstlzz { get; set; }
        public decimal Solzlzz { get; set; }
        public decimal Solzs { get; set; }
        public decimal Solzv { get; set; }
        public decimal Sts { get; set; }
        public decimal Stv { get; set; }
        public decimal Vkvlzz { get; set; }
        public decimal Vkvsonst { get; set; }

        // interne Felder or Ausgabeparamter DBA (Doppelbesterungsabkommen)

        public decimal Vfrb { get; set; }
        public decimal Vfrbs1 { get; set; }
        public decimal Vfrbs2 { get; set; }
        public decimal Wvfrb { get; set; }
        public decimal Wvfrbm { get; set; }
        public decimal Wvfrbo { get; set; }

        // interne Felder

        public decimal Alte { get; set; }
        public decimal Anp { get; set; }
        public decimal Anteil1 { get; set; }
        public decimal Bbgkvpv { get; set; }
        public decimal Bbgrv { get; set; }
        public decimal Bmg { get; set; }
        public decimal Diff { get; set; }
        public decimal Efa { get; set; }
        public decimal Fvb { get; set; }
        public decimal Fvbso { get; set; }
        public decimal Fvbz { get; set; }
        public decimal Fvbzso { get; set; }
        public decimal Gfb { get; set; }
        public decimal Hbalte { get; set; }
        public decimal Hfvb { get; set; }
        public decimal Hfvbz { get; set; }
        public decimal Hfvbzso { get; set; }
        public decimal Hoch { get; set; }
        public long J { get; set; }
        public decimal Jbmg { get; set; }
        public decimal Jlfreib { get; set; }
        public decimal Jlhinzu { get; set; }
        public decimal Jw { get; set; }
        public decimal Jwlsta { get; set; }
        public decimal Jwlstn { get; set; }
        public decimal Jwsolza { get; set; }
        public decimal Jwsolzn { get; set; }
        public decimal Jwbka { get; set; }
        public decimal Jwbkn { get; set; }
        public long K { get; set; }
        public long Kennvmt { get; set; }
        public decimal Kfb { get; set; }
        public decimal Kvsatzag { get; set; }
        public decimal Kvsatzan { get; set; }
        public long Kztab { get; set; }
        public decimal Lstjahr { get; set; }
        public decimal Lst1 { get; set; }
        public decimal Lst2 { get; set; }
        public decimal Lst3 { get; set; }
        public decimal Lstoso { get; set; }
        public decimal Lstso { get; set; }
        public decimal Mist { get; set; }
        public decimal Pvsatzag { get; set; }
        public decimal Pvsatzan { get; set; }
        public decimal Rvsatzan { get; set; }
        public decimal Rw { get; set; }
        public decimal Sap { get; set; }
        public decimal Schleifz { get; set; }
        public decimal Solzfrei { get; set; }
        public decimal Solzj { get; set; }
        public decimal Solzmin { get; set; }
        public decimal Solzsbmg { get; set; }
        public decimal Solzszve { get; set; }
        public decimal Solzvbmg { get; set; }
        public decimal St { get; set; }
        public decimal St1 { get; set; }
        public decimal St2 { get; set; }
        public decimal Stovmt { get; set; }
        public decimal Tab1 { get; set; }
        public decimal Tab2 { get; set; }
        public decimal Tab3 { get; set; }
        public decimal Tab4 { get; set; }
        public decimal Tab5 { get; set; }
        public decimal Vbezb { get; set; }
        public decimal Vbezbso { get; set; }
        public decimal Vergl { get; set; }
        public decimal Vhb { get; set; }
        public decimal Vkv { get; set; }
        public decimal Vsp { get; set; }
        public decimal Vspn { get; set; }
        public decimal Vsp1 { get; set; }
        public decimal Vsp2 { get; set; }
        public decimal Vsp3 { get; set; }
        public decimal W1stkl5 { get; set; }
        public decimal W2stkl5 { get; set; }
        public decimal W3stkl5 { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Zre4 { get; set; }
        public decimal Zre4j { get; set; }
        public decimal Zre4vp { get; set; }
        public decimal Zre4vpm { get; set; }
        public decimal Ztabfb { get; set; }
        public decimal Zvbez { get; set; }
        public decimal Zvbezj { get; set; }
        public decimal Zve { get; set; }
        public decimal Zx { get; set; }
        public decimal Zzx { get; set; }

        // eigene Felder

        public decimal Rentenversicherung { get; set; }
        public decimal Arbeitslosenversicherung { get; set; }
        public decimal Krankenversicherung { get; set; }
        public decimal Pflegeversicherung_Arbeitnehmer { get; set; }
        public decimal Pflegeversicherung_Arbeitgeber { get; set; }
        public decimal Kirschensteuer { get; set; }
        public decimal Gesamt_steuer { get; set; }
        public decimal Summe_Socialversicherung_Aarbeitnehmer { get; set; }
        public decimal Summe_Socialversicherung_Aarbeitgeber { get; set; }
        public decimal Netto_lohn { get; set; }
        public decimal Gesamt_belastung_Arbeitgeber { get; set; }
    }
}
