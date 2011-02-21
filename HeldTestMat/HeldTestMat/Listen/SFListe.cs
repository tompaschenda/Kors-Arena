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

    public enum Rituale
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
}
