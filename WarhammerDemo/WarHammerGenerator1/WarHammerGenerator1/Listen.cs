using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{

    public enum Attribute
    {
        [Description("undefined")]
        undefined,
        [Description("Kampfgeschick")]
        Kampfgeschick,
        [Description("Ballistische Fertigkeit")]
        BallistischeFertigkeit,
        [Description("Stärke")]
        Staerke,
        [Description("Widerstand")]
        Widerstand,
        [Description("Lebenspunkte")]
        Lebenspunkte,
        [Description("Initiative")]
        Initiative,
        [Description("Attacken")]
        Attacken,
        [Description("Moralwert")]
        Moralwert,
        [Description("Rüstungswert")]
        Ruestungsert,
    }

    public enum Reichweiten
    {
        [Description("undefined")]
        undefined,
        [Description("Flammen")]
        Flammen,
        [Description("12 Zoll")]
        Zoll12,
        [Description("24 Zoll")]
        Zoll24,
        [Description("36 Zoll")]
        Zoll36,
        [Description("48 Zoll")]
        Zoll48,
        [Description("unbeschränkt")]
        unbeschraenkt,
    }

    public enum Waffentypen
    {
        [Description("undefined")]
        undefined,
        [Description("Sturm 1")]
        Sturm1,
        [Description("Sturm 2")]
        Sturm2,
        [Description("Sturm 3")]
        Sturm3,
        [Description("Sturm 4")]
        Sturm4,
        [Description("Schwer 1")]
        Schwer1,
        [Description("Schwer 2")]
        Schwer2,
        [Description("Schwer 3")]
        Schwer3,
        [Description("Schwer 4")]
        Schwer4,
        [Description("Melter")]
        Melter,
        [Description("Schnellfeuer")]
        Schnellfeuer,
        [Description("Pistole")]
        Pistole,
        [Description("Überhitzen!")]
        Ueberhitzen,
        [Description("Rüstungsbrechend")]
        Ruestungsbrechend,
        [Description("Gift (+2)")]
        GiftPlus2,
        [Description("Gift (+4)")]
        GiftPlus4,
        [Description("Explosiv")]
        Explosiv,
        [Description("Explosiv (5 Zoll)")]
        Explosiv5Zoll,
    }

    public enum Sonderregeln
    {
        [Description("undefined")]
        undefined,
        [Description("Gegenschlag")]
        Gegenschlag,
        [Description("Ewiger Krieger")]
        EwigerKrieger,
        [Description("Furchtlos")]
        Furchtlos,
        [Description("Verletzungen ignorieren")]
        VerletzungenIgnorieren,
        [Description("Sprinten")]
        Sprinten,
        [Description("Rasender Angriff")]
        RasenderAngriff,
        [Description("Zurückfallen")]
        Zurueckfallen,
        [Description("Infiltratoren")]
        Infiltratoren,
        [Description("Durch Deckung Bewegen")]
        DurchDeckungBewegen,
        [Description("Nachtsicht")]
        Nachtsicht,
        [Description("Scharfe Sinne")]
        ScharfeSinne,
        [Description("Erzfeind")]
        Erzfeind,
        [Description("Blutrünstig")]
        Blutruenstig,
        [Description("Waffenexperten")]
        Waffenexperten,
        [Description("Scouts")]
        Scouts,
        [Description("Geländeerfahrung")]
        GelaendeErfahrung,
        [Description("Langsam und entschlossen")]
        LangsamUndEntschlossen,
        [Description("Deckung nutzen")]
        DeckungNutzen,
        [Description("Unnachgiebig")]
        Unnachgiebig,
        [Description("Schwärme")]
        Schwaerme,
        [Description("Panzerjäger")]
        Panzerjaeger,
        [Description("Turbo-Booster")]
        TurboBooser,
        [Description("Verwundbar gegen Explosiv- und Flammenwaffen")]
        VerwundbarExplosivFlamme,
        [Description("Schocktruppen")]
        Schocktruppen,
        [Description("Psioniker")]
        Psioniker,

        // An dieser Stelle folgen die Sonderregeln der Space Marines:
        [Description("Die keine Furcht kennen")]
        DieKeineFurchtKennen,
        [Description("Kampftaktiken")]
        Kampftaktiken,
        [Description("Unabhängiges Charaktermodell")]
        UnabhaengigesCharakterModell,
        [Description("Kampftrupps")]
        Kampftrupps,
        [Description("Orbitales Bombardement")]
        OrbitalesBombardement,
        [Description("Tod oder Ehre")]
        TodOderEhre,
        [Description("Die Ehre des Ordens")]
        DieEhreDesOrdens,
        [Description("Liturgien der Schlacht")]
        LiturgienDerSchlacht,
        [Description("Heroische Intervention")]
        HeroischeIntervention,
        [Description("Ehrwürdig")]
        Ehrwuerdig,
        [Description("Landungskapsel-Angriff")]
        LandungskapselAngriff,
        [Description("Inertial-Leitsystem")]
        InertialLeitsystem,
        [Description("Stationär")]
        Stationaer,
        [Description("Segen des Omnissiah")]
        SegenDesOmnissiah,
        [Description("Befestigen")]
        Befestige,
        [Description("Lobotomie")]
        Lobotomie,
        [Description("Reparieren")]
        Reparieren,
        [Description("Macht des Maschinengeistes")]
        MachtDesMaschinengeistes,
        [Description("Sturmpanzer")]
        Sturmpanzer,
        [Description("Titanische Macht")]
        TitanischeMacht,
        [Description("Kriegsgott")]
        Kriegsgott,
        [Description("Überrschungsangriff!")]
        Ueberraschungsangriff,
        [Description("Riten der Schlacht")]
        RitenDerSchlacht,
        [Description("Kampfgestählte Helden")]
        KampfgestaehlteHelden,
        [Description("Meisterpsioniker")]
        Meisterpsioniker,
        [Description("Gabe der Vorhersehung")]
        GabeDerVorhersehung,
        [Description("Auge der Vergeltung")]
        AugeDerVergeltung,
        [Description("Leitende Hand")]
        LeitendeHand,
        [Description("Panzerkommandant")]
        Panzerkommandant,
        [Description("Ordenstaktik (Haltet die Linien!)")]
        OrdenstaktikHaltet,
        [Description("Inspirierende Gegenwart")]
        InspirierendeGegenwart,
        [Description("Bolter-Drill")]
        BolterDrill,
        [Description("Ordenstaktik")]
        Ordenstaktik,
        [Description("Sehen, aber nicht gesehen werden")]
        SehenAberNichtGesehen,
        [Description("Meister der Jagd")]
        MeisterDerJagd,
        [Description("Unbeugsame Geister")]
        UnbeugsameGeister,
        [Description("Wie aus dem Nichts...")]
        WieAusDemNichts,
    }


    public enum Armeetyp
    {
        [Description("undefined")]
        undefined,
        [Description("Space Marines")]
        SpaceMarines,
        [Description("Tyranniden")]
        Tyranniden,
        [Description("Blood Angels")]
        BloodAngels,
        [Description("Dark Eldar")]
        DarkEldar,       
    }

    public enum Einheitstyp
    {
        [Description("undefined")]
        undefined,
        [Description("Infanterie")]
        Infanterie,
        [Description("Fahrzeug")]
        Fahrzeug,
        [Description("Fahrzeug (Läufer)")]
        FahrzeugLaeuferLaeufer,
        [Description("Fahrzeug (Schnell)")]
        FahrzeugSchnell,
        [Description("Fahrzeug (Antigrav)")]
        FahrzeugAntrigrav,
        [Description("Fahrzeug (Offen)")]
        FahrzeugOffen,
    }

    public enum EinheitenAuswahl
    {
        [Description("undefined")]
        undefined,
        [Description("HQ")]
        HQ,
        [Description("Standard")]
        Standard,
        [Description("Elite")]
        Elite,
        [Description("Sturm")]
        Sturm,
        [Description("Unterstützung")]
        Unterstuetzung,
    }

    public enum SpaceMarineEinheiten
    {
        [Description("undefined")]
        undefined,
        [Description("Ehrengarde-Trupp")]
        EhrengardeTrupp,
        [Description("Kommandotrupp")]
        Kommandotrupp,
        [Description("Taktischer Trupp")]
        TaktischerTrupp,
        [Description("Scouttrupp")]
        Scouttrupp,
        [Description("Scouttrupp mit Sergeant Telion")]
        ScouttruppMitSergeantTelion,
        [Description("Terminatortrupp")]
        Terminatortrupp,
        [Description("Terminator Strumtrupp")]
        TermiantorStrumtrupp,
        [Description("Protektorgarde")]
        Protektorgarde,
        [Description("Legion of the Damned")]
        LegionOfTheDamned,
        [Description("Sturmtrupp")]
        Sturmtrupp,
        [Description("Expugnatorgarde")]
        Expugnatorgarde,
        [Description("Landspeeder-Schwadron")]
        LandspeederSchwadron,
        [Description("Bikeschwadron der Space Marines")]
        Bikeschwadron,
        [Description("Trike-Schwadron")]
        Trikeschwadron,
        [Description("Scoutbike-Schwadron")]
        ScoutBikeSchwadron,
        [Description("Devastortrupp")]
        DevastorTrupp,
        [Description("Salvenkanone")]
        Salvenkanone,
    }

    public enum SpaceMarinesInfanterie
    {
        [Description("undefined")]
        undefined,
        [Description("Salvenkanone")]
        Salvenkanone,
        [Description("Apothecarius")]
        Apothecarius,
        [Description("Captain")]
        Captain,
        [Description("Captain Cato Sicarius")]
        CaptainCatoSicarius,
        [Description("Sergeant Chronus")]
        Chronus,
        [Description("Captain Darnath Lysander")]
        CaptainLysander,
        [Description("Ehrengarde")]
        Ehrengarde,
        [Description("Captain Kayvaan Shrike")]
        CaptainShrike,
        [Description("Kompaniechampion")]
        Kompaniechampion,
        [Description("Kor'sarro Khan")]
        KorsarroKhan,
        [Description("Legion (Legionär)")]
        LegionLegionaer,
        [Description("Marneus Calgar")]
        MarneusCalgar,
        [Description("Meister der Schmeide")]
        MeisterSchmiede,
        [Description("Ordenschampion")]
        Ordenschampion,
        [Description("Ordensmeister")]
        Ordensmeister,
        [Description("Ordenspriester")]
        Ordenspriester,
        [Description("Ortan Cassius")]
        OrtanCassius,
        [Description("Pedro Kantor")]
        PedroKantor,
        [Description("Scout")]
        Scout,
        [Description("Scout auf Bike")]
        ScoutAufBike,
        [Description("Scoutsergeant")]
        Scoutsergeant,
        [Description("Sergeant der Space Marines")]
        SergeantDerSpaceMarines,
        [Description("Sergeant Telion")]
        SergeantTelion,
        [Description("Servitor")]
        Servitor,
        [Description("Space Marine")]
        SpaceMarine,
        [Description("Space Marine auf Bike")]
        SpaceMarineAufBike,
        [Description("Techmarine")]
        Techmarine,
        [Description("Terminator")]
        Terminator,
        [Description("Terminatorsergeant")]
        Terminatorsergeant,
        [Description("Trike")]
        Trike,
        [Description("Varro Tigurius")]
        VarroTigurius,
        [Description("Veteran")]
        Veteran,
        [Description("Vulkan He'stan")]
        VulkanHestan,
    }

    public enum SpaceMarinesFahrzeuge
    {
        [Description("undefined")]
        undefined,
        [Description("Landungskapsel")]
        Landungskapsel,
        [Description("Land Raider")]
        LandRaider,
        [Description("Land Raider Crusader")]
        LandRaiderCrusader,
        [Description("Land Raider Redeemer")]
        LandRaiderRedeemer,
        [Description("Landspeeder")]
        Landspeeder,
        [Description("Landspeeder Storm")]
        LandspeederStorm,
        [Description("Predator")]
        Predator,
        [Description("Razorback")]
        Razorback,
        [Description("Rhino")]
        Rhino,
        [Description("Vindicator")]
        Vindicator,
        [Description("Whirlwind")]
        Whirlwind,
        [Description("Cybot")]
        Cybot,
        [Description("Ironclad-Cybot")]
        IroncladCybot,
        [Description("Ehrwürdiger Cybot")]
        EhrenwuerdigerCybot,
    }

    public enum SpaceMarinesWaffen
    {
        [Description("undefined")]
        undefined,
        [Description("Astartes-Granatwerfer")]
        AstartesGranatwerfer,
        [Description("Auxilaris-Granatwerfer")]
        AuxilarisGranatwerfer,
        [Description("Bolter")]
        Bolter,
        [Description("Boltpistole")]
        Boltpistole,
        [Description("Crozius Arcanum")]
        Crozius,
        [Description("Cyclone-Raketenwerfer")]
        CycloneRaketenwerfer,
        [Description("Digitalwaffe")]
        Digitalwaffe,
        [Description("Ehrenklinge")]
        Ehrenklinge,
        [Description("Energieklaue")]
        Energieklaue,
        [Description("Energiefaust")]
        Energiefaust,
        [Description("Energiewaffe")]
        Energiewaffe,
        [Description("Energiehammer")]
        Energiehammer,
        [Description("Fragmentgranaten")]
        Fragmentgranaten,
        [Description("Flammenwerfer")]
        Flammenwerfer,
        [Description("Kettenfaust")]
        Kettenfaust,
        [Description("Kettenschwert")]
        Kettenschwert,
        [Description("Kampfmesser")]
        Kampfmesser,
        [Description("Kombimelter")]
        KombiMelter,
        [Description("Kombiflammenwerfer")]
        KombiFlammenwerfer,
        [Description("Kombiplasmagewehr")]
        KombiPlasmagewehr,
        [Description("Konversionsstrahler")]
        Konversionsstrahler,
        [Description("Laserkanone")]
        Laserkanone,
        [Description("Meisterhafte Waffe")]
        MeisterhafteWaffe,
        [Description("Melterbomben")]
        Melterbomben,
        [Description("Melter")]
        Melter,
        [Description("Multimelter")]
        Multimelter,
        [Description("Psiwaffe")]
        Psiwaffe,
        [Description("Plasmakanone")]
        Plasmakanone,
        [Description("Plasmapistole")]
        Plasmapistole,
        [Description("Plasmawerfer")]
        Plasmawerfer,
        [Description("Raketenwerfer")]
        Raketenwerfer,
        [Description("Schwerer Bolter")]
        SchwererBolter,
        [Description("Schwerer Flammer")]
        SchwererFlammer,
        [Description("Schrotflinte")]
        Schrotflinte,
        [Description("Scharfschützengewehr")]
        Scharfschützengewehr,
        [Description("Sprenggranaten")]
        Sprenggranaten,
        [Description("Sturmbolter")]
        Sturmbolter,
        [Description("Sturmkanone")]
        Sturmkanone,
    }

    public enum SpaceMarinesAusruestung
    {
        [Description("undefined")]
        undefined,
        [Description("Höllenfeuergeschosse")]
        Hoellenfeuergeschosse,
        [Description("Höllenfeuermunition")]
        Hoellenfeuermunition,
        [Description("Kompaniestandarte")]
        Kompaniestandarte,
        [Description("Narthecium")]
        Narthecium,
        [Description("Ordensbanner")]
        Ordensbanner,
        [Description("Parierschild")]
        Parierschield,
        [Description("Peilsender")]
        Peilsender,
        [Description("Psimatrix")]
        Psimatrix,
        [Description("Rosarius")]
        Rosarius,
        [Description("Servoarm")]
        Servoarm,
        [Description("Servoharnisch")]
        Servoharnisch,
        [Description("Signum")]
        Signum,
        [Description("Space Marine Bike")]
        SpaceMarineBike,
        [Description("Splitterminen")]
        Splitterminen,
        [Description("Sprungmodul")]
        Sprungmodul,
        [Description("Stählerner Stern")]
        StaehlernerStern,
        [Description("Sturmschild")]
        Sturmschild,
        [Description("Tarnmantel")]
        Tarnmantel,
        [Description("Teleport-Peilsender")]
        TeleportPeilsender,
    }

    public enum SpaceMarinesRuestungen
    {
        [Description("undefined")]
        undefined,
        [Description("Meisterhafte Rüstung")]
        MeisterhafteRuestung,
        [Description("Servorüstung")]
        ServoRuestung,
        [Description("Scoutrüstung")]
        Scoutruestung,
        [Description("Terminatorrüstung")]
        TerminatorRuestung,
        [Description("Rüstung des Antilochus")]
        RuestungDesAntilochus,
    }

    public enum SpaceMarinesFahrzeugAusruestung
    {
        [Description("undefined")]
        undefined,
        [Description("Bulldozerschaufel")]
        Bulldozerschaufel,
        [Description("Cerberus-Werfer")]
        CerberusWerfer,
        [Description("Deathwind-System")]
        DeathwindSystem,
        [Description("Demolishergeschütz")]
        DemolisherGeschuetz,
        [Description("Flammensturmkanone")]
        Flammensturmkanone,
        [Description("Hurricane-Boltersystem")]
        HurricaneBolter,
        [Description("Ironclad-Sturmgranatwerfer")]
        IroncladSturmGranatwerfer,
        [Description("Maschinenkanone")]
        Maschinenkanone,
        [Description("Nebelwerfer")]
        Nebelwerfer,
        [Description("Radarsuchkopfrakete")]
        Radarsuchkopfrakete,
        [Description("Seismischer Hammer")]
        SeismischerHammer,
        [Description("Splittergranatwerfer")]
        Splittergranatwerfer,
        [Description("Störsender")]
        Stoersender,
        [Description("Suchscheinwerfer")]
        Suchscheinwerfer,
        [Description("Typhoon-Raketenwerfer")]
        TyphoonRaketenwerfer,
        [Description("Whirlwind-Mehrfachraketenwerfer")]
        WhirlwindMehrfachRaketenWerfer,
        [Description("Zusätzlicher Sturmbolter")]
        ZusaetzlicherSturmbolter,
    }


}
