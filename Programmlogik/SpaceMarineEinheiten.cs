using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Listen;
using Common;
using System.IO;

namespace WarhammerGUI
{

    /// <summary>
    /// Klasse, die alle Einheiten der Space Marines hält!
    /// </summary>
    public class SpaceMarineEinheitenListe
    {
        /// <summary>
        /// Gibt ALLE Einheiten der Space Marines zurück!
        /// </summary>
        /// <returns></returns>
        public List<Einheit> gibMirAlleSpaceMarineEinheiten()
        {
            var listeAllerSpaceMarineEinheiten = new List<Einheit>(){};

            var tTrupp = new taktischerTrupp() { };
            tTrupp.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(tTrupp);

            var termies = new terminatortrupp() { };
            termies.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(termies);

            var termiesturm = new terminatorSturmTrupp() { };
            termiesturm.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(termiesturm);

            var rhino = new rhino() { };
            rhino.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(rhino);

            var razorback = new razorback() { };
            razorback.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(razorback);

            var landungskapsel = new landungskapsel() { };
            landungskapsel.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(landungskapsel);

            var whirl = new whirlwind() { };
            whirl.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(whirl);

            var landRaider = new landRaider() { };
            landRaider.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(landRaider);

            var crusader = new landRaiderCrusader() { };
            crusader.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(crusader);

            var redeemer = new landRaiderRedeemer() { };
            redeemer.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(redeemer);

            var vindi = new vindicator() { };
            vindi.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(vindi);

            var chronus = new sargeChronus() { };
            chronus.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(chronus);

            var tellion = new sargeTellion() { };
            tellion.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(tellion);

            var sicarius = new capSicarius() { };
            sicarius.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(sicarius);

            var tigurius = new varroTigurius() { };
            tigurius.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(tigurius);

            var cass = new cassius() { };
            cass.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(cass);

            var pedro = new kantor() { };
            pedro.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(pedro);

            var lys = new lysander() { };
            lys.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(lys);

            var sh = new shrike() { };
            sh.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(sh);

            var vuk = new vukan() { };
            vuk.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(vuk);

            var kh = new khan() { };
            kh.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(kh);

            var salve = new salvenkanone() { };
            salve.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(salve);

            var deva = new devastortrupp() { };
            deva.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(deva);

            var storm = new landSpeederStorm() { };
            storm.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(storm);

            var scoutSchwad = new scoutbikerschwadron() { };
            scoutSchwad.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(scoutSchwad);

            var sturm = new sturmTrupp() { };
            sturm.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(sturm);

            var expu = new expugnatorGarde() { };
            expu.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(expu);

            var ehrw = new ehrwCybot() { };
            ehrw.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(ehrw);

            var cyv = new cybot() { };
            cyv.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(cyv);

            var iron = new ironclad() { };
            iron.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(iron);

            var scouts = new scoutTrupp() { };
            scouts.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(scouts);

            var cap = new spaceMarineCaptain() { };
            cap.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(cap);

            var ordnesmeist = new spaceMarineOrdensmeister() { };
            ordnesmeist.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(ordnesmeist);

            var protekt = new protektorGarde() { };
            protekt.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(protekt);

            var preda = new predator() { };
            preda.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(preda);

            var lsped = new landSpeederSchwadron() { };
            lsped.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(lsped);

            var tr = new trikeSchwadron() { };
            tr.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(tr);

            var bikeS = new bikeSchwadron() { };
            bikeS.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(bikeS);

            var leg = new legionOfTheDamned() { };
            leg.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(leg);

            var techm = new techmarine() { };
            techm.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(techm);

            var scrp = new scriptorDerSpaceMariens() { };
            scrp.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(scrp);

            var priest = new ordenspriesterDerSpaceMarines() { };
            priest.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(priest);

            
            var calgar = new marneusCalgar() { };
            calgar.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(calgar);

            var komtrupp = new kommandotrupp() { };
            komtrupp.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(komtrupp);

            var ehre = new ehrengarde() { };
            ehre.createUnitBase();
            listeAllerSpaceMarineEinheiten.Add(ehre);

            listeAllerSpaceMarineEinheiten.Sort();

            return listeAllerSpaceMarineEinheiten;
        }
    }

    public static class ultraMarineHelperClass
    {
        // Erzeugt die Subeinheit "Space Marine"
        public static subEinheit createSpaceMarine()
        {
            var spaceMarine = new subEinheit() { };
            spaceMarine.name = alleSubeinheitenNamen.SpaceMarine;

            // Jeder Space Marine hat eine Servorüstung (keine Extra-Kosten):
            spaceMarine.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.ServoRuestung);

            // Jeder Space Marine hat Fragment- und Sprenggranaten (keine Extra-Kosten):
            spaceMarine.ausruestung = new List<alleAusruestung>();
            spaceMarine.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            spaceMarine.ausruestung.Add(alleAusruestung.Sprenggranaten);

            // Das Gleiche gilt für die Boltpistole!
            spaceMarine.waffen = new List<waffe>() { };
            spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));

            // Fehlen noch die eigentlichen Were für den  Marine:
            spaceMarine.kg = 4;
            spaceMarine.bf = 4;
            spaceMarine.st = 4;
            spaceMarine.wid = 4;
            spaceMarine.lp = 1;
            spaceMarine.ini = 4;
            spaceMarine.at = 1;
            spaceMarine.mw = 8;
            spaceMarine.rw = 3;
            spaceMarine.ret = 0;

            spaceMarine.einheitentyp = Einheitstyp.Infanterie;

            return spaceMarine;
        }

        public static subEinheit createSpaceMarineSergeant()
        {
            // Außerdem gibt es ja noch den Sergeant:
            // Erstellen wir ihn:
            var spaceMarineSergeant = new subEinheit() { };
            spaceMarineSergeant.name = alleSubeinheitenNamen.SergeantDerSpaceMarines;

            spaceMarineSergeant.ausruestung = new List<alleAusruestung>() { };
            spaceMarineSergeant.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            spaceMarineSergeant.ausruestung.Add(alleAusruestung.Sprenggranaten);
            spaceMarineSergeant.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.ServoRuestung);

            spaceMarineSergeant.waffen = new List<waffe>() { };
            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));

            // Fehlen noch die eigentlichen Were für den  Marine:
            spaceMarineSergeant.kg = 4;
            spaceMarineSergeant.bf = 4;
            spaceMarineSergeant.st = 4;
            spaceMarineSergeant.wid = 4;
            spaceMarineSergeant.lp = 1;
            spaceMarineSergeant.ini = 4;
            spaceMarineSergeant.at = 2;
            spaceMarineSergeant.mw = 9;
            spaceMarineSergeant.rw = 3;
            spaceMarineSergeant.ret = 0;
            spaceMarineSergeant.einheitentyp = Einheitstyp.Infanterie;

            return spaceMarineSergeant;
        }

        public static subEinheit createScout()
        {
            var scout = createSpaceMarine();
            scout.name = alleSubeinheitenNamen.Scout;
            scout.kg = 3;
            scout.bf = 3;
            scout.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.Scoutruestung);
            return scout;
        }

        public static subEinheit createTerminator()
        {
            var terminator = new subEinheit() { };
            terminator.name = alleSubeinheitenNamen.SpaceMarineTerminator;

            terminator.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.TerminatorRuestung);

            terminator.ausruestung = new List<alleAusruestung>();

            terminator.waffen = new List<waffe>() { };

            // Fehlen noch die eigentlichen Were für den Terminator:
            terminator.kg = 4;
            terminator.bf = 4;
            terminator.st = 4;
            terminator.wid = 4;
            terminator.ini = 4;
            terminator.lp = 1;
            terminator.at = 2;
            terminator.mw = 9;
            terminator.rw = 2;
            terminator.ret = 5;

            terminator.einheitentyp = Einheitstyp.Infanterie;

            return terminator;
        }

        public static subEinheit createTermiantorSergeant()
        {
            var sarge = createTerminator();
            sarge.name = alleSubeinheitenNamen.Terminatorsergeant;
            return sarge;
        }

        public static subEinheit createVeteran()
        {
            var veteran = createSpaceMarine();
            veteran.name = alleSubeinheitenNamen.VeteranDerSpaceMariens;
            veteran.at = 2;
            veteran.mw = 9;

            veteran.ausruestung.Add(alleAusruestung.Spezialmunition);

            return veteran;
        }

        public static subEinheit createLegionaerSarge()
        {
            var sarge = createSpaceMarineSergeant();
            sarge.kg = 5;
            sarge.mw = 10;
            sarge.name = alleSubeinheitenNamen.LegionSergeant;
            return sarge;
        }

        public static subEinheit createLegionaerLegionaer()
        {
            var leg = createLegionaerSarge();
            leg.name = alleSubeinheitenNamen.LegionLegionaer;
            leg.kg = 4;
            return leg;
        }

        public static subEinheit createEhrengardist()
        {
            var gardist = createSpaceMarine();
            gardist.name = alleSubeinheitenNamen.Ehrengardist;
            gardist.mw = 10;
            gardist.rw = 2;
            gardist.at = 2;
            gardist.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.MeisterhafteRuestung);
            gardist.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));

            return gardist;
        }

        public static subEinheit createOrdenschampion()
        {
            var champ = createEhrengardist();
            champ.name = alleSubeinheitenNamen.Ordenschampion;
            champ.at = 3;
            champ.kg = 5;
            return champ;
        }

        public static subEinheit createKompaniechampion()
        {
            var champ = createSpaceMarine();
            champ.name = alleSubeinheitenNamen.Kompaniechampion;
            champ.kg = 5;
            champ.at = 2;
            champ.mw = 9;
            return champ;
        }

        public static subEinheit createApothecarius()
        {
            var apo = createSpaceMarine();
            apo.name = alleSubeinheitenNamen.Apothecarius;
            apo.mw = 9;
            apo.at = 2;
            return apo;
        }

        public static subEinheit createRhino()
        {
            var rhino = new subEinheit() { };
            rhino.name = alleSubeinheitenNamen.Rhino;

            rhino.ausruestung = new List<alleAusruestung>() { };
            rhino.ausruestung.Add(alleAusruestung.Nebelwerfer);
            rhino.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            rhino.waffen = new List<waffe>() { };
            rhino.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Sturmbolter));

            rhino.einheitentyp = Einheitstyp.FahrzeugPanzer;

            rhino.bf = 4;
            rhino.front = 11;
            rhino.seit = 11;
            rhino.heck = 10;
            rhino.transportkapazitaet = 10;

            return rhino;
        }

        public static subEinheit createRazorback()
        {
            var razor = createRhino();
            razor.name = alleSubeinheitenNamen.Razorback;
            razor.waffen = new List<waffe>() { };
            razor.transportkapazitaet = 6;
            return razor;
        }

        public static subEinheit createCybot()
        {
            var cybot = new subEinheit() { };
            cybot.name = alleSubeinheitenNamen.Cybot;
            cybot.ausruestung = new List<alleAusruestung>() { };
            cybot.waffen = new List<waffe>() { };

            // Die folgende Ausrüstung gibt es immer:
            cybot.ausruestung.Add(alleAusruestung.Nebelwerfer);
            cybot.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            cybot.einheitentyp = Einheitstyp.FahrzeugLaeufer;

            // Setzen der Panzerungswerte:
            cybot.kg = 4;
            cybot.bf = 4;
            cybot.st = 6;
            cybot.front = 12;
            cybot.seit = 12;
            cybot.heck = 10;
            cybot.ini = 4;
            cybot.at = 2;
            cybot.transportkapazitaet = 0;

            return cybot;
        }

        public static subEinheit createEhrwuerdigerCybot()
        {
            var ehrw = createCybot();
            ehrw.name = alleSubeinheitenNamen.EhrwuerdigerCybot;
            ehrw.kg = 5;
            ehrw.bf = 5;
            return ehrw;
        }

        public static subEinheit createIronclad()
        {
            var clad = createCybot();
            clad.name = alleSubeinheitenNamen.IroncladCybot;
            clad.front = 13;
            clad.seit = 13;
            clad.at = 3;
            clad.ausruestung.Add(alleAusruestung.ZusaetzlichePanzerung);
            return clad;
        }

        public static subEinheit createSpaceMarinesCaptain()
        {
            var cap = new subEinheit() { };
            cap.name = alleSubeinheitenNamen.CaptainDerSpaceMarines;

            cap.ausruestung = new List<alleAusruestung>() { };
            cap.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            cap.ausruestung.Add(alleAusruestung.Sprenggranaten);
            cap.ausruestung.Add(alleAusruestung.StaehlernerStern);

            cap.kg = 6;
            cap.bf = 5;
            cap.st = 4;
            cap.wid = 4;
            cap.ini = 5;
            cap.lp = 3;
            cap.at = 3;
            cap.mw = 10;
            cap.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.ServoRuestung);

            return cap;
        }

        public static subEinheit createSpaceMarineOrdensmeister()
        {
            var meister = createSpaceMarinesCaptain();
            meister.name = alleSubeinheitenNamen.Ordensmeister;
            return meister;
        }

        public static subEinheit createSpaceMarineTrike()
        {
            var trike = new subEinheit() { };
            trike.name = alleSubeinheitenNamen.Trike;
            trike.ausruestung = new List<alleAusruestung>() { };
            trike.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            trike.ausruestung.Add(alleAusruestung.Sprenggranaten);
            trike.ausruestung.Add(alleAusruestung.SpaceMarineBike);

            trike.waffen = new List<waffe>() { };
            trike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));

            trike.einheitentyp = Einheitstyp.Bike;

            // Setzen der Panzerungswerte:
            trike.kg = 4;
            trike.bf = 4;
            trike.st = 4;
            trike.wid = 5;
            trike.lp = 2;
            trike.ini = 4;
            trike.at = 2;
            trike.mw = 8;
            trike.rw = 3;

            return trike;
        }

        public static subEinheit createSpaceMarineBiker()
        {
            var bike = new subEinheit() { };
            bike.name = alleSubeinheitenNamen.SpaceMarineAufBike;
            bike.ausruestung = new List<alleAusruestung>() { };
            bike.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            bike.ausruestung.Add(alleAusruestung.Sprenggranaten);
            bike.ausruestung.Add(alleAusruestung.SpaceMarineBike);

            bike.waffen = new List<waffe>() { };
            bike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));

            bike.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.ServoRuestung);
            bike.einheitentyp = Einheitstyp.Bike;

            // Setzen der Panzerungswerte:
            bike.kg = 4;
            bike.bf = 4;
            bike.st = 4;
            bike.wid = 5;
            bike.lp = 1;
            bike.ini = 4;
            bike.at = 1;
            bike.mw = 8;
            bike.rw = 3;

            return bike;
        }

        public static subEinheit createSpaceMarineBikerSarge()
        {
            var sarge = createSpaceMarineBiker();
            sarge.name = alleSubeinheitenNamen.SergeantDerSpaceMarinesAufBike;
            sarge.at = 2;
            sarge.mw = 9;
            return sarge;
        }

        public static subEinheit createScoutBiker()
        {
            var scoutBiker = new subEinheit() { };
            scoutBiker.name = alleSubeinheitenNamen.ScoutAufBike;
            scoutBiker.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.Scoutruestung);
            scoutBiker.ausruestung = new List<alleAusruestung>() { };

            scoutBiker.waffen = new List<waffe>() { };
            scoutBiker.kg = 3;
            scoutBiker.bf = 3;
            scoutBiker.st = 4;
            scoutBiker.wid = 5;
            scoutBiker.lp = 1;
            scoutBiker.ini = 4;
            scoutBiker.at = 1;
            scoutBiker.mw = 8;
            scoutBiker.rw = 4;
            scoutBiker.ret = 0;

            scoutBiker.einheitentyp = Einheitstyp.Bike;

            return scoutBiker;
        }

        public static subEinheit createLandungskapsel()
        {
            var kapsel = new subEinheit() { };
            kapsel.name = alleSubeinheitenNamen.Landungskapsel;
            kapsel.ausruestung = new List<alleAusruestung>() { };
            kapsel.waffen = new List<waffe>() { };
            kapsel.einheitentyp = Einheitstyp.FahrzeugOffen;
            kapsel.bf = 4;
            kapsel.front = 12;
            kapsel.seit = 12;
            kapsel.heck = 12;
            kapsel.transportkapazitaet = 12;
            return kapsel;
        }

        public static subEinheit createLandraider()
        {
            var raider = new subEinheit() { };
            raider.name = alleSubeinheitenNamen.LandRaider;
            raider.ausruestung = new List<alleAusruestung>() { };
            raider.ausruestung.Add(alleAusruestung.Suchscheinwerfer);
            raider.ausruestung.Add(alleAusruestung.Nebelwerfer);
            raider.waffen = new List<waffe>() { };
            raider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncSchwererBolter));
            raider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncLaserKanone));
            raider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncLaserKanone));
            raider.einheitentyp = Einheitstyp.FahrzeugPanzer;
            raider.bf = 4;
            raider.front = 14;
            raider.seit = 14;
            raider.heck = 14;
            raider.transportkapazitaet = 12;
            return raider;
        }

        public static subEinheit createLandRaiderCrusader()
        {
            var raider = ultraMarineHelperClass.createLandraider();
            raider.name = alleSubeinheitenNamen.LandRaiderCrusader;
            raider.ausruestung.Add(alleAusruestung.Splittergranatwerfer);
            raider.waffen = new List<waffe>() { };
            raider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.HurricaneBolter));
            raider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.HurricaneBolter));
            raider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Syncsturmkanone));
            raider.transportkapazitaet = 16;
            return raider;
        }

        public static subEinheit createLandRaiderRedeemer()
        {
            var raider = ultraMarineHelperClass.createLandraider();
            raider.name = alleSubeinheitenNamen.LandRaiderRedeemer;
            raider.ausruestung.Add(alleAusruestung.Splittergranatwerfer);
            raider.waffen = new List<waffe>() { };
            raider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Flammensturmkanone));
            raider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Flammensturmkanone));
            raider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Syncsturmkanone));
            return raider;
        }

    }

    /// <summary>
    /// Taktischer Trupp der Space Marines!
    /// </summary>
    public class taktischerTrupp : Einheit
    {                
        /// <summary>
        /// Definieren der Auswahlen des Spielers:
        /// </summary>
        public override void declareChoices()
        {
            var auswahlen = new List<choiceDefinition>() { };

            var anzahlChoice = new zusSubeinheitenAuswahl() { };
            anzahlChoice.MinimaleAnzahl = 5;
            anzahlChoice.MaximaleAnzahl = 10;
            anzahlChoice.costPerAditionalSubUnit = 16;
            anzahlChoice.unitBaseCost = basispunkteKosten;
            anzahlChoice.auswahlIdentifier = ChoiceAuswahlIdentifier.AnzSub01;
            auswahlen.Add(anzahlChoice);


            //Tip von Tom: Wenn du hier einen Block benutzt (gewschweifte Klammer), dann 
            //kann "waffenChoice01" nicht versehentlich per copy-paste-Fehler unten nochmal benutzt werden
            {
                var waffenChoice01 = new waffenAuswahl() { };
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Flammenwerfer, kosten = 0 });
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Melter, kosten = 5 });
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmawerfer, kosten = 10 });
                waffenChoice01.labelString = "Auswahl der 1. Spezialwaffe: ";
                waffenChoice01.AuswahlOptionen[0].IstGewaehlt = true;
                auswahlen.Add(waffenChoice01);
            }

            {
                var waffenChoice02 = new waffenAuswahl() { };
                waffenChoice02.auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe02;
                waffenChoice02.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                waffenChoice02.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = 0 });
                waffenChoice02.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = 0 });
                waffenChoice02.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Raketenwerfer, kosten = 0 });
                waffenChoice02.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmakanone, kosten = 5 });
                waffenChoice02.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Laserkanone, kosten = 10 });
                waffenChoice02.labelString = "Auswahl der 2. Spezialwaffe: ";
                waffenChoice02.AuswahlOptionen[0].IstGewaehlt = true;
                auswahlen.Add(waffenChoice02);
            }

            {
                var waffenChoice03 = new waffenAuswahl() { };
                waffenChoice03.auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe03;
                waffenChoice03.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                waffenChoice03.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
                waffenChoice03.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
                waffenChoice03.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
                waffenChoice03.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
                waffenChoice03.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
                waffenChoice03.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });
                waffenChoice03.labelString = "Auswahl der 1. Waffe des Sergeants: ";
                waffenChoice03.AuswahlOptionen[0].IstGewaehlt = true;
                auswahlen.Add(waffenChoice03);
            }

            {
                var waffenChoice04 = new waffenAuswahl() { };
                waffenChoice04.auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe04;
                waffenChoice04.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
                waffenChoice04.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
                waffenChoice04.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenschwert, kosten = 0 });
                waffenChoice04.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
                waffenChoice04.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });
                waffenChoice04.labelString = "Auswahl der 2. Waffe des Sergeants: ";
                waffenChoice04.AuswahlOptionen[0].IstGewaehlt = true;
                auswahlen.Add(waffenChoice04);
            }

            {
                var ausruestungChoice01 = new ausruestungsAuswahl() { };
                ausruestungChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
                ausruestungChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.TeleportPeilsender, kosten = 15 });
                ausruestungChoice01.labelString = "Auswahl der Ausrüstung des Sergeants: ";
                auswahlen.Add(ausruestungChoice01);
            }

            /*
            {
                var transChoice01 = new transportfahrzeugWahl() { };
                transChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
                transChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Rhino, kosten = 35 });
                transChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Razorback, kosten = 40 });
                transChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });
                auswahlen.Add(transChoice01);
            }*/

            Auswahlen = auswahlen;
        }

        public override void updateChoiceDependencies()
        {
            // Die Auswahl der Spezialwaffen gibt es nur, wenn genau 10 Space Marines gewählt wurden!
            var anzahlMarines = ((zusSubeinheitenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.AnzSub01)).GewaehlteAnzahl;
            ((waffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe01)).IsActive = (anzahlMarines == 10);
            ((waffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe02)).IsActive = (anzahlMarines == 10);

            /*
            var wahlAngeschlossen = (transportfahrzeugWahl)getSpecificChoice(ChoiceAuswahlIdentifier.Trans01);
            if (anzahlMarines == 10)
            {
                wahlAngeschlossen.AuswahlOptionen.Clear();
                wahlAngeschlossen.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
                wahlAngeschlossen.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Rhino, kosten = 35 });
                wahlAngeschlossen.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Razorback, kosten = 40 });
                wahlAngeschlossen.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });
            }
            else
            {
                wahlAngeschlossen.AuswahlOptionen.Clear();
                wahlAngeschlossen.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
                wahlAngeschlossen.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Rhino, kosten = 35 });
                wahlAngeschlossen.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Razorback, kosten = 40 });
                // Die Kapsel gibt es nicht (mehr). Wenn der Spieler sie vorher selektiert hatte, setzen wir die Auswahl zurück und bleiben valide.
                if (wahlAngeschlossen.getSelectedVehicle() == alleEinheitenNamen.Landungskapsel)
                    wahlAngeschlossen.setChosenIndex(0);
            }*/
        }

        public override void evaluateChoices()
        {            
            base.evaluateChoices();

            einheitKostenGesamt = basispunkteKosten;

            int totaleEinheitenGroesse = (int)getSpecificChoiceValues(ChoiceAuswahlIdentifier.AnzSub01);
            int anzahlSpaceMarinesGesamt = totaleEinheitenGroesse - 1;

            // Update der Punktekosten:
            ChoiceExecuter.execChoice((zusSubeinheitenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.AnzSub01), this);

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlSpaceMarinesGesamt; ++i)
            {
                // Okay, legen wir die Space Marines an:
                var spaceMarine = ultraMarineHelperClass.createSpaceMarine();

                // Von 1 bis 8 nur Standard und keine weiteren Kosten!
                if (i == 7)
                {
                    // Bolter 'raus:
                    spaceMarine.waffen.Remove(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));
                    // Wahl abhandeln:
                    ChoiceExecuter.execChoice((waffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe01), this, spaceMarine);
                }
                else if (i == 8)
                {
                    // Bolter 'raus:
                    spaceMarine.waffen.Remove(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));
                    ChoiceExecuter.execChoice((waffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe02), this, spaceMarine);
                }
                subEinheiten.Add(spaceMarine);
            }

            ///
            // SARGE:
            ///

            // Außerdem gibt es ja noch den Sergeant:
            var spaceMarineSergeant = ultraMarineHelperClass.createSpaceMarineSergeant();

            spaceMarineSergeant.waffen.Remove(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            spaceMarineSergeant.waffen.Remove(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));

            // Auswahl linke Hand:
            ChoiceExecuter.execChoice((waffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe03), this, spaceMarineSergeant);

            // Auswahl rechte Hand:
            ChoiceExecuter.execChoice((waffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe04), this, spaceMarineSergeant);

            // Außerdem darf er sich noch Ausrüstung aussuchen!
            ChoiceExecuter.execChoice((ausruestungsAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Ausruest01), this, spaceMarineSergeant);

            subEinheiten.Add(spaceMarineSergeant);

            // Mat TODO:
            // Die Auswahl eines Transportfahrzeuges legen wir erst einmal auf Eis!

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }

        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.TaktischerTrupp;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 90;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Standard);
           
            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            throw new NotImplementedException();
        }
    }

    public class terminatortrupp : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Terminatortrupp;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 200;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }

        public override void declareChoices()
        {
            base.declareChoices();

            var auswahlen = new List<choiceDefinition>() { };

            var anzahlChoice = new zusSubeinheitenAuswahl() { };
            anzahlChoice.MinimaleAnzahl = 5;
            anzahlChoice.MaximaleAnzahl = 10;
            anzahlChoice.costPerAditionalSubUnit = 40;
            anzahlChoice.unitBaseCost = basispunkteKosten;
            anzahlChoice.auswahlIdentifier = ChoiceAuswahlIdentifier.AnzSub01;
            anzahlChoice.GewaehlteAnzahl = 5;
            auswahlen.Add(anzahlChoice);

            {
                var waffenChoice01 = new waffenAuswahl() { };
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 0 });
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = +5 });
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.CycloneRaketenwerfer, kosten = +30 });
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmkanone, kosten = +30 });
                waffenChoice01.auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe01;
                waffenChoice01.AuswahlOptionen[0].IstGewaehlt = true;
                waffenChoice01.labelString = "Auswahl der 1. Spezialwaffe: ";
                auswahlen.Add(waffenChoice01);
            }

            {
                var waffenChoice02 = new waffenAuswahl() { };
                waffenChoice02.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 0 });
                waffenChoice02.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = +5 });
                waffenChoice02.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.CycloneRaketenwerfer, kosten = +30 });
                waffenChoice02.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmkanone, kosten = +30 });
                waffenChoice02.labelString = "Auswahl der 2. Spezialwaffe: ";
                waffenChoice02.AuswahlOptionen[0].IstGewaehlt = true;
                waffenChoice02.auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe02;
                auswahlen.Add(waffenChoice02);
            }

            {
                var subWaffenChoice01 = new waffenProSubUnitWahl() { };
                subWaffenChoice01.defaultWep = alleWaffenNamen.Energiefaust;
                subWaffenChoice01.upgradeWep = alleWaffenNamen.Kettenfaust;
                subWaffenChoice01.costForNonUpgrade = 0;
                subWaffenChoice01.costForUpgrade = 5;
                subWaffenChoice01.labelString = "Jeder Terminator darf seine Energiefaust\n duch eine Kettenfaust ersetzen (+5 Punkte): ";
                subWaffenChoice01.auswahlIdentifier = ChoiceAuswahlIdentifier.SubWep01;
                subWaffenChoice01.MinimaleAnzahl = 0;
                subWaffenChoice01.MaximaleAnzahl = 10;
                auswahlen.Add(subWaffenChoice01);
            }

            Auswahlen = auswahlen;
        }

        public override void updateChoiceDependencies()
        {
            // Extrawaffen nur bei genau 5 und 10 Termies!
            var anzahlTermies = (int)((zusSubeinheitenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.AnzSub01)).getChoiceValues();
            ((waffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe01)).IsActive = (anzahlTermies >= 5);
            ((waffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe02)).IsActive = (anzahlTermies == 10);

            var wahlKettenfaust = ((waffenProSubUnitWahl)getSpecificChoice(ChoiceAuswahlIdentifier.SubWep01));
            wahlKettenfaust.MaximaleAnzahl = anzahlTermies-1;
        }

        public override void evaluateChoices()
        {
            base.evaluateChoices();

            einheitKostenGesamt = basispunkteKosten;

            int totaleEinheitenGroesse = (int)getSpecificChoiceValues(ChoiceAuswahlIdentifier.AnzSub01);
            int anzahlTermiesGesamt = totaleEinheitenGroesse - 1;

            // Update der Punktekosten:
            ChoiceExecuter.execChoice((zusSubeinheitenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.AnzSub01), this);

            subEinheiten = new List<subEinheit>() { };

            for (int i = 0; i < anzahlTermiesGesamt; ++i)
            {
                // Okay, legen wir die Space Marines an:
                var terminator = ultraMarineHelperClass.createTerminator();

                // Fünf Termies haben wir immer. Also auch immer eine Spezialwaffe.
                if (i == 0)
                {
                    terminator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe((alleWaffenNamen)getSpecificChoiceValues(ChoiceAuswahlIdentifier.Waffe01)));
                    einheitKostenGesamt += getSpecificChoiceCost(ChoiceAuswahlIdentifier.Waffe01);
                }

                // Ab Terminator 8 gibt es eine weitere Waffe!
                if (i == 7)
                {
                    terminator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe((alleWaffenNamen)getSpecificChoiceValues(ChoiceAuswahlIdentifier.Waffe02)));
                    einheitKostenGesamt += getSpecificChoiceCost(ChoiceAuswahlIdentifier.Waffe02);
                }

                // Auswahl der Kettenfaust oder E-Faust:
                ChoiceExecuter.execChoice((waffenProSubUnitWahl)getSpecificChoice(ChoiceAuswahlIdentifier.SubWep01), this, terminator, i);

                subEinheiten.Add(terminator);
            }


            // Sarge:
            var terminatorSergeant = ultraMarineHelperClass.createTermiantorSergeant();
            // Der Sarge hat immer den Sturmbolter und ein E-Schwert!
            terminatorSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Sturmbolter));
            terminatorSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));

            subEinheiten.Add(terminatorSergeant);
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
        }
    }

    public class terminatorSturmTrupp : Einheit
    {
        public override void declareChoices()
        {
            var auswahlen = new List<choiceDefinition>() { };

            var anzahlChoice = new zusSubeinheitenAuswahl() { };
            anzahlChoice.MinimaleAnzahl = 5;
            anzahlChoice.MaximaleAnzahl = 10;
            anzahlChoice.costPerAditionalSubUnit = 40;
            anzahlChoice.unitBaseCost = basispunkteKosten;
            anzahlChoice.auswahlIdentifier = ChoiceAuswahlIdentifier.AnzSub01;
            anzahlChoice.GewaehlteAnzahl = 5;
            auswahlen.Add(anzahlChoice);

            {
                var anzahlKlauenChoice = new zusSubeinheitenAuswahl() { };
                anzahlKlauenChoice.MinimaleAnzahl = 0;
                anzahlKlauenChoice.MaximaleAnzahl = 10;
                anzahlKlauenChoice.costPerAditionalSubUnit = 0;
                anzahlKlauenChoice.unitBaseCost = basispunkteKosten;
                anzahlKlauenChoice.auswahlIdentifier = ChoiceAuswahlIdentifier.AnzSub02;
                anzahlKlauenChoice.GewaehlteAnzahl = 0;
                anzahlKlauenChoice.labelString = "Jeder Terminator darf seine Energieklauen\ndurch E-Hammer und Sturmschild\nersetzen (0 Punkte):";
                auswahlen.Add(anzahlKlauenChoice);
            }         

            Auswahlen = auswahlen;
        }

        public override void updateChoiceDependencies()
        {
            // Wir müssen sagen, wie viele Termies ihre Klauen umwandeln dürfen:
            var anzahlTermies = (int)((zusSubeinheitenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.AnzSub01)).getChoiceValues();
            var wahlKettenfaust = ((zusSubeinheitenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.AnzSub02));
            wahlKettenfaust.MaximaleAnzahl = anzahlTermies;
        }

        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Terminatorsturmtrupp;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 200;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }


        public override void evaluateChoices()
        {
            base.evaluateChoices();

            einheitKostenGesamt = basispunkteKosten;

            int totaleEinheitenGroesse = (int)getSpecificChoiceValues(ChoiceAuswahlIdentifier.AnzSub01);
            int anzahlTermiesGesamt = totaleEinheitenGroesse - 1;

            // Update der Punktekosten:
            ChoiceExecuter.execChoice((zusSubeinheitenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.AnzSub01), this);

            subEinheiten = new List<subEinheit>() { };

            int anzahlSturmschilder = (int)((zusSubeinheitenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.AnzSub02)).getChoiceValues();
            for (int i = 0; i < anzahlTermiesGesamt; ++i)
            {
                // Okay, legen wir die Space Marines an:
                var terminator = ultraMarineHelperClass.createTerminator();

                // Für jeden Terminator, den der Spieler sich aussucht, fügen wir E-Hammer und Sturmschild hinzu:
                if (i < anzahlSturmschilder)
                {
                    terminator.ausruestung.Add(alleAusruestung.Sturmschild);
                    terminator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));
                }
                else
                {
                    terminator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                    terminator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                }             

                subEinheiten.Add(terminator);
            }

            // Sarge:
            var terminatorSergeant = ultraMarineHelperClass.createTermiantorSergeant();
            terminatorSergeant.waffen = new List<waffe>() { };
            if (anzahlSturmschilder == anzahlTermiesGesamt)
            {
                terminatorSergeant.ausruestung.Add(alleAusruestung.Sturmschild);
                terminatorSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));
            }
            else
            {
                terminatorSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                terminatorSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
            }
            subEinheiten.Add(terminatorSergeant);
        }


        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class rhino : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Rhino;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 35;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.Reparieren);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.AngeschlossenesTransportFahrzeug);

            base.createUnitBase();            
        }

        public override void declareChoices()
        {
            base.declareChoices();

            var auswahlen = new List<choiceDefinition>() { };

            {
                var ausruest01 = new ausruestungsAuswahl() { };
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Bulldozerschaufel, kosten = +5 });
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });
                ausruest01.auswahlIdentifier = ChoiceAuswahlIdentifier.Ausruest01;
                ausruest01.labelString = "Ausrüstungsauswahl: ";
                auswahlen.Add(ausruest01);
            }

            {
                var waffenChoice02 = new optWaffenAuswahl() { };
                waffenChoice02.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 10 });
                waffenChoice02.labelString = "Auswahl zusätzlicher Waffen: ";
                waffenChoice02.auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe01;
                auswahlen.Add(waffenChoice02);
            }
            Auswahlen = auswahlen;
        }

        public override void updateChoiceDependencies()
        {
        }

        public override void evaluateChoices()
        {
            base.evaluateChoices();

            einheitKostenGesamt = basispunkteKosten;

            subEinheiten = new List<subEinheit>() { };

            var rhino = ultraMarineHelperClass.createRhino();

            ChoiceExecuter.execChoice((ausruestungsAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Ausruest01), this, rhino);
            ChoiceExecuter.execChoice((optWaffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe01), this, rhino);

            subEinheiten.Add(rhino);
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class razorback : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Razorback;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 40;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.AngeschlossenesTransportFahrzeug);

            base.createUnitBase();
        }

        public override void declareChoices()
        {
            base.declareChoices();

            var auswahlen = new List<choiceDefinition>() { };

            {
                var ausruest01 = new ausruestungsAuswahl() { };
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Bulldozerschaufel, kosten = +5 });
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });
                ausruest01.auswahlIdentifier = ChoiceAuswahlIdentifier.Ausruest01;
                ausruest01.labelString = "Ausrüstungsauswahl: ";
                auswahlen.Add(ausruest01);
            }

            {
                var waffenChoice01 = new waffenAuswahl() { };
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncSchwererBolter, kosten = +0 });
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncSchwererFlammenwerfer, kosten = +25 });
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Syncsturmkanone, kosten = +35 });
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncLaserKanone, kosten = +35 });
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.LaserkanoneUndSynchroPlasma, kosten = +35 });
                waffenChoice01.labelString = "Auswahl der Hauptwaffe: ";
                waffenChoice01.auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe01;
                waffenChoice01.AuswahlOptionen[0].IstGewaehlt = true;
                auswahlen.Add(waffenChoice01);
            }
            {
                var waffenChoice02 = new optWaffenAuswahl() { };
                waffenChoice02.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });
                waffenChoice02.auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe02;
                auswahlen.Add(waffenChoice02);
            }


            Auswahlen = auswahlen;
        }

        public override void updateChoiceDependencies()
        {
        }

        public override void evaluateChoices()
        {
            base.evaluateChoices();

            einheitKostenGesamt = basispunkteKosten;

            subEinheiten = new List<subEinheit>() { };

            var razorback = ultraMarineHelperClass.createRazorback();

            ChoiceExecuter.execChoice((ausruestungsAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Ausruest01), this, razorback);
            ChoiceExecuter.execChoice((optWaffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe02), this, razorback);

            // Waffe 01 können wir nur automatisiert setzen, wenn es sich nicht um die letzte Option handelt, weil dort ZWEI
            // Waffen gesetzt werden müssen:
            var waffenChoice01 = (waffenAuswahl) getSpecificChoice(ChoiceAuswahlIdentifier.Waffe01);
            if (waffenChoice01.getSelectedWeaponName() == alleWaffenNamen.LaserkanoneUndSynchroPlasma)
            {
                einheitKostenGesamt += 35;
                razorback.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Laserkanone));
                razorback.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncPlasmawerfer));
            }
            else
                ChoiceExecuter.execChoice((waffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe01), this, razorback);

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(razorback);
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class landungskapsel : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Landungskapsel;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 35;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugOffen;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.InertialLeitsystem);
            sonderregeln.Add(Sonderregeln.Lahmgelegt);
            sonderregeln.Add(Sonderregeln.LandungskapselAngriff);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.AngeschlossenesTransportFahrzeug);

            base.createUnitBase();
        }

        public override void declareChoices()
        {
            base.declareChoices();

            var auswahlen = new List<choiceDefinition>() { };

            {
                var waffenChoice01 = new waffenAuswahl() { };
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +0 });
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.DeathwindSystem, kosten = +20 });
                waffenChoice01.labelString = "Auswahl der Bewaffnung: ";
                waffenChoice01.auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe01;
                waffenChoice01.AuswahlOptionen[0].IstGewaehlt = true;
                auswahlen.Add(waffenChoice01);
            }
            {
                var ausruest01 = new ausruestungsAuswahl() { };
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Peilsender, kosten = +10 });
                ausruest01.auswahlIdentifier = ChoiceAuswahlIdentifier.Ausruest01;
                ausruest01.labelString = "Ausrüstungsauswahl: ";
                auswahlen.Add(ausruest01);
            }

            Auswahlen = auswahlen;
        }

        public override void updateChoiceDependencies()
        {
            base.updateChoiceDependencies();
        }

        public override void evaluateChoices()
        {
            base.evaluateChoices();

            var kapsel = ultraMarineHelperClass.createLandungskapsel();
            ChoiceExecuter.execChoice((ausruestungsAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Ausruest01), this, kapsel);
            ChoiceExecuter.execChoice((waffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe01), this, kapsel);
            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(kapsel);
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {                        
            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class landRaiderCrusader : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.LandRaiderCrusader;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 250;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.MachtDesMaschinengeistes);
            sonderregeln.Add(Sonderregeln.Sturmpanzer);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        public override void declareChoices()
        {
            base.declareChoices();

            var auswahlen = new List<choiceDefinition>() { };

            {
                var waffenChoice01 = new optWaffenAuswahl() { };
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +10 });
                waffenChoice01.labelString = "Auswahl der Bewaffnung: ";
                waffenChoice01.auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe01;
                auswahlen.Add(waffenChoice01);
            }
            {
                var ausruest01 = new ausruestungsAuswahl() { };
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });
                ausruest01.auswahlIdentifier = ChoiceAuswahlIdentifier.Ausruest01;
                ausruest01.labelString = "Ausrüstungsauswahl: ";
                auswahlen.Add(ausruest01);
            }

            Auswahlen = auswahlen;
        }

        public override void updateChoiceDependencies()
        {
            base.updateChoiceDependencies();
        }

        public override void evaluateChoices()
        {
            base.evaluateChoices();
            var crusader = ultraMarineHelperClass.createLandRaiderCrusader();

            ChoiceExecuter.execChoice((ausruestungsAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Ausruest01), this, crusader);
            ChoiceExecuter.execChoice((optWaffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe01), this, crusader);

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(crusader);
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {          
            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class landRaider : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.LandRaider;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 250;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.MachtDesMaschinengeistes);
            sonderregeln.Add(Sonderregeln.Sturmpanzer);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        public override void declareChoices()
        {
            base.declareChoices();

            var auswahlen = new List<choiceDefinition>() { };

            {
                var waffenChoice01 = new optWaffenAuswahl() { };
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +10 });
                waffenChoice01.labelString = "Auswahl der Bewaffnung: ";
                waffenChoice01.auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe01;
                auswahlen.Add(waffenChoice01);
            }
            {
                var ausruest01 = new ausruestungsAuswahl() { };
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });
                ausruest01.auswahlIdentifier = ChoiceAuswahlIdentifier.Ausruest01;
                ausruest01.labelString = "Ausrüstungsauswahl: ";
                auswahlen.Add(ausruest01);
            }

            Auswahlen = auswahlen;
        }

        public override void updateChoiceDependencies()
        {
            base.updateChoiceDependencies();
        }

        public override void evaluateChoices()
        {
            base.evaluateChoices();
            var raider = ultraMarineHelperClass.createLandraider();

            ChoiceExecuter.execChoice((ausruestungsAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Ausruest01), this, raider);
            ChoiceExecuter.execChoice((optWaffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe01), this, raider);

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(raider);
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myLandRaider = new subEinheit() { };
            myLandRaider.name = alleSubeinheitenNamen.LandRaider;
            myLandRaider.ausruestung = new List<alleAusruestung>() { };
            myLandRaider.waffen = new List<waffe>() { };

            // Die folgende Ausrüstung gibt es immer:
            myLandRaider.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myLandRaider.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            // Die folgende Bewaffnung gibt es immer:
            myLandRaider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncSchwererBolter));
            myLandRaider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncLaserKanone));
            myLandRaider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncLaserKanone));



            // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
            var landRaiderZusatzwaffen = new List<pulldownAuswahl>() { };
            landRaiderZusatzwaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });
            landRaiderZusatzwaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +10 });

            AuswahlMAusN wahlLandRaiderZusatzwaffen = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Waffen dürfen gewählt werden:", landRaiderZusatzwaffen);
            if (!wahlLandRaiderZusatzwaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlLandRaiderZusatzwaffen.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myLandRaider.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(landRaiderZusatzwaffen[i].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + landRaiderZusatzwaffen[i].kosten * 1;
            }


            var landRaiderAusruestung = new List<pulldownAuswahl>() { };
            landRaiderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
            landRaiderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });

            AuswahlMAusN wahlLandRaiderAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", landRaiderAusruestung);
            if (!wahlLandRaiderAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlLandRaiderAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myLandRaider.ausruestung.Add((alleAusruestung)landRaiderAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + landRaiderAusruestung[i].kosten * 1;
            }

            myLandRaider.einheitentyp = Einheitstyp.FahrzeugPanzer;

            // Setzen der Panzerungswerte:
            myLandRaider.bf = 4;
            myLandRaider.front = 14;
            myLandRaider.seit = 14;
            myLandRaider.heck = 14;
            myLandRaider.transportkapazitaet = 12;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myLandRaider);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class landRaiderRedeemer : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.LandRaiderRedeemer;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 240;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.MachtDesMaschinengeistes);
            sonderregeln.Add(Sonderregeln.Sturmpanzer);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        public override void declareChoices()
        {
            base.declareChoices();

            var auswahlen = new List<choiceDefinition>() { };

            {
                var waffenChoice01 = new optWaffenAuswahl() { };
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +10 });
                waffenChoice01.labelString = "Auswahl der Bewaffnung: ";
                waffenChoice01.auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe01;
                auswahlen.Add(waffenChoice01);
            }
            {
                var ausruest01 = new ausruestungsAuswahl() { };
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });
                ausruest01.auswahlIdentifier = ChoiceAuswahlIdentifier.Ausruest01;
                ausruest01.labelString = "Ausrüstungsauswahl: ";
                auswahlen.Add(ausruest01);
            }

            Auswahlen = auswahlen;
        }

        public override void updateChoiceDependencies()
        {
            base.updateChoiceDependencies();
        }

        public override void evaluateChoices()
        {
            base.evaluateChoices();
            var redeemer = ultraMarineHelperClass.createLandRaiderRedeemer();

            ChoiceExecuter.execChoice((ausruestungsAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Ausruest01), this, redeemer);
            ChoiceExecuter.execChoice((optWaffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe01), this, redeemer);

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(redeemer);
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {          
            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class whirlwind : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Whirlwind;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 85;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        public override void declareChoices()
        {
            base.declareChoices();

            var auswahlen = new List<choiceDefinition>() { };

            {
                var waffenChoice01 = new optWaffenAuswahl() { };
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });
                waffenChoice01.labelString = "Auswahl der Bewaffnung: ";
                waffenChoice01.auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe01;
                auswahlen.Add(waffenChoice01);
            }
            {
                var ausruest01 = new ausruestungsAuswahl() { };
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Bulldozerschaufel, kosten = +5 });
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });
                ausruest01.auswahlIdentifier = ChoiceAuswahlIdentifier.Ausruest01;
                ausruest01.labelString = "Ausrüstungsauswahl: ";
                auswahlen.Add(ausruest01);
            }

            Auswahlen = auswahlen;
        }

        public override void updateChoiceDependencies()
        {
            base.updateChoiceDependencies();
        }

        public override void evaluateChoices()
        {
            base.evaluateChoices();

            var myWhirlwind = new subEinheit() { };
            myWhirlwind.name = alleSubeinheitenNamen.Whirlwind;
            myWhirlwind.ausruestung = new List<alleAusruestung>() { };
            myWhirlwind.waffen = new List<waffe>() { };

            // Die folgende Ausrüstung gibt es immer:
            myWhirlwind.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myWhirlwind.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            // Die folgende Bewaffnung gibt es immer:
            myWhirlwind.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.WhirlwindMehrfachRaketenWerfer));

            ChoiceExecuter.execChoice((ausruestungsAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Ausruest01), this, myWhirlwind);
            ChoiceExecuter.execChoice((optWaffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe01), this, myWhirlwind);

            myWhirlwind.einheitentyp = Einheitstyp.FahrzeugPanzer;

            // Setzen der Panzerungswerte:
            myWhirlwind.bf = 4;
            myWhirlwind.front = 11;
            myWhirlwind.seit = 11;
            myWhirlwind.heck = 10;
            myWhirlwind.transportkapazitaet = 0;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myWhirlwind);
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class vindicator : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Vindicator;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 115;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        public override void declareChoices()
        {
            base.declareChoices();

            var auswahlen = new List<choiceDefinition>() { };

            {
                var waffenChoice01 = new optWaffenAuswahl() { };
                waffenChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });
                waffenChoice01.labelString = "Auswahl der Bewaffnung: ";
                waffenChoice01.auswahlIdentifier = ChoiceAuswahlIdentifier.Waffe01;
                auswahlen.Add(waffenChoice01);
            }
            {
                var ausruest01 = new ausruestungsAuswahl() { };
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Bulldozerschaufel, kosten = +5 });
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Belagerungsschild, kosten = +10 });
                ausruest01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });
                ausruest01.auswahlIdentifier = ChoiceAuswahlIdentifier.Ausruest01;
                ausruest01.labelString = "Ausrüstungsauswahl: ";
                auswahlen.Add(ausruest01);
            }

            Auswahlen = auswahlen;
        }

        public override void updateChoiceDependencies()
        {
            base.updateChoiceDependencies();
        }

        public override void evaluateChoices()
        {
            base.evaluateChoices();

            var myVindi = new subEinheit() { };
            myVindi.name = alleSubeinheitenNamen.Vindicator;
            myVindi.ausruestung = new List<alleAusruestung>() { };
            myVindi.waffen = new List<waffe>() { };

            // Die folgende Ausrüstung gibt es immer:
            myVindi.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myVindi.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            // Die folgende Bewaffnung gibt es immer:
            myVindi.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.DemolisherGeschuetz));
            myVindi.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Sturmbolter));

            ChoiceExecuter.execChoice((ausruestungsAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Ausruest01), this, myVindi);
            ChoiceExecuter.execChoice((optWaffenAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Waffe01), this, myVindi);

            myVindi.einheitentyp = Einheitstyp.FahrzeugPanzer;

            // Setzen der Panzerungswerte:
            myVindi.bf = 4;
            myVindi.front = 13;
            myVindi.seit = 11;
            myVindi.heck = 10;
            myVindi.transportkapazitaet = 0;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myVindi);
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class sargeChronus : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.SergeantChronus;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 70;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.Panzerkommandant);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.keine);

            base.createUnitBase();
        }

        public override void declareChoices()
        {
            base.declareChoices();

            var auswahlen = new List<choiceDefinition>() { };

            Auswahlen = auswahlen;
        }

        public override void updateChoiceDependencies()
        {
            base.updateChoiceDependencies();
        }

        public override void evaluateChoices()
        {
            base.evaluateChoices();
            einheitKostenGesamt = basispunkteKosten;

            var sarge = new subEinheit() { };
            sarge.name = alleSubeinheitenNamen.SergeantChronus;
            sarge.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.ServoRuestung);
            sarge.ausruestung = new List<alleAusruestung>() { };
            sarge.ausruestung.Add(alleAusruestung.Servoarm);
            sarge.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            sarge.ausruestung.Add(alleAusruestung.Sprenggranaten);
            sarge.waffen = new List<waffe>() { };
            sarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));

            sarge.kg = 4;
            sarge.bf = 5;
            sarge.st = 4;
            sarge.wid = 4;
            sarge.ini = 4;
            sarge.lp = 1;
            sarge.at = 2;
            sarge.mw = 9;
            sarge.rw = 3;
            sarge.ret = 0;

            sarge.einheitentyp = Einheitstyp.Infanterie;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(sarge);
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {                     
            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class sargeTellion : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.SergeantTellion;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 50;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.Infiltratoren);
            sonderregeln.Add(Sonderregeln.DurchDeckungBewegen);
            sonderregeln.Add(Sonderregeln.Scouts);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.keine);

            base.createUnitBase();
        }

        public override void declareChoices()
        {
            base.declareChoices();

            var auswahlen = new List<choiceDefinition>() { };

            Auswahlen = auswahlen;
        }

        public override void updateChoiceDependencies()
        {
            base.updateChoiceDependencies();
        }

        public override void evaluateChoices()
        {
            base.evaluateChoices();

            var sarge = new subEinheit() { };
            sarge.name = alleSubeinheitenNamen.SergeantTelion;
            sarge.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.Scoutruestung);
            sarge.ausruestung = new List<alleAusruestung>() { };
            sarge.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            sarge.ausruestung.Add(alleAusruestung.Sprenggranaten);
            sarge.waffen = new List<waffe>() { };
            sarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            sarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.StalkerSchemaBolter));

            sarge.kg = 5;
            sarge.bf = 6;
            sarge.st = 4;
            sarge.wid = 4;
            sarge.ini = 4;
            sarge.lp = 1;
            sarge.at = 2;
            sarge.mw = 9;
            sarge.rw = 4;
            sarge.ret = 0;

            sarge.einheitentyp = Einheitstyp.Infanterie;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(sarge);
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class marneusCalgar : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.MarneusCalgar;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 250;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.TitanischeMacht);
            sonderregeln.Add(Sonderregeln.Kriegsgott);
            sonderregeln.Add(Sonderregeln.OrbitalesBombardement);
            sonderregeln.Add(Sonderregeln.EwigerKrieger);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        public override void declareChoices()
        {
            base.declareChoices();

            var auswahlen = new List<choiceDefinition>() { };

            {
                var ruestChoice01 = new ruestungsAuswahl() { };
                ruestChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleRuestungen.ServoRuestung, kosten = 0 });
                ruestChoice01.AuswahlOptionen.Add(new pulldownAuswahl() { auswahl = alleRuestungen.RuestungDesAntilochus, kosten = +15 });
                ruestChoice01.labelString = "Auswahl der Rüstung: ";
                ruestChoice01.auswahlIdentifier = ChoiceAuswahlIdentifier.Ruest01;
                ruestChoice01.AuswahlOptionen[0].IstGewaehlt = true;
                auswahlen.Add(ruestChoice01);
            }

            Auswahlen = auswahlen;
        }

        public override void updateChoiceDependencies()
        {
            base.updateChoiceDependencies();
        }

        public override void evaluateChoices()
        {
            base.evaluateChoices();

            var calgar = new subEinheit() { };
            calgar.name = alleSubeinheitenNamen.MarneusCalgar;
            calgar.ausruestung = new List<alleAusruestung>() { };
            calgar.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            calgar.ausruestung.Add(alleAusruestung.Sprenggranaten);
            calgar.ausruestung.Add(alleAusruestung.StaehlernerStern);

            calgar.waffen = new List<waffe>() { };
            calgar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));
            calgar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.FaeusteVonUltramar));

            ChoiceExecuter.execChoice((ruestungsAuswahl)getSpecificChoice(ChoiceAuswahlIdentifier.Ruest01), this, calgar);

            calgar.kg = 6;
            calgar.bf = 5;
            calgar.st = 4;
            calgar.wid = 4;
            calgar.lp = 4;
            calgar.ini = 5;
            calgar.at = 4;
            calgar.mw = 10;
            calgar.rw = 3;
            calgar.ret = 4;
            calgar.einheitentyp = Einheitstyp.Infanterie;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(calgar);
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }


    public class capSicarius : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.CaptainCatoSicarius;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 200;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.RitenDerSchlacht);
            sonderregeln.Add(Sonderregeln.Ueberraschungsangriff);
            sonderregeln.Add(Sonderregeln.KampfgestaehlteHelden);
            sonderregeln.Add(Sonderregeln.VerletzungenIgnorieren);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var cap = new subEinheit() { };
            cap.name = alleSubeinheitenNamen.CaptainCatoSicarius;
            cap.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.MeisterhafteRuestung);
            cap.ausruestung = new List<alleAusruestung>() { };
            cap.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            cap.ausruestung.Add(alleAusruestung.Sprenggranaten);
            cap.ausruestung.Add(alleAusruestung.StaehlernerStern);
            cap.waffen = new List<waffe>() { };
            cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.TalassarianischeSturmklinge));
            cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Plasmapistole));

            cap.kg = 6;
            cap.bf = 5;
            cap.st = 4;
            cap.wid = 4;
            cap.ini = 5;
            cap.lp = 3;
            cap.at = 3;
            cap.mw = 10;
            cap.rw = 2;
            cap.ret = 4;

            cap.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(cap);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class varroTigurius : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.VarroTigurius;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 230;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.Meisterpsioniker);
            sonderregeln.Add(Sonderregeln.GabeDerVorhersehung);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var tigurius = new subEinheit() { };
            tigurius.name = alleSubeinheitenNamen.VarroTigurius;
            tigurius.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.ServoRuestung);
            tigurius.ausruestung = new List<alleAusruestung>() { };
            tigurius.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            tigurius.ausruestung.Add(alleAusruestung.Sprenggranaten);
            tigurius.ausruestung.Add(alleAusruestung.Hoellenfeuermatrix);
            tigurius.waffen = new List<waffe>() { };
            tigurius.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.StabDesTigurius));
            tigurius.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));

            tigurius.psikraefte = new List<Psikraefte>() { };
            tigurius.psikraefte.Add(Psikraefte.Schmetterschlag);
            tigurius.psikraefte.Add(Psikraefte.Psischild);
            tigurius.psikraefte.Add(Psikraefte.AvatarDerSuehne);
            tigurius.psikraefte.Add(Psikraefte.MachtDerAlten);
            tigurius.psikraefte.Add(Psikraefte.Nullzone);
            tigurius.psikraefte.Add(Psikraefte.TorZurUnendlichkeit);
            tigurius.psikraefte.Add(Psikraefte.VortexDerVerdammnis);
            tigurius.psikraefte.Add(Psikraefte.Beschleunigung);
            tigurius.psikraefte.Add(Psikraefte.Maschinenfluch);

            tigurius.kg = 5;
            tigurius.bf = 4;
            tigurius.st = 4;
            tigurius.wid = 4;
            tigurius.ini = 4;
            tigurius.lp = 2;
            tigurius.at = 2;
            tigurius.mw = 10;
            tigurius.rw = 3;
            tigurius.ret = 0;

            tigurius.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(tigurius);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class cassius : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.OrtanCassius;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 125;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieEhreDesOrdens);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.LiturgienDerSchlacht);
            sonderregeln.Add(Sonderregeln.VerletzungenIgnorieren);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var cassius = new subEinheit() { };
            cassius.name = alleSubeinheitenNamen.OrtanCassius;
            cassius.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.ServoRuestung);
            cassius.ausruestung = new List<alleAusruestung>() { };
            cassius.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            cassius.ausruestung.Add(alleAusruestung.Sprenggranaten);
            cassius.ausruestung.Add(alleAusruestung.Rosarius);
            cassius.waffen = new List<waffe>() { };
            cassius.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Crozius));
            cassius.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            cassius.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Infernus));

            cassius.kg = 5;
            cassius.bf = 4;
            cassius.st = 4;
            cassius.wid = 6;
            cassius.ini = 4;
            cassius.lp = 2;
            cassius.at = 2;
            cassius.mw = 10;
            cassius.rw = 3;
            cassius.ret = 4;

            cassius.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(cassius);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class kantor : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.PedroKantor;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 175;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.OrbitalesBombardement);
            sonderregeln.Add(Sonderregeln.InspirierendeGegenwart);
            sonderregeln.Add(Sonderregeln.Ordenstaktik);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var cassius = new subEinheit() { };
            cassius.name = alleSubeinheitenNamen.PedroKantor;
            cassius.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.ServoRuestung);
            cassius.ausruestung = new List<alleAusruestung>() { };
            cassius.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            cassius.ausruestung.Add(alleAusruestung.Sprenggranaten);
            cassius.ausruestung.Add(alleAusruestung.StaehlernerStern);
            cassius.waffen = new List<waffe>() { };
            cassius.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.DornsPfeil));

            cassius.kg = 6;
            cassius.bf = 5;
            cassius.st = 4;
            cassius.wid = 4;
            cassius.ini = 5;
            cassius.lp = 3;
            cassius.at = 3;
            cassius.mw = 10;
            cassius.rw = 3;
            cassius.ret = 4;

            cassius.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(cassius);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class lysander : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.CaptainLysander;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 200;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.BolterDrill);
            sonderregeln.Add(Sonderregeln.EwigerKrieger);
            sonderregeln.Add(Sonderregeln.Ordenstaktik);
            sonderregeln.Add(Sonderregeln.Befestigen);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var lys = new subEinheit() { };
            lys.name = alleSubeinheitenNamen.CaptainLysander;
            lys.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.TerminatorRuestung);
            lys.ausruestung = new List<alleAusruestung>() { };
            lys.waffen = new List<waffe>() { };
            lys.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.DornsFaust));

            lys.kg = 6;
            lys.bf = 5;
            lys.st = 4;
            lys.wid = 4;
            lys.ini = 5;
            lys.lp = 4;
            lys.at = 3;
            lys.mw = 10;
            lys.rw = 2;
            lys.ret = 5;

            lys.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(lys);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class shrike : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.CaptainShrike;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 195;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Sprungtruppen;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.SehenAberNichtGesehen);
            sonderregeln.Add(Sonderregeln.Ordenstaktik);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var shrike = new subEinheit() { };
            shrike.name = alleSubeinheitenNamen.CaptainShrike;
            shrike.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.ServoRuestung);
            shrike.ausruestung = new List<alleAusruestung>() { };
            shrike.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            shrike.ausruestung.Add(alleAusruestung.Sprenggranaten);
            shrike.ausruestung.Add(alleAusruestung.Sprungmodul);
            shrike.ausruestung.Add(alleAusruestung.StaehlernerStern);
            shrike.waffen = new List<waffe>() { };
            shrike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            shrike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Rabenklauen));

            shrike.kg = 6;
            shrike.bf = 5;
            shrike.st = 4;
            shrike.wid = 4;
            shrike.ini = 5;
            shrike.lp = 3;
            shrike.at = 3;
            shrike.mw = 10;
            shrike.rw = 3;
            shrike.ret = 4;

            shrike.einheitentyp = Einheitstyp.Sprungtruppen;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(shrike);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class vukan : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.VulkanHestan;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 190;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.Ordenstaktik);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var vulkan = new subEinheit() { };
            vulkan.name = alleSubeinheitenNamen.VulkanHestan;
            vulkan.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.MeisterhafteRuestung);

            vulkan.ausruestung = new List<alleAusruestung>() { };
            vulkan.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            vulkan.ausruestung.Add(alleAusruestung.Sprenggranaten);
            vulkan.ausruestung.Add(alleAusruestung.KesaresMantel);
            vulkan.ausruestung.Add(alleAusruestung.Digitalwaffen);

            vulkan.waffen = new List<waffe>() { };
            vulkan.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            vulkan.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SpeerDesVulkan));
            vulkan.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Schmiedefeuerhandschuh));

            vulkan.kg = 6;
            vulkan.bf = 5;
            vulkan.st = 4;
            vulkan.wid = 4;
            vulkan.lp = 3;
            vulkan.ini = 5;
            vulkan.at = 3;
            vulkan.mw = 10;
            vulkan.rw = 2;
            vulkan.ret = 0;

            vulkan.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(vulkan);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class khan : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.KorsarroKhan;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 160;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = true;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.MeisterDerJagd);
            sonderregeln.Add(Sonderregeln.Ordenstaktik);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var khan = new subEinheit() { };
            khan.name = alleSubeinheitenNamen.KorsarroKhan;
            khan.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.ServoRuestung);

            khan.ausruestung = new List<alleAusruestung>() { };
            khan.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            khan.ausruestung.Add(alleAusruestung.Sprenggranaten);
            khan.ausruestung.Add(alleAusruestung.StaehlernerStern);


            var listeSubeinheit = new List<pulldownAuswahl>(){};
            listeSubeinheit.Add(new pulldownAuswahl(){auswahl = alleSubeinheitenNamen.SpaceMarineBike, kosten = +45});
            AuswahlMAusN wahlAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", listeSubeinheit);
            if (!wahlAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            // Ggfs. müssen wir noch ein Bike dazu nehmen!
            var wahlVektor = wahlAusruestung.wahlIndexVektor;
            if (wahlVektor.Count != 0)
            {
                khan.ausruestung.Add(alleAusruestung.SpaceMarineBike);
                khan.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                einheitKostenGesamt = einheitKostenGesamt + listeSubeinheit[0].kosten;

                khan.wid = 5;
                khan.einheitentyp = Einheitstyp.Bike;
            }
            else
            {
                khan.einheitentyp = Einheitstyp.Infanterie;
                khan.wid = 4;
            }

            khan.waffen = new List<waffe>() { };
            khan.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
            khan.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Mondfang));

            khan.kg = 6;
            khan.bf = 5;
            khan.st = 4;
            khan.lp = 3;
            khan.ini = 5;
            khan.at = 3;
            khan.mw = 10;
            khan.rw = 3;
            khan.ret = 4;

           
            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(khan);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class salvenkanone : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Salvenkanone;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 100;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Artillerie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.SegenDesOmnissiah);
            sonderregeln.Add(Sonderregeln.Befestigen);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };


            var techmarine = new subEinheit() { };
            techmarine.name = alleSubeinheitenNamen.Techmarine;
            techmarine.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.MeisterhafteRuestung);
            techmarine.ausruestung = new List<alleAusruestung>();
            techmarine.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            techmarine.ausruestung.Add(alleAusruestung.Sprenggranaten);
            techmarine.ausruestung.Add(alleAusruestung.Servoharnisch);
            techmarine.waffen = new List<waffe>() { };
            techmarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));

            techmarine.kg = 4;
            techmarine.bf = 4;
            techmarine.st = 4;
            techmarine.wid = 4;            
            techmarine.lp = 1;
            techmarine.ini = 4;
            techmarine.at = 1;
            techmarine.mw = 8;
            techmarine.rw = 2;
            techmarine.ret = 0;
            techmarine.einheitentyp = Einheitstyp.Infanterie;


            subEinheiten.Add(techmarine);

            // Jetzt die eigentliche Salvenkanone: Für sie setzen wir die Werte gleich null.
            var savle = new subEinheit() { };
            savle.name = alleSubeinheitenNamen.Salvenkanone;
            savle.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.keine);
            savle.ausruestung = new List<alleAusruestung>();
            savle.waffen = new List<waffe>() { };

            savle.kg = 0;
            savle.bf = 0;
            savle.st = 0;
            savle.wid = 0;
            savle.lp = 0;
            savle.ini = 0;
            savle.at = 0;
            savle.mw = 0;
            savle.rw = 0;
            savle.ret = 0;
            savle.einheitentyp = Einheitstyp.Artillerie;
            subEinheiten.Add(savle);



            // Wahl angeschlossenes Transportfahrzeug
            // => muss mit generiert werden!
            // Also müssen wir zunächst den Spieler fragen, ob er überhaupt ein Transportfahrzeug möchte!
            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0:
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                    break;
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class devastortrupp : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Devastortrupp;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 90;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            int punkteKostenProSpaceMarine = 16;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 5, 10, "Trupp darf bis zu fünf zusätzliche Space Marines erhalten", gesamtArmeePunkteKosten, punkteKostenProSpaceMarine) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheSpaceMariens = auswahlAnzahl.anzahlGewaehlt;
            int anzahlSpaceMarinesGesamt = 4 + zusaetlicheSpaceMariens;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheSpaceMariens * punkteKostenProSpaceMarine;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };


            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlSpaceMarinesGesamt; ++i)
            {
                // Okay, legen wir die Space Marines an:
                var spaceMarine = ultraMarineHelperClass.createSpaceMarine();
                
                // Das Gleiche gilt für die Boltpistole!
                spaceMarine.waffen = new List<waffe>() { };
                spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));

                // Die Marines 1 bis 4 dürfen Extra-Waffen erhalten!
                if (i < 4)
                {
                    // Jetzt darf ich auch andere Auswahlen durchühren:
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = 15 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = 15 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Raketenwerfer, kosten = 15 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmakanone, kosten = 25 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Laserkanone, kosten = 35 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Space Marine darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else
                {
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));
                }             

                subEinheiten.Add(spaceMarine);
            }

            ///
            // SARGE:
            ///
            var spaceMarineSergeant = ultraMarineHelperClass.createSpaceMarineSergeant();
           
            spaceMarineSergeant.ausruestung.Add(alleAusruestung.Signum);
            spaceMarineSergeant.waffen = new List<waffe>() { };

            // Erst einmal lassen wir den Spieler die Wahl für die erste Hand treffen:
            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            Auswahl1AusN auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen treffen:", auswahlSargePulldown);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlSarge.gewaehlterIndexAusN;
            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown[wahlIndex].kosten * 1;


            // Wenn er bereits eine Boltpistole hat, kann er sie nicht noch einmal nehmen, sonst schon!
            var auswahlSargePulldown2 = new List<pulldownAuswahl>() { };
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenschwert, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen für die Zweithand treffen:", auswahlSargePulldown2);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlSarge.gewaehlterIndexAusN;

            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown2[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown2[wahlIndex].kosten * 1;

            // Außerdem darf er sich noch Ausrüstung aussuchen!
            var pulldownSargeAusruestung = new List<pulldownAuswahl>() { };
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });

            AuswahlMAusN wahlSargeAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant darf folgende Optionen wählen:", pulldownSargeAusruestung);
            if (!wahlSargeAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlSargeAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                spaceMarineSergeant.ausruestung.Add((alleAusruestung)pulldownSargeAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + pulldownSargeAusruestung[i].kosten * 1;
            }

            subEinheiten.Add(spaceMarineSergeant);

            // Wahl angeschlossenes Transportfahrzeug
            // => muss mit generiert werden!
            // Also müssen wir zunächst den Spieler fragen, ob er überhaupt ein Transportfahrzeug möchte!
            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Rhino, kosten = 35 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Razorback, kosten = 40 });
            if (anzahlSpaceMarinesGesamt == 9)
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0:
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Rhino.ToString());
                    break;
                case 2:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Razorback.ToString());
                    break;
                case 3:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                    break;
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class landSpeederStorm : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.LandspeederStorm;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 50;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugSAO;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.Schocktruppen);
            sonderregeln.Add(Sonderregeln.Scouts);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Sturm);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var storm = new subEinheit() { };
            storm.name = alleSubeinheitenNamen.LandspeederStorm;
            storm.ausruestung = new List<alleAusruestung>() { };
            storm.waffen = new List<waffe>() { };

            // Die folgende Ausrüstung gibt es immer:
            storm.ausruestung.Add(alleAusruestung.Stoersender);

            // Die folgende Bewaffnung gibt es immer:
            storm.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.CerberusWerfer));


            // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
            var crusaderZusatzWaffen = new List<pulldownAuswahl>() { };
            crusaderZusatzWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = +0 });
            crusaderZusatzWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = +10 });
            crusaderZusatzWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +15 });
            crusaderZusatzWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmkanone, kosten = +35 });

            Auswahl1AusN wahlCrusaderZusatzwaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", crusaderZusatzWaffen);
            if (!wahlCrusaderZusatzwaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var myIndex = wahlCrusaderZusatzwaffen.gewaehlterIndexAusN;
            storm.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(crusaderZusatzWaffen[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + crusaderZusatzWaffen[myIndex].kosten * 1;


            storm.einheitentyp = Einheitstyp.FahrzeugSAO;

            // Setzen der Panzerungswerte:
            storm.bf = 3;
            storm.front = 10;
            storm.seit = 10;
            storm.heck = 10;
            storm.transportkapazitaet = 5;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(storm);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class scoutbikerschwadron : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Scoutbikeschwadron;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 70;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Bike;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.Infiltratoren);
            sonderregeln.Add(Sonderregeln.Scouts);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Sturm);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            int punkteKostenProSpaceMarine = 20;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 3, 10, "Trupp darf bis zu sieben zusätzliche Scouts erhalten", gesamtArmeePunkteKosten, punkteKostenProSpaceMarine) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheScouts = auswahlAnzahl.anzahlGewaehlt;
            int anzahlScoutsGesamt = 3 + zusaetlicheScouts;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheScouts * punkteKostenProSpaceMarine;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };


            // Soll es Splitterminen geben?
            var scoutExtras = new List<pulldownAuswahl>() { };
            scoutExtras.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Splitterminen, kosten = 10 });
            AuswahlMAusN wahlExtraAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die Scouts dürfen folgende Optionen wählen:", scoutExtras);
            if (!wahlExtraAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlExtraAusruestung.wahlIndexVektor;
            bool hatSplitterminen = false;
            foreach (int i in wahlVektor)
            {
                hatSplitterminen = true;
                einheitKostenGesamt = einheitKostenGesamt + scoutExtras[i].kosten * 1;
            }

            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlScoutsGesamt; ++i)
            {
                var scoutBike = ultraMarineHelperClass.createScoutBiker();              
                if (hatSplitterminen)
                    scoutBike.ausruestung.Add(alleAusruestung.Splitterminen);            

                if (i < 3)
                {
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncBolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.AstartesGranatwerfer, kosten = 10 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    scoutBike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else
                {
                    scoutBike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                }
 
                subEinheiten.Add(scoutBike);
            }

            ///
            // SARGE:
            ///

            var scoutSarge = ultraMarineHelperClass.createSpaceMarineBikerSarge();
            scoutSarge.name = alleSubeinheitenNamen.ScoutsergeantAufBike;
        
            if (hatSplitterminen)
                scoutSarge.ausruestung.Add(alleAusruestung.Splitterminen);

            scoutSarge.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.Scoutruestung);  

            // Erst einmal lassen wir den Spieler die Wahl für die erste Hand treffen:
            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            Auswahl1AusN auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scout Sergeant muss eine der folgenden Auswahlen treffen:", auswahlSargePulldown);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlSarge.gewaehlterIndexAusN;
            scoutSarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown[wahlIndex].kosten * 1;


            // Außerdem darf er sich noch Ausrüstung aussuchen!
            var sargeExtras = new List<pulldownAuswahl>() { };
            sargeExtras.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            sargeExtras.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Peilsender, kosten = 25 });

            AuswahlMAusN wahlSargeAus = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scout Sergeant darf folgende Optionen wählen:", sargeExtras);
            if (!wahlSargeAus.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlSargeAus.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                scoutSarge.ausruestung.Add((alleAusruestung)sargeExtras[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + sargeExtras[i].kosten * 1;
            }

            subEinheiten.Add(scoutSarge);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class sturmTrupp : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Sturmtrupp;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 100;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Sprungtruppen;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Sturm);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            int punkteKostenProSpaceMarine = 18;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 5, 10, "Trupp darf bis zu fünf zusätzliche Space Marines erhalten", gesamtArmeePunkteKosten, punkteKostenProSpaceMarine) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheSpaceMariens = auswahlAnzahl.anzahlGewaehlt;
            int anzahlSpaceMarinesGesamt = 4 + zusaetlicheSpaceMariens;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheSpaceMariens * punkteKostenProSpaceMarine;



            // Wir dürfen auf die Sprungmodule verzichten und stattdessen einen KOSTENLOSEN Rhino oder
            // eine KOSTENLOSE Landungskapsel bekommen. Spezialfall!
            var verzichtAuswahl = new List<pulldownAuswahl>() { };
            verzichtAuswahl.Add(new pulldownAuswahl() { auswahl = "Sprungmodule behalten", kosten = 0 });
            verzichtAuswahl.Add(new pulldownAuswahl() { auswahl = "Keine Module, aber kostenloses Transportfahrzeug", kosten = 0 });

            Auswahl1AusN auswahlModule = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen treffen:", verzichtAuswahl);
            if (!auswahlModule.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            bool hatSprungmodule = true;
            var gewaehlterIndex = auswahlModule.gewaehlterIndexAusN;
            if (gewaehlterIndex == 0)
                hatSprungmodule = true;
            else
                hatSprungmodule = false;


            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };


            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlSpaceMarinesGesamt; ++i)
            {
                // Okay, legen wir die Space Marines an:
                var spaceMarine = ultraMarineHelperClass.createSpaceMarine();
                
                // Jeder Space Marine hat Fragment- und Sprenggranaten (keine Extra-Kosten):
                if(hatSprungmodule)
                    spaceMarine.ausruestung.Add(alleAusruestung.Sprungmodul);

                // Das Gleiche gilt für die Boltpistole!
                spaceMarine.waffen = new List<waffe>() { };


                // Space Marine 5 und 10 dürfen folgende Option haben!
                if (i == 3 || i == 8)
                {
                    // Jetzt darf ich auch andere Auswahlen durchühren:
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Flammenwerfer, kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Space Marine darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else
                {
                    spaceMarine.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                }

                if(hatSprungmodule)
                    spaceMarine.einheitentyp = Einheitstyp.Sprungtruppen;
                else
                    spaceMarine.einheitentyp = Einheitstyp.Infanterie;

 
                subEinheiten.Add(spaceMarine);
            }

            ///
            // SARGE:
            ///

            // Außerdem gibt es ja noch den Sergeant:
            // Erstellen wir ihn:
            var spaceMarineSergeant = ultraMarineHelperClass.createSpaceMarineSergeant();
            
            if(hatSprungmodule)
                spaceMarineSergeant.ausruestung.Add(alleAusruestung.Sprungmodul);

            spaceMarineSergeant.waffen = new List<waffe>() { };

            // Erst einmal lassen wir den Spieler die Wahl für die erste Hand treffen:
            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Kettenschwert", kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Plasmapistole und Kettenschwert", kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energieschwert", kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energieklaue", kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energiefaust", kosten = 25 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energiehammer", kosten = 30 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Zwei Energieschwerter", kosten = 30 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Zwei Energieklauen", kosten = 30 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Zwei Energiefäuste", kosten = 50 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = "Zwei Energiehämmer", kosten = 60 });

            Auswahl1AusN auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen treffen:", auswahlSargePulldown);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlSarge.gewaehlterIndexAusN;
            switch (wahlIndex)
            {
                case 0:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Kettenschwert));
                    break;
                case 1:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Plasmapistole));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Kettenschwert));
                    break;
                case 2:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));
                    break;
                case 3:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                    break;
                case 4:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiefaust));
                    break;
                case 5:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));                    
                    break;
                case 6:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));
                    break;
                case 7:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                    break;
                case 8:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiefaust));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiefaust));
                    break;
                case 9:
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));
                    spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));
                    break;
                default:
                    throw new ArgumentException("Wieder mal nicht aufgepasst! Sturmtrupp Sarge! ;-)");
            }          
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown[wahlIndex].kosten * 1;

            // Außerdem darf er sich noch Ausrüstung aussuchen!
            var pulldownSargeAusruestung = new List<pulldownAuswahl>() { };
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Parierschield, kosten = 5 });


            AuswahlMAusN wahlSargeAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant darf folgende Optionen wählen:", pulldownSargeAusruestung);
            if (!wahlSargeAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            bool hatParierschild = false;
            var wahlVektor = wahlSargeAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                if (i == 1)
                    hatParierschild = true;
                spaceMarineSergeant.ausruestung.Add((alleAusruestung)pulldownSargeAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + pulldownSargeAusruestung[i].kosten * 1;
            }

            if(hatParierschild)
                spaceMarineSergeant.ret = 5;


            if (hatSprungmodule)
                spaceMarineSergeant.einheitentyp = Einheitstyp.Sprungtruppen;
            else
                spaceMarineSergeant.einheitentyp = Einheitstyp.Infanterie;

            subEinheiten.Add(spaceMarineSergeant);

            // Wahl angeschlossenes Transportfahrzeug
            // => muss mit generiert werden!
            // Also müssen wir zunächst den Spieler fragen, ob er überhaupt ein Transportfahrzeug möchte!
            // Das geht aber nur, wenn wir uns GEGEN Sprungmodule entschieden haben!
            if (!hatSprungmodule)
            {
                var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Rhino, kosten = 0 });
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 0 });

                Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
                if (!auswahlScreen.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                wahlIndex = auswahlScreen.gewaehlterIndexAusN;

                // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
                switch (wahlIndex)
                {
                    case 0:
                        break;
                    case 1:
                        angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.RhinoKostenlos.ToString());
                        break;
                    case 2:
                        angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.LandungskapselKostenlos.ToString());
                        break;
                }
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class expugnatorGarde : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Expugnatorgarde;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 125;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.HeroischeIntervention);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Sturm);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            int punkteKostenProVeteran = 20;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 5, 10, "Trupp darf bis zu fünf zusätzliche Veteranen erhalten", gesamtArmeePunkteKosten, punkteKostenProVeteran) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheSpaceMariens = auswahlAnzahl.anzahlGewaehlt;
            int anzahlVeteranenGesamt = 4 + zusaetlicheSpaceMariens;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheSpaceMariens * punkteKostenProVeteran;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };

            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Wollen wir Sprungmodule haben?
            var auswahlKonstrukt = new List<pulldownAuswahl>() { };
            auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "keine Sprungmodule", kosten = 0 });
            auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sprungmodul, kosten = (anzahlVeteranenGesamt+1)*10 });
            Auswahl1AusN auswahlSprung = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Alle Modelle dürfen Sprungmodule erhalten:", auswahlKonstrukt);
            if (!auswahlSprung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlSprung.gewaehlterIndexAusN;
            bool hatSprungmodule = false;
            if (wahlIndex == 1)
            {
                hatSprungmodule = true;
                einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
            }


            // Dürfen's auch ein paar Melterbomben sein?
            auswahlKonstrukt = new List<pulldownAuswahl>() { };
            auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "keine Melterbomben", kosten = 0 });
            auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            Auswahl1AusN auswahlMelter = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Alle Modelle dürfen Metlerbomben erhalten:", auswahlKonstrukt);
            if (!auswahlSprung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlMelter.gewaehlterIndexAusN;
            bool hatMelterbomben = false;
            if (wahlIndex == 1)
            {
                hatMelterbomben = true;
                einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
            }




            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlVeteranenGesamt; ++i)
            {
                // Okay, legen wir die Space Marines an:
                var veteran = ultraMarineHelperClass.createVeteran();
                veteran.name = alleSubeinheitenNamen.VeteranDerSpaceMariens;

                veteran.ausruestung.Remove(alleAusruestung.Spezialmunition);

                if (hatSprungmodule)
                    veteran.ausruestung.Add(alleAusruestung.Sprungmodul);
                if (hatMelterbomben)
                    veteran.ausruestung.Add(alleAusruestung.Melterbomben);

                // Das Gleiche gilt für die Boltpistole!
                veteran.waffen = new List<waffe>() { };

                // Jeder Veteran darf wählen zwischen folgenden Waffen (der Sarge auch!)
                auswahlKonstrukt = new List<pulldownAuswahl>() { };
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Kettenschwert", kosten = 0 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Sturmschild und Kettenschwert", kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Plasmapistole und Kettenschwert", kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energieschwert", kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energieklaue", kosten = 15});
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energiefaust", kosten = 25 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Energiehammer", kosten = 30 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Zwei Energieschwerter", kosten = 30 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Zwei Energieklauen", kosten = 30 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Zwei Energiefäuste", kosten = 50 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Zwei Energiehämmer", kosten = 60 });

                Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Space Marine darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                if (!auswahlWaffe1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                switch (wahlIndex)
                {
                    case 0:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Kettenschwert));
                        break;
                    case 1:
                        veteran.ausruestung.Add(alleAusruestung.Sturmschild);
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Kettenschwert));
                        break;
                    case 2:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Plasmapistole));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Kettenschwert));
                        break;
                    case 3:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));
                        break;
                    case 4:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                        break;
                    case 5:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiefaust));
                        break;
                    case 6:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));
                        break;
                    case 7:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));
                        break;
                    case 8:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieklaue));
                        break;
                    case 9:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiefaust));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiefaust));
                        break;
                    case 10:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energiehammer));
                        break;
                }           

                subEinheiten.Add(veteran);
            }

            ///
            // SARGE:
            ///

            // Außerdem gibt es ja noch den Sergeant:
            // Erstellen wir ihn:
            var spaceMarineSergeant = ultraMarineHelperClass.createSpaceMarineSergeant();
            
            if (hatSprungmodule)
                spaceMarineSergeant.ausruestung.Add(alleAusruestung.Sprungmodul);
            if (hatMelterbomben)
                spaceMarineSergeant.ausruestung.Add(alleAusruestung.Melterbomben);

            spaceMarineSergeant.waffen = new List<waffe>() { };

            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 10 });

            Auswahl1AusN auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen treffen:", auswahlSargePulldown);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlSarge.gewaehlterIndexAusN;
            spaceMarineSergeant.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown[wahlIndex].kosten * 1;

            subEinheiten.Add(spaceMarineSergeant);

            // Wahl angeschlossenes Transportfahrzeug
            // => nur dann, wenn keine Sprungmodule gewählt wurden!
            if (!hatSprungmodule)
            {
                var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Rhino, kosten = 35 });
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Razorback, kosten = 40 });
                fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

                Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
                if (!auswahlScreen.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                wahlIndex = auswahlScreen.gewaehlterIndexAusN;

                // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
                switch (wahlIndex)
                {
                    case 0:
                        break;
                    case 1:
                        angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Rhino.ToString());
                        break;
                    case 2:
                        angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Razorback.ToString());
                        break;
                    case 3:
                        angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                        break;
                }
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class ehrwCybot : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.EhrwuerdigerCybot;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 165;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugLaeufer;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.Ehrwuerdig);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myCybot = ultraMarineHelperClass.createEhrwuerdigerCybot();
         
            // Wahl des Sturmbolters:
            var wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 0});
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = 10 });

            Auswahl1AusN wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;

            // Wahl des Multimelters:
            wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncSchwererFlammenwerfer, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncSchwererBolter, kosten = 5 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncMaschkanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmakanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmkanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncLaserKanone, kosten = 30 });

            wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;

            // Wahl der Nahkampfwaffe:
            wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.CybotNahkampfWaffe, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncMaschkanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Raketenwerfer, kosten = 10 });
            wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;


            // Wahl der Extra-Ausrüstung:
            var landRaiderAusruestung = new List<pulldownAuswahl>() { };
            landRaiderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });

            AuswahlMAusN wahlLandRaiderAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", landRaiderAusruestung);
            if (!wahlLandRaiderAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlLandRaiderAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myCybot.ausruestung.Add((alleAusruestung)landRaiderAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + landRaiderAusruestung[i].kosten * 1;
            }

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myCybot);

            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = "kein Transportfahrzeug", kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0:
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                    break;
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class cybot : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Cybot;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 105;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugLaeufer;

            sonderregeln = new List<Sonderregeln>() { };

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myCybot = ultraMarineHelperClass.createCybot();
           
            // Wahl des Sturmbolters:
            var wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = 10 });

            Auswahl1AusN wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;

            // Wahl des Multimelters:
            wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncSchwererFlammenwerfer, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncSchwererBolter, kosten = 5 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncMaschkanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmakanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmkanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncLaserKanone, kosten = 30 });

            wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;

            // Wahl der Nahkampfwaffe:
            wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.CybotNahkampfWaffe, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncMaschkanone, kosten = 10 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Raketenwerfer, kosten = 10 });
            wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;


            // Wahl der Extra-Ausrüstung:
            var landRaiderAusruestung = new List<pulldownAuswahl>() { };
            landRaiderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });

            AuswahlMAusN wahlLandRaiderAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", landRaiderAusruestung);
            if (!wahlLandRaiderAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlLandRaiderAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myCybot.ausruestung.Add((alleAusruestung)landRaiderAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + landRaiderAusruestung[i].kosten * 1;
            }

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myCybot);

            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = "kein Transportfahrzeug", kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0:
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                    break;
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class ironclad : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.IroncladCybot;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 135;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugLaeufer;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DurchDeckungBewegen);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myCybot = ultraMarineHelperClass.createIronclad();

            // Frage: Will ich ein Hurricano statt Cybotnahkampfwaffe und Sturmbolter?
            var wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = "Cybotnahkampfwaffe und Sturmbolter", kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.HurricaneBolter, kosten = 0 });

            Auswahl1AusN wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;
            if (myIndex == 1)
            {
                myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.HurricaneBolter));
            }
            else
            {
                // Jetzt darf ich mir noch überlegen, den Sturmbolter zu ersetzen. Die Nahkampfwaffe gibt es immer!
                myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.CybotNahkampfWaffe));

                wahlBolter = new List<pulldownAuswahl>() { };
                wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 0 });
                wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = 10 });

                wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
                if (!wahlBolterWaffen.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
                myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;
            }         

            // Wahl des Multimelters:
            wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = 5 });
            wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;

            // Wahl der Nahkampfwaffe:
            wahlBolter = new List<pulldownAuswahl>() { };
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SeismischerHammer, kosten = 0 });
            wahlBolter.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenfaust, kosten = 0 });
            wahlBolterWaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", wahlBolter);
            if (!wahlBolterWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            myIndex = wahlBolterWaffen.gewaehlterIndexAusN;
            myCybot.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(wahlBolter[myIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + wahlBolter[myIndex].kosten * 1;


            // Wahl der Extra-Ausrüstung:
            var landRaiderAusruestung = new List<pulldownAuswahl>() { };
            landRaiderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
            landRaiderAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });

            AuswahlMAusN wahlLandRaiderAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", landRaiderAusruestung);
            if (!wahlLandRaiderAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlLandRaiderAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myCybot.ausruestung.Add((alleAusruestung)landRaiderAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + landRaiderAusruestung[i].kosten * 1;
            }

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myCybot);

            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = "kein Transportfahrzeug", kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0:
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                    break;
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class scoutTrupp : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Scouttrupp;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 75;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftrupps);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.Infiltratoren);
            sonderregeln.Add(Sonderregeln.DurchDeckungBewegen);
            sonderregeln.Add(Sonderregeln.Scouts);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Standard);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            int punkteKostenProSpaceMarine = 13;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 5, 10, "Trupp darf bis zu fünf zusätzliche Scouts erhalten", gesamtArmeePunkteKosten, punkteKostenProSpaceMarine) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheSpaceMariens = auswahlAnzahl.anzahlGewaehlt;
            int anzahlScoutsGesamt = 4 + zusaetlicheSpaceMariens;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheSpaceMariens * punkteKostenProSpaceMarine;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };

            // Auswahl vorbereiten:
            var wahlIndex = new int();


            // Tranmäntel?
            var auswahlTarn = new List<pulldownAuswahl>() { };
            auswahlTarn.Add(new pulldownAuswahl() { auswahl = "keine Tarnmäntel", kosten = 0 });
            auswahlTarn.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Tarnmantel, kosten = 3*(anzahlScoutsGesamt+1) });

            Auswahl1AusN ausWahlTarnMantel = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Alle Scouts dürfen Tarnmäntel erhalten:", auswahlTarn);
            if (!ausWahlTarnMantel.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = ausWahlTarnMantel.gewaehlterIndexAusN;
            bool habenTarnmaentel = false;
            if (wahlIndex == 1)
                habenTarnmaentel = true;

            // Auswahl nutzen und Kosten aktualisieren:
            einheitKostenGesamt = einheitKostenGesamt + auswahlTarn[wahlIndex].kosten * 1;



            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlScoutsGesamt; ++i)
            {
                // Okay, legen wir die Space Marines an:
                var scout = ultraMarineHelperClass.createScout();

                if (habenTarnmaentel)
                    scout.ausruestung.Add(alleAusruestung.Tarnmantel);

                scout.waffen = new List<waffe>() { };

                // Der erste Scout darf eine Extra-Auswahl treffen:
                if (i == 0)
                {
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Schwerer Bolter mit Höllenfeuergeschoss", kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Raketenwerfer, kosten = 10 });

                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Schrotflinte, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kampfmesser, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Scharfschützengewehr, kosten = 0 });


                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Scout darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;
                    switch (wahlIndex)
                    {
                        case 0:
                            scout.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));
                            break;
                        case 1:
                            scout.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SchwererBolter));
                            scout.ausruestung.Add(alleAusruestung.Hoellenfeuergeschosse);
                            break;
                        case 2:
                            scout.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Raketenwerfer));
                            break;
                        case 3:
                            scout.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Schrotflinte));
                            break;
                        case 4:
                            scout.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Kampfmesser));
                            break;
                        case 5:
                            scout.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Scharfschützengewehr));
                            break;
                    }


                    // Auswahl nutzen und Kosten aktualisieren:
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else
                {
                    // Jetzt darf ich auch andere Auswahlen durchühren:
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Schrotflinte, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kampfmesser, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Scharfschützengewehr, kosten = 0 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Space Marine darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    scout.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }                            
 
                subEinheiten.Add(scout);
            }

            ///
            // SARGE:
            ///

            // Außerdem gibt es ja noch den Sergeant:
            // Erstellen wir ihn:
            var scoutSarge = ultraMarineHelperClass.createSpaceMarineSergeant();

            if (habenTarnmaentel)
                scoutSarge.ausruestung.Add(alleAusruestung.Tarnmantel);

            scoutSarge.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.Scoutruestung);
            scoutSarge.waffen = new List<waffe>() { };

            // Erst einmal lassen wir den Spieler die Wahl für die erste Hand treffen:
            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Schrotflinte, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Scharfschützengewehr, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kampfmesser, kosten = 0 });            
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            Auswahl1AusN auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen treffen:", auswahlSargePulldown);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlSarge.gewaehlterIndexAusN;
            scoutSarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown[wahlIndex].kosten * 1;


            // Wenn er bereits eine Boltpistole hat, kann er sie nicht noch einmal nehmen, sonst schon!
            var auswahlSargePulldown2 = new List<pulldownAuswahl>() { };
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenschwert, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant muss eine der folgenden Auswahlen für die Zweithand treffen:", auswahlSargePulldown2);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlSarge.gewaehlterIndexAusN;

            scoutSarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown2[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown2[wahlIndex].kosten * 1;

            // Außerdem darf er sich noch Ausrüstung aussuchen!
            var pulldownSargeAusruestung = new List<pulldownAuswahl>() { };
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.TeleportPeilsender, kosten = 15 });


            AuswahlMAusN wahlSargeAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Sergeant darf folgende Optionen wählen:", pulldownSargeAusruestung);
            if (!wahlSargeAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlSargeAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                scoutSarge.ausruestung.Add((alleAusruestung)pulldownSargeAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + pulldownSargeAusruestung[i].kosten * 1;
            }

            subEinheiten.Add(scoutSarge);         

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class spaceMarineCaptain : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.CaptainDerSpaceMarines;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 100;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var cap = ultraMarineHelperClass.createSpaceMarinesCaptain();
            
            bool hasSturmschild = false;
            bool hasMeisterhafteRuestung = false;

            // Wahl der Rüstung:
            var auswahlFuerRuestung = new List<pulldownAuswahl>() { };
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.ServoRuestung, kosten = 0 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.MeisterhafteRuestung, kosten = 15 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.TerminatorRuestung, kosten = 40});

            cap.einheitentyp = Einheitstyp.Infanterie;

            Auswahl1AusN auswahlRuestung = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Rüstungen wählen:", auswahlFuerRuestung);
            if (!auswahlRuestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            var wahlIndex = auswahlRuestung.gewaehlterIndexAusN;
            if (wahlIndex == 0 || wahlIndex == 1)
            {
                // SERVO
                if (wahlIndex == 0)
                    cap.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.ServoRuestung);
                else
                {
                    cap.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.MeisterhafteRuestung);
                    hasMeisterhafteRuestung = true;
                }

                // Dann darf ich jetzt auch noch Sprungmodul oder Bike erhalten!
                var auswahlFuerMobil = new List<pulldownAuswahl>() { };
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = "keine Auswahl", kosten = 0 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sprungmodul, kosten = 25 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleAusruestung.SpaceMarineBike, kosten = 35 });

                Auswahl1AusN auswahlMobil = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Rüstungen wählen:", auswahlFuerMobil);
                if (!auswahlMobil.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                var intIndex = auswahlMobil.gewaehlterIndexAusN;
                switch (intIndex)
                {
                    case 0:
                        break;
                    case 1:
                        cap.ausruestung.Add(alleAusruestung.Sprungmodul);
                        break;
                    case 2:
                        cap.ausruestung.Add(alleAusruestung.SpaceMarineBike);
                        cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                        cap.einheitentyp = Einheitstyp.Bike;
                        break;
                }

                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerMobil[intIndex].kosten * 1;


                // Normale Waffen ersetzen:
                auswahlFuerMobil = new List<pulldownAuswahl>() { };
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 3 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Ehrenklinge, kosten = 30 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 30 });

                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sturmschild, kosten = 15 });

                auswahlMobil = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen wählen:", auswahlFuerMobil);
                if (!auswahlMobil.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                intIndex = auswahlMobil.gewaehlterIndexAusN;
                switch (intIndex)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlFuerMobil[intIndex].auswahl));
                        break;
                    case 12:
                        cap.ausruestung.Add(alleAusruestung.Sturmschild);
                        hasSturmschild = true;
                        break;
                }
                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerMobil[intIndex].kosten * 1;


                // Und jetzt denselben Spaß noch einmal für die andere Hand:
                auswahlFuerMobil = new List<pulldownAuswahl>() { };
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });               
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Ehrenklinge, kosten = 30 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 30 });


                auswahlMobil = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen für die Offhand wählen:", auswahlFuerMobil);
                if (!auswahlMobil.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                intIndex = auswahlMobil.gewaehlterIndexAusN;
                cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlFuerMobil[intIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerMobil[intIndex].kosten * 1;
            }
            else
            {
                // TERMIE
                cap.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.TerminatorRuestung);
                hasMeisterhafteRuestung = true;
                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerRuestung[wahlIndex].kosten * 1;

                // Auswahl: Ich darf den Sturmbolter ersetzen!

                var auswahlSturmbolterListe = new List<pulldownAuswahl>() { };
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 0 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 10 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 20 });

                Auswahl1AusN auswahlSturm = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen wählen:", auswahlSturmbolterListe);
                if (!auswahlSturm.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                var neuerIndex = auswahlSturm.gewaehlterIndexAusN;

                // Auswahl nutzen und Kosten aktualisieren:
                cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSturmbolterListe[neuerIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + auswahlSturmbolterListe[neuerIndex].kosten * 1;

                // Und das E-Schwert!
                auswahlSturmbolterListe = new List<pulldownAuswahl>() { };
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 0 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 10 });               
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 15 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenfaust, kosten = 15 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sturmschild, kosten = 10 });

                auswahlSturm = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen wählen:", auswahlSturmbolterListe);
                if (!auswahlSturm.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                neuerIndex = auswahlSturm.gewaehlterIndexAusN;

                switch (neuerIndex)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSturmbolterListe[neuerIndex].auswahl));
                        break;
                    case 5:
                        cap.ausruestung.Add(alleAusruestung.Sturmschild);
                        hasSturmschild = true;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Space Marine Cap OOR!");
                }

            }

            // Restliche Auswahlen:
            var pulldownCapAusruestung = new List<pulldownAuswahl>() { };
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Digitalwaffen, kosten = 10 });
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Hoellenfeuermunition, kosten = 10 });

            AuswahlMAusN wahlCapAusreustung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Captain darf folgende Optionen wählen:", pulldownCapAusruestung);
            if (!wahlCapAusreustung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlCapAusreustung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                cap.ausruestung.Add((alleAusruestung)pulldownCapAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + pulldownCapAusruestung[i].kosten * 1;
            }


            pulldownCapAusruestung = new List<pulldownAuswahl>() { };
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.AuxilarisGranatwerfer, kosten = 15 });
            wahlCapAusreustung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Captain darf folgende Waffen zusätzlich wählen:", pulldownCapAusruestung);
            if (!wahlCapAusreustung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlCapAusreustung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(pulldownCapAusruestung[i].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + pulldownCapAusruestung[i].kosten * 1;
            }

            if (!hasMeisterhafteRuestung)
                cap.rw = 3;
            else
                cap.rw = 2;
            cap.ret = 4;
            if (hasSturmschild)
                cap.ret = 3;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(cap);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class spaceMarineOrdensmeister : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.OrdensmeisterDerSpaceMarines;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 125;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.OrbitalesBombardement);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var cap = ultraMarineHelperClass.createSpaceMarineOrdensmeister();
           
            bool hasSturmschild = false;
            bool hasMeisterhafteRuestung = false;

            // Wahl der Rüstung:
            var auswahlFuerRuestung = new List<pulldownAuswahl>() { };
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.ServoRuestung, kosten = 0 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.MeisterhafteRuestung, kosten = 15 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.TerminatorRuestung, kosten = 40 });

            Auswahl1AusN auswahlRuestung = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Rüstungen wählen:", auswahlFuerRuestung);
            if (!auswahlRuestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            var wahlIndex = auswahlRuestung.gewaehlterIndexAusN;
            if (wahlIndex == 0 || wahlIndex == 1)
            {
                // SERVO
                if (wahlIndex == 0)
                    cap.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.ServoRuestung);
                else
                {
                    cap.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.MeisterhafteRuestung);
                    hasMeisterhafteRuestung = true;
                }

                // Dann darf ich jetzt auch noch Sprungmodul oder Bike erhalten!
                var auswahlFuerMobil = new List<pulldownAuswahl>() { };
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = "keine Auswahl", kosten = 0 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sprungmodul, kosten = 25 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleAusruestung.SpaceMarineBike, kosten = 35 });

                Auswahl1AusN auswahlMobil = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Rüstungen wählen:", auswahlFuerMobil);
                if (!auswahlMobil.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                var intIndex = auswahlMobil.gewaehlterIndexAusN;
                switch (intIndex)
                {
                    case 0:
                        break;
                    case 1:
                        cap.ausruestung.Add(alleAusruestung.Sprungmodul);
                        break;
                    case 2:
                        cap.ausruestung.Add(alleAusruestung.SpaceMarineBike);
                        cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                        cap.einheitentyp = Einheitstyp.Bike;
                        break;
                }

                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerMobil[intIndex].kosten * 1;


                // Normale Waffen ersetzen:
                auswahlFuerMobil = new List<pulldownAuswahl>() { };
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 3 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Ehrenklinge, kosten = 30 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 30 });

                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sturmschild, kosten = 15 });

                auswahlMobil = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen wählen:", auswahlFuerMobil);
                if (!auswahlMobil.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                intIndex = auswahlMobil.gewaehlterIndexAusN;
                switch (intIndex)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlFuerMobil[intIndex].auswahl));
                        break;
                    case 12:
                        cap.ausruestung.Add(alleAusruestung.Sturmschild);
                        hasSturmschild = true;
                        break;
                }
                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerMobil[intIndex].kosten * 1;


                // Und jetzt denselben Spaß noch einmal für die andere Hand:
                auswahlFuerMobil = new List<pulldownAuswahl>() { };
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Ehrenklinge, kosten = 30 });
                auswahlFuerMobil.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 30 });


                auswahlMobil = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen für die Offhand wählen:", auswahlFuerMobil);
                if (!auswahlMobil.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                intIndex = auswahlMobil.gewaehlterIndexAusN;
                cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlFuerMobil[intIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerMobil[intIndex].kosten * 1;
            }
            else
            {
                // TERMIE
                cap.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.TerminatorRuestung);
                hasMeisterhafteRuestung = true;
                einheitKostenGesamt = einheitKostenGesamt + auswahlFuerRuestung[wahlIndex].kosten * 1;

                // Auswahl: Ich darf den Sturmbolter ersetzen!

                var auswahlSturmbolterListe = new List<pulldownAuswahl>() { };
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 0 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 10 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 20 });

                Auswahl1AusN auswahlSturm = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen wählen:", auswahlSturmbolterListe);
                if (!auswahlSturm.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                var neuerIndex = auswahlSturm.gewaehlterIndexAusN;

                // Auswahl nutzen und Kosten aktualisieren:
                cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSturmbolterListe[neuerIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + auswahlSturmbolterListe[neuerIndex].kosten * 1;

                // Und das E-Schwert!
                auswahlSturmbolterListe = new List<pulldownAuswahl>() { };
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 0 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 5 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 10 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 15 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenfaust, kosten = 15 });
                auswahlSturmbolterListe.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sturmschild, kosten = 10 });

                auswahlSturm = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Muss eine der folgenden Waffen wählen:", auswahlSturmbolterListe);
                if (!auswahlSturm.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                neuerIndex = auswahlSturm.gewaehlterIndexAusN;

                switch (neuerIndex)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSturmbolterListe[neuerIndex].auswahl));
                        break;
                    case 5:
                        cap.ausruestung.Add(alleAusruestung.Sturmschild);
                        hasSturmschild = true;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Space Marine Cap OOR!");
                }
            }

            // Restliche Auswahlen:
            var pulldownCapAusruestung = new List<pulldownAuswahl>() { };
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Digitalwaffen, kosten = 10 });
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Hoellenfeuermunition, kosten = 10 });

            AuswahlMAusN wahlCapAusreustung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Captain darf folgende Optionen wählen:", pulldownCapAusruestung);
            if (!wahlCapAusreustung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlCapAusreustung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                cap.ausruestung.Add((alleAusruestung)pulldownCapAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + pulldownCapAusruestung[i].kosten * 1;
            }

            pulldownCapAusruestung = new List<pulldownAuswahl>() { };
            pulldownCapAusruestung.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.AuxilarisGranatwerfer, kosten = 15 });
            wahlCapAusreustung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Space Marine Captain darf folgende Waffen zusätzlich wählen:", pulldownCapAusruestung);
            if (!wahlCapAusreustung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlCapAusreustung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                cap.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(pulldownCapAusruestung[i].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + pulldownCapAusruestung[i].kosten * 1;
            }

            if (!hasMeisterhafteRuestung)
                cap.rw = 3;
            else
                cap.rw = 2;
            cap.ret = 4;
            if (hasSturmschild)
                cap.ret = 3;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(cap);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class protektorGarde : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Protektorgarde;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 125;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.Kampftrupps);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            int punkteKostenProVeteran = 25;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 5, 10, "Trupp darf bis zu fünf zusätzliche Veteranen erhalten", gesamtArmeePunkteKosten, punkteKostenProVeteran) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetzlicheVeteranen = auswahlAnzahl.anzahlGewaehlt;
            int anzahlVeteranenGesamt = 4 + zusaetzlicheVeteranen;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetzlicheVeteranen * punkteKostenProVeteran;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };


            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlVeteranenGesamt; ++i)
            {
                var veteran = ultraMarineHelperClass.createVeteran();              

                veteran.waffen = new List<waffe>() { };
                veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));               

                // Bolter darf immer ersetzt werden! Für die ersten beiden Modelle sogar durch noch mehr Extras!
                if (i < 2)
                {
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 5 });

                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Flammenwerfer, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Melter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Raketenwerfer, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmawerfer, kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmakanone, kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Laserkanone, kosten = 15 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Veteran darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else
                {
                    // Jetzt nur die Variante ohne Extras:
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 5 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Veteran darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }                          

                subEinheiten.Add(veteran);     
            }

            // Sarge:
            var sarge = ultraMarineHelperClass.createSpaceMarineSergeant();            
            sarge.ausruestung.Add(alleAusruestung.Spezialmunition);

            sarge.waffen = new List<waffe>() { };

            // Zunächst einmal darf der Bolter ersetzt werden:
            var auswSarge1 = new List<pulldownAuswahl>() { };
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 5 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 5 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 5 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 5 });

            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenschwert, kosten = 0 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 15 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            Auswahl1AusN auswahlWaffeS1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Sergeant darf eine der folgenden Waffen wählen:", auswSarge1);
            if (!auswahlWaffeS1.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlWaffeS1.gewaehlterIndexAusN;
            sarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswSarge1[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswSarge1[wahlIndex].kosten * 1;

            // Desgleichen für die zweite Hand:
            auswSarge1 = new List<pulldownAuswahl>() { };
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenschwert, kosten = 0 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 15 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswSarge1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            Auswahl1AusN auswahlWaffeS2 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Sergeant darf eine der folgenden Waffen wählen:", auswSarge1);
            if (!auswahlWaffeS1.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlWaffeS2.gewaehlterIndexAusN;
            sarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswSarge1[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswSarge1[wahlIndex].kosten * 1;

            // Außerdem darf er sich noch Ausrüstung aussuchen!
            var pulldownSargeAusruestung = new List<pulldownAuswahl>() { };
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });

            // Ausrüstung:
            AuswahlMAusN wahlSargeAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Sergeant darf folgende Optionen wählen:", pulldownSargeAusruestung);
            if (!wahlSargeAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlSargeAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                sarge.ausruestung.Add((alleAusruestung)pulldownSargeAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + pulldownSargeAusruestung[i].kosten * 1;
            }

            subEinheiten.Add(sarge);
                        
            // Wahl angeschlossenes Transportfahrzeug
            // => muss mit generiert werden!
            // Also müssen wir zunächst den Spieler fragen, ob er überhaupt ein Transportfahrzeug möchte!
            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Rhino, kosten = 35 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Razorback, kosten = 40 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0: 
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Rhino.ToString());
                    break;
                case 2:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Razorback.ToString());
                    break;
                case 3:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                    break;
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class predator : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Predator;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 60;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugPanzer;

            sonderregeln = new List<Sonderregeln>() { };

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Unterstuetzung);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var myPredator = new subEinheit() { };
            myPredator.name = alleSubeinheitenNamen.Predator;
            myPredator.ausruestung = new List<alleAusruestung>() { };
            myPredator.ausruestung.Add(alleAusruestung.Nebelwerfer);
            myPredator.ausruestung.Add(alleAusruestung.Suchscheinwerfer);

            myPredator.waffen = new List<waffe>() { };
            myPredator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Maschinenkanone));


            // Ich darf die Maschinenkanone auch ersetzen durch eine andere Auswahl!
            var predatorHauptWaffen = new List<pulldownAuswahl>() { };
            predatorHauptWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Maschinenkanone, kosten = 0 });
            predatorHauptWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SyncLaserKanone, kosten = 45 });

            Auswahl1AusN wahlPredatorHauptwaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", predatorHauptWaffen);
            if (!wahlPredatorHauptwaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlIndex = wahlPredatorHauptwaffen.gewaehlterIndexAusN;
            myPredator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(predatorHauptWaffen[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + predatorHauptWaffen[wahlIndex].kosten * 1;

            var predatorNebenWaffen = new List<pulldownAuswahl>() { };
            predatorNebenWaffen.Add(new pulldownAuswahl() { auswahl = "Zwei Seitenkuppeln mit schwerem Bolter", kosten = +25 });
            predatorNebenWaffen.Add(new pulldownAuswahl() { auswahl = "Zwei Seitenkuppeln mit Laserkanonen", kosten = +60 });
            Auswahl1AusN wahlPredatorNabenwaffen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", predatorNebenWaffen);
            if (!wahlPredatorNabenwaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = wahlPredatorNabenwaffen.gewaehlterIndexAusN;
            if (wahlIndex == 0)
            {
                myPredator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SchwererBolter));
                myPredator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SchwererBolter));
            }
            else
            {
                myPredator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Laserkanone));
                myPredator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Laserkanone));
            }
            einheitKostenGesamt = einheitKostenGesamt + predatorNebenWaffen[wahlIndex].kosten * 1;



            var predatorAusruestung = new List<pulldownAuswahl>() { };
            predatorAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Bulldozerschaufel, kosten = +5 });
            predatorAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Radarsuchkopfrakete, kosten = +10 });
            predatorAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.ZusaetzlichePanzerung, kosten = +15 });

            AuswahlMAusN wahlPredatorAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen gewählt werden:", predatorAusruestung);
            if (!wahlPredatorAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlPredatorAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                myPredator.ausruestung.Add((alleAusruestung)predatorAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + predatorAusruestung[i].kosten * 1;
            }



            var predatorWaffen = new List<pulldownAuswahl>() { };
            predatorWaffen.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = +10 });

            AuswahlMAusN wahlPredatorWaffen = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Waffen dürfen gewählt werden:", predatorWaffen);
            if (!wahlPredatorWaffen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlVektor = wahlPredatorWaffen.wahlIndexVektor;

            foreach (int i in wahlVektor)
            {
                myPredator.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(predatorWaffen[i].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + predatorWaffen[i].kosten * 1;
            }


            myPredator.einheitentyp = Einheitstyp.FahrzeugPanzer;

            // Setzen der Panzerungswerte:
            myPredator.bf = 4;
            myPredator.front = 13;
            myPredator.seit = 11;
            myPredator.heck = 10;
            myPredator.transportkapazitaet = 0;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(myPredator);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class landSpeederSchwadron : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Landspeederschwadron;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 50;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.FahrzeugSchnellAntigrav;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.Schocktruppen);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Sturm);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            subEinheiten = new List<subEinheit>() { };

            // Wie viele Speeder wollen wir haben?
            int punkteKostenProSpeeder = 50;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 1, 3, "Trupp darf bis zu zwei zusätzliche Speeder erhalten", gesamtArmeePunkteKosten, punkteKostenProSpeeder) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheSpeeder = auswahlAnzahl.anzahlGewaehlt;
            int anzahlSpeederGesamt = 1 + zusaetlicheSpeeder;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheSpeeder * punkteKostenProSpeeder;

            for (int k = 0; k < anzahlSpeederGesamt; ++k)
            {
                // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
                var speeder = new subEinheit() { };
                speeder.name = alleSubeinheitenNamen.Landspeeder;
                speeder.ausruestung = new List<alleAusruestung>() { };
                speeder.waffen = new List<waffe>() { };


                // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
                var speederWaffen1 = new List<pulldownAuswahl>() { };
                speederWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = +0 });
                speederWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = +0 });
                speederWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +10 });

                Auswahl1AusN wahlSpeederWaffen1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", speederWaffen1);
                if (!wahlSpeederWaffen1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                var myIndex = wahlSpeederWaffen1.gewaehlterIndexAusN;
                speeder.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(speederWaffen1[myIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + speederWaffen1[myIndex].kosten * 1;

                // Und zusätzlich zwischen diesen:
                var speederWaffen2 = new List<pulldownAuswahl>() { };
                speederWaffen2.Add(new pulldownAuswahl() { auswahl = "keine Zusatzwaffen", kosten = +0 });
                speederWaffen2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.TyphoonRaketenwerfer, kosten = +40 });
                speederWaffen2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = +10 });
                speederWaffen2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = +10 });
                speederWaffen2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +20 });
                speederWaffen2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmkanone, kosten = +40 });

                Auswahl1AusN wahlSpeederWaffen2 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", speederWaffen2);
                if (!wahlSpeederWaffen2.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                myIndex = wahlSpeederWaffen2.gewaehlterIndexAusN;
                if (myIndex != 0)
                    speeder.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(speederWaffen2[myIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + speederWaffen2[myIndex].kosten * 1;

                speeder.einheitentyp = Einheitstyp.FahrzeugSchnellAntigrav;

                // Setzen der Panzerungswerte:
                speeder.bf = 4;
                speeder.front = 10;
                speeder.seit = 10;
                speeder.heck = 10;
                speeder.transportkapazitaet = 0;
                subEinheiten.Add(speeder);
            }


            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class trikeSchwadron : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Trikeschwadron;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 40;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Bike;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Sturm);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            subEinheiten = new List<subEinheit>() { };

            // Wie viele Speeder wollen wir haben?
            int punkteKostenProTrike = 40;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 1, 3, "Trupp darf bis zu zwei zusätzliche Trikes erhalten", gesamtArmeePunkteKosten, punkteKostenProTrike) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheTrikes = auswahlAnzahl.anzahlGewaehlt;
            int anzahlTrikesGesamt = 1 + zusaetlicheTrikes;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheTrikes * punkteKostenProTrike;

            for (int k = 0; k < anzahlTrikesGesamt; ++k)
            {
                // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
                var trike = ultraMarineHelperClass.createSpaceMarineTrike();                

                // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
                var trikeWaffen1 = new List<pulldownAuswahl>() { };
                trikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = +0 });
                trikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +10 });

                Auswahl1AusN wahlTrikeWaffen1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", trikeWaffen1);
                if (!wahlTrikeWaffen1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                var myIndex = wahlTrikeWaffen1.gewaehlterIndexAusN;
                trike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(trikeWaffen1[myIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + trikeWaffen1[myIndex].kosten * 1;

                subEinheiten.Add(trike);
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class bikeSchwadron : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Bikerschwadron;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 90;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Bike;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.Kampftrupps);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Sturm);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            subEinheiten = new List<subEinheit>() { };

            // Wie viele Speeder wollen wir haben?
            int punkteKostenProBike = 40;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 3, 8, "Trupp darf bis zu fünf zusätzliche Bikes erhalten", gesamtArmeePunkteKosten, punkteKostenProBike) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheBikes = auswahlAnzahl.anzahlGewaehlt;
            int anzahlBikesGesamt = 1 + zusaetlicheBikes;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheBikes * punkteKostenProBike;

            for (int k = 0; k < anzahlBikesGesamt; ++k)
            {
                // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
                var bike = ultraMarineHelperClass.createSpaceMarineBiker();
              
                if (k < 2)
                {
                    // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
                    var bikeWaffen1 = new List<pulldownAuswahl>() { };
                    bikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = +0 });
                    bikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Flammenwerfer, kosten = +5 });
                    bikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Melter, kosten = +10 });
                    bikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmawerfer, kosten = +15 });

                    Auswahl1AusN wahlBikeWaffen1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss gewählt werden:", bikeWaffen1);
                    if (!wahlBikeWaffen1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }
                    var myIndex = wahlBikeWaffen1.gewaehlterIndexAusN;
                    bike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(bikeWaffen1[myIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + bikeWaffen1[myIndex].kosten * 1;
                }
                else
                {
                    bike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                }

                subEinheiten.Add(bike);
            }

            // Sarge:
            // Hier muss ich der Spieler nur noch überlegen, wass er für die Subeinheit an Optionen haben möchte:
            var sarge = ultraMarineHelperClass.createSpaceMarineBikerSarge();
           
            // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
            var sargeWaffen1 = new List<pulldownAuswahl>() { };
            sargeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = +0 });
            sargeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = +15 });
            sargeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = +10 });
            sargeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = +10 });
            sargeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = +10 });
            sargeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = +15 });
            sargeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = +25 });

            Auswahl1AusN wahlSargeWaffen1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss für den Sergeant gewählt werden:", sargeWaffen1);
            if (!wahlSargeWaffen1.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var myIndex2 = wahlSargeWaffen1.gewaehlterIndexAusN;
            sarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(sargeWaffen1[myIndex2].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + sargeWaffen1[myIndex2].kosten * 1;           

            // Es dürfen noch Melterbomben gewählt werden!
            var listeAusruestung = new List<pulldownAuswahl>() { };
            listeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = +5 });

            AuswahlMAusN wahlAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Die folgenden Optionen dürfen für den Sergeant gewählt werden:", listeAusruestung);
            if (!wahlAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                sarge.ausruestung.Add((alleAusruestung)listeAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + listeAusruestung[i].kosten * 1;
            }

            subEinheiten.Add(sarge);

            // Jetzt muss ich noch auswählen, ob ich ein Trike zusätzlich will!
            var wahlTrikeRein = new List<pulldownAuswahl>() { };
            wahlTrikeRein.Add(new pulldownAuswahl() { auswahl = "kein Trike", kosten = +0 });
            wahlTrikeRein.Add(new pulldownAuswahl() { auswahl = alleSubeinheitenNamen.Trike, kosten = +40 });
            Auswahl1AusN wahlTrikeReinS = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Soll ein Trike hinzugefügt werden?", wahlTrikeRein);
            if (!wahlTrikeReinS.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            myIndex2 = wahlTrikeReinS.gewaehlterIndexAusN;

            if (myIndex2 != 0)
            {
                // Also noch ein Trike rein!
                var trike = ultraMarineHelperClass.createSpaceMarineTrike();              

                // Der Spieler darf sich zwischen einer der folgenden Auswahlen entscheiden:
                var trikeWaffen1 = new List<pulldownAuswahl>() { };
                trikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = +0 });
                trikeWaffen1.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +10 });

                Auswahl1AusN wahlTrikeWaffen1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Eine der folgenden Waffen muss für das Trike gewählt werden:", trikeWaffen1);
                if (!wahlTrikeWaffen1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                var myIndex = wahlTrikeWaffen1.gewaehlterIndexAusN;
                trike.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(trikeWaffen1[myIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + trikeWaffen1[myIndex].kosten * 1;

                subEinheiten.Add(trike);
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class legionOfTheDamned : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.LegionOfTheDamned;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 155;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.Furchtlos);
            sonderregeln.Add(Sonderregeln.UnbeugsameGeister);
            sonderregeln.Add(Sonderregeln.WieAusDemNichts);
            sonderregeln.Add(Sonderregeln.LangsamUndEntschlossen);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            int punkteKostenProLegionaer = 30;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 5, 10, "Trupp darf bis zu fünf zusätzliche Legionäre erhalten", gesamtArmeePunkteKosten, punkteKostenProLegionaer) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheLegionaere = auswahlAnzahl.anzahlGewaehlt;
            int anzahlLegionaereGesamt = 4 + zusaetlicheLegionaere;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheLegionaere * punkteKostenProLegionaer;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };


            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlLegionaereGesamt; ++i)
            {
                // Okay, legen wir die Space Marines an:
                var legionaer = ultraMarineHelperClass.createLegionaerLegionaer();

                if (i == 0)
                {
                    // Jetzt darf ich auch andere Auswahlen durchühren:
                    legionaer.waffen.Remove(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Flammenwerfer, kosten = +20 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Melter, kosten = +20 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmawerfer, kosten = +20 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Legionär darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    legionaer.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else if (i == 1)
                {
                    legionaer.waffen.Remove(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Raketenwerfer, kosten = 15 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmakanone, kosten = 20 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Laserkanone, kosten = 30 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = 30 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererFlammer, kosten = 30 });

                    Auswahl1AusN auswahlWaffe2 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Legionär darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe2.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe2.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    legionaer.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }

                subEinheiten.Add(legionaer);
            }

            ///
            // SARGE:
            ///
            var legionSarge = ultraMarineHelperClass.createLegionaerSarge();
            
            legionSarge.waffen = new List<waffe>() { };

            // Erst einmal lassen wir den Spieler die Wahl für die erste Hand treffen:
            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            Auswahl1AusN auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Sergeant der Legion muss eine der folgenden Auswahlen treffen:", auswahlSargePulldown);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlSarge.gewaehlterIndexAusN;
            legionSarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown[wahlIndex].kosten * 1;


            // Wenn er bereits eine Boltpistole hat, kann er sie nicht noch einmal nehmen, sonst schon!
            var auswahlSargePulldown2 = new List<pulldownAuswahl>() { };
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kettenschwert, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

            auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Sergeant der Legion muss eine der folgenden Auswahlen für die Zweithand treffen:", auswahlSargePulldown2);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlSarge.gewaehlterIndexAusN;

            legionSarge.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown2[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown2[wahlIndex].kosten * 1;

            subEinheiten.Add(legionSarge);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class techmarine : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Techmarine;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 50;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.SegenDesOmnissiah);
            sonderregeln.Add(Sonderregeln.Befestigen);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.Elite);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            int punkteKostenProServitor = 15;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 0, 5, "Trupp darf bis zu fünf Servitoren erhalten", gesamtArmeePunkteKosten, punkteKostenProServitor) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheServitoren = auswahlAnzahl.anzahlGewaehlt;
            int anzahlServitorenGesamt = zusaetlicheServitoren;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheServitoren * punkteKostenProServitor;

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };

            // Auswahl vorbereiten:
            var wahlIndex = new int();

            // Genau soviele einordnen, wie vom Spieler gewünscht:
            for (int i = 0; i < anzahlServitorenGesamt; ++i)
            {
                var servitor = new subEinheit() { };
                servitor.name = alleSubeinheitenNamen.Servitor;

                servitor.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.Scoutruestung);

                servitor.ausruestung = new List<alleAusruestung>();

                servitor.waffen = new List<waffe>() { };

                if (i == 0)
                    this.sonderregeln.Add(Sonderregeln.Lobotomie);

                if (i < 2)
                {
                    // Servoarm darf ersetzt werden!
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Servoarm, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.SchwererBolter, kosten = +20 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Multimelter, kosten = +30 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmakanone, kosten = +30 });

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Servitor darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                    // Auswahl nutzen und Kosten aktualisieren:
                    servitor.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                }
                else
                {
                    servitor.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Servoarm));
                }

                servitor.kg = 3;
                servitor.bf = 3;
                servitor.st = 3;
                servitor.wid = 3;
                servitor.lp = 1;
                servitor.ini = 3;
                servitor.at = 8;
                servitor.mw = 10;
                servitor.rw = 4;
                servitor.ret = 0;

                servitor.einheitentyp = Einheitstyp.Infanterie;

                subEinheiten.Add(servitor);
            }

            ///
            // Techmarine:
            ///
            var techmar = new subEinheit() { };
            techmar.name = alleSubeinheitenNamen.Techmarine;

            techmar.ausruestung = new List<alleAusruestung>() { };
            techmar.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            techmar.ausruestung.Add(alleAusruestung.Sprenggranaten);
            techmar.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.MeisterhafteRuestung);
            techmar.waffen = new List<waffe>() { };

            // Servoarm aufwerten?
            var auswahlSargePulldown = new List<pulldownAuswahl>() { };
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Servoarm, kosten = 0 });
            auswahlSargePulldown.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Servoharnisch, kosten = 25 });

            Auswahl1AusN auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Techmarine muss eine der folgenden Auswahlen treffen:", auswahlSargePulldown);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            wahlIndex = auswahlSarge.gewaehlterIndexAusN;
            if (wahlIndex == 0)
            {
                techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown[wahlIndex].auswahl)); 
            }
            else
            {
                techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Servoarm));
                techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Servoarm));
                techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncPlasmapistole));
                techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Flammenwerfer));
            }            
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown[wahlIndex].kosten * 1;


            // Weitere Waffen:
            var auswahlSargePulldown2 = new List<pulldownAuswahl>() { };
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 3 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
            auswahlSargePulldown2.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });
            auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Techmarine muss eine der folgenden Auswahlen für die Zweithand treffen:", auswahlSargePulldown2);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlSarge.gewaehlterIndexAusN;

            techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown2[wahlIndex].auswahl));
            einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown2[wahlIndex].kosten * 1;


            var auswahlSargePulldown3 = new List<pulldownAuswahl>() { };
            auswahlSargePulldown3.Add(new pulldownAuswahl() { auswahl = "keine Auswahl", kosten = 0 });
            auswahlSargePulldown3.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
            auswahlSargePulldown3.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 30 });
            auswahlSarge = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Techmarine darf eine der folgenden Auswahlen für die Zweithand treffen:", auswahlSargePulldown3);
            if (!auswahlSarge.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlSarge.gewaehlterIndexAusN;

            if (wahlIndex > 0)
            {
                techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlSargePulldown3[wahlIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + auswahlSargePulldown3[wahlIndex].kosten * 1;
            }

            techmar.einheitentyp = Einheitstyp.Infanterie;
            techmar.wid = 4;

            // Außerdem darf er sich noch Ausrüstung aussuchen!
            var pulldownSargeAusruestung = new List<pulldownAuswahl>() { };
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.SpaceMarineBike, kosten = 35 });

            AuswahlMAusN wahlSargeAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Techmarine darf folgende Optionen wählen:", pulldownSargeAusruestung);
            if (!wahlSargeAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlSargeAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                techmar.ausruestung.Add((alleAusruestung)pulldownSargeAusruestung[i].auswahl);
                techmar.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                techmar.einheitentyp = Einheitstyp.Bike;
                techmar.wid = 5;
                einheitKostenGesamt = einheitKostenGesamt + pulldownSargeAusruestung[i].kosten * 1;
            }

            techmar.kg = 4;
            techmar.bf = 4;
            techmar.st = 4;
            techmar.wid = 4;
            techmar.lp = 1;
            techmar.ini = 4;
            techmar.at = 1;
            techmar.mw = 8;
            techmar.rw = 2;
            techmar.ret = 0;

            subEinheiten.Add(techmar);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class scriptorDerSpaceMariens : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Scriptor;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 100;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.Psioniker);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var scriptor = new subEinheit() { };
            scriptor.name = alleSubeinheitenNamen.ScriptorSpaceMarines;

            scriptor.einheitentyp = Einheitstyp.Infanterie;

            scriptor.ausruestung = new List<alleAusruestung>() { };
            scriptor.ausruestung.Add(alleAusruestung.Fragmentgranaten);
            scriptor.ausruestung.Add(alleAusruestung.Sprenggranaten);
            scriptor.ausruestung.Add(alleAusruestung.Psimatrix);
            scriptor.waffen = new List<waffe>() { };
            scriptor.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Psiwaffe));

            scriptor.einheitentyp = Einheitstyp.Infanterie;

            // Wahl der Rüstung:
            var auswahlFuerRuestung = new List<pulldownAuswahl>() { };
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.ServoRuestung, kosten = 0 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.TerminatorRuestung, kosten = 25 });           
            Auswahl1AusN auswahlRuestung = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scriptor muss eine der folgenden Rüstungen wählen:", auswahlFuerRuestung);
            if (!auswahlRuestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int wahlIndex = auswahlRuestung.gewaehlterIndexAusN;
            bool hasTermieRuestung = (wahlIndex==1);
            if (!hasTermieRuestung)
                scriptor.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.ServoRuestung);
            else
            {
                scriptor.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.TerminatorRuestung);
                einheitKostenGesamt = einheitKostenGesamt + 40;
            }


            // Wahl der Psikräfte:
            var wahlPsi = new List<pulldownAuswahl>() { };
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.Schmetterschlag, kosten = 0});
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.Psischild, kosten = 0 });
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.Maschinenfluch, kosten = 0 });
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.Beschleunigung, kosten = 0 });
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.Nullzone, kosten = 0 });
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.AvatarDerSuehne, kosten = 0 });
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.MachtDerAlten, kosten = 0 });
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.TorZurUnendlichkeit, kosten = 0 });
            wahlPsi.Add(new pulldownAuswahl() { auswahl = Psikraefte.VortexDerVerdammnis, kosten = 0 });
            Auswahl1AusN wahlPsi1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scriptor muss eine der folgenden Psikräfte wählen:", wahlPsi);
            if (!wahlPsi1.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = wahlPsi1.gewaehlterIndexAusN;

            scriptor.psikraefte.Add((Psikraefte)wahlPsi[wahlIndex].auswahl);

            // Für die zweite Wahl muss genau diese entfernt werden!
            wahlPsi.RemoveAt(wahlIndex);
            wahlPsi1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scriptor muss eine weitere der folgenden Psikräfte wählen:", wahlPsi);
            if (!wahlPsi1.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = wahlPsi1.gewaehlterIndexAusN;

            scriptor.psikraefte.Add((Psikraefte)wahlPsi[wahlIndex].auswahl);

            // Soll es ein Epistolarius sein?
            var wahlEpist = new List<pulldownAuswahl> { };
            wahlEpist.Add(new pulldownAuswahl() { auswahl = "keine Aufwertung", kosten = 0 });
            wahlEpist.Add(new pulldownAuswahl() { auswahl = "Aufwertung zum Epistolarius", kosten = 50 });
            Auswahl1AusN wahlEpi = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scriptor muss eine der folgenden Auswahlen treffen:", wahlEpist);
            if (!wahlEpi.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = wahlEpi.gewaehlterIndexAusN;
            if (wahlIndex > 0)
            {
                einheitKostenGesamt = einheitKostenGesamt + 50;
                sonderregeln.Add(Sonderregeln.Epistolarius);
            }


            scriptor.wid = 4;
            // Fall1: Kein Termi!
            if (!hasTermieRuestung)
            {
                // Wahl Waffe:
                var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 3 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });              

                Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scriptor darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                if (!auswahlWaffe1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                // Auswahl nutzen und Kosten aktualisieren:
                scriptor.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;

                scriptor.rw = 3;
                scriptor.ret = 0;

                // Wahl für Sprungmodul oder Bike!
                var auswahlSprung = new List<pulldownAuswahl>() { };
                auswahlSprung.Add(new pulldownAuswahl() { auswahl = "kein Upgrade", kosten = 0 });
                auswahlSprung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sprungmodul, kosten = +25 });
                auswahlSprung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.SpaceMarineBike, kosten = +35 });
                Auswahl1AusN auswahlSprung1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scriptor darf eine der folgenden Auswahlen treffen:", auswahlSprung);
                if (!auswahlWaffe1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;
                if(wahlIndex ==1)
                {
                    // Sprungmodul!
                    scriptor.ausruestung.Add(alleAusruestung.Sprungmodul);
                    einheitKostenGesamt = einheitKostenGesamt + 25;
                    this.einheitentyp = Einheitstyp.Sprungtruppen;
                    scriptor.einheitentyp = Einheitstyp.Sprungtruppen;
                }
                if (wahlIndex == 2)
                {
                    // Bike!
                    scriptor.ausruestung.Add(alleAusruestung.SpaceMarineBike);
                    einheitKostenGesamt = einheitKostenGesamt + 35;
                    this.einheitentyp = Einheitstyp.Bike;
                    scriptor.einheitentyp = Einheitstyp.Bike;
                    scriptor.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                    scriptor.wid = 5;
                }

            }
            else
            {
                // Doch Termie! Wähe die Waffe!
                var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 5 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Boltpistole und Sturmschild", kosten = 15 });

                Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Scriptor darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                if (!auswahlWaffe1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                if (wahlIndex != 5)
                {
                    scriptor.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));                    
                }
                else
                {
                    scriptor.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                    scriptor.ausruestung.Add(alleAusruestung.Sturmschild);              
                }
                einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;

                scriptor.rw = 2;
                scriptor.ret = 5;
            }


            scriptor.kg = 5;
            scriptor.bf = 4;
            scriptor.st = 4;           
            scriptor.ini = 4;
            scriptor.lp = 2;
            scriptor.at = 2;
            scriptor.mw = 10;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(scriptor);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }

    public class ordenspriesterDerSpaceMarines : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.OrdenspriesterDerSpaceMarines;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 100;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.UnabhaengigesCharakterModell);
            sonderregeln.Add(Sonderregeln.LiturgienDerSchlacht);
            sonderregeln.Add(Sonderregeln.DieEhreDesOrdens);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.HQ);

            base.createUnitBase();
        }

        /// <summary>
        /// Hier werden alle Spierloptionen abgehandelt
        /// </summary>
        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten;

            var ordenspriester = new subEinheit() { };
            ordenspriester.name = alleSubeinheitenNamen.OrdenspriesterDerSpaceMarines;

            ordenspriester.einheitentyp = Einheitstyp.Infanterie;

            ordenspriester.ausruestung = new List<alleAusruestung>() { };
            ordenspriester.ausruestung.Add(alleAusruestung.Rosarius);

            ordenspriester.waffen = new List<waffe>() { };
            ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Crozius));

            ordenspriester.einheitentyp = Einheitstyp.Infanterie;

            // Wahl der Rüstung:
            var auswahlFuerRuestung = new List<pulldownAuswahl>() { };
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = alleRuestungen.ServoRuestung, kosten = 0 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = "Terminatorrüstung und Sturmbolter", kosten = 30 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = "Terminatorrüstung und Kombi-Flammenwerfer", kosten = 35 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = "Terminatorrüstung und Kombi-Melter", kosten = 35 });
            auswahlFuerRuestung.Add(new pulldownAuswahl() { auswahl = "Terminatorrüstung und Kombi-Plasmawerfer", kosten = 35 });
            Auswahl1AusN auswahlRuestung = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Ordenspriester muss eine der folgenden Rüstungen wählen:", auswahlFuerRuestung);
            if (!auswahlRuestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int wahlIndex = auswahlRuestung.gewaehlterIndexAusN;
            bool hasTermieRuestung = (wahlIndex > 0);
            if (!hasTermieRuestung)
            {
                ordenspriester.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.ServoRuestung);
                ordenspriester.ausruestung.Add(alleAusruestung.Fragmentgranaten);
                ordenspriester.ausruestung.Add(alleAusruestung.Sprenggranaten);
            }
            else
            {
                ordenspriester.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.TerminatorRuestung);
                ordenspriester.rw = 2;
                ordenspriester.ret = 5;

                if (wahlIndex == 1)
                {
                    ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Sturmbolter));
                    einheitKostenGesamt = einheitKostenGesamt + 30;
                }
                if (wahlIndex == 2)
                {
                    ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.KombiFlammenwerfer));
                    einheitKostenGesamt = einheitKostenGesamt + 35;
                }
                if (wahlIndex == 3)
                {
                    ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.KombiMelter));
                    einheitKostenGesamt = einheitKostenGesamt + 35;
                }
                if (wahlIndex == 4)
                {
                    ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.KombiPlasmawerfer));
                    einheitKostenGesamt = einheitKostenGesamt + 35;
                }
            }


            ordenspriester.wid = 4;
            // Fall1: Kein Termi!
            if (!hasTermieRuestung)
            {
                ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));

                // Wahl Waffe:
                var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 3 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 15 });
                auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });

                Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Ordenspriester darf eine der folgenden Waffen wählen:", auswahlKonstrukt);
                if (!auswahlWaffe1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;

                // Auswahl nutzen und Kosten aktualisieren:
                ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;

                ordenspriester.rw = 3;
                ordenspriester.ret = 0;

                // Wahl für Sprungmodul oder Bike!
                var auswahlSprung = new List<pulldownAuswahl>() { };
                auswahlSprung.Add(new pulldownAuswahl() { auswahl = "kein Upgrade", kosten = 0 });
                auswahlSprung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sprungmodul, kosten = +15 });
                auswahlSprung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.SpaceMarineBike, kosten = +35 });
                Auswahl1AusN auswahlSprung1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Ordenspriester darf eine der folgenden Auswahlen treffen:", auswahlSprung);
                if (!auswahlWaffe1.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }

                wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;
                if (wahlIndex == 1)
                {
                    // Sprungmodul!
                    ordenspriester.ausruestung.Add(alleAusruestung.Sprungmodul);
                    einheitKostenGesamt = einheitKostenGesamt + 25;
                    this.einheitentyp = Einheitstyp.Sprungtruppen;
                    ordenspriester.einheitentyp = Einheitstyp.Sprungtruppen;
                }
                if (wahlIndex == 2)
                {
                    // Bike!
                    ordenspriester.ausruestung.Add(alleAusruestung.SpaceMarineBike);
                    einheitKostenGesamt = einheitKostenGesamt + 35;
                    this.einheitentyp = Einheitstyp.Bike;
                    ordenspriester.einheitentyp = Einheitstyp.Bike;
                    ordenspriester.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.SyncBolter));
                    ordenspriester.wid = 5;
                }

            }

            // Auwahl Ausrüstung:
            var pulldownSargeAusruestung = new List<pulldownAuswahl>() { };
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
            pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Digitalwaffen, kosten = 10 });


            AuswahlMAusN wahlSargeAusruestung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Ordenspriester darf folgende Optionen wählen:", pulldownSargeAusruestung);
            if (!wahlSargeAusruestung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlSargeAusruestung.wahlIndexVektor;
            foreach (int i in wahlVektor)
            {
                ordenspriester.ausruestung.Add((alleAusruestung)pulldownSargeAusruestung[i].auswahl);
                einheitKostenGesamt = einheitKostenGesamt + pulldownSargeAusruestung[i].kosten * 1;
            }


            ordenspriester.kg = 5;
            ordenspriester.bf = 4;
            ordenspriester.st = 4;
            ordenspriester.ini = 4;
            ordenspriester.lp = 2;
            ordenspriester.at = 2;
            ordenspriester.mw = 10;

            subEinheiten = new List<subEinheit>() { };
            subEinheiten.Add(ordenspriester);

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }


    public class kommandotrupp : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Kommandotrupp;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 115;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.keine);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };

            // Wollen wir Kompaniestandarte oder Space Marine Bikes?
            var pulldownAus = new List<pulldownAuswahl>() { };
            pulldownAus.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Kompaniestandarte, kosten = 15 });
            pulldownAus.Add(new pulldownAuswahl() { auswahl = alleAusruestung.SpaceMarineBike, kosten = 90 });
            AuswahlMAusN wahlAusreust = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Mögliche Ausrüstung:", pulldownAus);
            if (!wahlAusreust.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlAusreust.wahlIndexVektor;
            bool habenBike = false;
            bool habenStandarte = false;

            foreach (int kappa in wahlVektor)
            {
                if (kappa == 0)
                {
                    habenStandarte = true;
                    einheitKostenGesamt = einheitKostenGesamt + 15;
                }
                else if (kappa == 1)
                {
                    habenBike = true;
                    einheitKostenGesamt = einheitKostenGesamt + 90;
                }
            }

            // Wir fragen erst einmal, ob wir einen Kompaniechampion dabei haben wollen!
            var auswahlKonstrukt = new List<pulldownAuswahl>() { };
            auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "kein Champion", kosten = 0 });
            auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = "Einen Veteran zum Kompaniechampion aufrüsten", kosten = 15 });
            Auswahl1AusN auswahlSprung = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Auswahl des Upgrades:", auswahlKonstrukt);
            if (!auswahlSprung.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlIndex = auswahlSprung.gewaehlterIndexAusN;

            int weitereVeteranen = 5;

            if (wahlIndex == 1)
            {
                // Soll upgegradet werden!
                einheitKostenGesamt += 15;
                weitereVeteranen = 4;
                var champ = ultraMarineHelperClass.createKompaniechampion();
                champ.ausruestung = new List<alleAusruestung>() { };
                champ.ausruestung.Add(alleAusruestung.Parierschield);
                champ.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.ServoRuestung);
                champ.ausruestung.Add(alleAusruestung.Fragmentgranaten);
                champ.ausruestung.Add(alleAusruestung.Sprenggranaten);

                champ.waffen = new List<waffe>() { };
                champ.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));
                champ.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));
                subEinheiten.Add(champ);

                if (habenBike)
                    champ.ausruestung.Add(alleAusruestung.SpaceMarineBike);
            }


            // Jetzt noch 4-5 weitere Vetertanen!
            for (int i = 0; i < weitereVeteranen; ++i)
            {
                var veteran = ultraMarineHelperClass.createVeteran();
                veteran.ausruestung.Remove(alleAusruestung.Spezialmunition);

                veteran.waffen = new List<waffe>() { };

                for (int k = 0; k < 2; k++)
                {
                    // Jeder Veteran darf erst einmal seine erste Hand bestücken!
                    auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Boltpistole, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmapistole, kosten = 15 });

                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Sturmbolter, kosten = 3 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiFlammenwerfer, kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiMelter, kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.KombiPlasmawerfer, kosten = 10 });

                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Flammenwerfer, kosten = 5 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Melter, kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Plasmawerfer, kosten = 10 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 15 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieklaue, kosten = 15 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiefaust, kosten = 25 });

                    if (k == 0)
                    {
                        Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Veteran darf eine der folgenden Waffen wählen (linke Hand):", auswahlKonstrukt);
                        if (!auswahlWaffe1.allesOkay)
                        {
                            erschaffungOkay = false;
                            return;
                        }

                        wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;
                        // Auswahl nutzen und Kosten aktualisieren:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                        einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                    }
                    else
                    {
                        Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Ein Veteran darf eine der folgenden Waffen wählen (rechte Hand):", auswahlKonstrukt);
                        if (!auswahlWaffe1.allesOkay)
                        {
                            erschaffungOkay = false;
                            return;
                        }

                        wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;
                        // Auswahl nutzen und Kosten aktualisieren:
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                        einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;
                    }
                }

                // Und jetzt auch noch die Item-Auswahl:
                var pulldownSargeAusruestung = new List<pulldownAuswahl>() { };
                pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Melterbomben, kosten = 5 });
                pulldownSargeAusruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Sturmschild, kosten = 15 });
                wahlAusreust = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Jeder Veteran darf folgende Optionen wählen:", pulldownSargeAusruestung);
                if (!wahlAusreust.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                wahlVektor = wahlAusreust.wahlIndexVektor;
                foreach (int kappa in wahlVektor)
                {
                    veteran.ausruestung.Add((alleAusruestung)pulldownSargeAusruestung[kappa].auswahl);
                    einheitKostenGesamt = einheitKostenGesamt + pulldownSargeAusruestung[kappa].kosten * 1;
                }

                if (i == 0)
                {
                    // Ein Veteran ist immer der Apothecarius!
                    veteran.name = alleSubeinheitenNamen.Apothecarius;
                    veteran.ausruestung.Add(alleAusruestung.Narthecium);
                }
                if (i == 1)
                {
                    if (habenStandarte)
                        veteran.ausruestung.Add(alleAusruestung.Kompaniestandarte);
                }

                if (habenBike)
                    veteran.ausruestung.Add(alleAusruestung.SpaceMarineBike);

                subEinheiten.Add(veteran);
            }

            // Wahl angeschlossenes Transportfahrzeug
            // => muss mit generiert werden!
            // Also müssen wir zunächst den Spieler fragen, ob er überhaupt ein Transportfahrzeug möchte!
            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Rhino, kosten = 35 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Razorback, kosten = 40 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            wahlIndex = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlIndex)
            {
                case 0:
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Rhino.ToString());
                    break;
                case 2:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Razorback.ToString());
                    break;
                case 3:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                    break;
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }


    public class ehrengarde : Einheit
    {
        public override void createUnitBase()
        {
            einheitenName = alleEinheitenNamen.Ehrengarde;
            fraktion = Fraktionen.SpaceMarines;

            uniqueStringProperty = fraktion.ToString() + einheitenName.ToString();

            basispunkteKosten = 115;
            einheitKostenGesamt = basispunkteKosten;

            einzigartig = false;

            einheitentyp = Einheitstyp.Infanterie;

            sonderregeln = new List<Sonderregeln>() { };
            sonderregeln.Add(Sonderregeln.DieKeineFurchtKennen);
            sonderregeln.Add(Sonderregeln.Kampftaktiken);
            sonderregeln.Add(Sonderregeln.Kriegerstolz);

            auswahlTypBasis = new List<EinheitenAuswahl>() { };
            auswahlTypBasis.Add(EinheitenAuswahl.keine);

            base.createUnitBase();
        }

        public override void createUnitInteraktion(int gesamtArmeePunkteKosten)
        {

            // Gründen wir unsere Einheit neu:
            subEinheiten = new List<subEinheit>() { };
            
            // Wie viele Gardisten wollen wir überhaupt haben?
            int kostenProVeteran = 35;

            AuswahlAnzahlSpieler auswahlAnzahl = new AuswahlAnzahlSpieler(this, 3, 10, "Trupp darf bis zu sieben zusätzliche Gardisten erhalten", gesamtArmeePunkteKosten, kostenProVeteran) { };

            // Okay, wie viele Space Marines sollen dazu? Wenn abgebrochen wurde, hören wir auf!
            if (!auswahlAnzahl.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }

            int zusaetlicheSpaceMariens = auswahlAnzahl.anzahlGewaehlt;
            int anzahlGardistenGesamt = 3 + zusaetlicheSpaceMariens;
            // Update der Punktekosten:
            einheitKostenGesamt = basispunkteKosten + zusaetlicheSpaceMariens * kostenProVeteran;



            // Wollen wir Kompaniestandarte?
            var pulldownAus = new List<pulldownAuswahl>() { };
            pulldownAus.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Ordensbanner, kosten = 25 });
            AuswahlMAusN wahlAusreust = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Mögliche Ausrüstung:", pulldownAus);
            if (!wahlAusreust.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            var wahlVektor = wahlAusreust.wahlIndexVektor;
            bool habenOrdnesbanner = false;

            foreach (int kappa in wahlVektor)
            {
                if (kappa == 0)
                {
                    habenOrdnesbanner = true;
                    einheitKostenGesamt = einheitKostenGesamt + 25;
                }
            }

            // Okay, dann rein damit!
            for (int i = 0; i < anzahlGardistenGesamt; ++i)
            {
                subEinheit veteran = null;

                if (i != 0)
                    veteran = ultraMarineHelperClass.createEhrengardist();
                else
                    veteran = ultraMarineHelperClass.createOrdenschampion();    // ES gibt immer einen Champ!


                // Standardausrüstung:
                veteran.ausruestung = new List<alleAusruestung>() { };
                veteran.ausruestung.Add(alleAusruestung.Fragmentgranaten);
                veteran.ausruestung.Add(alleAusruestung.Sprenggranaten);
                veteran.ruestung = ruestungsfabrik.getInstance().gibMirFolgendeRuestung(alleRuestungen.MeisterhafteRuestung);

                veteran.waffen = new List<waffe>() { };
                veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Boltpistole));

                // Wenn ich kein Champ bin, habe ich immer:
                if (i != 0)
                {
                    veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Energieschwert));
                    veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Bolter));
                }
                else
                {
                    // Wenn ich Champ bin, darf ich mich zwischen Bolter und Messer entscheiden:
                    var auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Bolter, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Kampfmesser, kosten = 0 });                    

                    Auswahl1AusN auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Champion darf wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    int wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;
                    // Auswahl nutzen und Kosten aktualisieren:
                    veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;


                    // Sowie zwischen Eschwert und Ehammer:
                    auswahlKonstrukt = new List<pulldownAuswahl>() { };
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energieschwert, kosten = 0 });
                    auswahlKonstrukt.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Energiehammer, kosten = 15 });                    

                    auswahlWaffe1 = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Champion darf wählen:", auswahlKonstrukt);
                    if (!auswahlWaffe1.allesOkay)
                    {
                        erschaffungOkay = false;
                        return;
                    }

                    wahlIndex = auswahlWaffe1.gewaehlterIndexAusN;
                    // Auswahl nutzen und Kosten aktualisieren:
                    veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(auswahlKonstrukt[wahlIndex].auswahl));
                    einheitKostenGesamt = einheitKostenGesamt + auswahlKonstrukt[wahlIndex].kosten * 1;

                }

                // Ich darf immer zusätzlich eine Ehrenklinge und einen Auxilaris erhalten, sowie - falls ich Champ bin - Digitalwaffen!
                var ausruestung = new List<pulldownAuswahl>() { };
                ausruestung.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.Ehrenklinge, kosten = 15 });
                ausruestung.Add(new pulldownAuswahl() { auswahl = alleWaffenNamen.AuxilarisGranatwerfer, kosten = 15 });
                if(i==0)
                    ausruestung.Add(new pulldownAuswahl() { auswahl = alleAusruestung.Digitalwaffen, kosten = 10 });

                AuswahlMAusN wahlCapAusreustung = new AuswahlMAusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Mögliche Upgrades:", ausruestung);
                if (!wahlCapAusreustung.allesOkay)
                {
                    erschaffungOkay = false;
                    return;
                }
                wahlVektor = wahlCapAusreustung.wahlIndexVektor;
                foreach (int kappa in wahlVektor)
                {
                    if (kappa == 0)
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.Ehrenklinge));
                    else if (kappa == 1)
                        veteran.waffen.Add(waffenfabrik.getInstance().gibMirFolgendeWaffe(alleWaffenNamen.AuxilarisGranatwerfer));
                    else if (kappa == 2)
                        veteran.ausruestung.Add(alleAusruestung.Digitalwaffen);

                    einheitKostenGesamt = einheitKostenGesamt + ausruestung[kappa].kosten * 1;
                }


                if (i == 1)
                {
                    if (habenOrdnesbanner)
                        veteran.ausruestung.Add(alleAusruestung.Ordensbanner);
                }

                subEinheiten.Add(veteran);
            }

            // Wahl angeschlossenes Transportfahrzeug
            // => muss mit generiert werden!
            // Also müssen wir zunächst den Spieler fragen, ob er überhaupt ein Transportfahrzeug möchte!
            var fahrzeugAuswahl = new List<pulldownAuswahl>() { };
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.KeineEinheit, kosten = 0 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Rhino, kosten = 35 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Razorback, kosten = 40 });
            fahrzeugAuswahl.Add(new pulldownAuswahl() { auswahl = alleEinheitenNamen.Landungskapsel, kosten = 35 });

            Auswahl1AusN auswahlScreen = new Auswahl1AusN(this, gesamtArmeePunkteKosten, einheitKostenGesamt, 1, "Der Trupp darf eines der folgenden Transportfahrzeuge erhalten:", fahrzeugAuswahl);
            if (!auswahlScreen.allesOkay)
            {
                erschaffungOkay = false;
                return;
            }
            int wahlInd = auswahlScreen.gewaehlterIndexAusN;

            // Jetzt müssen wir abhängig vom Index die richtige neue Einheit erzeugen!
            switch (wahlInd)
            {
                case 0:
                    break;
                case 1:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Rhino.ToString());
                    break;
                case 2:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Razorback.ToString());
                    break;
                case 3:
                    angeschlossenesFahrzeugString = (Fraktionen.SpaceMarines.ToString() + alleEinheitenNamen.Landungskapsel.ToString());
                    break;
            }

            // Nur jetzt hat die Erschaffung wirklich funktioniert!
            erschaffungOkay = true;
        }
    }


}

