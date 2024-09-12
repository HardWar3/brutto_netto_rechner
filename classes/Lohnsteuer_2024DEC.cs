using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brutto_netto_rechner.classes
{
    internal class Lohnsteuer_2024DEC : Lohnsteuer_Basic
    {

        public void Start()
        {
            // CODE HERE LATER
        }
        private void Mpara()
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
        private void Mre4jl()
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
        private void Mre4()
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

                if (Lzz == 1)
                {
                    Vbezb = Vbezm * Zmvb + Vbezs;
                    Hfvb = Tab(2, J) / 12m * Zmvb;
                    // TODO aufrunden auf ganze euro
                    Fvbz = Tab(3, J) / 12m * Zmvb;
                }else
                {
                    Vbezb = Vbezb * 12m + Vbezs;
                    Hfvb = Tab(2, J);
                    Fvbz = Tab(3, J);
                }
                // TODO aufrunden auf ganze cents
                Fvb = Vbezb * Tab(1, J) / 100m;
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
                if (Fvbso > Tab(2, J))
                {
                    Fvbso = Tab(2, J);
                }
                Hfvbzso = (Vbezb + Vbezbso) / 100m - Fvbso;
                // TODO aufrunden auf ganze euro
                Fvbzso = Fvbz + Vbezbso / 100m;
                if (Fvbzso > Hfvbzso)
                {
                    // TODO aufrunden auf ganze euro
                    Fvbzso = Hfvbzso;
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
                }
            }
            Mre4alte();
        }
        private void Mre4alte() 
        { 
            if (Alter1 ==0)
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
                Alte = Bmg * Tab(4, J);
                Hbalte = Tab(5, J);
                if (Alte > Hbalte)
                {
                    Alte = Hbalte;
                }
            } else
            {
                Alte = decimal.Zero;
            }
        }
        private void Mre4abz()
        {
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
                    } else
                    {
                        Anp = 102;
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
                        Anp += Zre4 - Zvbez;
                    } else
                    {
                        Anp += 1230;
                    }
                }
            }
            Kztab = 1;
            if (Stkl == 1)
            {
                Sap = 36;
                Kfb = Zkf * 9312;
            } else if (Stkl == 2)
            {
                Efa = 4260;
                Sap = 36;
                Kfb = Zkf * 9312;
            } else if (Stkl == 3)
            {
                Kztab = 2;
                Sap = 36;
                Kfb = Zkf * 9312;
            } else if (Stkl == 4) {
                Sap = 36;
                Kfb = Zkf * 4656;
            } else if (Stkl == 5)
            {
                Sap = 36;
                Kfb = decimal.Zero;
            } else
            {
                Kfb = decimal.Zero;
            }
            Ztabfb = Efa + Anp + Sap + Fvbz;
        }
        private void Mztabfbn()
        {

        }
    }
}