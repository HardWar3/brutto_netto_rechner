namespace brutto_netto_rechner
{
    public enum BruttoNettoGuiFields : int
    {
        Brutto = 1,
        Abrechnungsart = 2,
        Abrechnungsjahr = 3,
        Versorgungsbezuege = 4,
        Steuerklasse = 5,
        Kirche = 6,
        Bundesland = 7,
        Alter = 8,
        Kinder = 9,
        Kinderfreibetrag = 10,
        KrankenversicherungsArt = 11,
        KrankenversicherungsBeitrag = 12,
        KrankenversicherungArbeitgeberzuschuss = 13
    }

    public enum BruttoNettoGuiFieldValues : int
    {
        Jahr = 1,
        Monat = 2,

        NichtKirchlich = 0,
        Kirchlich = 1,

        SchleswigHolstein = 1,
        Hamburg = 2,
        Niedersachsen = 3,
        Bremen = 4,
        NordrheinWestfalen = 5,
        Hessen = 6,
        RheinlandPfalz = 7,
        BadenWürttemberg = 8,
        Bayern = 9,
        Saarland = 10,
        Berlin = 11,
        Brandenburg = 12,
        MecklenburgVorpommern = 13,
        Sachsen = 14,
        SachsenAnhalt = 15,
        Thueringen = 16,

        KeineKinder = 0,
        HatKinder = 1,
        KeinenKinderfreibetrag = 0,

        GesetzlicheKrankenversicherung = 0,
        PrivateKrankenversicherungOhneZuschuss = 1,
        PrivateKrankenversicherungMitZuschuss = 2,
    }
}