﻿using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Listen
{

    public enum Fraktionen
    {
        // Zunächst möchte ich nur die Space Marines freischalten!
       [Description("Blood Angels")]
        BloodAngels,
        [Description("Chaosdämonen")]
        Chaosdaemonen,
        [Description("Chaos Space Marines")]
        ChaosSpaceMarines,
        [Description("Dark Eldar")]
        DarkEldar,
        [Description("Eldar")]
        Eldar,
        [Description("Grey Knights")]
        GreyKnights,
        [Description("Hexenjäger")]
        Hexenjaeger,
        [Description("Imperiale Armee")]
        ImperialeArmee,
        [Description("Necrons")]
        Necrons,
        [Description("Orks")]
        Orks,
        [Description("Space Marines")]
        SpaceMarines,
        [Description("Space Wolves")]
        SpaceWolves,
        [Description("Sternenreich der Tau")]
        SternenreichDerTau,
        [Description("Tyraniden")]
        Tyraniden,
        [Description("Apocalypse (Alle)")]
        Apocalypse,
    }

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
        Ruestungswert,
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
        [Description("Nahkampf")]
        Nahkampf,
        [Description("bis zu 18 Zoll")]
        Bis18Zoll,
        [Description("18-42 Zoll")]
        Von18Bis42Zoll,
        [Description("42-72 Zoll")]
        Von42Bis27Zoll,
        [Description("12-48 Zoll")]
        Von12Bis48Zoll,
    }

    public enum WaffenRegeln
    {
        [Description("undefined")]
        undefined,

        [Description("Paar Energiefäuste")]
        PaarEFaeuste,

        [Description("Ignoriert Rüstungswürfe")]
        IgnoriertRuestungswuerfe,
        [Description("verdoppelt Stärke (max. 10)")]
        verdoppeltStaerke,
        [Description("Verwundungswürfe wiederholen")]
        VerwundungswuerfeWiederholen,

        [Description("Moralverlust von -2 beim Gegner")]
        MoralverlustBeimGegnerM2,
        [Description("Plus 1 Schaden auf Fahrzeugtabelle")]
        FahrzeugtabellePlus1,
        [Description("Sofort ausgeschaltet")]
        SofotAusgeschaltet,
        [Description("Stun-Angriff")]
        StunAngriff,
        [Description("Ini-Verlust")]
        IniVerlust,
        [Description("Panzerungsds+ 2W6")]
        ExtraPanzerungsDurchschlag2W6,
        [Description("Energiewaffe")]
        Energiewaffe,
        [Description("Meisterhaft")]
        Meisterhaft,
        [Description("Psiwaffe")]
        Psiwaffe,
        [Description("Höllenfeuermunition")]
        Hoellenfeuermunition,
        [Description("Niederhalten")]
        Niederhalten,
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
        [Description("Scharfschütze")]
        Scharfschuetze,
        [Description("Synchronisiert")]
        Synchronisiert,
        [Description("Sperrfeuer")]
        Sperrfeuer,
        [Description("Geschütz 1")]
        Geschuetz1,
        [Description("Deckung ignorieren")]
        DeckungIgnorieren,
    }

    public enum Sonderregeln
    {
        [Description("undefined")]
        undefined,
        [Description("Epistolarius")]
        Epistolarius,
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
        TurboBooster,
        [Description("Verwundbar gegen Explosiv- und Flammenwaffen")]
        VerwundbarExplosivFlamme,
        [Description("Schocktruppen")]
        Schocktruppen,
        [Description("Psioniker")]
        Psioniker,
        [Description("Flankenangriff")]
        Flankenangriff,

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
        [Description("Kriegerstolz")]
        Kriegerstolz,
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
        Befestigen,
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
        [Description("Überraschungsangriff!")]
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
        [Description("Lahmgelegt")]
        Lahmgelegt,
        [Description("Geschenk der Vorsehung")]
        GeschenkDerVorsehung,
    }

    public enum WaffenSubTypen
    {
        [Description("undefined")]
        undefined,
        [Description("")]
        blank,
        [Description("Fragmentgranate")]
        Fragmentgranate,
        [Description("Sprenggranate")]
        Sprenggranate,
        [Description("Bolter")]
        Bolter,
        [Description("Melter")]
        Melter,
        [Description("Flammenwerfer")]
        Flammenwerfer,
        [Description("Plasmawerfer")]
        Plasmawerfer,
        [Description("Vergelterrakete")]
        Vergelterrakete,
        [Description("Kastellan-Brandrakete")]
        Kastellan,

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
        [Description("Bike")]
        Bike,
        [Description("Sprungtruppen")]
        Sprungtruppen,
        [Description("Fahrzeug (Panzer)")]
        FahrzeugPanzer,
        [Description("Fahrzeug (Läufer)")]
        FahrzeugLaeufer,
        [Description("Fahrzeug (Schnell)")]
        FahrzeugSchnell,
        [Description("Fahrzeug (Antigrav)")]
        FahrzeugAntrigrav,
        [Description("Fahrzeug (Offen)")]
        FahrzeugOffen,
        [Description("Artillerie")]
        Artillerie,
        [Description("Fahrzeug (Schnell, Antrigrav, Offen)")]
        FahrzeugSAO,
        [Description("Fahrzeug (Schnell, Antrigrav)")]
        FahrzeugSchnellAntigrav,
    }

    public enum EinheitenAuswahl
    {
        [Description("keine")]
        keine,
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
        [Description("Angeschlossenes Transportfahrzeug")]
        AngeschlossenesTransportFahrzeug,
    }


    // Liste ALLER Space Marine-Einheiten!
    public enum alleEinheitenNamen
    {
        [Description("Keine Einheit")]
        KeineEinheit,
        [Description("Marneus Calgar")]
        MarneusCalgar,
        [Description("Captain Cato Sicarius")]
        CaptainCatoSicarius,
        [Description("Scriptor-Magister Varro Tigurius")]
        VarroTigurius,
        [Description("Ordenspriester Ortan Cassius")]
        OrtanCassius,
        [Description("Pedro Kantor")]
        PedroKantor,
        [Description("Captain Darnath Lysander")]
        CaptainLysander,
        [Description("Captain Kayvaan Shrike")]
        CaptainShrike,
        [Description("Schmiedevater Vulkan He'stan")]
        VulkanHestan,
        [Description("Kor'sarro Khan")]
        KorsarroKhan,
        [Description("Ordensmeister der Space Marines")]
        OrdensmeisterDerSpaceMarines,
        [Description("Ehrengarde-Trupp")]
        Ehrengarde,
        [Description("Space Marine Captain")]
        CaptainDerSpaceMarines,
        [Description("Kommandotrupp")]
        Kommandotrupp,
        [Description("Scriptor der Space Marines")]
        Scriptor,
        [Description("Ordenspriester der Space Marines")]
        OrdenspriesterDerSpaceMarines,
        [Description("Meister der Schmeide")]
        MeisterSchmiede,
        [Description("Taktischer Trupp")]
        TaktischerTrupp,
        [Description("Scouttrupp")]
        Scouttrupp,
        [Description("Sergeant Tellion")]
        SergeantTellion,
        [Description("Rhino")]
        Rhino,
        [Description("Razorback")]
        Razorback,
        [Description("Landungskapsel")]
        Landungskapsel,
        [Description("Terminatortrupp")]
        Terminatortrupp,
        [Description("Terminatorsturmtrupp")]
        Terminatorsturmtrupp,
        [Description("Protektorgarde")]
        Protektorgarde,
        [Description("Ehrwürdiger Cybot")]
        EhrwuerdigerCybot,
        [Description("Cybot")]
        Cybot,
        [Description("Ironclad Cybot")]
        IroncladCybot,
        [Description("Techmarine")]
        Techmarine,
        [Description("Servitor")]
        Servitor,
        [Description("Legion of the Damned")]
        LegionOfTheDamned,
        [Description("Sturmtrupp")]
        Sturmtrupp,
        [Description("Expugnatorgarde")]
        Expugnatorgarde,
        [Description("Landspeederschwadron")]
        Landspeederschwadron,
        [Description("Bikerschwadron der Space Marines")]
        Bikerschwadron,
        [Description("Trikeschwadron")]
        Trikeschwadron,
        [Description("Landspeeder Storm")]
        LandspeederStorm,
        [Description("Scoutbikeschwadron")]
        Scoutbikeschwadron,
        [Description("Devastortrupp")]
        Devastortrupp,
        [Description("Salvenkanone")]
        Salvenkanone,
        [Description("Land Raider")]
        LandRaider,
        [Description("Land Raider Crusader")]
        LandRaiderCrusader,
        [Description("Land Raider Redeemer")]
        LandRaiderRedeemer,
        [Description("Predator")]
        Predator,
        [Description("Whirlwind")]
        Whirlwind,
        [Description("Vindicator")]
        Vindicator,
        [Description("Sergeant Chronus")]
        SergeantChronus,

        [Description("Rhino (kostenlos)")]
        RhinoKostenlos,
        [Description("Landungskapsel (kostenlos)")]
        LandungskapselKostenlos,
    }


    public enum alleSubeinheitenNamen
    {
        [Description("undefined")]
        undefined,
        [Description("Scriptor der Space Marines")]
        ScriptorSpaceMarines,
        [Description("Predator")]
        Predator,
        [Description("Salvenkanone")]
        Salvenkanone,
        [Description("Apothecarius")]
        Apothecarius,
        [Description("Captain")]
        CaptainDerSpaceMarines,
        [Description("Captain Cato Sicarius")]
        CaptainCatoSicarius,
        [Description("Captain Darnath Lysander")]
        CaptainLysander,
        [Description("Ehrengardist")]
        Ehrengardist,
        [Description("Captain Kayvaan Shrike")]
        CaptainShrike,
        [Description("Kompaniechampion")]
        Kompaniechampion,
        [Description("Kor'sarro Khan")]
        KorsarroKhan,
        [Description("Legion (Legionär)")]
        LegionLegionaer,
        [Description("Legion (Sergeant)")]
        LegionSergeant,
        [Description("Marneus Calgar")]
        MarneusCalgar,
        [Description("Meister der Schmeide")]
        MeisterSchmiede,
        [Description("Ordenschampion")]
        Ordenschampion,
        [Description("Ordensmeister")]
        Ordensmeister,
        [Description("Ordenspriester der Space Marines")]
        OrdenspriesterDerSpaceMarines,
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
        [Description("Scoutsergeant auf Bike")]
        ScoutsergeantAufBike,
        [Description("Sergeant der Space Marines")]
        SergeantDerSpaceMarines,
        [Description("Sergeant der Space Marines auf Bike")]
        SergeantDerSpaceMarinesAufBike,
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
        SpaceMarineTerminator,
        [Description("Terminatorsergeant")]
        Terminatorsergeant,
        [Description("Trike")]
        Trike,
        [Description("Varro Tigurius")]
        VarroTigurius,
        [Description("Veteran der Space Marines")]
        VeteranDerSpaceMariens,
        [Description("Vulkan He'stan")]
        VulkanHestan,
        [Description("Rhino")]
        Rhino,
        [Description("Razorback")]
        Razorback,
        [Description("Landungskapsel")]
        Landungskapsel,
        [Description("Land Raider")]
        LandRaider,
        [Description("Land Raider Crusader")]
        LandRaiderCrusader,
        [Description("Land Raider Redeemer")]
        LandRaiderRedeemer,
        [Description("Whirlwind")]
        Whirlwind,
        [Description("Vindicator")]
        Vindicator,
        [Description("Sergeant Chronus")]
        SergeantChronus,
        [Description("Space Marine Bike")]
        SpaceMarineBike,
        [Description("Landspeeder Storm")]
        LandspeederStorm,
        [Description("Landspeeder")]
        Landspeeder,
        [Description("Ehrwürdiger Cybot")]
        EhrwuerdigerCybot,
        [Description("Cybot")]
        Cybot,
        [Description("Ironclad-Cybot")]
        IroncladCybot,
    }

    public enum alleWaffenNamen
    {
        [Description("undefined")]
        undefined,
        [Description("Servoarm")]
        Servoarm,
        [Description("Servoharnisch")]
        Servoharnisch,
        [Description("Orbitales Bombardement")]
        OrbitalesBombardement,
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
        /*[Description("Energiewaffe")]
        Energiewaffe,*/
        [Description("Energiehammer")]
        Energiehammer,
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
        [Description("Kombiplasmawerfer")]
        KombiPlasmawerfer,
        [Description("Konversionsstrahler")]
        Konversionsstrahler,
        [Description("Laserkanone")]
        Laserkanone,
        /*[Description("Meisterhafte Waffe")]
        MeisterhafteWaffe,*/
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
        [Description("Sturmbolter")]
        Sturmbolter,
        [Description("Sturmkanone")]
        Sturmkanone,
        [Description("Stalker-Schema Bolter")]
        StalkerSchemaBolter,
        [Description("Talassarianische Sturmklinge")]
        TalassarianischeSturmklinge,
        [Description("Stab des Tigurius")]
        StabDesTigurius,
        [Description("Infernus")]
        Infernus,
        [Description("Dorns Pfeil")]
        DornsPfeil,
        [Description("Dorns Faust")]
        DornsFaust,
        [Description("Die Rabenklauen")]
        Rabenklauen,
        [Description("Speer des Vulkan")]
        SpeerDesVulkan,
        [Description("Schmiedefeuerhandschuh")]
        Schmiedefeuerhandschuh,
        [Description("Mondfang")]
        Mondfang,
        [Description("Die Fäuste von Ultramar")]
        FaeusteVonUltramar,
        [Description("Cybotnahkampfwaffe")]
        CybotNahkampfWaffe,
        [Description("Seismischer Hammer")]
        SeismischerHammer,


        [Description("Synchronisierter Melter")]
        SyncMelter,
        [Description("Synchronisierter Multimelter")]
        SyncMultiMelter,
        [Description("Synchronisierter Bolter")]
        SyncBolter,
        [Description("Synchronisierter Schwerer Bolter")]
        SyncSchwererBolter,
        [Description("Synchronisierter Schwerer Flammenwerfer")]
        SyncSchwererFlammenwerfer,
        [Description("Synchronisierte Sturmkanone")]
        Syncsturmkanone,
        [Description("Synchronisierte Laserkanone")]
        SyncLaserKanone,
        [Description("Synchronisierter Plasmawerfer")]
        SyncPlasmawerfer,
        [Description("Synchronisierte Plasmapistole")]
        SyncPlasmapistole,
        [Description("Energieschwert")]
        Energieschwert,
        [Description("Synchronisierte Maschinenkanone")]
        SyncMaschkanone,

        [Description("Laserkanone und synchronisierter Plasmawerfer")]
        LaserkanoneUndSynchroPlasma,


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
        [Description("Cerberus-Werfer")]
        CerberusWerfer,
        [Description("Typhoon-Raketenwerfer")]
        TyphoonRaketenwerfer,
        [Description("Whirlwind-Mehrfachraketenwerfer")]
        WhirlwindMehrfachRaketenWerfer,
    }

    public enum alleAusruestung
    {
        [Description("undefined")]
        undefined,
        [Description("keine")]
        keine,
        [Description("Spezialmunition")]
        Spezialmunition,
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
        Parierschild,
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
        [Description("Melterbomben")]
        Melterbomben,
        [Description("Fragmentgranaten")]
        Fragmentgranaten,
        [Description("Sprenggranaten")]
        Sprenggranaten,
        [Description("Höllenfeuermatrix")]
        Hoellenfeuermatrix,
        [Description("Kesares Mantel")]
        KesaresMantel,
        [Description("Digitalwaffen")]
        Digitalwaffen,

        // Alle Ausrüstung für Fahrzeuge:
        [Description("Bulldozerschaufel")]
        Bulldozerschaufel,
        [Description("Belagerungsschild")]
        Belagerungsschild,
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
        [Description("Zusätzliche Panzerung")]
        ZusaetzlichePanzerung,
    }

    public enum alleRuestungen
    {
        [Description("undefined")]
        undefined,
        [Description("keine")]
        keine,
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

    public enum Psikraefte
    {
        [Description("undefined")]
        undefined,
        [Description("Schmetterschlag")]
        Schmetterschlag,
        [Description("Psischild")]
        Psischild,
        [Description("Maschinenfluch")]
        Maschinenfluch,
        [Description("Avatar der Sühne")]
        AvatarDerSuehne,
        [Description("Beschleunigung")]
        Beschleunigung,
        [Description("Nullzone")]
        Nullzone,
        [Description("Macht der Alten")]
        MachtDerAlten,
        [Description("Tor zur Unendlichkeit")]
        TorZurUnendlichkeit,
        [Description("Vortex der Verdammnis")]
        VortexDerVerdammnis,
    }
}
