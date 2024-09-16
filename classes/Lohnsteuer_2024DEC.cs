﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
                    Kfb = Zkf * 4770;
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
                    Anp += Zre4 - Zvbez;
                } else
                {
                    Anp += 1230;
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
                    Kfb = Zkf * 4770;
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
                    Zve += (Vmt + Vkapa) / 500;
                    Upmlst();
                    St = (St - Stovmt) * 5m + Stovmt;
                }
            }
        }
        private void Mvsp()
        {
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
                        Vsp3 -= Zre4vp * (Kvsatzag + Pvsatzag);
                    }
                }
            } else
            {
                Vsp3 = Zre4vp * (Kvsatzan + Pvsatzan);
            }
            // TODO aufrunden auf ganze euro
            Vsp = Vsp3 + Vsp1;
        }
        private void Mst5_6()
        {
            Zzx = X;
            if (Zzx > W2stkl5)
            {
                Zx = W2stkl5;
                Up5_6();
                if (Zzx > W3stkl5)
                {
                    // TODO abrunden auf ganze euro
                    St += (W3stkl5 - W2stkl5) * 0.42m;
                    // TODO abrunden auf ganze euro
                    St += (Zzx - W3stkl5) * 0.45m;
                } else
                {
                    // TODO abrunden auf ganze euro
                    St += (Zzx - W2stkl5) * 0.42m;
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
        private void Upvkvlzz()
        {
            Upvkv();
            Jw = Vkv;
            Upanteil();
            Vkvlzz = Anteil1;
        }
        private void Upvkv()
        {
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
            Jw = Lstjahr * 100m;
            if (Schleifz == 1)
            {
                Jwlsta = Jw;
            } else
            {
                Jwlstn = Jw;
            }
            Upabteil();
            Lstlzz = Anteil1;
        }
        private void Upmlst()
        {
            if (Zve < 1)
            {
                Zve = decimal.Zero;
                X = decimal.Zero;
            } else
            {
                // TODO abrunden auf ganze euro
                X = Zve / Kztab;
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
            if (Krv > 1)
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
                Vhb = 3000;
            } else
            {
                Vhb = 1900;
            }
            if (Vsp2 > Vhb)
            {
                Vsp2 = Vhb;
            }
            // TODO aufrunden auf ganze euro
            Vspn = Vsp1 + Vsp2;
            Mvsp();
            if (Vspn > Vsp)
            {
                Vsp = Vspn;
            }
        }
    }
}