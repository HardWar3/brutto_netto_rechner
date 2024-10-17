using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Serilog;

namespace brutto_netto_rechner.classes
{
    internal class Lohnsteuer_2024DEC : Lohnsteuer_Basic
    {
        public override void Start()
        {
            Log.Debug("Start()");

            Lohnsteuer_2024();
            Sozialversicherung();
            Kirchensteuer_Berechnung();
            Zusammenrechnen();
        }
        protected override void Sozialversicherung()
        {
            Log.Debug("Sozialversicherung()");

            Arbeitslosenversicherung_Berechnung();
            Krankenversicherung_Berechnung();
            Pflegeversicherung_Berechnung();
            Rentenversicherung_Berechnung();
        }
        protected override void Arbeitslosenversicherung_Berechnung()
        {
            Log.Debug("Arbeitslosenversicherung_Berechnung()");

            const decimal Arbeitsversicherungsanteil = 0.013m;
            Arbeitslosenversicherung = Math.Round(Re4 * Arbeitsversicherungsanteil);
        }
        protected override void Krankenversicherung_Berechnung()
        {
            Log.Debug("Krankenversicherung_Berechnung()");

            const decimal Krankenversicherungsanteil = 0.073m;
            decimal Krankenversicherungs_Zusatzbeitrag_Arbteitsnehmeranteil = (Kvz / 2m) / 100m;
            Krankenversicherung = Math.Round(Re4 * (Krankenversicherungsanteil + Krankenversicherungs_Zusatzbeitrag_Arbteitsnehmeranteil), 2);
        }
        protected override void Pflegeversicherung_Berechnung()
        {
            Log.Debug("Pflegeversicherung_Berechnung()");

            const decimal Pflegeversicherungsanteil = 1.7m;
            const decimal Pflegeversicherungsanteil_Sachen = 2.2m;
            const decimal Pflegeversicherungsanteil_Zuschlag = 0.6m;

            decimal Pflegeversicherung_Zusammen;
            decimal Pflegeversicherung_Arbeitgeber_Zusammen;

            if (Pvs == 1)
            {
                if (Pvz == 0)
                {
                    Pflegeversicherung_Zusammen = Pflegeversicherungsanteil_Sachen;
                }
                else
                {
                    Pflegeversicherung_Zusammen = Pflegeversicherungsanteil_Sachen + Pflegeversicherungsanteil_Zuschlag;
                }
                Pflegeversicherung_Arbeitgeber_Zusammen = Pflegeversicherungsanteil_Sachen - 1m; // Sachen Arbeitgeber Zahlt weniger
            }
            else
            {
                if (Pvz == 0)
                {
                    Pflegeversicherung_Zusammen = Pflegeversicherungsanteil;
                }
                else
                {
                    Pflegeversicherung_Zusammen = Pflegeversicherungsanteil + Pflegeversicherungsanteil_Zuschlag;
                }
                Pflegeversicherung_Arbeitgeber_Zusammen = Pflegeversicherungsanteil;
            }

            Pflegeversicherung_Arbeitnehmer = Math.Round(Re4 * (Pflegeversicherung_Zusammen / 100m), 2);
            Pflegeversicherung_Arbeitgeber = Math.Round(Re4 * (Pflegeversicherung_Arbeitgeber_Zusammen / 100m), 2);
        }
        protected override void Rentenversicherung_Berechnung()
        {
            Log.Debug("Rentenversicherung_Berechnung()");

            const decimal Rentenversicherungsanteil = 0.093m;
            Rentenversicherung = Math.Round(Re4 * Rentenversicherungsanteil, 2);
        }
        protected void Kirchensteuer_Berechnung()
        {
            Log.Debug("Kirchensteuer_Berechnung()");

            if (R != 0)
            {
                const decimal Kirchensteueranteil = 0.09m;
                Kirchensteuer = Math.Round(Lstlzz * Kirchensteueranteil);
            }
        }
        private void Lohnsteuer_2024()
        {
            Log.Debug("Lohnsteuer_2024()");

            Mpara();
            Mre4jl();
            Vbezbso = decimal.Zero;
            Kennvmt = 0;
            Mre4();
            Mre4abz();
            Zre4vpm = Zre4vp;
            Schleifz = 1m;
            Mberech();
            Schleifz = 2m;
            W1stkl5 = 13432m;
            Gfb = 11784m;
            Zre4vp = Zre4vpm;
            Mberech();
            Mlst1224();
            Msonst();
            Mvmt();
        }
        private void Mpara()
        {
            Log.Debug("Mpara()");

            if (Krv < 2)
            {
                if (Krv == 0)
                {
                    Bbgrv = 90600m;
                }
                else
                {
                    Bbgrv = 89400m;
                }
                Rvsatzan = 0.093m;
            }

            Bbgkvpv = 62100m;
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
            if (Pvz == 1)
            {
                Pvsatzan += 0.006m;
            }
            else
            {
                Pvsatzan = Pvsatzan - Pva * 0.0025m;
            }
            W1stkl5 = 13279m;
            W2stkl5 = 33380m;
            W3stkl5 = 222260m;
            Gfb = 11604m;
            Solzfrei = 18130m;
        }
        private void Mre4jl()
        {
            Log.Debug("Mre4jl()");

            switch (Lzz)
            {
                case 1:
                    Zre4j = Re4 / 100m;
                    Zvbezj = Vbez / 100m;
                    Jlfreib = Lzzfreib / 100m;
                    Jlhinzu = Lzzhinzu / 100m;
                    break;
                case 2:
                    Zre4j = Re4 * 12m / 100m;
                    Zvbezj = Vbez * 12m / 100m;
                    Jlfreib = Lzzfreib * 12m / 100m;
                    Jlhinzu = Lzzhinzu * 12m / 100m;
                    break;
                case 3:
                    Zre4j = Re4 * 360m / 7m / 100m;
                    Zvbezj = Vbez * 360m / 7m / 100m;
                    Jlfreib = Lzzfreib * 360m / 7m / 100m;
                    Jlhinzu = Lzzhinzu * 360m / 7m / 100m;
                    break;
                default:
                    Zre4j = Re4 * 360m / 100m;
                    Zvbezj = Vbez * 360m / 100m;
                    Jlfreib = Lzzfreib * 360m / 100m;
                    Jlhinzu = Lzzhinzu * 360m / 100m;
                    break;
            }
            if (Af == 0)
            {
                F = 1;
            }
        }
        private void Mre4()
        {
            Log.Debug("Mre4()");

            if (Zvbezj == 0)
            {
                Fvbz = decimal.Zero;
                Fvb = decimal.Zero;
                Fvbzso = decimal.Zero;
                Fvbso = decimal.Zero;
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

                if (Lzz == 1)
                {
                    Vbezb = Vbezm * Zmvb + Vbezs;
                    Hfvb = Tab(2, J) / 12m * Zmvb;
                    // TODO aufrunden auf ganze euro
                    Fvbz = Tab(3, J) / 12m * Zmvb;
                    Fvbz = Math.Round(Fvbz, 0, MidpointRounding.ToPositiveInfinity);
                }else
                {
                    Vbezb = Vbezm * 12m + Vbezs;
                    Hfvb = Tab(2, J);
                    Fvbz = Tab(3, J);
                }
                // TODO aufrunden auf ganze cents
                Fvb = Vbezb * Tab(1, J) / 100m;
                Fvb = Math.Round(Fvb, 2, MidpointRounding.ToPositiveInfinity);
                if (Fvb > Hfvb)
                {
                    Fvb = Hfvb;
                }
                if (Fvb > Zvbezj)
                {
                    Fvb = Zvbezj;
                }
                // TODO aufrunden auf ganze cents
                Fvbso = Fvb + Vbezbso * Tab(1, J) / 100m;
                Fvbso = Math.Round(Fvbso, 2, MidpointRounding.ToPositiveInfinity);
                if (Fvbso > Tab(2, J))
                {
                    Fvbso = Tab(2, J);
                }
                Hfvbzso = (Vbezb + Vbezbso) / 100m - Fvbso;
                // TODO aufrunden auf ganze euro
                Fvbzso = Fvbz + Vbezbso / 100m;
                Fvbzso = Math.Round(Fvbzso, 0, MidpointRounding.ToPositiveInfinity);
                if (Fvbzso > Hfvbzso)
                {
                    // TODO aufrunden auf ganze euro
                    Fvbzso = Hfvbzso;
                    Fvbzso = Math.Round(Fvbzso, 0, MidpointRounding.ToPositiveInfinity);
                }
                if (Fvbzso > Tab(3, J))
                {
                    Fvbzso = Tab(3, J);
                }
                Hfvbz = Vbezb / 100m - Fvb;
                if (Fvbz > Hfvbz)
                {
                    // TODO aufrunden auf ganze euro
                    Fvbz = Hfvbz;
                    Fvbz = Math.Round(Fvbz, 0, MidpointRounding.ToPositiveInfinity);
                }
            }
            Mre4alte();
        }
        private void Mre4alte() 
        {
            Log.Debug("Mre4alte()");

            if (Alter1 == 0)
            {
                Alte = decimal.Zero;
            } else
            {
                if (Ajahr < 2006)
                {
                    K = 1;
                } else if (Ajahr < 2040)
                {
                    K = Ajahr - 2004;
                } else
                {
                    K = 36;
                }
                Bmg = Zre4j - Zvbezj;
                // TODO aufrunden auf ganze euro
                Alte = Bmg * Tab(4, K);
                Alte = Math.Round(Alte, 0, MidpointRounding.ToPositiveInfinity);
                Hbalte = Tab(5, K);
                if (Alte > Hbalte)
                {
                    Alte = Hbalte;
                }
            }
        }
        private void Mre4abz()
        {
            Log.Debug("Mre4abz()");

            Zre4 = Zre4j - Fvb - Alte - Jlfreib + Jlhinzu;
            if (Zre4 < 0)
            {
                Zre4 = decimal.Zero;
            }
            Zre4vp = Zre4j;
            if (Kennvmt == 2)
            {
                Zre4vp = Zre4vp - Entsch / 100m;
            }
            Zvbez = Zvbezj - Fvb;
            if (Zvbez < 0)
            {
                Zvbez = decimal.Zero;
            }
        }
        private void Mberech()
        {
            Log.Debug("Mberech()");

            if (Schleifz == 1)
            {
                Mztabfba();
            } else
            {
                Mztabfbn();
            }
            Vfrb = (Anp + Fvb + Fvbz) * 100m;
            Mlstjahr();
            Wvfrb = (Zve - Gfb) * 100m;
            if (Wvfrb < 0)
            {
                Wvfrb = decimal.Zero;
            }
            Lstjahr = St * F;
            Uplstlzz();
            Upvkvlzz();
            if (Zkf > 0)
            {
                Ztabfb += Kfb;
                Mre4abz();
                Mlstjahr();
                Jbmg = St * F;
            } else
            {
                Jbmg = Lstjahr;
            }
            Msolz();
        }
        private void Mztabfba()
        {
            Log.Debug("Mztabfba()");

            Anp = decimal.Zero;
            if (Zvbez >= 0 && Zvbez < Fvbz) 
            {
                Fvbz = Zvbez;
            }
            if (Stkl < 6)
            {
                if (Zvbez > 0)
                {
                    if (Zvbez - Fvbz < 102)
                    {
                        // TODO aufrunden auf ganze euro
                        Anp = Zvbez - Fvbz;
                        Anp = Math.Round(Anp, 0, MidpointRounding.ToPositiveInfinity);
                    } else
                    {
                        Anp = 102m;
                    }
                }
            } else
            {
                Fvbz = decimal.Zero;
                Fvbzso = decimal.Zero;
            }
            if (Stkl < 6)
            {
                if (Zre4 > Zvbez)
                {
                    if (Zre4 - Zvbez < 1230)
                    {
                        // TODO aufrunden auf ganze euro
                        Anp = Anp + Zre4 - Zvbez;
                        Anp = Math.Round(Anp, 0, MidpointRounding.ToPositiveInfinity);
                    } else
                    {
                        Anp += 1230m;
                    }
                }
            }
            Kztab = 1;
            switch (Stkl)
            {
                case 1:
                    Sap = 36m;
                    Kfb = Zkf * 9312m;
                    break;
                case 2:
                    Efa = 4260m;
                    Sap = 36m;
                    Kfb = Zkf * 9312m;
                    break;
                case 3:
                    Kztab = 2;
                    Sap = 36m;
                    Kfb = Zkf * 9312m;
                    break;
                case 4:
                    Sap = 36m;
                    Kfb = Zkf * 4656m;
                    break;
                case 5:
                    Sap = 36m;
                    Kfb = decimal.Zero;
                    break;
                default:
                    Kfb = decimal.Zero;
                    break;
            }
            Ztabfb = Efa + Anp + Sap + Fvbz;
        }
        private void Mztabfbn()
        {
            Log.Debug("Mztabfbn()");

            Anp = decimal.Zero;
            if (Zvbez >= 0 && Zvbez < Fvbz)
            {
                Fvbz = Zvbez;
            }
            if (Stkl < 6)
            {
                if (Zvbez > 0)
                {
                    if (Zvbez - Fvbz < 102)
                    {
                        // TODO aufrunden auf ganze euro
                        Anp = Zvbez - Fvbz;
                        Anp = Math.Round(Anp, 0, MidpointRounding.ToPositiveInfinity);
                    } else
                    {
                        Anp = 102m;
                    }
                }
            } else
            {
                Fvbz = decimal.Zero;
                Fvbzso = decimal.Zero;
            }
            if (Stkl < 6 && Zre4 > Zvbez)
            {
                if (Zre4 - Zvbez < 1230)
                {
                    // TODO aufrunden auf ganze euro
                    Anp = Anp + Zre4 - Zvbez;
                    Anp = Math.Round(Anp, 0, MidpointRounding.ToPositiveInfinity);
                } else
                {
                    Anp += 1230m;
                }
            }
            Kztab = 1;
            switch (Stkl)
            {
                case 1:
                    Sap = 36m;
                    Kfb = Zkf * 9540m;
                    break;
                case 2:
                    Efa = 4260m;
                    Sap = 36m;
                    Kfb = Zkf * 9540m;
                    break;
                case 3:
                    Kztab = 2;
                    Sap = 36m;
                    Kfb = Zkf * 9540m;
                    break;
                case 4:
                    Sap = 36m;
                    Kfb = Zkf * 4770m;
                    break;
                case 5:
                    Sap = 36m;
                    Kfb = decimal.Zero;
                    break;
                default:
                    Kfb = decimal.Zero;
                    break;
            }
            Ztabfb = Efa + Anp + Sap + Fvbz;
        }
        private void Mlstjahr()
        {
            Log.Debug("Mlstjahr()");

            Upevp();
            if (Kennvmt != 1)
            {
                Zve = Zre4 - Ztabfb - Vsp;
                Upmlst();
            } else
            {
                Zve = Zre4 - Ztabfb - Vsp - Vmt / 100m - Vkapa / 100m;
                if (Zve < 0)
                {
                    Zve = (Zve + Vmt / 100m + Vkapa / 100m) / 5m;
                    Upmlst();
                    St *= 5m;
                } else
                {
                    Upmlst();
                    Stovmt = St;
                    Zve = Zve + (Vmt + Vkapa) / 500m;
                    Upmlst();
                    St = (St - Stovmt) * 5m + Stovmt;
                }
            }
        }
        private void Mvsp()
        {
            Log.Debug("Mvsp()");

            if (Zre4vp > Bbgkvpv)
            {
                Zre4vp = Bbgkvpv;
            }
            if (Pkv > 0)
            {
                if (Stkl == 6)
                {
                    Vsp3 = decimal.Zero;
                } else
                {
                    Vsp3 = Pkpv * 12m / 100m;
                    if (Pkv == 2)
                    {
                        Vsp3 = Vsp3 - Zre4vp * (Kvsatzag + Pvsatzag);
                    }
                }
            } else
            {
                Vsp3 = Zre4vp * (Kvsatzan + Pvsatzan);
            }
            // TODO aufrunden auf ganze euro
            Vsp = Vsp3 + Vsp1;
            Vsp = Math.Round(Vsp, 0, MidpointRounding.ToPositiveInfinity);
        }
        private void Mst5_6()
        {
            Log.Debug("Mst5_6()");

            Zzx = X;
            if (Zzx > W2stkl5)
            {
                Zx = W2stkl5;
                Up5_6();
                if (Zzx > W3stkl5)
                {
                    // TODO abrunden auf ganze euro
                    St += (W3stkl5 - W2stkl5) * 0.42m;
                    St = Math.Round(St, 0, MidpointRounding.ToNegativeInfinity);
                    // TODO abrunden auf ganze euro
                    St += (Zzx - W3stkl5) * 0.45m;
                    St = Math.Round(St, 0, MidpointRounding.ToNegativeInfinity);
                } else
                {
                    // TODO abrunden auf ganze euro
                    St += (Zzx - W2stkl5) * 0.42m;
                    St = Math.Round(St, 0, MidpointRounding.ToNegativeInfinity);
                }
            } else
            {
                Zx = Zzx;
                Up5_6();
                if (Zzx > W1stkl5)
                {
                    Vergl = St;
                    Zx = W1stkl5;
                    Up5_6();
                    // TODO abrunden auf ganze euro
                    Hoch = St + (Zzx - W1stkl5) * 0.42m;
                    Hoch = Math.Round(Hoch, 0, MidpointRounding.ToNegativeInfinity);
                    if (Hoch < Vergl)
                    {
                        St = Hoch;
                    } else
                    {
                        St = Vergl;
                    }
                }
            }
        }
        private void Msolz()
        {
            Log.Debug("Msolz()");

            Solzfrei *= Kztab;
            if (Jbmg > Solzfrei)
            {
                // TODO abrunden auf ganze cents
                Solzj = Jbmg * 5.5m / 100m;
                Solzj = Math.Round(Solzj, 2, MidpointRounding.ToNegativeInfinity);
                Solzmin = (Jbmg - Solzfrei) * 11.9m / 100m;
                if (Solzmin < Solzj)
                {
                    Solzj = Solzmin;
                }
                Jw = Solzj * 100m;
                if (Schleifz == 1)
                {
                    Jwsolza = Jw;
                } else
                {
                    Jwsolzn = Jw;
                }
                Upanteil();
                Solzlzz = Anteil1;
            } else
            {
                Solzlzz = decimal.Zero;
            }
            if (R > 0)
            {
                Jw = Jbmg * 100m;
                if (Schleifz == 1)
                {
                    Jwbka = Jw;
                } else
                {
                    Jwbkn = Jw;
                }
                Upanteil();
                Bk = Anteil1;
            } else
            {
                Bk = decimal.Zero;
            }
        }
        private void Mlst1224()
        {
            Log.Debug("Mlst1224()");

            if (Lzz > 1)
            {
                Jw = Jwlstn - 11m * (Jwlsta - Jwlstn);
                if (Jw < 0)
                {
                    Anteil1 = decimal.Zero;
                } else
                {
                    Upanteil();
                }
                Lstlzz = Anteil1;
                Jw = Jwsolzn - 11m * (Jwsolza - Jwsolzn);
                if (Jw < 0)
                {
                    Anteil1 = decimal.Zero;
                } else
                {
                    Upanteil();
                }
                Solzlzz = Anteil1;
                Jw = Jwbkn - 11m * (Jwbka - Jwbkn);
                if (Jw < 0)
                {
                    Anteil1 = decimal.Zero;
                } else
                {
                    Upanteil();
                }
                Bk = Anteil1;
            }
        }
        private void Msonst()
        {
            Log.Debug("Msonst()");

            Lzz = 1;
            if (Zmvb == 0)
            {
                Zmvb = 12;
            }
            if (Sonstb == 0 && Mbv == 0)
            {
                Vkvsonst = decimal.Zero;
                Lstso = decimal.Zero;
                Sts = decimal.Zero;
                Solzs = decimal.Zero;
                Bks = decimal.Zero;
            } else
            {
                Mosonst();
                Upvkv();
                Vkvsonst = Vkv;
                Zre4j = (Jre4 + Sonstb) / 100m;
                Zvbezj = (Jvbez + Vbs) / 100m;
                Vbezbso = Sterbe;
                Mre4sonst();
                Mlstjahr();
                Wvfrbm = (Zve - Gfb) * 100m;
                if (Wvfrbm < 0)
                {
                    Wvfrbm = decimal.Zero;
                }
                Upvkv();
                Vkvsonst = Vkv - Vkvsonst;
                Lstso = St * 100m;
                // TODO abrunden auf ganze Euro !!! SPECIAL !!!
                Sts = (Lstso - Lstoso) * F;
                Sts = Math.Round(Sts, 0, MidpointRounding.ToNegativeInfinity);
                Stsmin();
            }
        }
        private void Msolzsts()
        {
            Log.Debug("Msolzsts()");

            if (Zkf > 0)
            {
                Solzszve = Zve - Kfb;
            } else
            {
                Solzszve = Zve;
            }
            if (Solzszve < 1)
            {
                Solzszve = decimal.Zero;
                X =  decimal.Zero;
            } else
            {
                // TODO abrunden auf ganze euro
                X = Solzszve / Kztab;
                X = Math.Round(X, 0, MidpointRounding.ToNegativeInfinity);
            }
            if (Stkl < 5)
            {
                Uptab24n();
            } else
            {
                Mst5_6();
            }
            // TODO abrunden auf ganze euro
            Solzsbmg = St * F;
            Solzsbmg = Math.Round(Solzsbmg, 0, MidpointRounding.ToNegativeInfinity);
            if (Solzsbmg > Solzfrei)
            {
                // TODO abrunden auf ganze cents
                Solzs = Sts * 5.5m / 100m;
                Solzs = Math.Round(Solzs, 2, MidpointRounding.ToNegativeInfinity);
            }
            else
            {
                Solzs = decimal.Zero;
            }
        }
        private void Mvmt()
        {
            Log.Debug("Mvmt()");

            if (Vkapa < 0)
            {
                Vkapa = decimal.Zero;
            }
            if (Vmt + Vkapa > 0)
            {
                if (Lstso == 0)
                {
                    Mosonst();
                    Lst1 = Lstoso;
                }
                else
                {
                    Lst1 = Lstso;
                }
                Vbezbso = Sterbe + Vkapa;
                Zre4j = (Zre4 + Sonstb + Vmt + Vkapa) / 100m;
                Zvbezj = (Jvbez + Vbs + Vkapa) / 100m;
                Kennvmt = 2;
                Mre4sonst();
                Mlstjahr();
                Lst3 = St * 100m;
                Mre4abz();
                Zre4vp = Zre4vp - Jre4ent / 100m - Sonstent / 100m;
                Kennvmt = 1;
                Mlstjahr();
                Lst2 = St * 100m;
                Stv = Lst2 - Lst1;
                Lst3 -= Lst1;
                if (Lst3 < Stv)
                {
                    Stv = Lst3;
                }
                if (Stv < 0)
                {
                    Stv = decimal.Zero;
                } else
                {
                    // TODO abrunden auf ganze Euro
                    Stv *= F;
                    Stv = Math.Round(Stv, 0, MidpointRounding.ToNegativeInfinity);
                }
                Solzvbmg = Stv / 100m + Jbmg;
                if (Solzvbmg > Solzfrei)
                {
                    // TODO abrunden auf ganze cents
                    Solzv = Stv * 5.5m / 100m;
                    Solzv = Math.Round(Solzv, 2, MidpointRounding.ToNegativeInfinity);
                } else
                {
                    Solzv = decimal.Zero;
                }
                if (R > 0)
                {
                    Bkv = Stv;
                } else
                {
                    Bkv = decimal.Zero;
                }
            } else
            {
                Stv = decimal.Zero;
                Solzv = decimal.Zero;
                Bkv = decimal.Zero;
            }
        }
        private void Mosonst()
        {
            Log.Debug("Mosonst()");

            Zre4j = Jre4 / 100m;
            Zvbezj = Jvbez / 100m;
            Jlfreib = Jfreib / 100m;
            Jlhinzu = Jhinzu / 100m;
            Mre4();
            Mre4abz();
            Zre4vp = Zre4vp - Jre4ent / 100m;
            Mztabfbn();
            Vfrbs1 = (Anp + Fvb + Fvbz) * 100m;
            Mlstjahr();
            Wvfrbo = (Zve - Gfb) * 100m;
            if (Wvfrbo < 0)
            {
                Wvfrbo = decimal.Zero;
            }
            Lstoso = St * 100m;
        }
        private void Mre4sonst()
        {
            Log.Debug("Mre4sonst()");

            Mre4();
            Fvb = Fvbso;
            Mre4abz();
            Zre4vp = Zre4vp + Mbv / 100m - Jre4ent / 100m - Sonstent / 100m;
            Fvbz = Fvbzso;
            Mztabfbn();
            Vfrbs2 = (Anp + Fvb + Fvbz) * 100m - Vfrbs1;
        }
        private void Stsmin()
        {
            Log.Debug("Stsmin()");

            if (Sts < 0)
            {
                if (Mbv != 0)
                {
                    Lstlzz += Sts;
                    if (Lstlzz < 0)
                    {
                        Lstlzz = decimal.Zero;
                    }
                    // TODO abrunden auf ganze cents
                    Solzlzz += Sts * 5.5m / 100m;
                    Solzlzz = Math.Round(Solzlzz, 2, MidpointRounding.ToNegativeInfinity);
                    if (Solzlzz < 0)
                    {
                        Solzlzz = decimal.Zero;
                    }
                    Bk += Sts;
                    if (Bk < 0)
                    {
                        Bk = decimal.Zero;
                    }
                }
                Sts = decimal.Zero;
                Solzs = decimal.Zero;
            } else
            {
                Msolzsts();
            }
            if (R > 0)
            {
                Bks = Sts;
            } else
            {
                Bks = decimal.Zero;
            }
        }
        private void Uptab24a()
        {
            Log.Debug("Uptab24a()");

            if (X < Gfb + 1)
            {
                St = decimal.Zero;
            }
            else if (X < 17006)
            {
                Y = (X - Gfb) / 10000m;
                Rw = Y * 922.98m;
                Rw += 1400m;
                // TODO abrunde auf ganze euro
                St = Rw * Y;
                St = Math.Round(St, 0, MidpointRounding.ToNegativeInfinity);
            }
            else if (X < 66761)
            {
                Y = (X - 17005m) / 10000m;
                Rw = Y * 181.19m;
                Rw += 2397m;
                Rw *= Y;
                // TODO abrunde auf ganze euro
                St = Rw + 1025.38m;
                St = Math.Round(St, 0, MidpointRounding.ToNegativeInfinity);
            }
            else if (X < 277826)
            {
                // TODO abrunde auf ganze euro
                St = X * 0.42m - 10602.13m;
                St = Math.Round(St, 0, MidpointRounding.ToNegativeInfinity);
            }
            else
            {
                // TODO abrunde auf ganze euro
                St = X * 0.45m - 18936.88m;
                St = Math.Round(St, 0, MidpointRounding.ToNegativeInfinity);
            }
            St *= Kztab;
        }
        private void Uptab24n()
        {
            Log.Debug("Uptab24n()");

            if (X < Gfb + 1)
            {
                St = decimal.Zero;
            } else if (X < 17006)
            {
                Y = (X - Gfb) / 10000m;
                Rw = Y * 954.8m;
                Rw += 1400m;
                // TODO abrunde auf ganze euro
                St = Rw * Y;
                St = Math.Round(St, 0, MidpointRounding.ToNegativeInfinity);
            } else if (X < 66761)
            {
                Y = (X - 17005m) / 10000m;
                Rw = Y * 181.19m;
                Rw += 2397m;
                Rw *= Y;
                // TODO abrunde auf ganze euro
                St = Rw + 991.21m;
                St = Math.Round(St, 0, MidpointRounding.ToNegativeInfinity);
            } else if (X < 277826)
            {
                // TODO abrunde auf ganze euro
                St = X * 0.42m - 10636.31m;
                St = Math.Round(St, 0, MidpointRounding.ToNegativeInfinity);
            } else
            {
                // TODO abrunde auf ganze euro
                St = X * 0.45m - 18971.06m;
                St = Math.Round(St, 0, MidpointRounding.ToNegativeInfinity);
            }
            St *= Kztab;
        }
        private void Upanteil()
        {
            Log.Debug("Upanteil()");

            switch (Lzz)
            {
                case 1:
                    Anteil1 = Jw;
                    break;
                case 2:
                    // TODO ergebnis aufrunden
                    Anteil1 = Jw / 12m;
                    Anteil1 = Math.Round(Anteil1, 2, MidpointRounding.ToPositiveInfinity);
                    break;
                case 3:
                    // TODO ergebnis aufrunden
                    Anteil1 = Jw * 7m / 360m;
                    Anteil1 = Math.Round(Anteil1, 2, MidpointRounding.ToPositiveInfinity);
                    break;
                default:
                    // TODO ergebnis aufrunden
                    Anteil1 = Jw / 360m;
                    Anteil1 = Math.Round(Anteil1, 2, MidpointRounding.ToPositiveInfinity);
                    break;
            }
        }
        private void Up5_6()
        {
            Log.Debug("Up5_6()");

            X = Zx * 1.25m;
            if (Schleifz == 1)
            {
                Uptab24a();
            } else
            {
                Uptab24n();
            }
            St1 = St;
            X = Zx * 0.75m;
            if (Schleifz ==  1)
            {
                Uptab24a();
            } else
            {
                Uptab24n();
            }
            St2 = St;
            Diff = (St1 - St2) * 2m;
            // TODO abrunden auf ganze Euro
            Mist = Zx * 0.14m;
            Mist = Math.Round(Mist, 0, MidpointRounding.ToNegativeInfinity);
            if (Mist > Diff)
            {
                St = Mist;
            } else
            {
                St = Diff;
            }
        }
        private void Upvkvlzz()
        {
            Log.Debug("Upvkvlzz()");

            Upvkv();
            Jw = Vkv;
            Upanteil();
            Vkvlzz = Anteil1;
        }
        private void Upvkv()
        {
            Log.Debug("Upvkv()");

            if (Pkv > 0)
            {
                if (Vsp2 > Vsp3)
                {
                    Vkv = Vsp2 * 100m;
                } else
                {
                    Vkv = Vsp3 * 100m;
                }
            } else
            {
                Vkv = decimal.Zero;
            }
        }
        private void Uplstlzz()
        {
            Log.Debug("Uplstlzz()");

            Jw = Lstjahr * 100m;
            if (Schleifz == 1)
            {
                Jwlsta = Jw;
            } else
            {
                Jwlstn = Jw;
            }
            Upanteil();
            Lstlzz = Anteil1;
        }
        private void Upmlst()
        {
            Log.Debug("Upmlst()");

            if (Zve < 1)
            {
                Zve = decimal.Zero;
                X = decimal.Zero;
            } else
            {
                // TODO abrunden auf ganze euro
                X = Zve / Kztab;
                X = Math.Round(X, 0, MidpointRounding.ToNegativeInfinity);
            }
            if ( Stkl < 5)
            {
                if (Schleifz == 1)
                {
                    Uptab24a();
                } else
                {
                    Uptab24n();
                }
            } else
            {
                Mst5_6();
            }
        }
        private void Upevp()
        {
            Log.Debug("Upevp()");

            if (Krv != 0)
            {
                Vsp1 = decimal.Zero;
            } else
            {
                if (Zre4vp > Bbgrv)
                {
                    Zre4vp = Bbgrv;
                }
                Vsp1 = Zre4vp * Rvsatzan;
            }
            Vsp2 = 0.12m * Zre4vp;
            if (Stkl == 3)
            {
                Vhb = 3000m;
            } else
            {
                Vhb = 1900m;
            }
            if (Vsp2 > Vhb)
            {
                Vsp2 = Vhb;
            }
            // TODO aufrunden auf ganze euro
            Vspn = Vsp1 + Vsp2;
            Vspn = Math.Round(Vspn, 0, MidpointRounding.ToPositiveInfinity);
            Mvsp();
            if (Vspn > Vsp)
            {
                Vsp = Vspn;
            }
        }
    }
}