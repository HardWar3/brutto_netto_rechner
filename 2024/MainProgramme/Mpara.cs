using brutto_netto_rechner.classes;

namespace brutto_netto_rechner.MainProgramme2024 {
    internal class MainProgramm2024 {

        public void Mpara(ref Class_Lohnsteuer class_Lohnsteuer)
        {
            if (class_Lohnsteuer.Krv < 2)
            {
                if (class_Lohnsteuer.Krv == 0)
                {
                    class_Lohnsteuer.Bbgrv = 90600;
                }
                else
                {
                    class_Lohnsteuer.Bbgrv = 89400;
                }
                class_Lohnsteuer.Rvsatzan = 0.093m;
            }

            class_Lohnsteuer.Bbgkvpv = 62100
            class_Lohnsteuer.Kvsatzan = class_Lohnsteuer.Kvz / 2 / 100 + 0.07m
            class_Lohnsteuer.Kvsatzag = 0.0085m + 0.07m;

            if (class_Lohnsteuer.Pvs == 1)
            {
                class_Lohnsteuer.Pvsatzan = 0.022m;
                class_Lohnsteuer.Pvsatzag = 0.012m;
            } else
            {
                class_Lohnsteuer.Pvsatzan = 0.017m;
                class_Lohnsteuer.Pvsatzag = 0.017m;
            }
            if (class_Lohnsteuer.Pvs == 1)
            {
                class_Lohnsteuer.Pvsatzan += 0.006m;
            } else
            {
                class_Lohnsteuer.Pvsatzan -= class_Lohnsteuer.Pva * 0.0025m;
            }
            class_Lohnsteuer.W1stkl5 = 13279;
            class_Lohnsteuer.W2stkl5 = 33380;
            class_Lohnsteuer.W3stkl5 = 222260;
            class_Lohnsteuer.Gfb = 11604;
            class_Lohnsteuer.Solzfrei = 18130;
        }
    }
}