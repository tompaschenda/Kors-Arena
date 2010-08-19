﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{
    public enum SpielerRassenName
    {
        [Description("undefined")]
        undefined,
        [Description("Mittelländer")]
        Mittellaender,
        [Description("Tulamiden")]
        Tulamiden,
        [Description("Thorwaler")]
        Thorwaler,
        [Description("Nivese")]
        Nivese,
        [Description("Norbarde")]
        Norbarde,
        [Description("Trollzacker")]
        Trollzacker,
        [Description("Waldmensch")]
        Waldmensch,
        [Description("Utulu")]
        Utulu,
        [Description("Elf")]
        Elf,
        [Description("Halbelf")]
        Halbelf,
        [Description("Zwerg")]
        Zwerg,
        [Description("Ork")]
        Ork,
        [Description("Halbork")]
        Halbork,
        [Description("Goblin")]
        Goblin,
        [Description("Achaz")]
        Achaz,

    }

    public enum SpielerSubRassenName
    {
        [Description("undefined")]
        undefined,
        // Keine Subrasse ist auch manchmal möglich!
        [Description("keine")]
        keine,
        [Description("Fjarninger")]
        Fjarninger,
        [Description("Gjalskerländer")]
        Gjalskerlaender,
        [Description("Rochshaz")]
        Rochshaz,
        [Description("Tocamuyac")]
        Tocamuyac,
        [Description("Auelf")]
        Auelf,
        [Description("Waldelf")]
        Waldelf,
        [Description("Firnelf")]
        Firnelf,
        [Description("Halbelf aus elfischer Siedlung")]
        HalbelfAusElfischerSiedlung,
        [Description("Halbelf aus auelfischer Sippe")]
        HalbelfAusAuelfischerSippe,
        [Description("Halbelf aus waldelfischer Sippe")]
        HalbelfAusWaldelfischerSippe,
        [Description("Halbelf aus firnelfischer Sippe")]
        HalbelfAusFirnelfischerSippe,
        [Description("Halbelf firnelfischer Abstammung")]
        HalbelfFirnelf,
        [Description("Halbelf nivesischer Abstammung")]
        HalbelfNivesenElf,
        [Description("Halbelf thorwalscher Abstammung")]
        HalbelfThorwalElf,
        [Description("Brilliantzwerg")]
        Brilliantzwerg,
        [Description("Ambosszwerg")]
        Ambosszwerg,
        [Description("Wilder Zwerg")]
        WilderZwerg,
        [Description("Orkfrau")]
        Orkfrau,
        [Description("Goblinfrau")]
        Goblinfrau,
        [Description("Orkland-Achaz")]
        OrklandAchaz,
        [Description("Waldinsel-Achaz")]
        WaldinselAchaz,
        [Description("Maraskan-Achaz")]
        MaraskanAchaz,
    }					   
}
