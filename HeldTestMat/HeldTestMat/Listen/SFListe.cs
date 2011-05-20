using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{


    public enum TierischeBegleiter
    {
        [Description("undefined")]
        undefined,
        [Description("Elfenpony")]
        Elfenpony,


    };

    public enum SFKategorien
    {
        [Description("undefined")]
        undefined,
        [Description("Allgemeine Sonderfertigkeiten")]
        AllgemeineSF,
        [Description("Kampfsonderfertigkeiten (bewaffneter Nahkampf)")]
        KampfSFBewaffnet,
        [Description("Kampfsonderfertigkeiten (waffenlos)")]
        KampfSFWaffenlos,
        [Description("Kampfsonderfertigkeiten (Fernkampf)")]
        KampfSFFernkampf,
        [Description("Magische Sonderfertigkeiten")]
        MagischeSF,
        [Description("Klerikale Sonderfertigkeiten")]
        KlerikaleSF,
    }

    public enum SFNamen
    {
        [Description("undefined")]
        undefined,
        // Allgemeine:
        [Description("Akklimatisierung")]
        Akklimatisierung,
        [Description("Berufsgeheimnis")]
        Berufsgeheimnis,
        [Description("Fälscher")]
        Faelscher,
        [Description("Geländekunde")]
        Gelaendekunde,
        [Description("Kulturkunde")]
        Kulturkunde,
        [Description("Meister der Improvisation")]
        MeisterDerImprovisation,
        [Description("Nandusgefälliges Wesen")]
        NandusgefaelligesWesen,
        [Description("Ortskenntnis")]
        Ortskenntnis,
        [Description("Rosstäuscher")]
        Rosstaeuscher,
        [Description("Standfest")]
        Standfest,
        [Description("Talentspezialisierung")]
        Talentspezialisierung,

        // Arsenal:
        [Description("Waffenmeister")]
        Waffenmeister,
        [Description("Festnageln")]
        Festnageln,

        // Kampfsonderfertigkeiten (Reiterei):
        [Description("Reiterkampf")]
        Reiterkampf,
        [Description("Turnierreiterei")]
        Turnierreiterei,
        [Description("Kriegsreiterei")]
        Kriegsreiterei,

        // Kampfsonderfertigkeiten  (bewaffneter Nahkampf):
        [Description("Aufmerksamkeit")]
        Aufmerksamkeit,
        [Description("Ausfall")]
        Ausfall,
        [Description("Ausweichen I")]
        Ausweichen1,
        [Description("Ausweichen II")]
        Ausweichen2,
        [Description("Ausweichen III")]
        Ausweichen3,
        [Description("Befreiungsschlag")]
        Befreiungsschlag,
        [Description("Beidhändiger Kampf I")]
        BeidhaendigerKampf1,
        [Description("Beidhändiger Kampf II")]
        BeidhaendigerKampf2,
        [Description("Betäubungsschlag")]
        Betaeubungsschlag,
        [Description("Binden")]
        Binden,
        [Description("Blindkampf")]
        Blindkampf,
        [Description("Defensiver Kampfstil")]
        DefensiverKampfstil,
        [Description("Doppelangriff")]
        Doppelangriff,
        [Description("Entwaffnen")]
        Entwaffnen,
        [Description("Finte")]
        Finte,
        [Description("Formation")]
        Formation,
        [Description("Gegenhalten")]
        Gegenhalten,
        [Description("Geschützmeister")]
        Geschuetzmeister,
        [Description("Gezielter Stich")]
        GezielterStich,
        [Description("Halbschwert")]
        Halbschwert,
        [Description("Hammerschlag")]
        Hammerschlag,
        [Description("Improvisierte Waffen")]
        ImprovisierteWaffen,
        [Description("Kampf im Wasser")]
        KampfImWasser,
        [Description("Kampfgespühr")]
        Kampfgespuehr,
        [Description("Kampfreflexe")]
        Kampfreflexe,
        [Description("Klingensturm")]
        Klingensturm,
        [Description("Klingentänzer")]
        Klingentaenzer,
        [Description("Klingenwand")]
        Klingenwand,
        [Description("Linkhand")]
        Linkhand,
        [Description("Meisterliches Entwaffen")]
        MeisterlichesEntwaffen,
        [Description("Meisterparade")]
        Meisterparade,
        [Description("Niederwerfen")]
        Niederwerfen,
        [Description("Parierwaffen I")]
        Parierwaffen1,
        [Description("Parierwaffen II")]
        Parierwaffen2,
        [Description("Rüstungsgewöhnung I")]
        Ruestungsgewoehnung1,
        [Description("Rüstungsgewöhnung II")]
        Ruestungsgewoehnung2,
        [Description("Rüstungsgewöhnung III")]
        Ruestungsgewoehnung3,
        [Description("Schildkampf I")]
        Schildkampf1,
        [Description("Schildkampf II")]
        Schildkampf2,
        [Description("Schildspalter")]
        Schildspalter,
        [Description("Spießgespann")]
        Spiessgespann,
        [Description("Sturmangriff")]
        Sturmangriff,
        [Description("Tod von links")]
        TodVonLinks,
        [Description("Todesstoß")]
        Todesstoss,
        [Description("Umreißen")]
        Umreissen,
        [Description("Unterwasserkampf")]
        Unterwasserkampf,
        [Description("Waffe zerbrechen")]
        WaffeZerbrechen,
        [Description("Waffenspezialisierung")]
        Waffenspezialisierung,
        [Description("Windmühle")]
        Windmuehle,
        [Description("Wuchtschlag")]
        Wuchtschlag,

        // Kampfsonderfertigkeiten (Fernkampf):
        [Description("Berittener Schütze")]
        BerittenerSchuetze,
        [Description("Eisenhagel")]
        Eisenhagel,
        [Description("Meisterschütze")]
        Meisterschuetze,
        [Description("Scharfschütze")]
        Scharfschuetze,
        [Description("Schnelladen")]
        Schnelladen,
        [Description("Schnellziehen")]
        Schnellziehen,

        // Kampfsonderfertigkeiten (Waffenloser Kampf):
        [Description("Waffenloser Kampfstil (Bornländisch)")]
        Bornlaendisch,
        [Description("Waffenloser Kampfstil (Gladiatorenstil)")]
        Gladiatorenstil,
        [Description("Waffenloser Kampfstil (Hammerfaust)")]
        Hammerfaust,
        [Description("Waffenloser Kampfstil (Hruruzat)")]
        Hruruzat,
        [Description("Waffenloser Kampfstil (Mercenario)")]
        Mercenario,
        [Description("Waffenloser Kampfstil (Unauer Schule)")]
        UnauerSchule,
        [Description("Auspendeln")]
        Auspendeln,
        [Description("Beinarbeit")]
        Beinarbeit,
        [Description("Biss")]
        Biss,
        [Description("Block")]
        Block,
        [Description("Doppelschlag")]
        Doppelschlag,
        [Description("Eisenarm")]
        Eisenarm,
        [Description("Fußfeger")]
        Fussfeger,
        [Description("Gerade")]
        Gerade,
        [Description("Griff")]
        Griff,
        [Description("Halten")]
        Halten,
        [Description("Handkante")]
        Handkante,
        [Description("Hoher Tritt")]
        HoherTritt,
        [Description("Klammer")]
        Klammer,
        [Description("Knaufschlag")]
        Knaufschlag,
        [Description("Knie")]
        Knie,
        [Description("Kopfstoß")]
        Kopfstoss,
        [Description("Kreuzblock")]
        Kreuzblock,
        [Description("Niederringen")]
        Niederringen,
        [Description("Schmetterschlag")]
        Schmetterschlag,
        [Description("Schmutzige Tricks")]
        SchmutzigeTricks,
        [Description("Schwanzfeger")]
        Schwanzfeger,
        [Description("Schwanzschlag")]
        Schwanzschlag,
        [Description("Schwinger")]
        Schwinger,
        [Description("Schwitzkasten")]
        Schwitzkasten,
        [Description("Sprung")]
        Sprung,
        [Description("Sprungtritt")]
        Sprungtritt,
        [Description("Tritt")]
        Tritt,
        [Description("Versteckte Klinge")]
        VersteckteKlinge,
        [Description("Würgegriff")]
        Wuergegriff,
        [Description("Wurf")]
        Wurf,

        // Klerikale Sonderfertigkeiten:
        [Description("Akoluth")]
        Akoluth,
        [Description("Aura der Heiligkeit")]
        AuraDerHeiligkeit,
        [Description("Karmalqueste")]
        Karmalqueste,
        [Description("Kontakt zum Großen Geist")]
        KontaktZumGrossenGeist,
        [Description("Liturgiekenntnis")]
        Liturgiekenntnis,
        [Description("Liturgie")]
        Liturgie,
        [Description("Ritualkenntnis")]
        Ritualkenntnis,
        [Description("Ritualkenntnis (Alchimist)")]
        RitualkenntnisAlchimist,
        [Description("Ritualkenntnis (Durro Dun)")]
        RitualkenntnisDurroDun,
        [Description("Spätweihe")]
        Spaetweihe,

        // Magische Sonderfertigkeiten:
        [Description("Apport")]
        Apport,
        [Description("Astrale Meditation")]
        AstraleMeditation,
        [Description("Aura verhüllen")]
        AuraVerhuellen,
        [Description("Aurapanzer")]
        Aurapanzer,
        [Description("Bann- und Schutzkreise")]
        BannUndSchutzkreise,
        [Description("Bannschwert")]
        Bannschwert,
        [Description("Blutmagie")]
        Blutmagie,
        [Description("Chimärenmeister")]
        Chimaerenmeister,
        [Description("Dämonenbindung")]
        Daemonenbindung,
        [Description("Druidenrache")]
        Druidenrache,
        [Description("Druidische Dolchrituale")]
        DruidischeDolchrituale,
        [Description("Druidische Herrschaftsrituale")]
        DruidischeHerrschaftsrituale,
        [Description("Eiserner Wille 1")]
        EisernerWille1,
        [Description("Eiserner Wille 2")]
        EisernerWille2,
        [Description("Elementarharmonisierte Aura")]
        ElementarharmonisierteAura,
        [Description("Elfenlieder")]
        Elfenlieder,
        [Description("Exorzist")]
        Exorzist,
        [Description("Fernzauberei")]
        Fernzauberei,
        [Description("Form der Formlosigkeit")]
        FormDerFormlosigkeit,
        [Description("Geber der Gestalt")]
        GeberDerGestalt,
        [Description("Gedankenschutz")]
        Gedankenschutz,
        [Description("Gefäß der Sterne")]
        GefaessDerSterne,
        [Description("Geodenrituale")]
        Geodenrituale,
        [Description("Golembauer")]
        Golembauer,
        [Description("Große Meditation")]
        GrosseMeditation,
        [Description("Hexenflüche")]
        Hexenflueche,
        [Description("Höhere Dämonenbindung")]
        HoehereDaemonenbindung,
        [Description("Hypervehemenz")]
        Hypervehemenz,
        [Description("Invocatio Integra")]
        InvocatioIntegra,
        [Description("Keulenrituale")]
        Keulenrituale,
        [Description("Konzentrationsstärke")]
        Konzentrationsstaerke,
        [Description("Kraftkontrolle")]
        Kraftkontrolle,
        [Description("Kraflinienmagie 1")]
        Kraflinienmagie1,
        [Description("Kraflinienmagie 2")]
        Kraflinienmagie2,
        [Description("Kristallomantische Rituale")]
        KristallomantischeRituale,
        [Description("Kugelzauber")]
        Kugelzauber,
        [Description("Lockeres Zaubern")]
        LockeresZaubern,
        [Description("Matrixgeber")]
        Matrixgeber,
        [Description("Matrixkontrolle")]
        Matrixkontrolle,
        [Description("Matrixregeneration 1")]
        Matrixregeneration1,
        [Description("Matrixregeneration 2")]
        Matrixregeneration2,

        [Description("Matrixverständnis")]
        Matrixverstaendnis,
        [Description("Meisterliche Regeneration")]
        MeisterlicheRegeneration,
        [Description("Meisterliche Zauberkontrolle")]
        MeisterlicheZauberkontrolle,
        [Description("Merkmalskenntnis")]
        Merkmalskenntnis,
        [Description("Nekromant")]
        Nekromant,
        [Description("Odun-Gaben")]
        OdunGaben,
        [Description("Ottagaldr")]
        Ottagaldr,
        [Description("Regeneration I")]
        Regeneration1,
        [Description("Regeneration II")]
        Regeneration2,
        [Description("Repräsentation")]
        Repraesentation,
        [Description("Ritualkenntins")]
        Ritualkenntins,
        [Description("Runenkunde")]
        Runenkunde,
        [Description("Salasandra")]
        Salasandra,
        [Description("Schalenzauber")]
        Schalenzauber,
        [Description("Schamanistische Rituale")]
        SchamanistischeRituale,
        [Description("Schlangenring Zauber")]
        SchlangenringZauber,
        [Description("Schuppenbeutel")]
        Schuppenbeutel,
        [Description("Semipermanenz")]
        Semipermanenz,
        [Description("Signaturkenntnis")]
        Signaturkenntnis,
        [Description("Simultanzaubern")]
        Simultanzaubern,
        [Description("Stabzauber")]
        Stabzauber,
        [Description("Stepeleffekt")]
        Stepeleffekt,
        [Description("Tanz der Mada")]
        TanzDerMada,
        [Description("Tierischer Begleiter")]
        TierischerBegleiter,
        [Description("Traumgänger")]
        Traumgaenger,
        [Description("Trommelzauber")]
        Trommelzauber,
        [Description("Verbotene Pforten")]
        VerbotenePforten,
        [Description("Vertrautenbindung")]
        Vertrautenbindung,
        [Description("Vielfache Ladungen")]
        VielfacheLadungen,
        [Description("Zauber bereithalten")]
        ZauberBereithalten,
        [Description("Zauber unterbrechen")]
        ZauberUnterbrechen,
        [Description("Zauber vereinigen")]
        ZauberVereinigen,
        [Description("Zauberkontrolle")]
        Zauberkontrolle,
        [Description("Zauberroutine")]
        Zauberroutine,
        [Description("Zauberspezialisierung")]
        Zauberspezialisierung,
        [Description("Zaubertänze")]
        Zaubertaenze,
        [Description("Zauberzeichen")]
        Zauberzeichen,
        [Description("Zibilja-Rituale")]
        ZibiljaRituale,
        [Description("Ritualkenntnis (Derwisch)")]
        RitualkenntnisDerwisch,
        [Description("Ritualkenntnis (Druide)")]
        RitualkenntnisDruide,
        [Description("Ritualkenntnis (Hexe)")]
        RitualkenntnisHexe,
    }

    public enum SFSubNamen
    {
        [Description("undefined")]
        undefined,
        // Akklimatisierung:
        [Description("Hitze")]
        Hitze,
        [Description("Kälte")]
        Kaelte,

        // Geländekunde:
        [Description("dschungelkundig")]
        Dschungelkundig,
        [Description("eiskundig")]
        Eiskundig,
        [Description("gebirgskundig")]
        Gebirgskundig,
        [Description("höhlenkundig")]
        Hoehlenkundig,
        [Description("maraskankundig")]
        Maraskankundig,
        [Description("meereskundig")]
        Meereskundig,
        [Description("steppenkundig")]
        Steppenkundig,
        [Description("sumpfkundig")]
        Sumpfkundig,
        [Description("waldkundig")]
        Waldkundig,
        [Description("wüstenkundig")]
        Wuestenkundig,

        // Kulturkunde:
        [Description("je nach Kultur")]
        JeNachKultur,
        [Description("Schwarze Lande")]
        SchwarzeLande,
        [Description("Trolle")]
        Trolle,
        [Description("Grolme")]
        Grolme,

        // Talentspezialisierung:
        [Description("je nach Talent")]
        JaNachTalent,

        // Schnellladen:
        [Description("Bogen")]
        Bogen,
        [Description("Armbrust")]
        Armbrust,

        // Liturgienkenntnis:
        [Description("je nach Kirche")]
        JeNachKirche,

        // Elemente:
        [Description("je nach Element")]
        JeNachElement,

        // Je nach Merkmalskenntins:
        [Description("je nach Merkmal")]
        JeNachMerkmal,

        // Ritualkenntins
        [Description("je nach Repräsentation")]
        JeNachRepraesentation,

    }

    public enum Elfenlieder
    {
        [Description("undefined")]
        undefined,
        [Description("Sorgenlied")]
        Sorgenlied,
        [Description("Zaubermelodie")]
        Zaubermelodie,
        [Description("Friedenslied")]
        Friedenslied,
        [Description("Windgeflüster")]
        Windgefluester,
        [Description("Lied der Lieder")]
        LiedDerLieder,
        [Description("Freundschaftslied")]
        Freundschaftslied,
        [Description("Erinnerungsmelodie")]
        Erinnerungsmelodie,
        [Description("Melodie der Kunstfertigkeit")]
        MelodieDerKunstfertigkeit,
        [Description("Lied des Trostes")]
        LiedDesTrostes,
        [Description("Lied der Reinheit")]
        LiedDerReinheit,
    };

    public enum Schalenzauber
    {
        [Description("undefined")]
        undefined,

        // Wir beginnen mit den Schalenzaubern:
        [Description("Weihe der Schale")]
        WeiheDerSchale,
        [Description("Allegorische Analyse")]
        AllegorischeAnalyse,
        [Description("Chymische Hochzeit")]
        ChymischeHochzeit,
        [Description("Mandricons Bindung")]
        MandriconsBindung,
        [Description("FeuerUndEis")]
        FeuerUndEis,
        [Description("Transmutation der Elemente")]
        TransmutationDerElemente,
    }

    public enum Trommelzauber
    {
        [Description("undefined")]
        undefined,

        [Description("Ruf des Krieges")]
        RufdesKrieges,
        [Description("Sturm der Wüste")]
        SturmDerWueste,
        [Description("SchutzRastullahs")]
        SchutzRastullahs,
        [Description("Rastullahs Güte")]
        RastullahsGuete,
        [Description("Zorn des Gottgefälligen")]
        ZornDesGottgefaelligen,
    }

    public enum DruidischeDolchrituale
    {
        [Description("undefined")]
        undefined,
        [Description("Weihe des Dolches")]
        weiheDesDolches,
        [Description("Gespür des Dolches")]
        gespuerDesDolches,
        [Description("Bann des Dolches")]
        bannDesDolches,
        [Description("Leib des Dolches")]
        leibDesDolches,
        [Description("Schutz des Dolches")]
        schutzDesDolches,
        [Description("Weg des Dolches")]
        wegDesDolches,
        [Description("Ernte des Dolches")]
        ernteDesDolches,
        [Description("Lebenskraft des Dolches")]
        lebenskraftDesDolches,
        [Description("Opferdolch")]
        opferdolch,
        [Description("Schneide des Dolches")]
        schneideDesDolches,
        [Description("Weisung des Dolches")]
        weisungDesDolches,
    }

    public enum DruidischeHerrschaftsrituale
    {
        [Description("undefined")]
        undefined,
        [Description("Wachs der Herrschaft")]
        wachsDerHerrschaft,
        [Description("Miniatur der Herrschaft")]
        miniaturDerHerrschaft,
        [Description("Kristall der Herrschaft")]
        kristallDerHerrschaft,
        [Description("Amulett der Herrschaft")]
        amulettDerHerrschaft,
        [Description("Wurzel des Blutes")]
        wurzeslDesBlutes,
    }

    public enum Hexenflueche
    {
        [Description("undefined")]
        undefined,
        [Description("Ängste mehren")]
        aengsteMehren,
        [Description("Beiß auf Granit")]
        beissAufGranit,
        [Description("Beute")]
        beute,
        [Description("Hagelschlag")]
        hagelschlag,
        [Description("Hexenschuss")]
        hexenschuss,
        [Description("Kornfäule")]
        kornfaeule,
        [Description("Krötenkuss")]
        kroetenkuss,
        [Description("Mit Blindheit schlagen")]
        mitBlindheitSchlagen,
        [Description("Pech an den Hals")]
        pechAnDenHals,
        [Description("Pestilenz")]
        pestilenz,
        [Description("Schlaf rauben")]
        schlafRauben,
        [Description("Todesfluch")]
        todesfluch,
        [Description("Unfruchtbarkeit")]
        unfruchtbarkeit,
        [Description("Viehverstümmelung")]
        viehverstuemmelung,
        [Description("Warzen sprießen")]
        warzenSpriessen,
        [Description("Zunge lähmen")]
        zungeLaehmen,
    }

    public enum Geodenrituale
    {
        [Description("undefined")]
        undefined,
        [Description("Gestalt aus Rauch")]
        gestaltAusRauch,
        [Description("Trank des ungehinderten Weges")]
        trankDesUngehindertenWeges,
    }

    public enum Keulenrituale
    {
        [Description("undefined")]
        undefined,
        [Description("Weihe der Keule")]
        weiheDerKeule,
        [Description("Härte der Keule")]
        haerteDerKeule,
        [Description("Gespür der Keule")]
        gespuerDerKeule,
        [Description("Kraft der Keule")]
        kraftDerKeule,
        [Description("Hilfe der Keule")]
        hilfeDerKeule,
        [Description("Nähe zur Natur")]
        naeheZurNatur,
        [Description("Zauber der Keule")]
        zauberDerKeule,
        [Description("Bann der Keule")]
        bannDerKeule,
        [Description("Geist der Keule")]
        geistDerKeule,
        [Description("Apport der Keule")]
        apportDerKeule,
    }

    public enum KristallomantischeRituale
    {
        [Description("undefined")]
        undefined,
        [Description("Kristallbindung")]
        kristallbindung,
        [Description("Kristallformung")]
        kristallformung,
        [Description("Thesiskristall")]
        thesiskristall,
        [Description("Madakristall")]
        madakristall,
        [Description("Matrixkristall")]
        matrixkristall,
        [Description("Kristallkraft bündeln")]
        kristallkraftBuendeln,
    }

    public enum Kugelzauber
    {
        [Description("undefined")]
        undefined,
        [Description("Bindung der Kristallkugel")]
        bindungDerKugel,
        [Description("Brennglas und Prisma")]
        brennglasUndPrisma,
        [Description("Schutz gegen Untote")]
        schutzGegenUntote,
        [Description("Warnendes Leuchten")]
        warnendesLeuchten,
        [Description("Kugel des Hellsehers")]
        kugelDesHellsehers,
        [Description("Kugel des Illusionisten")]
        kugelDesIllusionisten,
        [Description("Orbitarium")]
        orbitarium,
        [Description("Bilderspiel")]
        bilderspiel,
        [Description("Fernbild")]
        fernbild,
        [Description("Bildergalerie")]
        bildergalerie,
        [Description("H'Szints Auge")]
        hszintsAuge,
        [Description("Farben des Geistes")]
        farbenDesGeistes,
        [Description("Wachendes Auge")]
        wachendesAuge,
    }

    public enum OdunGaben
    {
        [Description("undefined")]
        undefined,
        [Description("Hauch des Odun")]
        hauchDesOdun,
        [Description("Blut des Odun")]
        blutDesOdun,
        [Description("Haut des Odun")]
        hautDesOdun,
        [Description("Ruf des Odun")]
        rufDesOdun,
        [Description("Seele des Odun")]
        seeleDesOdun,
    }

    public enum SchlangenRingZauber
    {
        [Description("undefined")]
        undefined,
        [Description("Weihe der Schlange")]
        weiheDerSchlange,
        [Description("Magnetismus")]
        magnetismus,
        [Description("Wasserbann")]
        wasserbann,
        [Description("Macht über den Regen")]
        machtUeberDenRegen,
        [Description("Seelenfeuer")]
        seelenfeuer,
        [Description("Herr der Flammen")]
        herrDerFlammen,
        [Description("Macht des Lebens")]
        machtDesLebens,
        [Description("Kräfte der Natur")]
        kraefteDerNatur,
        [Description("Wirbelnder Luftschild")]
        wirbelnderLuftschild,
        [Description("Launen des Windes")]
        launenDesWindes,
        [Description("Weg durch Sumus Leib")]
        wegDurchSumusLeib,
    }

    public enum Zaubertaenze
    {
        [Description("undefined")]
        undefined,
        [Description("Tanz der Liebe")]
        tanzDerLiebe,
        [Description("Tanz der Freude")]
        tanzDerFreude,
        [Description("Tanz der Ermutigung")]
        tanzDerErmutigung,
        [Description("Tanz der Wahrheit")]
        tanzDerWahrheit,
        [Description("Tanz der Erlösung")]
        tanzDerErloesung,
        [Description("Tanz der Bilder")]
        tanzDerBilder,
        [Description("Tanz ohne Ende")]
        tanzOhneEnde,
        [Description("Tanz des Ungehorsams")]
        tanzDesUngehorsams,
        [Description("Tanz der Gemeinschaft")]
        tanzDerGemeinschaft,
        [Description("Tanz der Weisheit")]
        tanzDerWeisheit,
        [Description("Tanz der Unantastbarkeit")]
        tanzDerUnantastbarkeit,
        [Description("Selinata")]
        selinata,
        [Description("Madayana")]
        madayana,
        [Description("Firuns Jagd")]
        firunsJagd,
        [Description("Rahjas Begeheren")]
        rahjasBegehren,
    }

    public enum ZibiljaRituale
    {
        [Description("undefined")]
        undefined,
        [Description("Scharmseele")]
        schwarmseele,
        [Description("Mackestopp")]
        mackestopp,
        [Description("Traumseherin")]
        Traumseherin,
        [Description("Weisheit der Schrift")]
        weisheitDerSchrift,
        [Description("Siegel der ewigen Ruhe")]
        siegelDerEwigenRuhe,
        [Description("Unsichtbare Chronik")]
        unsichtbareChronik,
        [Description("Winterlage")]
        winterlager,
        [Description("Bienenschwarm")]
        bienenschwarm,
        [Description("Wachshaut")]
        wachshaut,
        [Description("Bienenkönigin")]
        bienenkoenigin,
        [Description("Bienenfleiß")]
        bienenfleiss,
        [Description("Bienentanz")]
        bienentanz,
        [Description("Traumwissen")]
        traumwissen,
    }
}
