using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{
    public enum KulturName
    {
        [Description("undefined")]
        undefined,
        [Description("Mittelländische Städte")]
        MittellaendischeStaedte,
        [Description("Mittelländische Landbevölkerung")]
        MittellaendischeLandbevoelkerung,
        [Description("Andergast und Nostria")]
        AndergastUndNostria,
        [Description("Bornland")]
        Bornland,
        [Description("Svellttal und Nordlande")]
        SvellttalUndNordlande,
        [Description("Almada")]
        Almada,
        [Description("Horasreich")]
        Horasreich,
        [Description("Zyklopeninseln")]
        Zyklopeninseln,
        [Description("Amazonenburg")]
        Amazonenburg,
        [Description("Aranien")]
        Aranien,
        [Description("Mhanadistan")]
        Mhanadistan,
        [Description("Tulamidische Stadtstaaten")]
        TulamidischeStadtstaaten,       
        [Description("Novadi")]
        Novadi, 
        [Description("Ferkina")]
        Ferkina, 
        [Description("Zahori")]
        Zahori,
        [Description("Thorwal")]
        Thorwal,
        [Description("Gjalskerland")]
        Gjalskerland,
        [Description("Fjarninger")]
        Fjarninger,	
        [Description("Dschungelstämme")]
        Dschungelstaemme,
        [Description("Darna")]
        Darna,
        [Description("Verlorene Stämme")]
        VerloreneStaemme,		
        [Description("Waldinsel Utulus")]        
        WaldinselUtulus,	
        [Description("Miniwatu")]
        Miniwatu,	
        [Description("Tocamuyac")]
        Tocamuyac,	       
        [Description("Maraskan")]
        Maraskan,
        [Description("Südaventurien")]
        Suedaventurien,
        [Description("Bukanier")]
        Bukanier,
        [Description("Nivesenstämme")]
        Nivesenstaemme,
        [Description("Nuanaä-Lie")]
        NuanaaeLie,
        [Description("Norbardensippe")]
        Norbardensippe,
        [Description("Trollzacken")]
        Trollzacken,
        [Description("Auelfische Sippe")]
        AuelfischeSippe,
        [Description("Elfische Siedlung")]
        ElfischeSiedlung,
        [Description("Steppenelfische Sippe")]
        SteppenelfischeSippe,
        [Description("Waldelfische Sippe")]
        WaldelfischeSippe,
        [Description("Firnelfische Sippe")]
        FirnelfischeSippe,
        [Description("Ambosszwerge")]
        Ambosszwerge,
        [Description("Erzzwerge")]
        Erzzwerge,
        [Description("Hügelzwerge")]
        Huegelzwerge,
        [Description("Brillantzwerge")]
        Brillantzwerge,
        [Description("Brobim")]
        Brobim,
        [Description("Orkland")]
        Orkland,
        [Description("Yurach")]
        Yurach,
        [Description("Svellttal Besatzer")]
        SvellttalBesatzer,
        [Description("Goblinstamm")]
        Goblinstamm,
        [Description("Goblinbande")]
        Goblinbande,
        [Description("Festumer Ghetto")]
        FestumerGhetto,
        [Description("Archaische Achaz")]
        ArchaischeAchaz,
        [Description("Stammes-Achaz")]
        StammesAchaz,
    }

    public enum SubKulturName
    {
        [Description("undefined")]
        undefined,
        // Man kann (fast) immer die Variante "keine" wählen:
        [Description("keine")]
        Keine,

        [Description("Hafenstädte und Städte an großen Flüssen")]
        HafenstaedteUndStaedteAnGroessenFluessen,
        [Description("Städte mit wichtigem Tempel/Pilgerstätte")]
        StaedteMitWichtigemTempelOderPilgerstaette,
        [Description("Siedlerstädte des Nordens")]
        SiedlerstaedteDesNordens,
        [Description("Städtischer Adel")]
        StaedtischerAdel,
        [Description("Kannemünde / Mhanerhaven")]
        KannemuendeMhanerhaven,
        [Description("Flüchtlinge aus borbaradianisch besetzten Städten")]
        FluechtlingeAusBorbaradianischenStaedten,
        [Description("Maraskanische Exilanten")]
        MaraskanischeExilanten,

        [Description("Küstengebiete oder an großen Flüssen")]
        KuestengebieteOderGroesseFluesse,
        [Description("An einer wichtigen Handelsroute/Reichsstraße")]
        AnWichtigerHandelsrouteOderReichsstrasse,
        [Description("Regionen Weiden und Greifenfurt")]
        RegionenWeidenUndGreifenfurt,
        [Description("Gebirge")]
        Gebirge,
        [Description("Fern der Zivilisation")]
        FernDerZivilisation,
        [Description("Landadel")]
        Landadel,
        [Description("Jilaskan")]
        Jilaskan,
        [Description("Borbaradianisch besetzte Gebiete")]
        BorbaradianischBesetzteGebiete,

        [Description("Stadt")]
        Stadt,
        [Description("Küstengebiete")]
        Kuestengebiete,
        [Description("Teshkalien")]
        Teshkalien,

        [Description("Landstädte")]
        Landstaedte,

        [Description("Kleinstädte")]
        Kleinstaedte,
        [Description("Küstengebiete oder an großen Flüssen")]
        KuestengebieteOderAnGrossenFluessen,
        [Description("Flüchtlinge aus Glorania")]
        FluechtlingeAusGlorania,

        [Description("Städte am Yaquir")]
        StaedteAmYaquir,
        [Description("An einer wichtigen Handelsroute")]
        AnEinerWichtigenHandelsroute,

        [Description("Dörfer an der Küste oder an großen Flüssen")]
        DoerferAnKuesteOderAnGrossenFluessen,

        [Description("Küstengebiete oder am Barun-Ulah")]
        KuestengebieteOderAmBarunUlah,

        [Description("Tulamidische Nomadenstämme")]
        TulamidischeNomadenstaemme,

        [Description("See- oder Mhanadihafen")]
        SeeOderMhanadihafen,
        [Description("Kasimiten")]
        Kasimiten,

        [Description("Wüstenoase")]
        Wuestenoase,

        [Description("Binnenland")]
        Binnenland,

        [Description("Tschopukikuha")]
        Tschopukikuha,
        [Description("Bergstämme")]
        Bergstaemme,
        [Description("Haipu")]
        Haipu,
        [Description("Darna")]
        Darna,

        [Description("Shokubunga")]
        Shokubunga,
        [Description("Chirakha")]
        Chirakha,

        [Description("Dschungel")]
        Dschungel,
        [Description("Maraskanische Städte")]
        MaraskanischeStaedte,

        [Description("Südliche Stadtstaaten")]
        SuedlicheStadtstaaten,
        [Description("Kolonialhäfen")]
        Kolonialhaefen,
        [Description("Dschungeldorf/Plantage")]
        DschungeldorfOderPlantage,
        [Description("Selem")]
        Selem,

        [Description("Halbsesshafte Küstenstämme")]
        HalbsesshafteKuestenstaemme,

        [Description("Nauoke")]
        Nauoke,

        [Description("Hoher Norden")]
        HoherNorden,

        [Description("Südliche Mittellande")]
        SuedlicheMittellande,
        [Description("Großstadt")]
        Grossstadt,
        [Description("Firnelfisch beeinflusste Siedlung")]
        FirnelfischBeeinflussteSiedlung,
        [Description("Waldelfisch beeinflusste Siedlung")]
        WaldelfischBeeinflussteSiedlung,

        [Description("Küste und Inseln")]
        KuesteUndInseln,

        [Description("Ebene")]
        Ebene,
        [Description("Schneegoblins")]
        Schneegoblins,

        [Description("Maraskan")]
        Maraskan,
        [Description("Orkland")]
        Orkland,
        [Description("Echsensümpfe")]
        Echsensuempfe,
        [Description("Loch Harodrol")]
        LochHarodrol,
        [Description("Waldinseln/Südaventurien")]
        WaldinselnUndSuedaventurien,


    }							

    public enum OrkstaemmeName
    {
        [Description("undefined")]
        undefined,
        [Description("Korogai")]
        Korogai,
        [Description("Molokash")]
        Molokash,
        [Description("Olochtai")]
        Olochtai,
        [Description("Orichai")]
        Orichai,
        [Description("Truanzhai")]
        Truanzhai,
        [Description("Tscharshai")]
        Tscharshai,
        [Description("Zholochai")]
        Zholochai,
    }

    public enum OrkkastenName
    {
        [Description("undefined")]
        undefined,
        [Description("Ergoch")]
        Ergoch,
        [Description("Grishik")]
        Grishik,
        [Description("Drasdech")]
        Drasdech,
        [Description("Khurkach")]
        Khurkach,
    }

}
