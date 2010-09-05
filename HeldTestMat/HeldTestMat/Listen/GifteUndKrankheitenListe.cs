using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{
    public enum GiftName
    {
        [Description("undefined")]
        undefined,
        [Description("Angstgift")]
        Angstgift,
        [Description("Arachnae")]
        Arachnae,
        [Description("Arax")]
        AdligArax,
        [Description("Bannstaub")]
        Bannstaub,
        [Description("Boabungaha")]
        Boabungaha,
        [Description("Drachenspeichel")]
        Drachenspeichel,
        [Description("Feuerzunge")]
        Feuerzunge,
        [Description("Goldleim")]
        Goldleim,        
        [Description("Gonede")]
        Gonede,
        [Description("Halbgift")]
        Halbgift,
        [Description("Kelmon")]
        Kelmon,
        [Description("Kukris")]
        Kukris,
        [Description("Mandragora")]
        Mandragora,
        [Description("Omrais")]
        Omrais,
        [Description("Purpurblitz")]
        Purpurblitz,
        [Description("Samthauch")]
        Samthauch,
        [Description("Schlafgift")]
        Schlafgift,
        [Description("Schwarzer Lotos")]
        SchwarzerLotos,
        [Description("Sunsura")]
        Sunsura,
        [Description("Tinzal")]
        Tinzal,
        [Description("Tulmadron")]
        Tulmadron,
        [Description("Wuara")]
        Wuara,
    }


    public enum GiftArt
    {
        [Description("undefined")]
        undefined,
        [Description("pflanzliche Gifte")]
        PflanzlicheGifte,
        [Description("tierische Gifte")]
        TierischeGifte,
        [Description("alchimistische/Zaubergifte")]
        AlchimistischeUndZaubergifte,
        [Description("mineralische Gifte")]
        MineralischeGifte,
    }

    public enum GiftWirkungsTyp
    {
        [Description("undefined")]
        undefined,
        [Description("Atemgifte")]
        Atemgifte,
        [Description("Einnahmegifte")]
        Einnahmegifte,
        [Description("Kontaktgifte")]
        Kontaktgifte,
        [Description("Waffengifte")]
        Waffengifte,
    }

    public enum KrankheitsName
    {
        [Description("undefined")]
        undefined,
        [Description("Blutiger Rotz")]
        BlutigerRotz,
        [Description("Brabaker Schweiß")]
        BrabakerSchweiss,
        [Description("Dumpfschädel")]
        Dumpfschaedel,
        [Description("Flinker Difar")]
        FlinkerDifar,
        [Description("Schlafkrankheit")]
        Schlafkrankheit,
        [Description("Lutanas")]
        Lutanas,
        [Description("Wundfieber")]
        Wundfieber,
        [Description("Paralyse")]
        Paralyse,
        [Description("Jahresfieber")]
        Jahresfieber,
        [Description("Rascher Wahn")]
        RascherWahn,
        [Description("Blaue Keuche")]
        BlaueKeuche,
        [Description("Zorgan-Pocken")]
        ZorganPocken,
        [Description("Tollwut")]
        Tollwut,
        [Description("Schwarze Wut")]
        SchwarzeWut,
        [Description("Efferd- und Kerkersieche")]
        EfferdUndKerkersieche,
        [Description("Duglumspest")]
        Duglumspest,
        [Description("Lykanthrophie")]
        Lykanthrophie,
    }

    public enum Suchtmittel
    {
        [Description("undefined")]
        undefined,
        [Description("Alkohol")]
        Alkohol,
        [Description("Drogen")]
        Drogen,
    }

    public enum Angst
    {
        [Description("undefined")]
        undefined,
        [Description("Insekten")]
        Insekten,
        [Description("Spinnen")]
        Spinnen,
        [Description("Reptilien")]
        Reptilien,
        [Description("Pelztieren")]
        Pelztieren,
        [Description("Feuer")]
        Feuer,
        [Description("Wasser")]
        Wasser,
        [Description("Menschenmassen")]
        Menschenmassen,
        [Description("Klerikalem Wirken")]
        KlerikalemWirken,
        [Description("Fliegenden Wesen")]
        FliegendenWesen,
    }

}
